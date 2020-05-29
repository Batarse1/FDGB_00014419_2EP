using System.ComponentModel;

namespace SourceCode
{
    partial class AddAddress
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
            this.tableLayoutPanelAddress = new System.Windows.Forms.TableLayoutPanel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnEliminateAddress = new System.Windows.Forms.Button();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelAddress
            // 
            this.tableLayoutPanelAddress.ColumnCount = 4;
            this.tableLayoutPanelAddress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelAddress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelAddress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelAddress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelAddress.Controls.Add(this.lblAddress, 1, 1);
            this.tableLayoutPanelAddress.Controls.Add(this.btnEliminateAddress, 1, 3);
            this.tableLayoutPanelAddress.Controls.Add(this.txtBoxAddress, 2, 1);
            this.tableLayoutPanelAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAddress.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelAddress.Name = "tableLayoutPanelAddress";
            this.tableLayoutPanelAddress.RowCount = 5;
            this.tableLayoutPanelAddress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.33F));
            this.tableLayoutPanelAddress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanelAddress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.34F));
            this.tableLayoutPanelAddress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelAddress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.33F));
            this.tableLayoutPanelAddress.Size = new System.Drawing.Size(746, 463);
            this.tableLayoutPanelAddress.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(40, 112);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(217, 19);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Dirección";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEliminateAddress
            // 
            this.btnEliminateAddress.BackColor = System.Drawing.Color.MediumPurple;
            this.tableLayoutPanelAddress.SetColumnSpan(this.btnEliminateAddress, 2);
            this.btnEliminateAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminateAddress.FlatAppearance.BorderSize = 0;
            this.btnEliminateAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminateAddress.ForeColor = System.Drawing.Color.White;
            this.btnEliminateAddress.Location = new System.Drawing.Point(40, 259);
            this.btnEliminateAddress.Name = "btnEliminateAddress";
            this.btnEliminateAddress.Size = new System.Drawing.Size(664, 86);
            this.btnEliminateAddress.TabIndex = 1;
            this.btnEliminateAddress.Text = "Agregar Dirección";
            this.btnEliminateAddress.UseVisualStyleBackColor = false;
            this.btnEliminateAddress.Click += new System.EventHandler(this.btnEliminateAddress_Click);
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxAddress.Location = new System.Drawing.Point(263, 115);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(441, 22);
            this.txtBoxAddress.TabIndex = 2;
            // 
            // AddAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanelAddress);
            this.Name = "AddAddress";
            this.Size = new System.Drawing.Size(746, 463);
            this.tableLayoutPanelAddress.ResumeLayout(false);
            this.tableLayoutPanelAddress.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnEliminateAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAddress;
        private System.Windows.Forms.TextBox txtBoxAddress;

        #endregion
    }
}