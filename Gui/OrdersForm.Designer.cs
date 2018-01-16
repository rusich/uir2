namespace BrickWorks
{
    partial class OrdersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.styleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mtClients = new MetroFramework.Controls.MetroTile();
            this.mtDelivery = new MetroFramework.Controls.MetroTile();
            this.mtBricks = new MetroFramework.Controls.MetroTile();
            this.mtAbout = new MetroFramework.Controls.MetroTile();
            this.lnkDelete = new MetroFramework.Controls.MetroLink();
            this.lnkEdit = new MetroFramework.Controls.MetroLink();
            this.lnkAdd = new MetroFramework.Controls.MetroLink();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersGrid = new MetroFramework.Controls.MetroGrid();
            this.ordersSummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.styleManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersSummaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager
            // 
            this.styleManager.Owner = this;
            // 
            // mtClients
            // 
            this.mtClients.ActiveControl = null;
            this.mtClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mtClients.BackColor = System.Drawing.Color.Red;
            this.mtClients.ForeColor = System.Drawing.Color.DarkRed;
            this.mtClients.Location = new System.Drawing.Point(620, 224);
            this.mtClients.Name = "mtClients";
            this.mtClients.Size = new System.Drawing.Size(107, 89);
            this.mtClients.Style = MetroFramework.MetroColorStyle.Lime;
            this.mtClients.TabIndex = 4;
            this.mtClients.Text = "Клиенты";
            this.mtClients.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtClients.TileImage = global::BrickWorks.Properties.Resources.clients;
            this.mtClients.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtClients.UseSelectable = true;
            this.mtClients.UseTileImage = true;
            this.mtClients.Click += new System.EventHandler(this.mtClients_Click);
            // 
            // mtDelivery
            // 
            this.mtDelivery.ActiveControl = null;
            this.mtDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mtDelivery.BackColor = System.Drawing.Color.Red;
            this.mtDelivery.ForeColor = System.Drawing.Color.DarkRed;
            this.mtDelivery.Location = new System.Drawing.Point(620, 319);
            this.mtDelivery.Name = "mtDelivery";
            this.mtDelivery.Size = new System.Drawing.Size(107, 89);
            this.mtDelivery.Style = MetroFramework.MetroColorStyle.Purple;
            this.mtDelivery.TabIndex = 4;
            this.mtDelivery.Text = "Доставка";
            this.mtDelivery.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtDelivery.TileImage = global::BrickWorks.Properties.Resources.delivery;
            this.mtDelivery.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtDelivery.UseSelectable = true;
            this.mtDelivery.UseTileImage = true;
            this.mtDelivery.Click += new System.EventHandler(this.mtDelivery_Click);
            // 
            // mtBricks
            // 
            this.mtBricks.ActiveControl = null;
            this.mtBricks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mtBricks.BackColor = System.Drawing.Color.Red;
            this.mtBricks.ForeColor = System.Drawing.Color.DarkRed;
            this.mtBricks.Location = new System.Drawing.Point(620, 129);
            this.mtBricks.Name = "mtBricks";
            this.mtBricks.Size = new System.Drawing.Size(107, 89);
            this.mtBricks.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtBricks.TabIndex = 4;
            this.mtBricks.Text = "Продукция";
            this.mtBricks.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtBricks.TileImage = global::BrickWorks.Properties.Resources.bricks;
            this.mtBricks.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtBricks.UseSelectable = true;
            this.mtBricks.UseTileImage = true;
            this.mtBricks.Click += new System.EventHandler(this.mtBricks_Click);
            // 
            // mtAbout
            // 
            this.mtAbout.ActiveControl = null;
            this.mtAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mtAbout.BackColor = System.Drawing.Color.Red;
            this.mtAbout.ForeColor = System.Drawing.Color.DarkRed;
            this.mtAbout.Location = new System.Drawing.Point(620, 414);
            this.mtAbout.Name = "mtAbout";
            this.mtAbout.Size = new System.Drawing.Size(107, 89);
            this.mtAbout.Style = MetroFramework.MetroColorStyle.Magenta;
            this.mtAbout.TabIndex = 4;
            this.mtAbout.Text = "О программе";
            this.mtAbout.TileImage = global::BrickWorks.Properties.Resources.about;
            this.mtAbout.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtAbout.UseSelectable = true;
            this.mtAbout.UseTileImage = true;
            this.mtAbout.Click += new System.EventHandler(this.mtAbout_Click);
            // 
            // lnkDelete
            // 
            this.lnkDelete.Image = global::BrickWorks.Properties.Resources.delete;
            this.lnkDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkDelete.ImageSize = 32;
            this.lnkDelete.Location = new System.Drawing.Point(256, 69);
            this.lnkDelete.Margin = new System.Windows.Forms.Padding(0);
            this.lnkDelete.Name = "lnkDelete";
            this.lnkDelete.Size = new System.Drawing.Size(81, 36);
            this.lnkDelete.TabIndex = 2;
            this.lnkDelete.Text = "Удалить";
            this.lnkDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkDelete.UseSelectable = true;
            this.lnkDelete.Click += new System.EventHandler(this.lnkDelete_Click);
            // 
            // lnkEdit
            // 
            this.lnkEdit.Image = global::BrickWorks.Properties.Resources.edit;
            this.lnkEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkEdit.ImageSize = 32;
            this.lnkEdit.Location = new System.Drawing.Point(123, 69);
            this.lnkEdit.Margin = new System.Windows.Forms.Padding(0);
            this.lnkEdit.Name = "lnkEdit";
            this.lnkEdit.Size = new System.Drawing.Size(122, 36);
            this.lnkEdit.TabIndex = 1;
            this.lnkEdit.Text = "Редактировать";
            this.lnkEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkEdit.UseSelectable = true;
            this.lnkEdit.Click += new System.EventHandler(this.lnkEdit_Click);
            // 
            // lnkAdd
            // 
            this.lnkAdd.Image = global::BrickWorks.Properties.Resources.add;
            this.lnkAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkAdd.ImageSize = 32;
            this.lnkAdd.Location = new System.Drawing.Point(23, 69);
            this.lnkAdd.Margin = new System.Windows.Forms.Padding(0);
            this.lnkAdd.Name = "lnkAdd";
            this.lnkAdd.Size = new System.Drawing.Size(81, 36);
            this.lnkAdd.TabIndex = 0;
            this.lnkAdd.Text = "Новый";
            this.lnkAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkAdd.UseSelectable = true;
            this.lnkAdd.Click += new System.EventHandler(this.lnkAdd_Click);
            // 
            // ordersGrid
            // 
            this.ordersGrid.AllowUserToAddRows = false;
            this.ordersGrid.AllowUserToDeleteRows = false;
            this.ordersGrid.AllowUserToResizeRows = false;
            this.ordersGrid.AutoGenerateColumns = false;
            this.ordersGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ordersGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ordersGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ordersGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordersGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ordersGrid.ColumnHeadersHeight = 40;
            this.ordersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ordersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.orderedDateDataGridViewTextBoxColumn,
            this.clientDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.ordersGrid.DataSource = this.ordersSummaryBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ordersGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.ordersGrid.EnableHeadersVisualStyles = false;
            this.ordersGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ordersGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ordersGrid.Location = new System.Drawing.Point(24, 131);
            this.ordersGrid.Name = "ordersGrid";
            this.ordersGrid.ReadOnly = true;
            this.ordersGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordersGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ordersGrid.RowHeadersWidth = 35;
            this.ordersGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ordersGrid.RowTemplate.Height = 30;
            this.ordersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersGrid.Size = new System.Drawing.Size(566, 379);
            this.ordersGrid.TabIndex = 5;
            this.ordersGrid.SelectionChanged += new System.EventHandler(this.ordersGrid_SelectionChanged);
            this.ordersGrid.DoubleClick += new System.EventHandler(this.ordersGrid_DoubleClick_1);
            // 
            // ordersSummaryBindingSource
            // 
            this.ordersSummaryBindingSource.AllowNew = false;
            this.ordersSummaryBindingSource.DataSource = typeof(BrickWorks.OrdersSummary);
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "№";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderIdDataGridViewTextBoxColumn.Width = 35;
            // 
            // orderedDateDataGridViewTextBoxColumn
            // 
            this.orderedDateDataGridViewTextBoxColumn.DataPropertyName = "OrderedDate";
            this.orderedDateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.orderedDateDataGridViewTextBoxColumn.Name = "orderedDateDataGridViewTextBoxColumn";
            this.orderedDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderedDateDataGridViewTextBoxColumn.Width = 110;
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "Ф.И.О. Клиента";
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            this.clientDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientDataGridViewTextBoxColumn.Width = 280;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.amountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.amountDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 517);
            this.Controls.Add(this.ordersGrid);
            this.Controls.Add(this.mtClients);
            this.Controls.Add(this.mtDelivery);
            this.Controls.Add(this.mtBricks);
            this.Controls.Add(this.mtAbout);
            this.Controls.Add(this.lnkDelete);
            this.Controls.Add(this.lnkEdit);
            this.Controls.Add(this.lnkAdd);
            this.Name = "OrdersForm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "ЗАКАЗЫ                                 АРМ Менеджер кирпичного завода";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.styleManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersSummaryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager styleManager;
        private MetroFramework.Controls.MetroLink lnkAdd;
        private MetroFramework.Controls.MetroLink lnkDelete;
        private MetroFramework.Controls.MetroLink lnkEdit;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private MetroFramework.Controls.MetroTile mtAbout;
        private MetroFramework.Controls.MetroTile mtBricks;
        private MetroFramework.Controls.MetroTile mtClients;
        private MetroFramework.Controls.MetroTile mtDelivery;
        private MetroFramework.Controls.MetroGrid ordersGrid;
        private System.Windows.Forms.BindingSource ordersSummaryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
    }
}

