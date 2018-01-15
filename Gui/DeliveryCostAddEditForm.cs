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
    public partial class DeliveryCostAddEditForm : MetroFramework.Forms.MetroForm
        
    {
        DeliveryCost DeliveryInfo;
        public DeliveryCostAddEditForm(DeliveryCost obj)
        {
            DeliveryInfo = obj;
            InitializeComponent();
            deliveryCostBindingSource.DataSource = DeliveryInfo;
            this.mdtDate.Select();
        }

        private void mbtSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void mdtDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
