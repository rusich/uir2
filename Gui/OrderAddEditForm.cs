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
    {
        BrickWorksModel db;
        public Order OrderInfo;

        public OrderAddEditForm(Order obj)
        {
            db = new BrickWorksModel();
            OrderInfo = obj;
            InitializeComponent();
            orderBindingSource.DataSource = OrderInfo;
            clientBindingSource.DataSource = db.Clients.ToList();
            LoadBricks();
        }

        public void LoadBricks()
        {
            var bricks = db.OrderedBricks.Where(o => o.OrderId == OrderInfo.Id).Select(o => new BricksInOrderView
            {
                Id = o.Id,
                BrickId = o.BrickId,
                OrderId = o.OrderId,
                BrickMark = o.Brick.Mark,
                OrderDate = OrderInfo.OrderedDate,
                Quantity = o.Quantity
            });
            bricksInOrderViewBindingSource.DataSource = bricks.ToList();
            bricksGrid.Refresh();
        }

        private void OrderAddEditForm_Load(object sender, EventArgs e)
        {
            bricksGrid.Theme = this.Theme;
            bricksGrid.Style = this.Style;
        }

        private void mbtnSave_Click(object sender, EventArgs e)
        {
            if (mcbClient.SelectedIndex < 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Клиент не выбран",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            orderBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void mteOrderDate_ValueChanged(object sender, EventArgs e)
        {
            OrderInfo.OrderedDate = mteOrderDate.Value;
            LoadBricks();
        }

        private void bricksGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 || e.ColumnIndex == 5)
            {
                var boundItem = ((BricksInOrderView)bricksGrid.Rows[e.RowIndex].DataBoundItem);
                var oBricks = db.OrderedBricks.FirstOrDefault(ob => ob.Id == boundItem.Id);
                var oBricks_edit = new OrderedBrick 
                {
                    Id = oBricks.Id,
                    OrderId = oBricks.OrderId,
                    Quantity = oBricks.Quantity,
                    BrickId = oBricks.BrickId 
                };
                
                switch (e.ColumnIndex)
                {
                    //bricks edit
                    case 4:
                        using (var frm = new BricksInOrderAddEditFrom(oBricks_edit))
                        {
                            frm.Theme = this.Theme;
                            frm.Style = this.Style;
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                if (oBricks != null)
                                {
                                    oBricks.Id = oBricks_edit.Id;
                                    oBricks.OrderId = oBricks_edit.OrderId;
                                    oBricks.Quantity = oBricks_edit.Quantity;
                                    oBricks.BrickId = oBricks_edit.BrickId;
                                    db.SaveChanges();
                                }
                                LoadBricks();
                            }
                        }
                        break;
                    //bricks delete
                    case 5:
                        if (oBricks != null)
                        {
                            if(OrderInfo.Id>0)
                            { 
                            db.OrderedBricks.Remove(oBricks);
                            db.SaveChanges();
}
                        }
                        bricksInOrderViewBindingSource.Remove(boundItem);
                        LoadBricks();
                        break;
                    default:
                        break;
                }
            }
        }

        private void OrderAddEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.SaveChanges();
        }


        private void pbBricksAdd_Click(object sender, EventArgs e)
        {
            using (var frm = new BricksInOrderAddEditFrom(new OrderedBrick()))
            {
                frm.Theme = this.Theme;
                frm.Style = this.Style;
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    if (OrderInfo.Id > 0)
                    {
                        Order ord = db.Orders.FirstOrDefault(o => o.Id == OrderInfo.Id);
                        if (ord != null)
                        {
                            ord.OrderedBricks.Add(frm.OrderedBrickInfo);
                            db.SaveChanges();
                            LoadBricks();
                        }
                    }
                    else
                    {
                        OrderInfo.OrderedBricks.Add(frm.OrderedBrickInfo);
                        string brickMark = db.Bricks.FirstOrDefault(b => b.Id == frm.OrderedBrickInfo.BrickId).Mark;
                        bricksInOrderViewBindingSource.Add(new BricksInOrderView
                        {
                            Id = frm.OrderedBrickInfo.Id,
                            BrickId = frm.OrderedBrickInfo.BrickId,
                            OrderId = frm.OrderedBrickInfo.OrderId,
                            BrickMark = brickMark,
                            OrderDate = OrderInfo.OrderedDate,
                            Quantity = frm.OrderedBrickInfo.Quantity
                        });
                        orderBindingSource.EndEdit();
                    }
                }
            }
        }

        private void bricksGrid_DoubleClick(object sender, EventArgs e)
        {
            bricksGrid_CellContentClick(this, new DataGridViewCellEventArgs( 4,
                bricksGrid.SelectedRows[0].Index));
        }
    }
}