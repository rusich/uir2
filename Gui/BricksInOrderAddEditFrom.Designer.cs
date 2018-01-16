namespace BrickWorks
{
    partial class BricksInOrderAddEditFrom
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
            this.mcbBrick = new MetroFramework.Controls.MetroComboBox();
            this.orderedBrickBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brickBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mbSave = new MetroFramework.Controls.MetroButton();
            this.mtbQuantity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mlRemainingBricks = new MetroFramework.Controls.MetroLabel();
            this.mbCalc = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.orderedBrickBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brickBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(108, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Марка кирпича:";
            // 
            // mcbBrick
            // 
            this.mcbBrick.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderedBrickBindingSource, "BrickId", true));
            this.mcbBrick.DataSource = this.brickBindingSource;
            this.mcbBrick.DisplayMember = "Mark";
            this.mcbBrick.FormattingEnabled = true;
            this.mcbBrick.ItemHeight = 23;
            this.mcbBrick.Location = new System.Drawing.Point(148, 69);
            this.mcbBrick.Name = "mcbBrick";
            this.mcbBrick.Size = new System.Drawing.Size(291, 29);
            this.mcbBrick.TabIndex = 0;
            this.mcbBrick.UseSelectable = true;
            this.mcbBrick.ValueMember = "Id";
            this.mcbBrick.SelectedIndexChanged += new System.EventHandler(this.mcbBrick_SelectedIndexChanged);
            // 
            // orderedBrickBindingSource
            // 
            this.orderedBrickBindingSource.DataSource = typeof(BrickWorks.OrderedBrick);
            // 
            // brickBindingSource
            // 
            this.brickBindingSource.DataSource = typeof(BrickWorks.Brick);
            // 
            // mbSave
            // 
            this.mbSave.Location = new System.Drawing.Point(406, 212);
            this.mbSave.Name = "mbSave";
            this.mbSave.Size = new System.Drawing.Size(75, 23);
            this.mbSave.TabIndex = 2;
            this.mbSave.Text = "Сохранить";
            this.mbSave.UseSelectable = true;
            this.mbSave.Click += new System.EventHandler(this.mbSave_Click);
            // 
            // mtbQuantity
            // 
            // 
            // 
            // 
            this.mtbQuantity.CustomButton.Image = null;
            this.mtbQuantity.CustomButton.Location = new System.Drawing.Point(62, 1);
            this.mtbQuantity.CustomButton.Name = "";
            this.mtbQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbQuantity.CustomButton.TabIndex = 1;
            this.mtbQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbQuantity.CustomButton.UseSelectable = true;
            this.mtbQuantity.CustomButton.Visible = false;
            this.mtbQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderedBrickBindingSource, "Quantity", true));
            this.mtbQuantity.Lines = new string[0];
            this.mtbQuantity.Location = new System.Drawing.Point(148, 144);
            this.mtbQuantity.MaxLength = 32767;
            this.mtbQuantity.Name = "mtbQuantity";
            this.mtbQuantity.PasswordChar = '\0';
            this.mtbQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbQuantity.SelectedText = "";
            this.mtbQuantity.SelectionLength = 0;
            this.mtbQuantity.SelectionStart = 0;
            this.mtbQuantity.ShortcutsEnabled = true;
            this.mtbQuantity.Size = new System.Drawing.Size(84, 23);
            this.mtbQuantity.TabIndex = 1;
            this.mtbQuantity.UseSelectable = true;
            this.mtbQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 145);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Количество:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 109);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(123, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Остаток на складе:";
            // 
            // mlRemainingBricks
            // 
            this.mlRemainingBricks.AutoSize = true;
            this.mlRemainingBricks.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlRemainingBricks.Location = new System.Drawing.Point(146, 110);
            this.mlRemainingBricks.Name = "mlRemainingBricks";
            this.mlRemainingBricks.Size = new System.Drawing.Size(33, 19);
            this.mlRemainingBricks.TabIndex = 0;
            this.mlRemainingBricks.Text = "123";
            // 
            // mbCalc
            // 
            this.mbCalc.Location = new System.Drawing.Point(252, 144);
            this.mbCalc.Name = "mbCalc";
            this.mbCalc.Size = new System.Drawing.Size(75, 23);
            this.mbCalc.TabIndex = 3;
            this.mbCalc.Text = "Расчитать";
            this.mbCalc.UseSelectable = true;
            this.mbCalc.Click += new System.EventHandler(this.mbCalc_Click);
            // 
            // BricksInOrderAddEditFrom
            // 
            this.AcceptButton = this.mbSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 258);
            this.Controls.Add(this.mbCalc);
            this.Controls.Add(this.mtbQuantity);
            this.Controls.Add(this.mbSave);
            this.Controls.Add(this.mcbBrick);
            this.Controls.Add(this.mlRemainingBricks);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BricksInOrderAddEditFrom";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Позиция в заказе";
            ((System.ComponentModel.ISupportInitialize)(this.orderedBrickBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brickBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton mbSave;
        private MetroFramework.Controls.MetroTextBox mtbQuantity;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel mlRemainingBricks;
        private System.Windows.Forms.BindingSource orderedBrickBindingSource;
        private System.Windows.Forms.BindingSource brickBindingSource;
        private MetroFramework.Controls.MetroButton mbCalc;
        public MetroFramework.Controls.MetroComboBox mcbBrick;
    }
}