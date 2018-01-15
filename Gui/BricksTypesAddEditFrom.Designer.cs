namespace BrickWorks
{
    partial class BricksTypesAddEditFrom
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
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.mtbMark = new MetroFramework.Controls.MetroTextBox();
            this.brickBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mtbHeight = new MetroFramework.Controls.MetroTextBox();
            this.mtbWidth = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox5 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtbLenght = new MetroFramework.Controls.MetroTextBox();
            this.mbtSave = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.brickBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(41, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Марка:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(41, 126);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(55, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Высота:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(41, 159);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(63, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Ширина:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(41, 192);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(109, 19);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Характеристики:";
            // 
            // mtbMark
            // 
            // 
            // 
            // 
            this.mtbMark.CustomButton.Image = null;
            this.mtbMark.CustomButton.Location = new System.Drawing.Point(324, 1);
            this.mtbMark.CustomButton.Name = "";
            this.mtbMark.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbMark.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbMark.CustomButton.TabIndex = 1;
            this.mtbMark.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbMark.CustomButton.UseSelectable = true;
            this.mtbMark.CustomButton.Visible = false;
            this.mtbMark.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brickBindingSource, "Mark", true));
            this.mtbMark.Lines = new string[0];
            this.mtbMark.Location = new System.Drawing.Point(150, 58);
            this.mtbMark.MaxLength = 32767;
            this.mtbMark.Name = "mtbMark";
            this.mtbMark.PasswordChar = '\0';
            this.mtbMark.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbMark.SelectedText = "";
            this.mtbMark.SelectionLength = 0;
            this.mtbMark.SelectionStart = 0;
            this.mtbMark.ShortcutsEnabled = true;
            this.mtbMark.Size = new System.Drawing.Size(346, 23);
            this.mtbMark.TabIndex = 0;
            this.mtbMark.UseSelectable = true;
            this.mtbMark.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbMark.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // brickBindingSource
            // 
            this.brickBindingSource.DataSource = typeof(BrickWorks.Brick);
            // 
            // mtbHeight
            // 
            // 
            // 
            // 
            this.mtbHeight.CustomButton.Image = null;
            this.mtbHeight.CustomButton.Location = new System.Drawing.Point(66, 1);
            this.mtbHeight.CustomButton.Name = "";
            this.mtbHeight.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbHeight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbHeight.CustomButton.TabIndex = 1;
            this.mtbHeight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbHeight.CustomButton.UseSelectable = true;
            this.mtbHeight.CustomButton.Visible = false;
            this.mtbHeight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brickBindingSource, "Height", true));
            this.mtbHeight.Lines = new string[0];
            this.mtbHeight.Location = new System.Drawing.Point(150, 124);
            this.mtbHeight.MaxLength = 32767;
            this.mtbHeight.Name = "mtbHeight";
            this.mtbHeight.PasswordChar = '\0';
            this.mtbHeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbHeight.SelectedText = "";
            this.mtbHeight.SelectionLength = 0;
            this.mtbHeight.SelectionStart = 0;
            this.mtbHeight.ShortcutsEnabled = true;
            this.mtbHeight.Size = new System.Drawing.Size(88, 23);
            this.mtbHeight.TabIndex = 2;
            this.mtbHeight.UseSelectable = true;
            this.mtbHeight.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbHeight.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbWidth
            // 
            // 
            // 
            // 
            this.mtbWidth.CustomButton.Image = null;
            this.mtbWidth.CustomButton.Location = new System.Drawing.Point(66, 1);
            this.mtbWidth.CustomButton.Name = "";
            this.mtbWidth.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbWidth.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbWidth.CustomButton.TabIndex = 1;
            this.mtbWidth.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbWidth.CustomButton.UseSelectable = true;
            this.mtbWidth.CustomButton.Visible = false;
            this.mtbWidth.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brickBindingSource, "Width", true));
            this.mtbWidth.Lines = new string[0];
            this.mtbWidth.Location = new System.Drawing.Point(150, 157);
            this.mtbWidth.MaxLength = 32767;
            this.mtbWidth.Name = "mtbWidth";
            this.mtbWidth.PasswordChar = '\0';
            this.mtbWidth.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbWidth.SelectedText = "";
            this.mtbWidth.SelectionLength = 0;
            this.mtbWidth.SelectionStart = 0;
            this.mtbWidth.ShortcutsEnabled = true;
            this.mtbWidth.Size = new System.Drawing.Size(88, 23);
            this.mtbWidth.TabIndex = 3;
            this.mtbWidth.UseSelectable = true;
            this.mtbWidth.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbWidth.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox5
            // 
            // 
            // 
            // 
            this.metroTextBox5.CustomButton.Image = null;
            this.metroTextBox5.CustomButton.Location = new System.Drawing.Point(324, 1);
            this.metroTextBox5.CustomButton.Name = "";
            this.metroTextBox5.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox5.CustomButton.TabIndex = 1;
            this.metroTextBox5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox5.CustomButton.UseSelectable = true;
            this.metroTextBox5.CustomButton.Visible = false;
            this.metroTextBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brickBindingSource, "Parameters", true));
            this.metroTextBox5.Lines = new string[0];
            this.metroTextBox5.Location = new System.Drawing.Point(150, 190);
            this.metroTextBox5.MaxLength = 32767;
            this.metroTextBox5.Name = "metroTextBox5";
            this.metroTextBox5.PasswordChar = '\0';
            this.metroTextBox5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox5.SelectedText = "";
            this.metroTextBox5.SelectionLength = 0;
            this.metroTextBox5.SelectionStart = 0;
            this.metroTextBox5.ShortcutsEnabled = true;
            this.metroTextBox5.Size = new System.Drawing.Size(346, 23);
            this.metroTextBox5.TabIndex = 4;
            this.metroTextBox5.UseSelectable = true;
            this.metroTextBox5.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox5.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(41, 93);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Длина:";
            // 
            // mtbLenght
            // 
            // 
            // 
            // 
            this.mtbLenght.CustomButton.Image = null;
            this.mtbLenght.CustomButton.Location = new System.Drawing.Point(66, 1);
            this.mtbLenght.CustomButton.Name = "";
            this.mtbLenght.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbLenght.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbLenght.CustomButton.TabIndex = 1;
            this.mtbLenght.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbLenght.CustomButton.UseSelectable = true;
            this.mtbLenght.CustomButton.Visible = false;
            this.mtbLenght.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brickBindingSource, "Lenght", true));
            this.mtbLenght.Lines = new string[0];
            this.mtbLenght.Location = new System.Drawing.Point(150, 91);
            this.mtbLenght.MaxLength = 32767;
            this.mtbLenght.Name = "mtbLenght";
            this.mtbLenght.PasswordChar = '\0';
            this.mtbLenght.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbLenght.SelectedText = "";
            this.mtbLenght.SelectionLength = 0;
            this.mtbLenght.SelectionStart = 0;
            this.mtbLenght.ShortcutsEnabled = true;
            this.mtbLenght.Size = new System.Drawing.Size(88, 23);
            this.mtbLenght.TabIndex = 1;
            this.mtbLenght.UseSelectable = true;
            this.mtbLenght.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbLenght.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mbtSave
            // 
            this.mbtSave.Location = new System.Drawing.Point(421, 225);
            this.mbtSave.Name = "mbtSave";
            this.mbtSave.Size = new System.Drawing.Size(75, 23);
            this.mbtSave.TabIndex = 5;
            this.mbtSave.Text = "Сохранить";
            this.mbtSave.UseSelectable = true;
            this.mbtSave.Click += new System.EventHandler(this.mbtSave_Click);
            // 
            // BricksTypesAddEditFrom
            // 
            this.AcceptButton = this.mbtSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 271);
            this.Controls.Add(this.mbtSave);
            this.Controls.Add(this.metroTextBox5);
            this.Controls.Add(this.mtbWidth);
            this.Controls.Add(this.mtbHeight);
            this.Controls.Add(this.mtbLenght);
            this.Controls.Add(this.mtbMark);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BricksTypesAddEditFrom";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Информация о виде продукции";
            ((System.ComponentModel.ISupportInitialize)(this.brickBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox mtbMark;
        private MetroFramework.Controls.MetroTextBox mtbHeight;
        private MetroFramework.Controls.MetroTextBox mtbWidth;
        private MetroFramework.Controls.MetroTextBox metroTextBox5;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mtbLenght;
        private MetroFramework.Controls.MetroButton mbtSave;
        private System.Windows.Forms.BindingSource brickBindingSource;
    }
}