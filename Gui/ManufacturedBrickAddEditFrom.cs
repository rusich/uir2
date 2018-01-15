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
    public partial class ManufacturedBrickAddEditFrom : MetroFramework.Forms.MetroForm
    {
        ManufacturedBrick MFInfo;
        BrickWorksModel db;
        public ManufacturedBrickAddEditFrom(ManufacturedBrick obj)
        {
            db = new BrickWorksModel();
            MFInfo = obj;
            InitializeComponent();
            brickBindingSource.DataSource = db.Bricks.ToList(); 
            manufacturedBrickBindingSource.DataSource = MFInfo;
            mDate.Select();
        }

        private void mbSave_Click(object sender, EventArgs e)
        {
            if (mcbBrick.SelectedIndex < 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Продукт не выбран",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
