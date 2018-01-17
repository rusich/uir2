namespace BrickWorks
{
    partial class BrickCostAddEditForm
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
            this.mtbCost = new MetroFramework.Controls.MetroTextBox();
            this.brickCostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mbSave = new MetroFramework.Controls.MetroButton();
            this.mcbBrick = new MetroFramework.Controls.MetroComboBox();
            this.brickBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mdtDate = new MetroFramework.Controls.MetroDateTime();
            ((System.ComponentModel.ISupportInitialize)(this.brickCostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brickBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mtbCost
            // 
            // 
            // 
            // 
            this.mtbCost.CustomButton.Image = null;
            this.mtbCost.CustomButton.Location = new System.Drawing.Point(62, 1);
            this.mtbCost.CustomButton.Name = "";
            this.mtbCost.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbCost.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbCost.CustomButton.TabIndex = 1;
            this.mtbCost.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbCost.CustomButton.UseSelectable = true;
            this.mtbCost.CustomButton.Visible = false;
            this.mtbCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brickCostBindingSource, "Cost", true));
            this.mtbCost.Lines = new string[0];
            this.mtbCost.Location = new System.Drawing.Point(144, 146);
            this.mtbCost.MaxLength = 32767;
            this.mtbCost.Name = "mtbCost";
            this.mtbCost.PasswordChar = '\0';
            this.mtbCost.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbCost.SelectedText = "";
            this.mtbCost.SelectionLength = 0;
            this.mtbCost.SelectionStart = 0;
            this.mtbCost.ShortcutsEnabled = true;
            this.mtbCost.Size = new System.Drawing.Size(84, 23);
            this.mtbCost.TabIndex = 6;
            this.mtbCost.UseSelectable = true;
            this.mtbCost.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbCost.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // brickCostBindingSource
            // 
            this.brickCostBindingSource.DataSource = typeof(BrickWorks.BrickCost);
            // 
            // mbSave
            // 
            this.mbSave.Location = new System.Drawing.Point(359, 189);
            this.mbSave.Name = "mbSave";
            this.mbSave.Size = new System.Drawing.Size(75, 23);
            this.mbSave.TabIndex = 7;
            this.mbSave.Text = "Сохранить";
            this.mbSave.UseSelectable = true;
            this.mbSave.Click += new System.EventHandler(this.mbSave_Click);
            // 
            // mcbBrick
            // 
            this.mcbBrick.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.brickCostBindingSource, "BrickId", true));
            this.mcbBrick.DataSource = this.brickBindingSource;
            this.mcbBrick.DisplayMember = "Mark";
            this.mcbBrick.FormattingEnabled = true;
            this.mcbBrick.ItemHeight = 23;
            this.mcbBrick.Location = new System.Drawing.Point(144, 103);
            this.mcbBrick.Name = "mcbBrick";
            this.mcbBrick.Size = new System.Drawing.Size(291, 29);
            this.mcbBrick.TabIndex = 3;
            this.mcbBrick.UseSelectable = true;
            this.mcbBrick.ValueMember = "Id";
            // 
            // brickBindingSource
            // 
            this.brickBindingSource.DataSource = typeof(BrickWorks.Brick);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 147);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(117, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Цена за единицу:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 107);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(108, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Марка кирпича:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 64);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(40, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Дата:";
            // 
            // mdtDate
            // 
            this.mdtDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.brickCostBindingSource, "Date", true));
            this.mdtDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brickCostBindingSource, "Date", true));
            this.mdtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mdtDate.Location = new System.Drawing.Point(144, 61);
            this.mdtDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtDate.Name = "mdtDate";
            this.mdtDate.Size = new System.Drawing.Size(115, 29);
            this.mdtDate.TabIndex = 9;
            this.mdtDate.Value = new System.DateTime(2018, 1, 15, 10, 50, 34, 0);
            // 
            // BrickCostAddEditForm
            // 
            this.AcceptButton = this.mbSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 232);
            this.Controls.Add(this.mdtDate);
            this.Controls.Add(this.mtbCost);
            this.Controls.Add(this.mbSave);
            this.Controls.Add(this.mcbBrick);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BrickCostAddEditForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Цена на кирпич";
            ((System.ComponentModel.ISupportInitialize)(this.brickCostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brickBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox mtbCost;
        private MetroFramework.Controls.MetroButton mbSave;
        public MetroFramework.Controls.MetroComboBox mcbBrick;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.BindingSource brickCostBindingSource;
        private System.Windows.Forms.BindingSource brickBindingSource;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime mdtDate;
    }
}