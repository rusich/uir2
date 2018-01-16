namespace BrickWorks
{
    partial class WallAddEditForm
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
            this.mtbLenght = new MetroFramework.Controls.MetroTextBox();
            this.wallSizeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtbSave = new MetroFramework.Controls.MetroButton();
            this.mtbHeight = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtbNum = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.wallSizeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mtbLenght
            // 
            // 
            // 
            // 
            this.mtbLenght.CustomButton.Image = null;
            this.mtbLenght.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.mtbLenght.CustomButton.Name = "";
            this.mtbLenght.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbLenght.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbLenght.CustomButton.TabIndex = 1;
            this.mtbLenght.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbLenght.CustomButton.UseSelectable = true;
            this.mtbLenght.CustomButton.Visible = false;
            this.mtbLenght.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wallSizeBindingSource, "Length", true));
            this.mtbLenght.Lines = new string[0];
            this.mtbLenght.Location = new System.Drawing.Point(104, 58);
            this.mtbLenght.MaxLength = 32767;
            this.mtbLenght.Name = "mtbLenght";
            this.mtbLenght.PasswordChar = '\0';
            this.mtbLenght.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbLenght.SelectedText = "";
            this.mtbLenght.SelectionLength = 0;
            this.mtbLenght.SelectionStart = 0;
            this.mtbLenght.ShortcutsEnabled = true;
            this.mtbLenght.Size = new System.Drawing.Size(74, 23);
            this.mtbLenght.TabIndex = 0;
            this.mtbLenght.UseSelectable = true;
            this.mtbLenght.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbLenght.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // wallSizeBindingSource
            // 
            this.wallSizeBindingSource.DataSource = typeof(BrickWorks.WallSize);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(33, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Длина:";
            // 
            // mtbSave
            // 
            this.mtbSave.Location = new System.Drawing.Point(117, 167);
            this.mtbSave.Name = "mtbSave";
            this.mtbSave.Size = new System.Drawing.Size(75, 23);
            this.mtbSave.TabIndex = 3;
            this.mtbSave.Text = "Сохранить";
            this.mtbSave.UseSelectable = true;
            this.mtbSave.Click += new System.EventHandler(this.mtbSave_Click);
            // 
            // mtbHeight
            // 
            // 
            // 
            // 
            this.mtbHeight.CustomButton.Image = null;
            this.mtbHeight.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.mtbHeight.CustomButton.Name = "";
            this.mtbHeight.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbHeight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbHeight.CustomButton.TabIndex = 1;
            this.mtbHeight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbHeight.CustomButton.UseSelectable = true;
            this.mtbHeight.CustomButton.Visible = false;
            this.mtbHeight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wallSizeBindingSource, "Height", true));
            this.mtbHeight.Lines = new string[0];
            this.mtbHeight.Location = new System.Drawing.Point(104, 91);
            this.mtbHeight.MaxLength = 32767;
            this.mtbHeight.Name = "mtbHeight";
            this.mtbHeight.PasswordChar = '\0';
            this.mtbHeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbHeight.SelectedText = "";
            this.mtbHeight.SelectionLength = 0;
            this.mtbHeight.SelectionStart = 0;
            this.mtbHeight.ShortcutsEnabled = true;
            this.mtbHeight.Size = new System.Drawing.Size(74, 23);
            this.mtbHeight.TabIndex = 1;
            this.mtbHeight.UseSelectable = true;
            this.mtbHeight.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbHeight.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(33, 93);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Ширина:";
            // 
            // mtbNum
            // 
            // 
            // 
            // 
            this.mtbNum.CustomButton.Image = null;
            this.mtbNum.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.mtbNum.CustomButton.Name = "";
            this.mtbNum.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbNum.CustomButton.TabIndex = 1;
            this.mtbNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbNum.CustomButton.UseSelectable = true;
            this.mtbNum.CustomButton.Visible = false;
            this.mtbNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wallSizeBindingSource, "NumberOfWalls", true));
            this.mtbNum.Lines = new string[0];
            this.mtbNum.Location = new System.Drawing.Point(104, 126);
            this.mtbNum.MaxLength = 32767;
            this.mtbNum.Name = "mtbNum";
            this.mtbNum.PasswordChar = '\0';
            this.mtbNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbNum.SelectedText = "";
            this.mtbNum.SelectionLength = 0;
            this.mtbNum.SelectionStart = 0;
            this.mtbNum.ShortcutsEnabled = true;
            this.mtbNum.Size = new System.Drawing.Size(74, 23);
            this.mtbNum.TabIndex = 2;
            this.mtbNum.UseSelectable = true;
            this.mtbNum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbNum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(33, 128);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(55, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Кол-во:";
            // 
            // WallAddEditForm
            // 
            this.AcceptButton = this.mtbSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 213);
            this.Controls.Add(this.mtbSave);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mtbNum);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mtbHeight);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mtbLenght);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WallAddEditForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Стена";
            ((System.ComponentModel.ISupportInitialize)(this.wallSizeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox mtbLenght;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton mtbSave;
        private MetroFramework.Controls.MetroTextBox mtbHeight;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mtbNum;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.BindingSource wallSizeBindingSource;
    }
}