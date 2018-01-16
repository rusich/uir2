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
        private BrickWorksModel db;
        public Client ClientInfo;
        public ClientAddEditForm(Client obj)
        {
            InitializeComponent();
            ClientInfo = obj;
            db = new BrickWorksModel();
            clientBindingSource.DataSource = ClientInfo;
            buildingBindingSource.DataSource = db.Buildings.Where(c => c.ClientID == ClientInfo.Id).ToList();
            buildingsGrid.Refresh();
        }

        //public Client ClientInfo {  get { return client; } }

        private void mbtnSave_Click(object sender, EventArgs e)
        {
            clientBindingSource.EndEdit();
            buildingBindingSource.EndEdit();
            wallSizeBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
            db.SaveChanges();
            this.Close();
        }

        private void ClientAddEditForm_Load(object sender, EventArgs e)
        {
            buildingsGrid.Theme = Theme;
            buildingsGrid.Style = Style;
            wallsGrid.Theme = Theme;
            wallsGrid.Style = Style;
            if (buildingsGrid.Rows.Count > 0)
                pbWallAdd.Visible = true;
            else
                pbWallAdd.Visible = false;
        }

        private void buildingsGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (buildingsGrid.SelectedRows.Count > 0)
            {
                pbWallAdd.Visible = true;
            }
            else
            {
                pbWallAdd.Visible = false;
            }
                UpdateWalls();
        }

        private void UpdateWalls()
        {
            if (buildingsGrid.SelectedRows.Count > 0)
            {
                Building b = (Building)buildingsGrid.SelectedRows[0].DataBoundItem;
                //wallSizeBindingSource.DataSource = db.WallSizes.Where(c => c.BuildingId == b.Id).ToList();
                wallSizeBindingSource.DataSource = b.WallSizes.ToList();
                wallsGrid.Refresh();
                return;
            }
            wallSizeBindingSource.DataSource = null;
            wallsGrid.Refresh();
        }

        private void wallsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var ws = (WallSize)wallsGrid.SelectedRows[0].DataBoundItem;
            var ws_edit = new WallSize { Height = ws.Height, Length = ws.Length, NumberOfWalls = ws.NumberOfWalls };

            switch (e.ColumnIndex)
            {
                //walls edit
                case 3:
                    using (var frm = new WallAddEditForm(ws_edit))
                    {
                        frm.Theme = this.Theme;
                        frm.Style = this.Style;
                        if(frm.ShowDialog() == DialogResult.OK)
                        {
                            ws.Height = ws_edit.Height;
                            ws.Length = ws_edit.Length;
                            ws.NumberOfWalls = ws_edit.NumberOfWalls;
                            wallsGrid.Refresh();
                        }
                    }
                    break;
                //walls delete
                case 4:
                    db.WallSizes.Remove(ws);
                    wallSizeBindingSource.Remove(ws);
                    wallsGrid.Refresh();
                    break;
                default:
                    break;
            }
        }

        private void pbWallAdd_Click(object sender, EventArgs e)
        {
            using (var frm = new WallAddEditForm(new WallSize()))
            {
                frm.Theme = this.Theme;
                frm.Style = this.Style;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Building bld = (Building)buildingBindingSource.Current;
                    frm.WallSizeInfo.Building = bld;
                    bld.WallSizes.Add(frm.WallSizeInfo);
                    wallSizeBindingSource.Add(frm.WallSizeInfo);
                    wallsGrid.Refresh();
                }
            }
        }

        private void buildingsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var bld = (Building)buildingsGrid.SelectedRows[0].DataBoundItem;
            var bld = (Building)buildingBindingSource.Current;
            //var bld_edit = (Building)db.Entry(bld).CurrentValues.ToObject();
            var bld_edit = new Building { Address = bld.Address, DeliveryDistanse = bld.DeliveryDistanse };
            switch (e.ColumnIndex)
            {
                //building edit
                case 2:
                    using (var frm = new BuildingAddEditForm(bld_edit))
                    {
                        frm.Style = this.Style;
                        frm.Theme = this.Theme;
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            frm.Theme = this.Theme;
                            frm.Style = this.Style;
                            bld.Address = bld_edit.Address;
                            bld.DeliveryDistanse = bld_edit.DeliveryDistanse;
                            buildingsGrid.Refresh();
                        }
                    }
                    break;
                //building delete
                case 3:
                    db.Buildings.Remove(bld);
                    buildingBindingSource.Remove(bld);
                    buildingsGrid.Refresh();
                    UpdateWalls();
                    break;
                default:
                    break;
            }
        }

        private void pbBuildingAdd_Click(object sender, EventArgs e)
        {
            using (var frm = new BuildingAddEditForm(new Building()))
            {
                frm.Theme = this.Theme;
                frm.Style = this.Style;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    var client = (Client)clientBindingSource.Current;
                    client.Buildings.Add(frm.BuildingInfo);
                    buildingBindingSource.Add(frm.BuildingInfo);
                    //buildingsGrid.Refresh();
                }
            }
        }

        private void buildingsGrid_BindingContextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("sdfsdf");
        }

        private void buildingsGrid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        private void buildingsGrid_DoubleClick(object sender, EventArgs e)
        {
            buildingsGrid_CellContentClick(this, new DataGridViewCellEventArgs( 2,
                buildingsGrid.SelectedRows[0].Index));
        }

        private void wallsGrid_DoubleClick(object sender, EventArgs e)
        {
            wallsGrid_CellContentClick(this, new DataGridViewCellEventArgs( 3,
                wallsGrid.SelectedRows[0].Index));
        }
    }
}
