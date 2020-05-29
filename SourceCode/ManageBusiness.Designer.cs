using System.ComponentModel;

namespace SourceCode
{
    partial class ManageBusiness
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
            this.btnAddBusiness = new System.Windows.Forms.Button();
            this.btnEliminateBusiness = new System.Windows.Forms.Button();
            this.addBusiness1 = new SourceCode.AddBusiness();
            this.tableLayoutPanelBusiness.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelBusiness
            // 
            this.tableLayoutPanelBusiness.ColumnCount = 2;
            this.tableLayoutPanelBusiness.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBusiness.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBusiness.Controls.Add(this.btnAddBusiness, 0, 0);
            this.tableLayoutPanelBusiness.Controls.Add(this.btnEliminateBusiness, 1, 0);
            this.tableLayoutPanelBusiness.Controls.Add(this.addBusiness1, 0, 1);
            this.tableLayoutPanelBusiness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBusiness.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelBusiness.Name = "tableLayoutPanelBusiness";
            this.tableLayoutPanelBusiness.RowCount = 2;
            this.tableLayoutPanelBusiness.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelBusiness.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelBusiness.Size = new System.Drawing.Size(673, 462);
            this.tableLayoutPanelBusiness.TabIndex = 0;
            // 
            // btnAddBusiness
            // 
            this.btnAddBusiness.BackColor = System.Drawing.Color.Transparent;
            this.btnAddBusiness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddBusiness.FlatAppearance.BorderSize = 0;
            this.btnAddBusiness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBusiness.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAddBusiness.ForeColor = System.Drawing.Color.White;
            this.btnAddBusiness.Location = new System.Drawing.Point(0, 0);
            this.btnAddBusiness.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddBusiness.Name = "btnAddBusiness";
            this.btnAddBusiness.Size = new System.Drawing.Size(336, 92);
            this.btnAddBusiness.TabIndex = 1;
            this.btnAddBusiness.Text = "Añadir";
            this.btnAddBusiness.UseVisualStyleBackColor = false;
            this.btnAddBusiness.Click += new System.EventHandler(this.btnAddBusiness_Click);
            // 
            // btnEliminateBusiness
            // 
            this.btnEliminateBusiness.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminateBusiness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminateBusiness.FlatAppearance.BorderSize = 0;
            this.btnEliminateBusiness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminateBusiness.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEliminateBusiness.ForeColor = System.Drawing.Color.White;
            this.btnEliminateBusiness.Location = new System.Drawing.Point(336, 0);
            this.btnEliminateBusiness.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminateBusiness.Name = "btnEliminateBusiness";
            this.btnEliminateBusiness.Size = new System.Drawing.Size(337, 92);
            this.btnEliminateBusiness.TabIndex = 2;
            this.btnEliminateBusiness.Text = "Eliminar";
            this.btnEliminateBusiness.UseVisualStyleBackColor = false;
            this.btnEliminateBusiness.Click += new System.EventHandler(this.btnEliminateBusiness_Click);
            // 
            // addBusiness1
            // 
            this.addBusiness1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelBusiness.SetColumnSpan(this.addBusiness1, 2);
            this.addBusiness1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addBusiness1.Location = new System.Drawing.Point(0, 92);
            this.addBusiness1.Margin = new System.Windows.Forms.Padding(0);
            this.addBusiness1.Name = "addBusiness1";
            this.addBusiness1.Size = new System.Drawing.Size(673, 370);
            this.addBusiness1.TabIndex = 3;
            // 
            // ManageBusiness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanelBusiness);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ManageBusiness";
            this.Size = new System.Drawing.Size(673, 462);
            this.tableLayoutPanelBusiness.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private SourceCode.AddBusiness addBusiness1;
        private System.Windows.Forms.Button btnAddBusiness;
        private System.Windows.Forms.Button btnEliminateBusiness;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBusiness;

        #endregion
    }
}