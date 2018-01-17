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
    public partial class BricksCostForm : MetroFramework.Forms.MetroForm 
    {
        BrickWorksModel db;
        public BricksCostForm()
        {
            InitializeComponent();
            db = new BrickWorksModel();
            brickCostBindingSource.DataSource = db.BrickCosts.OrderByDescending(d => d.Date).ToList();
            brickBindingSource.DataSource = db.Bricks.ToList();
        }

        private void BricksCostForm_Load(object sender, EventArgs e)
        {
            costGrid.Style = this.Style;
            costGrid.Theme = this.Theme;
        }

        private void lnkAdd_Click(object sender, EventArgs e)
        {
            var cost = new BrickCost();
            using (var frm = new BrickCostAddEditForm(cost))
            {
                frm.Theme = this.Theme;
                frm.Style = this.Style;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    db.BrickCosts.Add(cost);
                    db.SaveChanges();
                    brickCostBindingSource.DataSource = db.BrickCosts.OrderByDescending(d => d.Date).ToList();
                    costGrid.Refresh();
                }
            }
        }

        private void lnkEdit_Click(object sender, EventArgs e)
        {
            var cost = (BrickCost)brickCostBindingSource.Current;
            var cost_edit = new BrickCost{ Id = cost.Id, BrickId = cost.BrickId, Date = cost.Date, Cost = cost.Cost};
            using (var frm = new BrickCostAddEditForm(cost_edit))
            {
                frm.Theme = this.Theme;
                frm.Style = this.Style;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    cost.BrickId = cost_edit.BrickId;
                    cost.Date = cost_edit.Date;
                    cost.Cost = cost_edit.Cost;
                    db.SaveChanges();
                    brickCostBindingSource.DataSource = db.BrickCosts.OrderByDescending(d => d.Date).ToList();
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
                        BrickCost dc = db.BrickCosts.FirstOrDefault(o => o.Date == dt);
                        db.BrickCosts.Remove(dc);
                        brickCostBindingSource.RemoveAt(costGrid.Rows[i].Index);
                    }
                }

                db.SaveChanges();
            }
        }

        private void costGrid_DoubleClick(object sender, EventArgs e)
        {
            if (costGrid.Rows.Count > 0)
            {
                lnkEdit_Click(sender, e);
            }
        }
    }
}
