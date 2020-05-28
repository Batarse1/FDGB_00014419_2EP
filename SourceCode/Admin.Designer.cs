using System.ComponentModel;

namespace SourceCode
{
    partial class Admin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.tableLayoutPanelAdmin = new System.Windows.Forms.TableLayoutPanel();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnBusiness = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnGraphics = new System.Windows.Forms.Button();
            this.manageUsers1 = new SourceCode.ManageUsers();
            this.tableLayoutPanelAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelAdmin
            // 
            this.tableLayoutPanelAdmin.ColumnCount = 5;
            this.tableLayoutPanelAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelAdmin.Controls.Add(this.btnUsers, 0, 0);
            this.tableLayoutPanelAdmin.Controls.Add(this.btnBusiness, 1, 0);
            this.tableLayoutPanelAdmin.Controls.Add(this.btnProducts, 2, 0);
            this.tableLayoutPanelAdmin.Controls.Add(this.btnOrders, 3, 0);
            this.tableLayoutPanelAdmin.Controls.Add(this.btnGraphics, 4, 0);
            this.tableLayoutPanelAdmin.Controls.Add(this.manageUsers1, 0, 1);
            this.tableLayoutPanelAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAdmin.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelAdmin.Name = "tableLayoutPanelAdmin";
            this.tableLayoutPanelAdmin.RowCount = 2;
            this.tableLayoutPanelAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelAdmin.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanelAdmin.TabIndex = 0;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Indigo;
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Location = new System.Drawing.Point(3, 3);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(154, 84);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "Usuarios";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnBusiness
            // 
            this.btnBusiness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBusiness.FlatAppearance.BorderSize = 0;
            this.btnBusiness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusiness.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnBusiness.ForeColor = System.Drawing.Color.White;
            this.btnBusiness.Location = new System.Drawing.Point(163, 3);
            this.btnBusiness.Name = "btnBusiness";
            this.btnBusiness.Size = new System.Drawing.Size(154, 84);
            this.btnBusiness.TabIndex = 1;
            this.btnBusiness.Text = "Negocios";
            this.btnBusiness.UseVisualStyleBackColor = true;
            this.btnBusiness.Click += new System.EventHandler(this.btnBusiness_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Location = new System.Drawing.Point(323, 3);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(154, 84);
            this.btnProducts.TabIndex = 2;
            this.btnProducts.Text = "Productos";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Location = new System.Drawing.Point(483, 3);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(154, 84);
            this.btnOrders.TabIndex = 3;
            this.btnOrders.Text = "Ordenes";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnGraphics
            // 
            this.btnGraphics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGraphics.FlatAppearance.BorderSize = 0;
            this.btnGraphics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraphics.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnGraphics.ForeColor = System.Drawing.Color.White;
            this.btnGraphics.Location = new System.Drawing.Point(643, 3);
            this.btnGraphics.Name = "btnGraphics";
            this.btnGraphics.Size = new System.Drawing.Size(154, 84);
            this.btnGraphics.TabIndex = 4;
            this.btnGraphics.Text = "Gráfica";
            this.btnGraphics.UseVisualStyleBackColor = true;
            // 
            // manageUsers1
            // 
            this.manageUsers1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelAdmin.SetColumnSpan(this.manageUsers1, 5);
            this.manageUsers1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageUsers1.Location = new System.Drawing.Point(3, 93);
            this.manageUsers1.Name = "manageUsers1";
            this.manageUsers1.Size = new System.Drawing.Size(794, 354);
            this.manageUsers1.TabIndex = 5;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanelAdmin);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de Hugo";
            this.tableLayoutPanelAdmin.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnBusiness;
        private System.Windows.Forms.Button btnGraphics;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnUsers;
        private SourceCode.ManageUsers manageUsers1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAdmin;

        #endregion
    }
}