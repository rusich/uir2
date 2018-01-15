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
    public partial class ClientsForm : MetroFramework.Forms.MetroForm
    {
        private BrickWorksModel db;
        public ClientsForm()
        {
            InitializeComponent();

            db = new BrickWorksModel();
            LoadClients();
        }

        public void LoadClients()
        {
            try
            {
                clientBindingSource.DataSource = db.Clients.ToList();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "\n\n\n" + ex.InnerException.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
                clientsGrid.Theme = this.Theme;
                clientsGrid.Style = this.Style;
                LoadClients();
        }

        private void lnkAdd_Click(object sender, EventArgs e)
        {
            using (ClientAddEditForm frm = new ClientAddEditForm(new Client()))
            {
                frm.Theme = this.Theme;
                frm.Style = this.Style;

                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        db.Clients.Add(frm.ClientInfo);
                        db.SaveChanges();
                        LoadClients();
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private async void lnkEdit_Click(object sender, EventArgs e)
        {
            if (clientsGrid.Rows.Count > 0)
            {
                int id = Convert.ToInt32(clientsGrid.SelectedRows[0].Cells[0].Value);
                Client client = db.Clients.First(o => o.Id == id);
                if (client != null)
                {
                    using (ClientAddEditForm frm = new ClientAddEditForm(client))
                    {
                        frm.Theme = this.Theme;
                        frm.Style = this.Style;
                        if (frm.ShowDialog(this) == DialogResult.OK)
                        {
                            try
                            {
                                await db.SaveChangesAsync();
                                LoadClients();
                            }
                            catch (Exception ex)
                            {
                                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                }
            }
        }

        private void lnkDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Вы дейсвительно хотите удалить клиента(ов)?",
               "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rows = clientsGrid.RowCount;
                for (int i = rows - 1; i >= 0; i--)
                {
                    if (clientsGrid.Rows[i].Selected)
                    {
                        int id = Convert.ToInt32(clientsGrid.Rows[i].Cells[0].Value);
                        Client client = db.Clients.First(o => o.Id == id);
                        db.Clients.Remove(client);
                        clientBindingSource.RemoveAt(clientsGrid.Rows[i].Index);

                    }
                }

                db.SaveChanges();
                LoadClients();
            }
        }

        private void clientsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
