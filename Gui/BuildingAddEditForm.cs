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
    public partial class BuildingAddEditForm : MetroFramework.Forms.MetroForm 
    {
        public Building BuildingInfo;
        public BuildingAddEditForm(Building obj)
        {
            InitializeComponent();
            BuildingInfo = obj;
            buildingBindingSource.DataSource = BuildingInfo;
        }

        private void mbSave_Click(object sender, EventArgs e)
        {
            ValidateChildren();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
