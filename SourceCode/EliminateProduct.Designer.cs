using System.ComponentModel;

namespace SourceCode
{
    partial class EliminateProduct
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
            this.tableLayoutPanelProduct = new System.Windows.Forms.TableLayoutPanel();
            this.lblProductIdDB = new System.Windows.Forms.Label();
            this.btnEliminateProduct = new System.Windows.Forms.Button();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelProduct
            // 
            this.tableLayoutPanelProduct.ColumnCount = 4;
            this.tableLayoutPanelProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelProduct.Controls.Add(this.lblProductIdDB, 1, 1);
            this.tableLayoutPanelProduct.Controls.Add(this.btnEliminateProduct, 1, 3);
            this.tableLayoutPanelProduct.Controls.Add(this.comboBoxProducts, 2, 1);
            this.tableLayoutPanelProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelProduct.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelProduct.Name = "tableLayoutPanelProduct";
            this.tableLayoutPanelProduct.RowCount = 5;
            this.tableLayoutPanelProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.33F));
            this.tableLayoutPanelProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanelProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.34F));
            this.tableLayoutPanelProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.33F));
            this.tableLayoutPanelProduct.Size = new System.Drawing.Size(663, 459);
            this.tableLayoutPanelProduct.TabIndex = 2;
            // 
            // lblProductIdDB
            // 
            this.lblProductIdDB.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProductIdDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProductIdDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblProductIdDB.ForeColor = System.Drawing.Color.White;
            this.lblProductIdDB.Location = new System.Drawing.Point(36, 111);
            this.lblProductIdDB.Name = "lblProductIdDB";
            this.lblProductIdDB.Size = new System.Drawing.Size(192, 22);
            this.lblProductIdDB.TabIndex = 0;
            this.lblProductIdDB.Text = "Producto";
            this.lblProductIdDB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEliminateProduct
            // 
            this.btnEliminateProduct.BackColor = System.Drawing.Color.MediumPurple;
            this.tableLayoutPanelProduct.SetColumnSpan(this.btnEliminateProduct, 2);
            this.btnEliminateProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminateProduct.FlatAppearance.BorderSize = 0;
            this.btnEliminateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminateProduct.ForeColor = System.Drawing.Color.White;
            this.btnEliminateProduct.Location = new System.Drawing.Point(36, 257);
            this.btnEliminateProduct.Name = "btnEliminateProduct";
            this.btnEliminateProduct.Size = new System.Drawing.Size(589, 85);
            this.btnEliminateProduct.TabIndex = 1;
            this.btnEliminateProduct.Text = "Eliminar Producto";
            this.btnEliminateProduct.UseVisualStyleBackColor = false;
            this.btnEliminateProduct.Click += new System.EventHandler(this.btnEliminateProduct_Click);
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(234, 114);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(391, 24);
            this.comboBoxProducts.TabIndex = 2;
            // 
            // EliminateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanelProduct);
            this.Name = "EliminateProduct";
            this.Size = new System.Drawing.Size(663, 459);
            this.Load += new System.EventHandler(this.EliminateProduct_Load);
            this.tableLayoutPanelProduct.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnEliminateProduct;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.Label lblProductIdDB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelProduct;

        #endregion
    }
}