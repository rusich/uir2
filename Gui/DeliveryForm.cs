using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickWorks
{
    public partial class DeliveryForm : MetroFramework.Forms.MetroForm
    {
        BrickWorksModel db;
        public DeliveryForm()
        {
            InitializeComponent();
            costGrid.Theme = this.Theme;
            costGrid.Style = this.Style;
            db = new BrickWorksModel();
            deliveryCostBindingSource.DataSource = db.DeliveryCosts.OrderByDescending(d => d.Date).ToList();
        }

        private void lnkAdd_Click(object sender, EventArgs e)
        {
            var cost = new DeliveryCost();
            using (var frm = new DeliveryCostAddEditForm(cost))
            {
                frm.Theme = this.Theme;
                frm.Style = this.Style;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    db.DeliveryCosts.Add(cost);
                    db.SaveChanges();
                    deliveryCostBindingSource.DataSource = db.DeliveryCosts.OrderByDescending(d => d.Date).ToList();
                    costGrid.Refresh();
                }
            }
        }

        private void lnkEdit_Click(object sender, EventArgs e)
        {
            var cost = (DeliveryCost)deliveryCostBindingSource.Current;
            //var bld_edit = (Building)db.Entry(bld).CurrentValues.ToObject();
            var cost_edit = new DeliveryCost { Date = cost.Date, CostPerKm = cost.CostPerKm };
            using (var frm = new DeliveryCostAddEditForm(cost_edit))
            {
                frm.Theme = this.Theme;
                frm.Style = this.Style;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    cost.Date = cost_edit.Date;
                    cost.CostPerKm = cost_edit.CostPerKm;
                    db.SaveChanges();
                    deliveryCostBindingSource.DataSource = db.DeliveryCosts.OrderByDescending(d => d.Date).ToList();
                    costGrid.Refresh();
                }
            }
        }

        private void lnkDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Вы дейсвительно хотите удалить цену?",
              "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rows = costGrid.RowCount;
                for (int i = rows - 1; i >= 0; i--)
                {
                    if (costGrid.Rows[i].Selected)
                    {
                        DateTime dt = (DateTime)costGrid.Rows[i].Cells[0].Value;
                        DeliveryCost dc = db.DeliveryCosts.FirstOrDefault(o => o.Date == dt);
                        db.DeliveryCosts.Remove(dc);
                        deliveryCostBindingSource.RemoveAt(costGrid.Rows[i].Index);
                    }
                }

                db.SaveChanges();
            }
        }

        private void DeliveryForm_Load(object sender, EventArgs e)
        {
            costGrid.Style = this.Style;
            costGrid.Theme = this.Theme;
        }
    }
}
