namespace BrickWorks
{
    partial class ClientAddEditForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mtId = new MetroFramework.Controls.MetroTextBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mtName = new MetroFramework.Controls.MetroTextBox();
            this.mtPhone = new MetroFramework.Controls.MetroTextBox();
            this.mbtnSave = new MetroFramework.Controls.MetroButton();
            this.buildingsGrid = new MetroFramework.Controls.MetroGrid();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDistanseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDel = new System.Windows.Forms.DataGridViewImageColumn();
            this.buildingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.wallsGrid = new MetroFramework.Controls.MetroGrid();
            this.wallsLengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wallsHeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfWallsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.cDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.wallSizeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pbWallAdd = new System.Windows.Forms.PictureBox();
            this.pbBuildingAdd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallSizeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWallAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuildingAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(45, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "№ клиента:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(45, 109);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Ф.И.О.:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(346, 107);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Телефон:";
            // 
            // mtId
            // 
            // 
            // 
            // 
            this.mtId.CustomButton.Image = null;
            this.mtId.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.mtId.CustomButton.Name = "";
            this.mtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtId.CustomButton.TabIndex = 1;
            this.mtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtId.CustomButton.UseSelectable = true;
            this.mtId.CustomButton.Visible = false;
            this.mtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Id", true));
            this.mtId.Enabled = false;
            this.mtId.Lines = new string[0];
            this.mtId.Location = new System.Drawing.Point(123, 75);
            this.mtId.MaxLength = 32767;
            this.mtId.Name = "mtId";
            this.mtId.PasswordChar = '\0';
            this.mtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtId.SelectedText = "";
            this.mtId.SelectionLength = 0;
            this.mtId.SelectionStart = 0;
            this.mtId.ShortcutsEnabled = true;
            this.mtId.Size = new System.Drawing.Size(80, 23);
            this.mtId.TabIndex = 0;
            this.mtId.UseSelectable = true;
            this.mtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(BrickWorks.Client);
            // 
            // mtName
            // 
            // 
            // 
            // 
            this.mtName.CustomButton.Image = null;
            this.mtName.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.mtName.CustomButton.Name = "";
            this.mtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtName.CustomButton.TabIndex = 1;
            this.mtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtName.CustomButton.UseSelectable = true;
            this.mtName.CustomButton.Visible = false;
            this.mtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Name", true));
            this.mtName.Lines = new string[0];
            this.mtName.Location = new System.Drawing.Point(123, 105);
            this.mtName.MaxLength = 32767;
            this.mtName.Name = "mtName";
            this.mtName.PasswordChar = '\0';
            this.mtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtName.SelectedText = "";
            this.mtName.SelectionLength = 0;
            this.mtName.SelectionStart = 0;
            this.mtName.ShortcutsEnabled = true;
            this.mtName.Size = new System.Drawing.Size(217, 23);
            this.mtName.TabIndex = 1;
            this.mtName.UseSelectable = true;
            this.mtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtPhone
            // 
            // 
            // 
            // 
            this.mtPhone.CustomButton.Image = null;
            this.mtPhone.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.mtPhone.CustomButton.Name = "";
            this.mtPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtPhone.CustomButton.TabIndex = 1;
            this.mtPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtPhone.CustomButton.UseSelectable = true;
            this.mtPhone.CustomButton.Visible = false;
            this.mtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Phone", true));
            this.mtPhone.Lines = new string[0];
            this.mtPhone.Location = new System.Drawing.Point(410, 105);
            this.mtPhone.MaxLength = 32767;
            this.mtPhone.Name = "mtPhone";
            this.mtPhone.PasswordChar = '\0';
            this.mtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtPhone.SelectedText = "";
            this.mtPhone.SelectionLength = 0;
            this.mtPhone.SelectionStart = 0;
            this.mtPhone.ShortcutsEnabled = true;
            this.mtPhone.Size = new System.Drawing.Size(142, 23);
            this.mtPhone.TabIndex = 2;
            this.mtPhone.UseSelectable = true;
            this.mtPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mbtnSave
            // 
            this.mbtnSave.Location = new System.Drawing.Point(504, 363);
            this.mbtnSave.Name = "mbtnSave";
            this.mbtnSave.Size = new System.Drawing.Size(75, 23);
            this.mbtnSave.TabIndex = 4;
            this.mbtnSave.Text = "Сохранить";
            this.mbtnSave.UseSelectable = true;
            this.mbtnSave.Click += new System.EventHandler(this.mbtnSave_Click);
            // 
            // buildingsGrid
            // 
            this.buildingsGrid.AllowUserToAddRows = false;
            this.buildingsGrid.AllowUserToDeleteRows = false;
            this.buildingsGrid.AllowUserToResizeRows = false;
            this.buildingsGrid.AutoGenerateColumns = false;
            this.buildingsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buildingsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.buildingsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.buildingsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.buildingsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.buildingsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buildingsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addressDataGridViewTextBoxColumn,
            this.deliveryDistanseDataGridViewTextBoxColumn,
            this.colEdit,
            this.colDel});
            this.buildingsGrid.DataSource = this.buildingBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.buildingsGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.buildingsGrid.EnableHeadersVisualStyles = false;
            this.buildingsGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buildingsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buildingsGrid.Location = new System.Drawing.Point(45, 172);
            this.buildingsGrid.Name = "buildingsGrid";
            this.buildingsGrid.ReadOnly = true;
            this.buildingsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.buildingsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.buildingsGrid.RowHeadersVisible = false;
            this.buildingsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.buildingsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.buildingsGrid.Size = new System.Drawing.Size(319, 177);
            this.buildingsGrid.TabIndex = 5;
            this.buildingsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.buildingsGrid_CellContentClick);
            this.buildingsGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.buildingsGrid_RowsRemoved);
            this.buildingsGrid.SelectionChanged += new System.EventHandler(this.buildingsGrid_SelectionChanged);
            this.buildingsGrid.BindingContextChanged += new System.EventHandler(this.buildingsGrid_BindingContextChanged);
            this.buildingsGrid.DoubleClick += new System.EventHandler(this.buildingsGrid_DoubleClick);
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 200;
            // 
            // deliveryDistanseDataGridViewTextBoxColumn
            // 
            this.deliveryDistanseDataGridViewTextBoxColumn.DataPropertyName = "DeliveryDistanse";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.deliveryDistanseDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.deliveryDistanseDataGridViewTextBoxColumn.HeaderText = "Расстояние";
            this.deliveryDistanseDataGridViewTextBoxColumn.Name = "deliveryDistanseDataGridViewTextBoxColumn";
            this.deliveryDistanseDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliveryDistanseDataGridViewTextBoxColumn.Width = 80;
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
            // buildingBindingSource
            // 
            this.buildingBindingSource.DataSource = typeof(BrickWorks.Building);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(45, 150);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(124, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Строения клиента:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(370, 150);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(50, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Стены:";
            // 
            // wallsGrid
            // 
            this.wallsGrid.AllowUserToAddRows = false;
            this.wallsGrid.AllowUserToDeleteRows = false;
            this.wallsGrid.AllowUserToResizeRows = false;
            this.wallsGrid.AutoGenerateColumns = false;
            this.wallsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.wallsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wallsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.wallsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.wallsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.wallsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wallsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wallsLengthDataGridViewTextBoxColumn,
            this.wallsHeightDataGridViewTextBoxColumn,
            this.numberOfWallsDataGridViewTextBoxColumn,
            this.cEdit,
            this.cDelete});
            this.wallsGrid.DataSource = this.wallSizeBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.wallsGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.wallsGrid.EnableHeadersVisualStyles = false;
            this.wallsGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.wallsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.wallsGrid.Location = new System.Drawing.Point(370, 172);
            this.wallsGrid.Name = "wallsGrid";
            this.wallsGrid.ReadOnly = true;
            this.wallsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.wallsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.wallsGrid.RowHeadersVisible = false;
            this.wallsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.wallsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.wallsGrid.Size = new System.Drawing.Size(217, 177);
            this.wallsGrid.TabIndex = 7;
            this.wallsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.wallsGrid_CellContentClick);
            this.wallsGrid.DoubleClick += new System.EventHandler(this.wallsGrid_DoubleClick);
            // 
            // wallsLengthDataGridViewTextBoxColumn
            // 
            this.wallsLengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.wallsLengthDataGridViewTextBoxColumn.HeaderText = "Длина";
            this.wallsLengthDataGridViewTextBoxColumn.Name = "wallsLengthDataGridViewTextBoxColumn";
            this.wallsLengthDataGridViewTextBoxColumn.ReadOnly = true;
            this.wallsLengthDataGridViewTextBoxColumn.Width = 50;
            // 
            // wallsHeightDataGridViewTextBoxColumn
            // 
            this.wallsHeightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            this.wallsHeightDataGridViewTextBoxColumn.HeaderText = "Высота";
            this.wallsHeightDataGridViewTextBoxColumn.Name = "wallsHeightDataGridViewTextBoxColumn";
            this.wallsHeightDataGridViewTextBoxColumn.ReadOnly = true;
            this.wallsHeightDataGridViewTextBoxColumn.Width = 50;
            // 
            // numberOfWallsDataGridViewTextBoxColumn
            // 
            this.numberOfWallsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfWalls";
            this.numberOfWallsDataGridViewTextBoxColumn.HeaderText = "Кол-во";
            this.numberOfWallsDataGridViewTextBoxColumn.Name = "numberOfWallsDataGridViewTextBoxColumn";
            this.numberOfWallsDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberOfWallsDataGridViewTextBoxColumn.Width = 50;
            // 
            // cEdit
            // 
            this.cEdit.HeaderText = "";
            this.cEdit.Image = global::BrickWorks.Properties.Resources.edit_small;
            this.cEdit.Name = "cEdit";
            this.cEdit.ReadOnly = true;
            this.cEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cEdit.Width = 18;
            // 
            // cDelete
            // 
            this.cDelete.HeaderText = "";
            this.cDelete.Image = global::BrickWorks.Properties.Resources.delete_small;
            this.cDelete.Name = "cDelete";
            this.cDelete.ReadOnly = true;
            this.cDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cDelete.Width = 18;
            // 
            // wallSizeBindingSource
            // 
            this.wallSizeBindingSource.DataSource = typeof(BrickWorks.WallSize);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "###";
            this.dataGridViewImageColumn1.Image = global::BrickWorks.Properties.Resources.edit_small;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 18;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::BrickWorks.Properties.Resources.delete_small;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 18;
            // 
            // pbWallAdd
            // 
            this.pbWallAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbWallAdd.Image = global::BrickWorks.Properties.Resources.new_small;
            this.pbWallAdd.Location = new System.Drawing.Point(418, 152);
            this.pbWallAdd.Name = "pbWallAdd";
            this.pbWallAdd.Size = new System.Drawing.Size(16, 16);
            this.pbWallAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbWallAdd.TabIndex = 9;
            this.pbWallAdd.TabStop = false;
            this.pbWallAdd.Click += new System.EventHandler(this.pbWallAdd_Click);
            // 
            // pbBuildingAdd
            // 
            this.pbBuildingAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBuildingAdd.Image = global::BrickWorks.Properties.Resources.new_small;
            this.pbBuildingAdd.Location = new System.Drawing.Point(168, 152);
            this.pbBuildingAdd.Name = "pbBuildingAdd";
            this.pbBuildingAdd.Size = new System.Drawing.Size(16, 16);
            this.pbBuildingAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbBuildingAdd.TabIndex = 10;
            this.pbBuildingAdd.TabStop = false;
            this.pbBuildingAdd.Click += new System.EventHandler(this.pbBuildingAdd_Click);
            // 
            // ClientAddEditForm
            // 
            this.AcceptButton = this.mbtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 409);
            this.Controls.Add(this.pbBuildingAdd);
            this.Controls.Add(this.pbWallAdd);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.wallsGrid);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.buildingsGrid);
            this.Controls.Add(this.mbtnSave);
            this.Controls.Add(this.mtPhone);
            this.Controls.Add(this.mtName);
            this.Controls.Add(this.mtId);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientAddEditForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Информация о клиенте";
            this.Load += new System.EventHandler(this.ClientAddEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallSizeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWallAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuildingAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource clientBindingSource;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox mtId;
        private MetroFramework.Controls.MetroTextBox mtName;
        private MetroFramework.Controls.MetroTextBox mtPhone;
        private MetroFramework.Controls.MetroButton mbtnSave;
        private MetroFramework.Controls.MetroGrid buildingsGrid;
        private System.Windows.Forms.BindingSource buildingBindingSource;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroGrid wallsGrid;
        private System.Windows.Forms.BindingSource wallSizeBindingSource;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn wallsLengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wallsHeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfWallsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn cEdit;
        private System.Windows.Forms.DataGridViewImageColumn cDelete;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.PictureBox pbWallAdd;
        private System.Windows.Forms.PictureBox pbBuildingAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDistanseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn colEdit;
        private System.Windows.Forms.DataGridViewImageColumn colDel;
    }
}