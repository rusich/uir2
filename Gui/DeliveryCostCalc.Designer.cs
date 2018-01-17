namespace BrickWorks
{
    partial class DeliveryCostCalc
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
            this.mbCalc = new MetroFramework.Controls.MetroButton();
            this.mlvBuildings = new MetroFramework.Controls.MetroListView();
            this.SuspendLayout();
            // 
            // mbCalc
            // 
            this.mbCalc.Location = new System.Drawing.Point(268, 232);
            this.mbCalc.Name = "mbCalc";
            this.mbCalc.Size = new System.Drawing.Size(75, 23);
            this.mbCalc.TabIndex = 3;
            this.mbCalc.Text = "Расчитать";
            this.mbCalc.UseSelectable = true;
            this.mbCalc.Click += new System.EventHandler(this.mbCalc_Click);
            // 
            // mlvBuildings
            // 
            this.mlvBuildings.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mlvBuildings.FullRowSelect = true;
            this.mlvBuildings.Location = new System.Drawing.Point(34, 63);
            this.mlvBuildings.Name = "mlvBuildings";
            this.mlvBuildings.OwnerDraw = true;
            this.mlvBuildings.Size = new System.Drawing.Size(294, 154);
            this.mlvBuildings.TabIndex = 2;
            this.mlvBuildings.UseCompatibleStateImageBehavior = false;
            this.mlvBuildings.UseSelectable = true;
            this.mlvBuildings.View = System.Windows.Forms.View.List;
            // 
            // DeliveryCostCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 275);
            this.Controls.Add(this.mbCalc);
            this.Controls.Add(this.mlvBuildings);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeliveryCostCalc";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Расчет стоимости доставки";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton mbCalc;
        private MetroFramework.Controls.MetroListView mlvBuildings;
    }
}