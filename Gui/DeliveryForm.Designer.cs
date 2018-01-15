﻿namespace BrickWorks
{
    partial class DeliveryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.costGrid = new MetroFramework.Controls.MetroGrid();
            this.lnkDelete = new MetroFramework.Controls.MetroLink();
            this.lnkEdit = new MetroFramework.Controls.MetroLink();
            this.lnkAdd = new MetroFramework.Controls.MetroLink();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costPerKmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryCostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.costGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryCostBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // costGrid
            // 
            this.costGrid.AllowUserToAddRows = false;
            this.costGrid.AllowUserToDeleteRows = false;
            this.costGrid.AllowUserToResizeRows = false;
            this.costGrid.AutoGenerateColumns = false;
            this.costGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.costGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.costGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.costGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.costGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.costGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.costGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.costPerKmDataGridViewTextBoxColumn});
            this.costGrid.DataSource = this.deliveryCostBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.costGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.costGrid.EnableHeadersVisualStyles = false;
            this.costGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.costGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.costGrid.Location = new System.Drawing.Point(37, 115);
            this.costGrid.Name = "costGrid";
            this.costGrid.ReadOnly = true;
            this.costGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.costGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.costGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.costGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.costGrid.Size = new System.Drawing.Size(342, 209);
            this.costGrid.TabIndex = 0;
            // 
            // lnkDelete
            // 
            this.lnkDelete.Image = global::BrickWorks.Properties.Resources.delete;
            this.lnkDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkDelete.ImageSize = 32;
            this.lnkDelete.Location = new System.Drawing.Point(270, 65);
            this.lnkDelete.Margin = new System.Windows.Forms.Padding(0);
            this.lnkDelete.Name = "lnkDelete";
            this.lnkDelete.Size = new System.Drawing.Size(81, 36);
            this.lnkDelete.TabIndex = 6;
            this.lnkDelete.Text = "Удалить";
            this.lnkDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkDelete.UseSelectable = true;
            this.lnkDelete.Click += new System.EventHandler(this.lnkDelete_Click);
            // 
            // lnkEdit
            // 
            this.lnkEdit.Image = global::BrickWorks.Properties.Resources.edit;
            this.lnkEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkEdit.ImageSize = 32;
            this.lnkEdit.Location = new System.Drawing.Point(137, 65);
            this.lnkEdit.Margin = new System.Windows.Forms.Padding(0);
            this.lnkEdit.Name = "lnkEdit";
            this.lnkEdit.Size = new System.Drawing.Size(122, 36);
            this.lnkEdit.TabIndex = 5;
            this.lnkEdit.Text = "Редактировать";
            this.lnkEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkEdit.UseSelectable = true;
            this.lnkEdit.Click += new System.EventHandler(this.lnkEdit_Click);
            // 
            // lnkAdd
            // 
            this.lnkAdd.Image = global::BrickWorks.Properties.Resources.add;
            this.lnkAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkAdd.ImageSize = 32;
            this.lnkAdd.Location = new System.Drawing.Point(37, 65);
            this.lnkAdd.Margin = new System.Windows.Forms.Padding(0);
            this.lnkAdd.Name = "lnkAdd";
            this.lnkAdd.Size = new System.Drawing.Size(81, 36);
            this.lnkAdd.TabIndex = 4;
            this.lnkAdd.Text = "Новый";
            this.lnkAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkAdd.UseSelectable = true;
            this.lnkAdd.Click += new System.EventHandler(this.lnkAdd_Click);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.dateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата (начало действия)";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // costPerKmDataGridViewTextBoxColumn
            // 
            this.costPerKmDataGridViewTextBoxColumn.DataPropertyName = "CostPerKm";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.costPerKmDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.costPerKmDataGridViewTextBoxColumn.HeaderText = "Стоимость за километр";
            this.costPerKmDataGridViewTextBoxColumn.Name = "costPerKmDataGridViewTextBoxColumn";
            this.costPerKmDataGridViewTextBoxColumn.ReadOnly = true;
            this.costPerKmDataGridViewTextBoxColumn.Width = 150;
            // 
            // deliveryCostBindingSource
            // 
            this.deliveryCostBindingSource.DataSource = typeof(BrickWorks.DeliveryCost);
            // 
            // DeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 355);
            this.Controls.Add(this.lnkDelete);
            this.Controls.Add(this.lnkEdit);
            this.Controls.Add(this.lnkAdd);
            this.Controls.Add(this.costGrid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeliveryForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Доставка";
            this.Load += new System.EventHandler(this.DeliveryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.costGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryCostBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid costGrid;
        private System.Windows.Forms.BindingSource deliveryCostBindingSource;
        private MetroFramework.Controls.MetroLink lnkDelete;
        private MetroFramework.Controls.MetroLink lnkEdit;
        private MetroFramework.Controls.MetroLink lnkAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPerKmDataGridViewTextBoxColumn;
    }
}