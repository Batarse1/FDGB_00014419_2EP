using System.ComponentModel;

namespace SourceCode
{
    partial class AddOrder
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
            this.tableLayoutPanelAddOrder = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.comboBoxDirection = new System.Windows.Forms.ComboBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblDirection = new System.Windows.Forms.Label();
            this.btnAddProductDB = new System.Windows.Forms.Button();
            this.tableLayoutPanelAddOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelAddOrder
            // 
            this.tableLayoutPanelAddOrder.ColumnCount = 4;
            this.tableLayoutPanelAddOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelAddOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelAddOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelAddOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelAddOrder.Controls.Add(this.comboBoxProducts, 2, 1);
            this.tableLayoutPanelAddOrder.Controls.Add(this.comboBoxDirection, 2, 3);
            this.tableLayoutPanelAddOrder.Controls.Add(this.lblProduct, 1, 1);
            this.tableLayoutPanelAddOrder.Controls.Add(this.lblDirection, 1, 3);
            this.tableLayoutPanelAddOrder.Controls.Add(this.btnAddProductDB, 1, 5);
            this.tableLayoutPanelAddOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAddOrder.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelAddOrder.Name = "tableLayoutPanelAddOrder";
            this.tableLayoutPanelAddOrder.RowCount = 7;
            this.tableLayoutPanelAddOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.5F));
            this.tableLayoutPanelAddOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanelAddOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.5F));
            this.tableLayoutPanelAddOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanelAddOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.5F));
            this.tableLayoutPanelAddOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelAddOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.5F));
            this.tableLayoutPanelAddOrder.Size = new System.Drawing.Size(670, 488);
            this.tableLayoutPanelAddOrder.TabIndex = 0;
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(237, 83);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(396, 24);
            this.comboBoxProducts.TabIndex = 0;
            // 
            // comboBoxDirection
            // 
            this.comboBoxDirection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxDirection.FormattingEnabled = true;
            this.comboBoxDirection.Location = new System.Drawing.Point(237, 197);
            this.comboBoxDirection.Name = "comboBoxDirection";
            this.comboBoxDirection.Size = new System.Drawing.Size(396, 24);
            this.comboBoxDirection.TabIndex = 1;
            // 
            // lblProduct
            // 
            this.lblProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblProduct.ForeColor = System.Drawing.Color.White;
            this.lblProduct.Location = new System.Drawing.Point(36, 80);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(195, 34);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.Text = "Producto";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDirection
            // 
            this.lblDirection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDirection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDirection.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblDirection.ForeColor = System.Drawing.Color.White;
            this.lblDirection.Location = new System.Drawing.Point(36, 194);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(195, 34);
            this.lblDirection.TabIndex = 3;
            this.lblDirection.Text = "Dirección";
            this.lblDirection.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddProductDB
            // 
            this.btnAddProductDB.BackColor = System.Drawing.Color.MediumPurple;
            this.tableLayoutPanelAddOrder.SetColumnSpan(this.btnAddProductDB, 2);
            this.btnAddProductDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddProductDB.FlatAppearance.BorderSize = 0;
            this.btnAddProductDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProductDB.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAddProductDB.ForeColor = System.Drawing.Color.White;
            this.btnAddProductDB.Location = new System.Drawing.Point(36, 311);
            this.btnAddProductDB.Name = "btnAddProductDB";
            this.btnAddProductDB.Size = new System.Drawing.Size(597, 91);
            this.btnAddProductDB.TabIndex = 7;
            this.btnAddProductDB.Text = "Añadir Orden";
            this.btnAddProductDB.UseVisualStyleBackColor = false;
            this.btnAddProductDB.Click += new System.EventHandler(this.btnAddProductDB_Click);
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanelAddOrder);
            this.Name = "AddOrder";
            this.Size = new System.Drawing.Size(670, 488);
            this.Load += new System.EventHandler(this.AddOrder_Load);
            this.tableLayoutPanelAddOrder.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAddProductDB;
        private System.Windows.Forms.ComboBox comboBoxDirection;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAddOrder;

        #endregion
    }
}