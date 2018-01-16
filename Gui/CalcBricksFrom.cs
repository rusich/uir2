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
    public partial class CalcBricksFrom : MetroFramework.Forms.MetroForm
    {
        public int Quantity;
        private BrickWorksModel db;
        public int ClientId;
        public int BrickId;
        public CalcBricksFrom(int ClientId, int BrickId)
        {
            InitializeComponent();
            Quantity = 0;
            mlvBuildings.CheckBoxes = true;
            this.ClientId = ClientId;
            this.BrickId = BrickId;
            db = new BrickWorksModel();
            var buildings = db.Buildings.Where(b => b.ClientID == ClientId);
            foreach(var building in buildings)
            {
                var item = new ListViewItem();
                item.Tag = building.Id;
                item.Text = building.Address;
                mlvBuildings.Items.Add(item);
            }
        }

        private void CalcBricksFrom_Load(object sender, EventArgs e)
        {

        }

        private void mbCalc_Click(object sender, EventArgs e)
        {
           float sum = 0;
           foreach(ListViewItem item in mlvBuildings.CheckedItems)
            {
                var buildings = db.Buildings.Where(b => b.ClientID == this.ClientId).ToList();
                foreach(var building in buildings)
                {
                    foreach(var wall in building.WallSizes)
                    {
                        float wallsSquare = wall.Height * wall.Height * wall.NumberOfWalls;
                        var brick = db.Bricks.First(b => b.Id == BrickId);
                        float numOfBricks = wallsSquare/(brick.Lenght*brick.Height);
                        sum += numOfBricks;
                    }
                }
            }
            Quantity = (int)Math.Ceiling(sum);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void mlvBuildings_MouseUp(object sender, MouseEventArgs e)
        {
          
        }
    }
}