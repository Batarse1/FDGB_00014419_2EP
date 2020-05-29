using System.ComponentModel;

namespace SourceCode
{
    partial class AddProduct
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblBusiness = new System.Windows.Forms.Label();
            this.btnAddProductDB = new System.Windows.Forms.Button();
            this.txtBoxName = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanelBusiness.Controls.Add(this.lblName, 1, 1);
            this.tableLayoutPanelBusiness.Controls.Add(this.lblBusiness, 1, 3);
            this.tableLayoutPanelBusiness.Controls.Add(this.btnAddProductDB, 1, 5);
            this.tableLayoutPanelBusiness.Controls.Add(this.txtBoxName, 2, 1);
            this.tableLayoutPanelBusiness.Controls.Add(this.comboBoxBusiness, 2, 3);
            this.tableLayoutPanelBusiness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBusiness.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelBusiness.Name = "tableLayoutPanelBusiness";
            this.tableLayoutPanelBusiness.RowCount = 7;
            this.tableLayoutPanelBusiness.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.5F));
            this.tableLayoutPanelBusiness.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanelBusiness.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.5F));
            this.tableLayoutPanelBusiness.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanelBusiness.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.5F));
            this.tableLayoutPanelBusiness.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelBusiness.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.5F));
            this.tableLayoutPanelBusiness.Size = new System.Drawing.Size(684, 528);
            this.tableLayoutPanelBusiness.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(37, 87);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(199, 36);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBusiness
            // 
            this.lblBusiness.BackColor = System.Drawing.Color.Transparent;
            this.lblBusiness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBusiness.ForeColor = System.Drawing.Color.White;
            this.lblBusiness.Location = new System.Drawing.Point(37, 210);
            this.lblBusiness.Name = "lblBusiness";
            this.lblBusiness.Size = new System.Drawing.Size(199, 36);
            this.lblBusiness.TabIndex = 2;
            this.lblBusiness.Text = "Negocio";
            this.lblBusiness.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddProductDB
            // 
            this.btnAddProductDB.BackColor = System.Drawing.Color.MediumPurple;
            this.tableLayoutPanelBusiness.SetColumnSpan(this.btnAddProductDB, 2);
            this.btnAddProductDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddProductDB.FlatAppearance.BorderSize = 0;
            this.btnAddProductDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProductDB.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAddProductDB.ForeColor = System.Drawing.Color.White;
            this.btnAddProductDB.Location = new System.Drawing.Point(37, 336);
            this.btnAddProductDB.Name = "btnAddProductDB";
            this.btnAddProductDB.Size = new System.Drawing.Size(609, 99);
            this.btnAddProductDB.TabIndex = 6;
            this.btnAddProductDB.Text = "Añadir Producto";
            this.btnAddProductDB.UseVisualStyleBackColor = false;
            this.btnAddProductDB.Click += new System.EventHandler(this.btnAddProductDB_Click);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxName.Location = new System.Drawing.Point(242, 90);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(404, 22);
            this.txtBoxName.TabIndex = 7;
            // 
            // comboBoxBusiness
            // 
            this.comboBoxBusiness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxBusiness.FormattingEnabled = true;
            this.comboBoxBusiness.Location = new System.Drawing.Point(242, 213);
            this.comboBoxBusiness.Name = "comboBoxBusiness";
            this.comboBoxBusiness.Size = new System.Drawing.Size(404, 24);
            this.comboBoxBusiness.TabIndex = 8;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanelBusiness);
            this.Name = "AddProduct";
            this.Size = new System.Drawing.Size(684, 528);
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.tableLayoutPanelBusiness.ResumeLayout(false);
            this.tableLayoutPanelBusiness.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAddProductDB;
        private System.Windows.Forms.ComboBox comboBoxBusiness;
        private System.Windows.Forms.Label lblBusiness;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBusiness;
        private System.Windows.Forms.TextBox txtBoxName;

        #endregion
    }
}