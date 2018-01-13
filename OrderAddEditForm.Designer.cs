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
            this.mteDelivery = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(60, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "№ заказа:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(60, 117);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(40, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Дата:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(60, 155);
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
            this.mteOrderId.CustomButton.Location = new System.Drawing.Point(88, 1);
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
            this.mteOrderId.Location = new System.Drawing.Point(137, 79);
            this.mteOrderId.MaxLength = 32767;
            this.mteOrderId.Name = "mteOrderId";
            this.mteOrderId.PasswordChar = '\0';
            this.mteOrderId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mteOrderId.SelectedText = "";
            this.mteOrderId.SelectionLength = 0;
            this.mteOrderId.SelectionStart = 0;
            this.mteOrderId.ShortcutsEnabled = true;
            this.mteOrderId.Size = new System.Drawing.Size(110, 23);
            this.mteOrderId.TabIndex = 1;
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
            this.mteOrderDate.Location = new System.Drawing.Point(137, 114);
            this.mteOrderDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.mteOrderDate.Name = "mteOrderDate";
            this.mteOrderDate.Size = new System.Drawing.Size(110, 29);
            this.mteOrderDate.TabIndex = 2;
            this.mteOrderDate.Value = new System.DateTime(2018, 1, 10, 1, 49, 35, 0);
            // 
            // mcbClient
            // 
            this.mcbClient.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderBindingSource, "ClientId", true));
            this.mcbClient.DataSource = this.clientBindingSource;
            this.mcbClient.DisplayMember = "Name";
            this.mcbClient.FormattingEnabled = true;
            this.mcbClient.ItemHeight = 23;
            this.mcbClient.Location = new System.Drawing.Point(137, 155);
            this.mcbClient.Name = "mcbClient";
            this.mcbClient.Size = new System.Drawing.Size(222, 29);
            this.mcbClient.TabIndex = 3;
            this.mcbClient.UseSelectable = true;
            this.mcbClient.ValueMember = "Id";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(BrickWorks.Client);
            // 
            // mbtnSave
            // 
            this.mbtnSave.Location = new System.Drawing.Point(451, 364);
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
            this.metroLabel4.Location = new System.Drawing.Point(60, 196);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(67, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Доставка:";
            // 
            // mteDelivery
            // 
            // 
            // 
            // 
            this.mteDelivery.CustomButton.Image = null;
            this.mteDelivery.CustomButton.Location = new System.Drawing.Point(88, 1);
            this.mteDelivery.CustomButton.Name = "";
            this.mteDelivery.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mteDelivery.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mteDelivery.CustomButton.TabIndex = 1;
            this.mteDelivery.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mteDelivery.CustomButton.UseSelectable = true;
            this.mteDelivery.CustomButton.Visible = false;
            this.mteDelivery.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "DeliveryCost", true));
            this.mteDelivery.Lines = new string[0];
            this.mteDelivery.Location = new System.Drawing.Point(137, 196);
            this.mteDelivery.MaxLength = 32767;
            this.mteDelivery.Name = "mteDelivery";
            this.mteDelivery.PasswordChar = '\0';
            this.mteDelivery.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mteDelivery.SelectedText = "";
            this.mteDelivery.SelectionLength = 0;
            this.mteDelivery.SelectionStart = 0;
            this.mteDelivery.ShortcutsEnabled = true;
            this.mteDelivery.Size = new System.Drawing.Size(110, 23);
            this.mteDelivery.TabIndex = 4;
            this.mteDelivery.UseSelectable = true;
            this.mteDelivery.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mteDelivery.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // OrderAddEditForm
            // 
            this.AcceptButton = this.mbtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.Controls.Add(this.mteDelivery);
            this.Controls.Add(this.metroLabel4);
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
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Информация о заказе";
            this.Load += new System.EventHandler(this.OrderAddEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox mteOrderId;
        private MetroFramework.Controls.MetroDateTime mteOrderDate;
        private MetroFramework.Controls.MetroComboBox mcbClient;
        private MetroFramework.Controls.MetroButton mbtnSave;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox mteDelivery;
    }
}