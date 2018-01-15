namespace BrickWorks
{
    partial class BuildingAddEditForm
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
            this.mtbAddress = new MetroFramework.Controls.MetroTextBox();
            this.buildingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mbSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtbDistance = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(36, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Адрес:";
            // 
            // mtbAddress
            // 
            // 
            // 
            // 
            this.mtbAddress.CustomButton.Image = null;
            this.mtbAddress.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.mtbAddress.CustomButton.Name = "";
            this.mtbAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbAddress.CustomButton.TabIndex = 1;
            this.mtbAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbAddress.CustomButton.UseSelectable = true;
            this.mtbAddress.CustomButton.Visible = false;
            this.mtbAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buildingBindingSource, "Address", true));
            this.mtbAddress.Lines = new string[0];
            this.mtbAddress.Location = new System.Drawing.Point(122, 69);
            this.mtbAddress.MaxLength = 32767;
            this.mtbAddress.Name = "mtbAddress";
            this.mtbAddress.PasswordChar = '\0';
            this.mtbAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbAddress.SelectedText = "";
            this.mtbAddress.SelectionLength = 0;
            this.mtbAddress.SelectionStart = 0;
            this.mtbAddress.ShortcutsEnabled = true;
            this.mtbAddress.Size = new System.Drawing.Size(173, 23);
            this.mtbAddress.TabIndex = 0;
            this.mtbAddress.UseSelectable = true;
            this.mtbAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // buildingBindingSource
            // 
            this.buildingBindingSource.DataSource = typeof(BrickWorks.Building);
            // 
            // mbSave
            // 
            this.mbSave.Location = new System.Drawing.Point(236, 166);
            this.mbSave.Name = "mbSave";
            this.mbSave.Size = new System.Drawing.Size(75, 23);
            this.mbSave.TabIndex = 2;
            this.mbSave.Text = " Сохранить";
            this.mbSave.UseSelectable = true;
            this.mbSave.Click += new System.EventHandler(this.mbSave_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(36, 107);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Расстояние:";
            // 
            // mtbDistance
            // 
            // 
            // 
            // 
            this.mtbDistance.CustomButton.Image = null;
            this.mtbDistance.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.mtbDistance.CustomButton.Name = "";
            this.mtbDistance.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbDistance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbDistance.CustomButton.TabIndex = 1;
            this.mtbDistance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbDistance.CustomButton.UseSelectable = true;
            this.mtbDistance.CustomButton.Visible = false;
            this.mtbDistance.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buildingBindingSource, "DeliveryDistanse", true));
            this.mtbDistance.Lines = new string[0];
            this.mtbDistance.Location = new System.Drawing.Point(122, 105);
            this.mtbDistance.MaxLength = 32767;
            this.mtbDistance.Name = "mtbDistance";
            this.mtbDistance.PasswordChar = '\0';
            this.mtbDistance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbDistance.SelectedText = "";
            this.mtbDistance.SelectionLength = 0;
            this.mtbDistance.SelectionStart = 0;
            this.mtbDistance.ShortcutsEnabled = true;
            this.mtbDistance.Size = new System.Drawing.Size(173, 23);
            this.mtbDistance.TabIndex = 1;
            this.mtbDistance.UseSelectable = true;
            this.mtbDistance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbDistance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BuildingAddEditForm
            // 
            this.AcceptButton = this.mbSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(334, 212);
            this.Controls.Add(this.mbSave);
            this.Controls.Add(this.mtbDistance);
            this.Controls.Add(this.mtbAddress);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuildingAddEditForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Строение";
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox mtbAddress;
        private MetroFramework.Controls.MetroButton mbSave;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mtbDistance;
        private System.Windows.Forms.BindingSource buildingBindingSource;
    }
}