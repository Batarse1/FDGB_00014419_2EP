using System.ComponentModel;

namespace SourceCode
{
    partial class EliminateBusiness
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
            this.lblBusinessIdDB = new System.Windows.Forms.Label();
            this.btnEliminateBusiness = new System.Windows.Forms.Button();
            this.comboBoxBusiness = new System.Windows.Forms.ComboBox();
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
            this.tableLayoutPanelBusiness.Controls.Add(this.lblBusinessIdDB, 1, 1);
            this.tableLayoutPanelBusiness.Controls.Add(this.btnEliminateBusiness, 1, 3);
            this.tableLayoutPanelBusiness.Controls.Add(this.comboBoxBusiness, 2, 1);
            this.tableLayoutPanelBusiness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBusiness.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelBusiness.Name = "tableLayoutPanelBusiness";
            this.tableLayoutPanelBusiness.RowCount = 5;
            this.tableLayoutPanelBusiness.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.33F));
            this.tableLayoutPanelBusiness.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanelBusiness.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.34F));
            this.tableLayoutPanelBusiness.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelBusiness.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.33F));
            this.tableLayoutPanelBusiness.Size = new System.Drawing.Size(414, 322);
            this.tableLayoutPanelBusiness.TabIndex = 1;
            // 
            // lblBusinessIdDB
            // 
            this.lblBusinessIdDB.BackColor = System.Drawing.Color.Transparent;
            this.lblBusinessIdDB.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBusinessIdDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblBusinessIdDB.ForeColor = System.Drawing.Color.White;
            this.lblBusinessIdDB.Location = new System.Drawing.Point(23, 78);
            this.lblBusinessIdDB.Name = "lblBusinessIdDB";
            this.lblBusinessIdDB.Size = new System.Drawing.Size(118, 19);
            this.lblBusinessIdDB.TabIndex = 0;
            this.lblBusinessIdDB.Text = "Negocio";
            this.lblBusinessIdDB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEliminateBusiness
            // 
            this.btnEliminateBusiness.BackColor = System.Drawing.Color.MediumPurple;
            this.tableLayoutPanelBusiness.SetColumnSpan(this.btnEliminateBusiness, 2);
            this.btnEliminateBusiness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminateBusiness.FlatAppearance.BorderSize = 0;
            this.btnEliminateBusiness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminateBusiness.ForeColor = System.Drawing.Color.White;
            this.btnEliminateBusiness.Location = new System.Drawing.Point(23, 181);
            this.btnEliminateBusiness.Name = "btnEliminateBusiness";
            this.btnEliminateBusiness.Size = new System.Drawing.Size(366, 58);
            this.btnEliminateBusiness.TabIndex = 1;
            this.btnEliminateBusiness.Text = "Eliminar Negocio";
            this.btnEliminateBusiness.UseVisualStyleBackColor = false;
            this.btnEliminateBusiness.Click += new System.EventHandler(this.btnEliminateBusiness_Click);
            // 
            // comboBoxBusiness
            // 
            this.comboBoxBusiness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxBusiness.FormattingEnabled = true;
            this.comboBoxBusiness.Location = new System.Drawing.Point(147, 81);
            this.comboBoxBusiness.Name = "comboBoxBusiness";
            this.comboBoxBusiness.Size = new System.Drawing.Size(242, 24);
            this.comboBoxBusiness.TabIndex = 2;
            // 
            // EliminateBusiness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelBusiness);
            this.Name = "EliminateBusiness";
            this.Size = new System.Drawing.Size(414, 322);
            this.Load += new System.EventHandler(this.EliminateBusiness_Load);
            this.tableLayoutPanelBusiness.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnEliminateBusiness;
        private System.Windows.Forms.ComboBox comboBoxBusiness;
        private System.Windows.Forms.Label lblBusinessIdDB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBusiness;

        #endregion
    }
}