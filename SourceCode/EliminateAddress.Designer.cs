using System.ComponentModel;

namespace SourceCode
{
    partial class EliminateAddress
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
            this.tableLayoutPanelBusiness = new System.Windows.Forms.TableLayoutPanel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnEliminateAddress = new System.Windows.Forms.Button();
            this.comboBoxAddress = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelBusiness.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelBusiness
            // 
            this.tableLayoutPanelBusiness.ColumnCount = 4;
            this.tableLayoutPanelBusiness.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelBusiness.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelBusiness.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelBusiness.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelBusiness.Controls.Add(this.lblAddress, 1, 1);
            this.tableLayoutPanelBusiness.Controls.Add(this.btnEliminateAddress, 1, 3);
            this.tableLayoutPanelBusiness.Controls.Add(this.comboBoxAddress, 2, 1);
            this.tableLayoutPanelBusiness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBusiness.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelBusiness.Name = "tableLayoutPanelBusiness";
            this.tableLayoutPanelBusiness.RowCount = 5;
            this.tableLayoutPanelBusiness.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.33F));
            this.tableLayoutPanelBusiness.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanelBusiness.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.34F));
            this.tableLayoutPanelBusiness.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelBusiness.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.33F));
            this.tableLayoutPanelBusiness.Size = new System.Drawing.Size(560, 342);
            this.tableLayoutPanelBusiness.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(31, 83);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(162, 17);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Dirección";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEliminateAddress
            // 
            this.btnEliminateAddress.BackColor = System.Drawing.Color.MediumPurple;
            this.tableLayoutPanelBusiness.SetColumnSpan(this.btnEliminateAddress, 2);
            this.btnEliminateAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminateAddress.FlatAppearance.BorderSize = 0;
            this.btnEliminateAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminateAddress.ForeColor = System.Drawing.Color.White;
            this.btnEliminateAddress.Location = new System.Drawing.Point(31, 192);
            this.btnEliminateAddress.Name = "btnEliminateAddress";
            this.btnEliminateAddress.Size = new System.Drawing.Size(498, 62);
            this.btnEliminateAddress.TabIndex = 1;
            this.btnEliminateAddress.Text = "Eliminar Dirección";
            this.btnEliminateAddress.UseVisualStyleBackColor = false;
            this.btnEliminateAddress.Click += new System.EventHandler(this.btnEliminateAddress_Click);
            // 
            // comboBoxAddress
            // 
            this.comboBoxAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxAddress.FormattingEnabled = true;
            this.comboBoxAddress.Location = new System.Drawing.Point(199, 86);
            this.comboBoxAddress.Name = "comboBoxAddress";
            this.comboBoxAddress.Size = new System.Drawing.Size(330, 24);
            this.comboBoxAddress.TabIndex = 2;
            // 
            // EliminateAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanelBusiness);
            this.Name = "EliminateAddress";
            this.Size = new System.Drawing.Size(560, 342);
            this.Load += new System.EventHandler(this.EliminateAddress_Load);
            this.tableLayoutPanelBusiness.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnEliminateAddress;
        private System.Windows.Forms.ComboBox comboBoxAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBusiness;

        #endregion
    }
}