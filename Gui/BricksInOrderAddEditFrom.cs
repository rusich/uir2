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
    public partial class BricksInOrderAddEditFrom : MetroFramework.Forms.MetroForm
    {
        private BrickWorksModel db;
        public OrderedBrick OrderedBrickInfo;
        public int ClientId { get; set; }

        public BricksInOrderAddEditFrom(OrderedBrick obj)
        {
            InitializeComponent();
            OrderedBrickInfo = obj;
            db = new BrickWorksModel();
            if (OrderedBrickInfo.Id == 0)
            {
                OrderedBrickInfo.BrickId = db.Bricks.First().Id;
                
            }
            orderedBrickBindingSource.DataSource = OrderedBrickInfo;
            brickBindingSource.DataSource = db.Bricks.ToList();

            CalcRemaindedBricks();   
        }

        void CalcRemaindedBricks()
        {
            if (mcbBrick.SelectedItem != null)
            {
                var mBricks = db.ManufacturedBricks.Where(b => b.BrickId == ((Brick)mcbBrick.SelectedItem).Id).ToList();
                var oBricks = db.OrderedBricks.Where(b => b.BrickId == ((Brick)mcbBrick.SelectedItem).Id).ToList();
                int remainingBricks = (mBricks.Sum(m => m.Quantity) - oBricks.Sum(o => o.Quantity));
                mlRemainingBricks.Text = remainingBricks.ToString();
            }
        }

        private void mbSave_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(mlRemainingBricks.Text)<Convert.ToInt32(mtbQuantity.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "На складе недостаточно кирпичей данной марки",
                   "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
            if(OrderedBrickInfo.Id>0)
                db.SaveChanges();
            orderedBrickBindingSource.EndEdit();
            this.Close();
        }

        private void mbCalc_Click(object sender, EventArgs e)
        {
            if (ClientId==0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Не выбран клиент",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (mcbBrick.SelectedIndex < 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Не выбрана марка кирпича",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var frm = new CalcBricksFrom(ClientId, (brickBindingSource.Current as Brick).Id)
            {
                Style = this.Style,
                Theme = this.Theme
            };

            if(frm.ShowDialog() == DialogResult.OK)
            {
                
                mtbQuantity.Text= Convert.ToString(frm.Quantity);
                
            }

        }


        private void mcbBrick_SelectedIndexChanged(object sender, EventArgs e)
        {
            mcbBrick.Select(); 
            CalcRemaindedBricks();
        }
    }
}
