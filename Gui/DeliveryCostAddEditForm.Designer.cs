namespace BrickWorks
{
    partial class DeliveryCostAddEditForm
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
            this.mbtSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtbCost = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mdtDate = new MetroFramework.Controls.MetroDateTime();
            this.deliveryCostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.deliveryCostBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mbtSave
            // 
            this.mbtSave.Location = new System.Drawing.Point(235, 154);
            this.mbtSave.Name = "mbtSave";
            this.mbtSave.Size = new System.Drawing.Size(75, 23);
            this.mbtSave.TabIndex = 0;
            this.mbtSave.Text = "Сохранить";
            this.mbtSave.UseSelectable = true;
            this.mbtSave.Click += new System.EventHandler(this.mbtSave_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(39, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(40, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Дата:";
            // 
            // mtbCost
            // 
            // 
            // 
            // 
            this.mtbCost.CustomButton.Image = null;
            this.mtbCost.CustomButton.Location = new System.Drawing.Point(93, 1);
            this.mtbCost.CustomButton.Name = "";
            this.mtbCost.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbCost.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbCost.CustomButton.TabIndex = 1;
            this.mtbCost.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbCost.CustomButton.UseSelectable = true;
            this.mtbCost.CustomButton.Visible = false;
            this.mtbCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryCostBindingSource, "CostPerKm", true));
            this.mtbCost.Lines = new string[0];
            this.mtbCost.Location = new System.Drawing.Point(125, 96);
            this.mtbCost.MaxLength = 32767;
            this.mtbCost.Name = "mtbCost";
            this.mtbCost.PasswordChar = '\0';
            this.mtbCost.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbCost.SelectedText = "";
            this.mtbCost.SelectionLength = 0;
            this.mtbCost.SelectionStart = 0;
            this.mtbCost.ShortcutsEnabled = true;
            this.mtbCost.Size = new System.Drawing.Size(115, 23);
            this.mtbCost.TabIndex = 1;
            this.mtbCost.UseSelectable = true;
            this.mtbCost.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbCost.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(39, 98);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Цена за км:";
            // 
            // mdtDate
            // 
            this.mdtDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryCostBindingSource, "Date", true));
            this.mdtDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.deliveryCostBindingSource, "Date", true));
            this.mdtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mdtDate.Location = new System.Drawing.Point(125, 59);
            this.mdtDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtDate.Name = "mdtDate";
            this.mdtDate.Size = new System.Drawing.Size(115, 29);
            this.mdtDate.TabIndex = 3;
            this.mdtDate.Value = new System.DateTime(2018, 1, 15, 10, 50, 34, 0);
            this.mdtDate.ValueChanged += new System.EventHandler(this.mdtDate_ValueChanged);
            // 
            // deliveryCostBindingSource
            // 
            this.deliveryCostBindingSource.DataSource = typeof(BrickWorks.DeliveryCost);
            // 
            // DeliveryCostAddEditForm
            // 
            this.AcceptButton = this.mbtSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 200);
            this.Controls.Add(this.mdtDate);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mtbCost);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mbtSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeliveryCostAddEditForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Информация о доставке";
            ((System.ComponentModel.ISupportInitialize)(this.deliveryCostBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton mbtSave;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox mtbCost;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.BindingSource deliveryCostBindingSource;
        private MetroFramework.Controls.MetroDateTime mdtDate;
    }
}