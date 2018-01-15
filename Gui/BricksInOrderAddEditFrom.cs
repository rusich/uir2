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
        public BricksInOrderAddEditFrom(OrderedBrick obj)
        {
            InitializeComponent();
            OrderedBrickInfo = obj;
            db = new BrickWorksModel();
            orderedBrickBindingSource.DataSource = OrderedBrickInfo;
            brickBindingSource.DataSource = db.Bricks.ToList();
        }

        private void mbSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            if(OrderedBrickInfo.Id>0)
                db.SaveChanges();
            orderedBrickBindingSource.EndEdit();
            this.Close();
        }
    }
}
