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
    public partial class BricksTypesForm : MetroFramework.Forms.MetroForm 
    {
        BrickWorksModel db;
        public BricksTypesForm()
        {
            InitializeComponent();
            db = new BrickWorksModel();
            brickBindingSource.DataSource = db.Bricks.ToList();
        }

        private void lnkDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Вы дейсвительно хотите удалить данный вид продукции?",
             "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rows = gridBricks.RowCount;
                for (int i = rows - 1; i >= 0; i--)
                {
                    if (gridBricks.Rows[i].Selected)
                    {
                        int id = (int)gridBricks.Rows[i].Cells[0].Value;
                        Brick brick = db.Bricks.FirstOrDefault(o => o.Id == id);
                        db.Bricks.Remove(brick);
                        brickBindingSource.RemoveAt(gridBricks.Rows[i].Index);
                    }
                }

                db.SaveChanges();
            }
        }

        private void lnkEdit_Click(object sender, EventArgs e)
        {
            var Brick = (Brick)brickBindingSource.Current;
            var Brick_edit = new Brick { Mark = Brick.Mark, Lenght = Brick.Lenght, Height = Brick.Height,
                                         Width = Brick.Width, Parameters = Brick.Parameters };
            using (var frm = new BricksTypesAddEditFrom(Brick_edit))
            {
                frm.Theme = this.Theme;
                frm.Style = this.Style;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Brick.Mark = Brick_edit.Mark;
                    Brick.Lenght = Brick_edit.Lenght;
                    Brick.Height = Brick_edit.Height;
                    Brick.Width = Brick_edit.Width;
                    Brick.Parameters = Brick_edit.Parameters;
                    db.SaveChanges();
                    brickBindingSource.DataSource = db.Bricks.OrderByDescending(d => d.Id).ToList();
                    gridBricks.Refresh();
                }
            }
        }

        private void lnkAdd_Click(object sender, EventArgs e)
        {
            var Brick = new Brick();
            using (var frm = new BricksTypesAddEditFrom(Brick))
            {
                frm.Theme = this.Theme;
                frm.Style = this.Style;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    db.Bricks.Add(Brick);
                    db.SaveChanges();
                    brickBindingSource.DataSource = db.Bricks.OrderByDescending(d => d.Id).ToList();
                    gridBricks.Refresh();
                }
            }
        }

        private void gridBricks_DoubleClick(object sender, EventArgs e)
        {
            if (gridBricks.Rows.Count > 0)
                lnkEdit_Click(sender, e);
        }
    }
}
