using System.ComponentModel;

namespace SourceCode
{
    partial class ChangeAddress
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblOldAddress = new System.Windows.Forms.Label();
            this.lblNewAddress = new System.Windows.Forms.Label();
            this.textBoxNewAddress = new System.Windows.Forms.TextBox();
            this.comboBoxOldAddress = new System.Windows.Forms.ComboBox();
            this.btnChangeAddress = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.lblOldAddress, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblNewAddress, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNewAddress, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxOldAddress, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnChangeAddress, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(543, 456);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblOldAddress
            // 
            this.lblOldAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOldAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOldAddress.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblOldAddress.ForeColor = System.Drawing.Color.White;
            this.lblOldAddress.Location = new System.Drawing.Point(30, 75);
            this.lblOldAddress.Name = "lblOldAddress";
            this.lblOldAddress.Size = new System.Drawing.Size(156, 31);
            this.lblOldAddress.TabIndex = 0;
            this.lblOldAddress.Text = "Dirección Actual";
            this.lblOldAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNewAddress
            // 
            this.lblNewAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNewAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNewAddress.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblNewAddress.ForeColor = System.Drawing.Color.White;
            this.lblNewAddress.Location = new System.Drawing.Point(30, 181);
            this.lblNewAddress.Name = "lblNewAddress";
            this.lblNewAddress.Size = new System.Drawing.Size(156, 31);
            this.lblNewAddress.TabIndex = 1;
            this.lblNewAddress.Text = "Dirección Nueva";
            this.lblNewAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNewAddress
            // 
            this.textBoxNewAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNewAddress.Location = new System.Drawing.Point(192, 184);
            this.textBoxNewAddress.Name = "textBoxNewAddress";
            this.textBoxNewAddress.Size = new System.Drawing.Size(319, 22);
            this.textBoxNewAddress.TabIndex = 2;
            // 
            // comboBoxOldAddress
            // 
            this.comboBoxOldAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxOldAddress.FormattingEnabled = true;
            this.comboBoxOldAddress.Location = new System.Drawing.Point(192, 78);
            this.comboBoxOldAddress.Name = "comboBoxOldAddress";
            this.comboBoxOldAddress.Size = new System.Drawing.Size(319, 24);
            this.comboBoxOldAddress.TabIndex = 3;
            // 
            // btnChangeAddress
            // 
            this.btnChangeAddress.BackColor = System.Drawing.Color.MediumPurple;
            this.tableLayoutPanel1.SetColumnSpan(this.btnChangeAddress, 2);
            this.btnChangeAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChangeAddress.FlatAppearance.BorderSize = 0;
            this.btnChangeAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeAddress.ForeColor = System.Drawing.Color.White;
            this.btnChangeAddress.Location = new System.Drawing.Point(30, 290);
            this.btnChangeAddress.Name = "btnChangeAddress";
            this.btnChangeAddress.Size = new System.Drawing.Size(481, 85);
            this.btnChangeAddress.TabIndex = 4;
            this.btnChangeAddress.Text = "Cambiar Dirección";
            this.btnChangeAddress.UseVisualStyleBackColor = false;
            this.btnChangeAddress.Click += new System.EventHandler(this.btnChangeAddress_Click);
            // 
            // ChangeAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ChangeAddress";
            this.Size = new System.Drawing.Size(543, 456);
            this.Load += new System.EventHandler(this.ChangeAddress_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnChangeAddress;
        private System.Windows.Forms.ComboBox comboBoxOldAddress;
        private System.Windows.Forms.Label lblNewAddress;
        private System.Windows.Forms.Label lblOldAddress;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxNewAddress;

        #endregion
    }
}