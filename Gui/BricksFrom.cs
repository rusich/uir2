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
    public partial class BricksFrom : MetroFramework.Forms.MetroForm
    {
        BrickWorksModel db;
        public BricksFrom()
        {
            InitializeComponent();
            db = new BrickWorksModel();
            manufacturedBrickBindingSource.DataSource = db.ManufacturedBricks.OrderByDescending(m => m.Id).ToList();
            brickBindingSource.DataSource = db.Bricks.ToList(); 
        }

        private void BricksFrom_Load(object sender, EventArgs e)
        {
            gridBricks.Theme = this.Theme;
            gridBricks.Style = this.Style;
        }

        private void lnkAdd_Click(object sender, EventArgs e)
        {
            var mfBrick = new ManufacturedBrick(); 
            using (var frm = new ManufacturedBrickAddEditFrom(mfBrick))
            {
                frm.Theme = this.Theme;
                frm.Style = this.Style;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    db.ManufacturedBricks.Add(mfBrick);
                    db.SaveChanges();
                    manufacturedBrickBindingSource.DataSource = db.ManufacturedBricks.OrderByDescending(d => d.Id).ToList();
                    gridBricks.Refresh();
                }
            }
        }

        private void lnkEdit_Click(object sender, EventArgs e)
        {
            var mfBrick = (ManufacturedBrick)manufacturedBrickBindingSource.Current;
            //var bld_edit = (Building)db.Entry(bld).CurrentValues.ToObject();
            var mfBrick_edit = new ManufacturedBrick { Date = mfBrick.Date, BrickId = mfBrick.BrickId, Quantity = mfBrick.Quantity};
            using (var frm = new ManufacturedBrickAddEditFrom(mfBrick_edit))
            {
                frm.Theme = this.Theme;
                frm.Style = this.Style;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    mfBrick.Date = mfBrick_edit.Date;
                    mfBrick.BrickId = mfBrick_edit.BrickId;
                    mfBrick.Quantity = mfBrick_edit.Quantity;
                    db.SaveChanges();
                    manufacturedBrickBindingSource.DataSource = db.ManufacturedBricks.OrderByDescending(d => d.Id).ToList();
                    gridBricks.Refresh();
                }
            }
        }

        private void lnkDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Вы дейсвительно хотите удалить выпущенную партию?",
             "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rows = gridBricks.RowCount;
                for (int i = rows - 1; i >= 0; i--)
                {
                    if (gridBricks.Rows[i].Selected)
                    {
                        int id = (int)gridBricks.Rows[i].Cells[0].Value;
                        ManufacturedBrick brick = db.ManufacturedBricks.FirstOrDefault(o => o.Id == id);
                        db.ManufacturedBricks.Remove(brick);
                        manufacturedBrickBindingSource.RemoveAt(gridBricks.Rows[i].Index);
                    }
                }

                db.SaveChanges();
                gridBricks.Refresh();
            }
        }

        private void lnkBricks_Click(object sender, EventArgs e)
        {
            using (var frm = new BricksTypesForm())
            {
                frm.Theme = this.Theme;
                frm.Style = this.Style;

                frm.ShowDialog();

                manufacturedBrickBindingSource.DataSource = db.ManufacturedBricks.OrderByDescending(d => d.Id).ToList();
                brickBindingSource.DataSource = db.Bricks.ToList();
                gridBricks.Refresh();
            }
        }
    }
}
