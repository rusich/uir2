namespace BrickWorks
{
    partial class OrderAddEditForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mteOrderId = new MetroFramework.Controls.MetroTextBox();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mteOrderDate = new MetroFramework.Controls.MetroDateTime();
            this.mcbClient = new MetroFramework.Controls.MetroComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mbtnSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.pbBricksAdd = new System.Windows.Forms.PictureBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.bricksGrid = new MetroFramework.Controls.MetroGrid();
            this.brickMarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDel = new System.Windows.Forms.DataGridViewImageColumn();
            this.bricksInOrderViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mbCalcDelivery = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.mteDelivery = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBricksAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bricksGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bricksInOrderViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(32, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "№ заказа:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(179, 71);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(40, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Дата:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(335, 71);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(54, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Клиент:";
            // 
            // mteOrderId
            // 
            // 
            // 
            // 
            this.mteOrderId.CustomButton.Image = null;
            this.mteOrderId.CustomButton.Location = new System.Drawing.Point(48, 1);
            this.mteOrderId.CustomButton.Name = "";
            this.mteOrderId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mteOrderId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mteOrderId.CustomButton.TabIndex = 1;
            this.mteOrderId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mteOrderId.CustomButton.UseSelectable = true;
            this.mteOrderId.CustomButton.Visible = false;
            this.mteOrderId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Id", true));
            this.mteOrderId.Enabled = false;
            this.mteOrderId.Lines = new string[0];
            this.mteOrderId.Location = new System.Drawing.Point(103, 71);
            this.mteOrderId.MaxLength = 32767;
            this.mteOrderId.Name = "mteOrderId";
            this.mteOrderId.PasswordChar = '\0';
            this.mteOrderId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mteOrderId.SelectedText = "";
            this.mteOrderId.SelectionLength = 0;
            this.mteOrderId.SelectionStart = 0;
            this.mteOrderId.ShortcutsEnabled = true;
            this.mteOrderId.Size = new System.Drawing.Size(70, 23);
            this.mteOrderId.TabIndex = 0;
            this.mteOrderId.UseSelectable = true;
            this.mteOrderId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mteOrderId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(BrickWorks.Order);
            // 
            // mteOrderDate
            // 
            this.mteOrderDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "OrderedDate", true));
            this.mteOrderDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "OrderedDate", true));
            this.mteOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mteOrderDate.Location = new System.Drawing.Point(218, 68);
            this.mteOrderDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.mteOrderDate.Name = "mteOrderDate";
            this.mteOrderDate.Size = new System.Drawing.Size(107, 29);
            this.mteOrderDate.TabIndex = 1;
            this.mteOrderDate.Value = new System.DateTime(2018, 1, 10, 1, 49, 35, 0);
            this.mteOrderDate.ValueChanged += new System.EventHandler(this.mteOrderDate_ValueChanged);
            // 
            // mcbClient
            // 
            this.mcbClient.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderBindingSource, "ClientId", true));
            this.mcbClient.DataSource = this.clientBindingSource;
            this.mcbClient.DisplayMember = "Name";
            this.mcbClient.FormattingEnabled = true;
            this.mcbClient.ItemHeight = 23;
            this.mcbClient.Location = new System.Drawing.Point(388, 68);
            this.mcbClient.Name = "mcbClient";
            this.mcbClient.Size = new System.Drawing.Size(219, 29);
            this.mcbClient.TabIndex = 2;
            this.mcbClient.UseSelectable = true;
            this.mcbClient.ValueMember = "Id";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(BrickWorks.Client);
            // 
            // mbtnSave
            // 
            this.mbtnSave.Location = new System.Drawing.Point(532, 326);
            this.mbtnSave.Name = "mbtnSave";
            this.mbtnSave.Size = new System.Drawing.Size(75, 23);
            this.mbtnSave.TabIndex = 5;
            this.mbtnSave.Text = "Сохранить";
            this.mbtnSave.UseSelectable = true;
            this.mbtnSave.Click += new System.EventHandler(this.mbtnSave_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(26, 328);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(67, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Доставка:";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // pbBricksAdd
            // 
            this.pbBricksAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBricksAdd.Image = global::BrickWorks.Properties.Resources.new_small;
            this.pbBricksAdd.Location = new System.Drawing.Point(155, 108);
            this.pbBricksAdd.Name = "pbBricksAdd";
            this.pbBricksAdd.Size = new System.Drawing.Size(16, 16);
            this.pbBricksAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbBricksAdd.TabIndex = 13;
            this.pbBricksAdd.TabStop = false;
            this.pbBricksAdd.Click += new System.EventHandler(this.pbBricksAdd_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(32, 106);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(120, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Кирпичи в заказе:";
            // 
            // bricksGrid
            // 
            this.bricksGrid.AllowUserToAddRows = false;
            this.bricksGrid.AllowUserToDeleteRows = false;
            this.bricksGrid.AllowUserToResizeRows = false;
            this.bricksGrid.AutoGenerateColumns = false;
            this.bricksGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bricksGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bricksGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bricksGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bricksGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.bricksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bricksGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brickMarkDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.colEdit,
            this.colDel});
            this.bricksGrid.DataSource = this.bricksInOrderViewBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bricksGrid.DefaultCellStyle = dataGridViewCellStyle11;
            this.bricksGrid.EnableHeadersVisualStyles = false;
            this.bricksGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bricksGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bricksGrid.Location = new System.Drawing.Point(32, 128);
            this.bricksGrid.Name = "bricksGrid";
            this.bricksGrid.ReadOnly = true;
            this.bricksGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bricksGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.bricksGrid.RowHeadersVisible = false;
            this.bricksGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.bricksGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bricksGrid.Size = new System.Drawing.Size(583, 192);
            this.bricksGrid.TabIndex = 11;
            this.bricksGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bricksGrid_CellContentClick);
            this.bricksGrid.DoubleClick += new System.EventHandler(this.bricksGrid_DoubleClick);
            // 
            // brickMarkDataGridViewTextBoxColumn
            // 
            this.brickMarkDataGridViewTextBoxColumn.DataPropertyName = "BrickMark";
            this.brickMarkDataGridViewTextBoxColumn.HeaderText = "Марка кирпича";
            this.brickMarkDataGridViewTextBoxColumn.Name = "brickMarkDataGridViewTextBoxColumn";
            this.brickMarkDataGridViewTextBoxColumn.ReadOnly = true;
            this.brickMarkDataGridViewTextBoxColumn.Width = 330;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.quantityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Кол-во";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 70;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Format = "C2";
            dataGridViewCellStyle9.NullValue = "0";
            this.costDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.costDataGridViewTextBoxColumn.HeaderText = "Цена за шт.";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            this.costDataGridViewTextBoxColumn.Width = 70;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = "0";
            this.totalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.totalDataGridViewTextBoxColumn.HeaderText = "Итого";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 70;
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "";
            this.colEdit.Image = global::BrickWorks.Properties.Resources.edit_small;
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colEdit.Width = 18;
            // 
            // colDel
            // 
            this.colDel.HeaderText = "";
            this.colDel.Image = global::BrickWorks.Properties.Resources.delete_small;
            this.colDel.Name = "colDel";
            this.colDel.ReadOnly = true;
            this.colDel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colDel.Width = 18;
            // 
            // bricksInOrderViewBindingSource
            // 
            this.bricksInOrderViewBindingSource.DataSource = typeof(BrickWorks.BricksInOrderView);
            // 
            // mbCalcDelivery
            // 
            this.mbCalcDelivery.Location = new System.Drawing.Point(227, 326);
            this.mbCalcDelivery.Name = "mbCalcDelivery";
            this.mbCalcDelivery.Size = new System.Drawing.Size(75, 23);
            this.mbCalcDelivery.TabIndex = 5;
            this.mbCalcDelivery.Text = "Расчитать";
            this.mbCalcDelivery.UseSelectable = true;
            this.mbCalcDelivery.Click += new System.EventHandler(this.mbtnCalcDelivery_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "ИТОГО: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotal.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTotal.Location = new System.Drawing.Point(375, 327);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(39, 20);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "123";
            // 
            // mteDelivery
            // 
            this.mteDelivery.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "DeliveryCost", true));
            this.mteDelivery.Location = new System.Drawing.Point(99, 327);
            this.mteDelivery.Mask = "00000";
            this.mteDelivery.Name = "mteDelivery";
            this.mteDelivery.Size = new System.Drawing.Size(100, 20);
            this.mteDelivery.TabIndex = 16;
            this.mteDelivery.ValidatingType = typeof(int);
            this.mteDelivery.TextChanged += new System.EventHandler(this.mteDelivery_TextChanged);
            // 
            // OrderAddEditForm
            // 
            this.AcceptButton = this.mbtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 372);
            this.Controls.Add(this.mteDelivery);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbBricksAdd);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.bricksGrid);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.mbCalcDelivery);
            this.Controls.Add(this.mbtnSave);
            this.Controls.Add(this.mcbClient);
            this.Controls.Add(this.mteOrderDate);
            this.Controls.Add(this.mteOrderId);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderAddEditForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Информация о заказе";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderAddEditForm_FormClosed);
            this.Load += new System.EventHandler(this.OrderAddEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBricksAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bricksGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bricksInOrderViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox mteOrderId;
        private MetroFramework.Controls.MetroDateTime mteOrderDate;
        private MetroFramework.Controls.MetroButton mbtnSave;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.PictureBox pbBricksAdd;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroGrid bricksGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn brickDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bricksInOrderViewBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn brickMarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn colEdit;
        private System.Windows.Forms.DataGridViewImageColumn colDel;
        public MetroFramework.Controls.MetroComboBox mcbClient;
        private MetroFramework.Controls.MetroButton mbCalcDelivery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.MaskedTextBox mteDelivery;
    }
}