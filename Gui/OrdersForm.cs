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
        private BrickWorksModel db;
        public OrdersForm()
        {
            try
            {
                db = new BrickWorksModel();
                InitializeComponent();
                this.StyleManager = styleManager;
                styleManager.Theme = MetroFramework.MetroThemeStyle.Light;
                styleManager.Style = MetroFramework.MetroColorStyle.Orange;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                var orders = db.Orders.Select(o => new OrdersSummary
                {
                    OrderId = o.Id,
                    OrderedDate = o.OrderedDate,
                    Client = o.Client.Name
                }).OrderByDescending(d => d.OrderId);
                ordersSummaryBindingSource.DataSource = orders.ToList();
                clientBindingSource.DataSource = db.Clients.ToList();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "\n\n\n" + ex.InnerException.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void lnkAdd_Click(object sender, EventArgs e)
        {
            using (OrderAddEditForm frm = new OrderAddEditForm(new Order() { DeliveryCost = 0 }))
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
                        MetroFramework.MetroMessageBox.Show(this, ex.InnerException.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        db.Orders.Load();
                        LoadOrders();
                    }
                    ordersGrid.Refresh(); 
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
                        ordersSummaryBindingSource.RemoveAt(ordersGrid.Rows[i].Index);

                    }
                }

                db.SaveChanges();
                LoadOrders();
                ordersGrid.Refresh();
            }
        }

        private async void lnkEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ordersGrid.SelectedRows[0].Cells[0].Value);
            Order ord = db.Orders.First(o => o.Id == id);
            if (ord != null)
            {
                using (OrderAddEditForm frm = new OrderAddEditForm(ord))
                {
                    frm.StyleManager = styleManager;
                    if (frm.ShowDialog(this) == DialogResult.OK)
                    {
                        try
                        {
                            await db.SaveChangesAsync();
                            db = new BrickWorksModel();
                            LoadOrders();
                        }
                        catch (Exception ex)
                        {
                            MetroFramework.MetroMessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
                        }
                    }
                    ordersGrid.Refresh();
                }
            }
        }

        private void ordersGrid_DoubleClick(object sender, EventArgs e)
        {
            lnkEdit_Click(sender, e);
        }

        private void mtAbout_Click(object sender, EventArgs e)
        {
            using (AboutForm frm = new AboutForm())
            {
                frm.Theme = mtAbout.Theme;
                frm.Style = mtAbout.Style;
                frm.ShowDialog();
            }
        }



        private void mtClients_Click(object sender, EventArgs e)
        {
            using (ClientsForm frm = new ClientsForm())
            {
                frm.Theme = mtClients.Theme;
                frm.Style = mtClients.Style;
                frm.ShowDialog();
                LoadOrders();
            }
        }

        private void htmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ordersGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (ordersGrid.SelectedRows.Count > 0)
            {
                lnkDelete.Enabled = true;
                lnkEdit.Enabled = true;
                return;
            }
            lnkDelete.Enabled = false;
            lnkEdit.Enabled = false;
        }

        private void mtDelivery_Click(object sender, EventArgs e)
        {
            using (DeliveryForm frm = new DeliveryForm())
            {
                frm.Theme = mtDelivery.Theme;
                frm.Style = mtDelivery.Style;
                frm.ShowDialog();
                LoadOrders();
            }
        }

        private void mtBricks_Click(object sender, EventArgs e)
        {
            using (var frm = new BricksFrom())
            {
                frm.Theme = mtBricks.Theme;
                frm.Style = mtBricks.Style;
                frm.ShowDialog();
                LoadOrders();
            }
        }

        private void ordersGrid_DoubleClick_1(object sender, EventArgs e)
        {
            if(ordersGrid.Rows.Count>0)
                lnkEdit_Click(sender, e);

        }
    }
}
