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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mtId = new MetroFramework.Controls.MetroTextBox();
            this.mtName = new MetroFramework.Controls.MetroTextBox();
            this.mtPhone = new MetroFramework.Controls.MetroTextBox();
            this.mbtnSave = new MetroFramework.Controls.MetroButton();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(60, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "№ клиента:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(60, 117);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Ф.И.О.:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(60, 155);
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
            this.mtId.CustomButton.Location = new System.Drawing.Point(98, 1);
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
            this.mtId.Location = new System.Drawing.Point(141, 79);
            this.mtId.MaxLength = 32767;
            this.mtId.Name = "mtId";
            this.mtId.PasswordChar = '\0';
            this.mtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtId.SelectedText = "";
            this.mtId.SelectionLength = 0;
            this.mtId.SelectionStart = 0;
            this.mtId.ShortcutsEnabled = true;
            this.mtId.Size = new System.Drawing.Size(120, 23);
            this.mtId.TabIndex = 1;
            this.mtId.UseSelectable = true;
            this.mtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.mtName.Location = new System.Drawing.Point(141, 118);
            this.mtName.MaxLength = 32767;
            this.mtName.Name = "mtName";
            this.mtName.PasswordChar = '\0';
            this.mtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtName.SelectedText = "";
            this.mtName.SelectionLength = 0;
            this.mtName.SelectionStart = 0;
            this.mtName.ShortcutsEnabled = true;
            this.mtName.Size = new System.Drawing.Size(217, 23);
            this.mtName.TabIndex = 2;
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
            this.mtPhone.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.mtPhone.CustomButton.Name = "";
            this.mtPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtPhone.CustomButton.TabIndex = 1;
            this.mtPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtPhone.CustomButton.UseSelectable = true;
            this.mtPhone.CustomButton.Visible = false;
            this.mtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Phone", true));
            this.mtPhone.Lines = new string[0];
            this.mtPhone.Location = new System.Drawing.Point(141, 156);
            this.mtPhone.MaxLength = 32767;
            this.mtPhone.Name = "mtPhone";
            this.mtPhone.PasswordChar = '\0';
            this.mtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtPhone.SelectedText = "";
            this.mtPhone.SelectionLength = 0;
            this.mtPhone.SelectionStart = 0;
            this.mtPhone.ShortcutsEnabled = true;
            this.mtPhone.Size = new System.Drawing.Size(158, 23);
            this.mtPhone.TabIndex = 3;
            this.mtPhone.UseSelectable = true;
            this.mtPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mbtnSave
            // 
            this.mbtnSave.Location = new System.Drawing.Point(344, 250);
            this.mbtnSave.Name = "mbtnSave";
            this.mbtnSave.Size = new System.Drawing.Size(75, 23);
            this.mbtnSave.TabIndex = 4;
            this.mbtnSave.Text = "Сохранить";
            this.mbtnSave.UseSelectable = true;
            this.mbtnSave.Click += new System.EventHandler(this.mbtnSave_Click);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(BrickWorks.Client);
            // 
            // ClientAddEditForm
            // 
            this.AcceptButton = this.mbtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 296);
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
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Информация о клиенте";
            this.Load += new System.EventHandler(this.ClientAddEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
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
    }
}