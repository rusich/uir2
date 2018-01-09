using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace BrickWorks
{
    public partial class OrdersForm : MetroFramework.Forms.MetroForm
    {
        private bwksEntities db;
        public OrdersForm()
        {
            db = new bwksEntities();
            InitializeComponent();
            this.StyleManager = styleManager;
            styleManager.Theme = MetroFramework.MetroThemeStyle.Light;
            styleManager.Style = MetroFramework.MetroColorStyle.Yellow;
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders()
        {
            ordersViewBindingSource.DataSource = db.ordersViews.ToList();
            ordersGrid.DataSource = ordersViewBindingSource;
            clientBindingSource.DataSource = db.Clients.ToList();
        }

        private void lnkAdd_Click(object sender, EventArgs e)
        {
            using (OrderAddEditForm frm = new OrderAddEditForm(new Order() { DeliveryCost = 100 }))
            {
                frm.StyleManager = styleManager;
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        db.Orders.Add(frm.OrderInfo);
                        db.SaveChanges();
                        LoadOrders();
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void lnkDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Вы дейсвительно хотите удалить заказ(ы)?",
                "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rows = ordersGrid.RowCount;
                for (int i = rows - 1; i >= 0; i--)
                {
                    if (ordersGrid.Rows[i].Selected)
                    {
                        int id = Convert.ToInt32(ordersGrid.Rows[i].Cells[0].Value);
                        Order ord = db.Orders.First(o => o.Id == id);
                        db.Orders.Remove(ord);
                        ordersViewBindingSource.RemoveAt(ordersGrid.Rows[i].Index);
                    }
                }
            }
        }

        private async void lnkEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ordersGrid.SelectedRows[0].Cells[0].Value);
            Order ord = db.Orders.First(o => o.Id == id);
            if(ord!=null)
            {
                using (OrderAddEditForm frm = new OrderAddEditForm(ord))
                {
                    frm.StyleManager = styleManager;
                    if (frm.ShowDialog(this) == DialogResult.OK)
                    {
                        try
                        {
                            await db.SaveChangesAsync();
                            db.ordersViews.Load();
                            db = new bwksEntities();
                            LoadOrders();
                        }
                        catch (Exception ex)
                        {
                            MetroFramework.MetroMessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
        }

        private void ordersGrid_DoubleClick(object sender, EventArgs e)
        {
            lnkEdit_Click(sender, e);
        }
    }
}
