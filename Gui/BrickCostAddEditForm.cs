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
    public partial class BrickCostAddEditForm : MetroFramework.Forms.MetroForm 
    {
        private BrickWorksModel db;
        public BrickCost BrickCostInfo;
        public BrickCostAddEditForm(BrickCost obj)
        {

            InitializeComponent();
            BrickCostInfo = obj;
            db = new BrickWorksModel();
            if (BrickCostInfo.Id == 0)
            {
                BrickCostInfo.BrickId = db.Bricks.First().Id;

            }
            brickCostBindingSource.DataSource = BrickCostInfo;
            this.mdtDate.Select();
            brickBindingSource.DataSource = db.Bricks.ToList();
        }

        private void mbSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
