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
    public partial class OrderAddEditForm : MetroFramework.Forms.MetroForm 
    //public partial class OrderAddEditForm : Form 
    {
        public OrderAddEditForm(Order obj)
        {
            InitializeComponent();
            orderBindingSource.DataSource = obj;
            using (bwksEntities db = new bwksEntities())
            {
                clientBindingSource.DataSource = db.Clients.ToList();
            }
        }

        public Order OrderInfo {  get { return orderBindingSource.Current as Order; } }
        private void OrderAddEditForm_Load(object sender, EventArgs e)
        {
          
        }

        private void mbtnSave_Click(object sender, EventArgs e)
        {
            Console.WriteLine("click");
            orderBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
