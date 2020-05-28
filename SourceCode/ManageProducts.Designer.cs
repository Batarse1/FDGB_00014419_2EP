using System.ComponentModel;

namespace SourceCode
{
    partial class ManageProducts
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
            this.tableLayoutPanelProduct = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.BtnEliminateProduct = new System.Windows.Forms.Button();
            this.addProduct1 = new SourceCode.AddProduct();
            this.tableLayoutPanelBusiness.SuspendLayout();
            this.tableLayoutPanelProduct.SuspendLayout();
            this.SuspendLayout();
            this.tableLayoutPanelBusiness.ColumnCount = 2;
            this.tableLayoutPanelBusiness.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBusiness.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBusiness.Controls.Add(this.btnAddBusiness, 0, 0);
            this.tableLayoutPanelBusiness.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelBusiness.Name = "tableLayoutPanelBusiness";
            this.tableLayoutPanelBusiness.RowCount = 1;
            this.tableLayoutPanelBusiness.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelBusiness.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanelBusiness.TabIndex = 0;
            this.btnAddBusiness.BackColor = System.Drawing.Color.Transparent;
            this.btnAddBusiness.FlatAppearance.BorderSize = 0;
            this.btnAddBusiness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBusiness.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAddBusiness.ForeColor = System.Drawing.Color.White;
            this.btnAddBusiness.Location = new System.Drawing.Point(3, 3);
            this.btnAddBusiness.Name = "btnAddBusiness";
            this.btnAddBusiness.Size = new System.Drawing.Size(94, 64);
            this.btnAddBusiness.TabIndex = 1;
            this.btnAddBusiness.Text = "Añadir";
            this.btnAddBusiness.UseVisualStyleBackColor = false;
            this.btnEliminateBusiness.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminateBusiness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminateBusiness.FlatAppearance.BorderSize = 0;
            this.btnEliminateBusiness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminateBusiness.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEliminateBusiness.ForeColor = System.Drawing.Color.White;
            this.btnEliminateBusiness.Location = new System.Drawing.Point(103, 3);
            this.btnEliminateBusiness.Name = "btnEliminateBusiness";
            this.btnEliminateBusiness.Size = new System.Drawing.Size(94, 94);
            this.btnEliminateBusiness.TabIndex = 2;
            this.btnEliminateBusiness.Text = "Eliminar";
            this.btnEliminateBusiness.UseVisualStyleBackColor = false;
            this.tableLayoutPanelProduct.ColumnCount = 2;
            this.tableLayoutPanelProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelProduct.Controls.Add(this.btnAddProduct, 0, 0);
            this.tableLayoutPanelProduct.Controls.Add(this.BtnEliminateProduct, 1, 0);
            this.tableLayoutPanelProduct.Controls.Add(this.addProduct1, 0, 1);
            this.tableLayoutPanelProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelProduct.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelProduct.Name = "tableLayoutPanelProduct";
            this.tableLayoutPanelProduct.RowCount = 2;
            this.tableLayoutPanelProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelProduct.Size = new System.Drawing.Size(413, 368);
            this.tableLayoutPanelProduct.TabIndex = 1;
            this.btnAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(3, 3);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(200, 67);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "Añadir";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            this.BtnEliminateProduct.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminateProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEliminateProduct.FlatAppearance.BorderSize = 0;
            this.BtnEliminateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminateProduct.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.BtnEliminateProduct.ForeColor = System.Drawing.Color.White;
            this.BtnEliminateProduct.Location = new System.Drawing.Point(209, 3);
            this.BtnEliminateProduct.Name = "BtnEliminateProduct";
            this.BtnEliminateProduct.Size = new System.Drawing.Size(201, 67);
            this.BtnEliminateProduct.TabIndex = 2;
            this.BtnEliminateProduct.Text = "Eliminar";
            this.BtnEliminateProduct.UseVisualStyleBackColor = false;
            this.BtnEliminateProduct.Click += new System.EventHandler(this.BtnEliminateProduct_Click);
            this.addProduct1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelProduct.SetColumnSpan(this.addProduct1, 2);
            this.addProduct1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addProduct1.Location = new System.Drawing.Point(3, 76);
            this.addProduct1.Name = "addProduct1";
            this.addProduct1.Size = new System.Drawing.Size(407, 289);
            this.addProduct1.TabIndex = 3;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanelProduct);
            this.Location = new System.Drawing.Point(19, 19);
            this.Name = "ManageProducts";
            this.Size = new System.Drawing.Size(413, 368);
            this.tableLayoutPanelBusiness.ResumeLayout(false);
            this.tableLayoutPanelProduct.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private SourceCode.AddProduct addProduct1;
        private System.Windows.Forms.Button btnAddBusiness;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnEliminateBusiness;
        private System.Windows.Forms.Button BtnEliminateProduct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBusiness;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelProduct;

        #endregion
    }
}