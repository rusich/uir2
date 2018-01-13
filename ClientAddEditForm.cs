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
    public partial class ClientAddEditForm : MetroFramework.Forms.MetroForm
    {
        private bwksEntities db;
        public Client ClientInfo;
        public ClientAddEditForm(Client obj)
        {
            InitializeComponent();
            ClientInfo = obj;
            db = new bwksEntities();
            clientBindingSource.DataSource = ClientInfo;
        }

        //public Client ClientInfo {  get { return client; } }

        private void mbtnSave_Click(object sender, EventArgs e)
        {
            clientBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ClientAddEditForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
