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
    public partial class WallAddEditForm : MetroFramework.Forms.MetroForm
    {
        public WallSize WallSizeInfo;
        public WallAddEditForm(WallSize obj)
        {
            InitializeComponent();
            WallSizeInfo = obj;
            wallSizeBindingSource.DataSource = WallSizeInfo;
        }

        private void mtbSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
