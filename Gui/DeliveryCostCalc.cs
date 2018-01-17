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
    public partial class DeliveryCostCalc : MetroFramework.Forms.MetroForm 
    {
        private BrickWorksModel db;
        public float DeliveryCost;
        public int ClientId;
        public DateTime OrderDate;
        public DeliveryCostCalc(int ClientId, DateTime OrderDate)
        {
            
            InitializeComponent();
            DeliveryCost = 0;
            mlvBuildings.CheckBoxes = true;
            this.ClientId = ClientId;
            this.OrderDate = OrderDate;
            db = new BrickWorksModel();
            var buildings = db.Buildings.Where(b => b.ClientID == ClientId);
            foreach (var building in buildings)
            {
                var item = new ListViewItem();
                item.Tag = building.Id;
                item.Text = building.Address;
                mlvBuildings.Items.Add(item);
            }
        }

        private void mbCalc_Click(object sender, EventArgs e)
        {
            float sum = 0;
            foreach (ListViewItem item in mlvBuildings.CheckedItems)
            {
                var buildings = db.Buildings.Where(b => b.ClientID == this.ClientId).ToList();
                foreach (var building in buildings)
                {
                    sum += building.DeliveryDistanse;      
                }
            }
            var costs = db.DeliveryCosts.Where(b => b.Date <= OrderDate);
            if (costs.Count() > 0)
            {
                DeliveryCost = sum * costs.OrderByDescending(d => d.Date).FirstOrDefault().CostPerKm;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
