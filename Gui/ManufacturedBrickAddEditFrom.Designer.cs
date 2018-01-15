namespace BrickWorks
{
    partial class ManufacturedBrickAddEditFrom
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
            this.mDate = new MetroFramework.Controls.MetroDateTime();
            this.manufacturedBrickBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mcbBrick = new MetroFramework.Controls.MetroComboBox();
            this.brickBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mtbQuantity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mbSave = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturedBrickBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brickBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(44, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(40, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Дата:";
            // 
            // mDate
            // 
            this.mDate.CustomFormat = "dd-mm-yyyy";
            this.mDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.manufacturedBrickBindingSource, "Date", true));
            this.mDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturedBrickBindingSource, "Date", true));
            this.mDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mDate.Location = new System.Drawing.Point(132, 77);
            this.mDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.mDate.Name = "mDate";
            this.mDate.Size = new System.Drawing.Size(200, 29);
            this.mDate.TabIndex = 1;
            this.mDate.Value = new System.DateTime(2018, 1, 15, 12, 45, 11, 0);
            // 
            // manufacturedBrickBindingSource
            // 
            this.manufacturedBrickBindingSource.DataSource = typeof(BrickWorks.ManufacturedBrick);
            // 
            // mcbBrick
            // 
            this.mcbBrick.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.manufacturedBrickBindingSource, "BrickId", true));
            this.mcbBrick.DataSource = this.brickBindingSource;
            this.mcbBrick.DisplayMember = "Mark";
            this.mcbBrick.FormattingEnabled = true;
            this.mcbBrick.ItemHeight = 23;
            this.mcbBrick.Location = new System.Drawing.Point(132, 112);
            this.mcbBrick.Name = "mcbBrick";
            this.mcbBrick.Size = new System.Drawing.Size(347, 29);
            this.mcbBrick.TabIndex = 2;
            this.mcbBrick.UseSelectable = true;
            this.mcbBrick.ValueMember = "Id";
            // 
            // brickBindingSource
            // 
            this.brickBindingSource.DataSource = typeof(BrickWorks.Brick);
            // 
            // mtbQuantity
            // 
            // 
            // 
            // 
            this.mtbQuantity.CustomButton.Image = null;
            this.mtbQuantity.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.mtbQuantity.CustomButton.Name = "";
            this.mtbQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbQuantity.CustomButton.TabIndex = 1;
            this.mtbQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbQuantity.CustomButton.UseSelectable = true;
            this.mtbQuantity.CustomButton.Visible = false;
            this.mtbQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturedBrickBindingSource, "Quantity", true));
            this.mtbQuantity.Lines = new string[0];
            this.mtbQuantity.Location = new System.Drawing.Point(132, 147);
            this.mtbQuantity.MaxLength = 32767;
            this.mtbQuantity.Name = "mtbQuantity";
            this.mtbQuantity.PasswordChar = '\0';
            this.mtbQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbQuantity.SelectedText = "";
            this.mtbQuantity.SelectionLength = 0;
            this.mtbQuantity.SelectionStart = 0;
            this.mtbQuantity.ShortcutsEnabled = true;
            this.mtbQuantity.Size = new System.Drawing.Size(75, 23);
            this.mtbQuantity.TabIndex = 3;
            this.mtbQuantity.UseSelectable = true;
            this.mtbQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(44, 114);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(35, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Вид:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(44, 151);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(82, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Количество:";
            // 
            // mbSave
            // 
            this.mbSave.Location = new System.Drawing.Point(420, 208);
            this.mbSave.Name = "mbSave";
            this.mbSave.Size = new System.Drawing.Size(75, 23);
            this.mbSave.TabIndex = 4;
            this.mbSave.Text = "Сохранить";
            this.mbSave.UseSelectable = true;
            this.mbSave.Click += new System.EventHandler(this.mbSave_Click);
            // 
            // ManufacturedBrickAddEditFrom
            // 
            this.AcceptButton = this.mbSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 254);
            this.Controls.Add(this.mbSave);
            this.Controls.Add(this.mtbQuantity);
            this.Controls.Add(this.mcbBrick);
            this.Controls.Add(this.mDate);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManufacturedBrickAddEditFrom";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Информация о выпускаемой продукции";
            ((System.ComponentModel.ISupportInitialize)(this.manufacturedBrickBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brickBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime mDate;
        private MetroFramework.Controls.MetroComboBox mcbBrick;
        private MetroFramework.Controls.MetroTextBox mtbQuantity;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.BindingSource manufacturedBrickBindingSource;
        private System.Windows.Forms.BindingSource brickBindingSource;
        private MetroFramework.Controls.MetroButton mbSave;
    }
}