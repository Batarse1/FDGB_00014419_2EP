using System.ComponentModel;

namespace SourceCode
{
    partial class ManageUserOrders
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
            this.btnAddUserOrder = new System.Windows.Forms.Button();
            this.btnEliminateUserOrder = new System.Windows.Forms.Button();
            this.btnViewUserOrders = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnAddUserOrder, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEliminateUserOrder, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnViewUserOrders, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(807, 418);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAddUserOrder
            // 
            this.btnAddUserOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUserOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddUserOrder.FlatAppearance.BorderSize = 0;
            this.btnAddUserOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUserOrder.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAddUserOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddUserOrder.Location = new System.Drawing.Point(3, 3);
            this.btnAddUserOrder.Name = "btnAddUserOrder";
            this.btnAddUserOrder.Size = new System.Drawing.Size(263, 77);
            this.btnAddUserOrder.TabIndex = 2;
            this.btnAddUserOrder.Text = "Añadir Orden";
            this.btnAddUserOrder.UseVisualStyleBackColor = false;
            this.btnAddUserOrder.Click += new System.EventHandler(this.btnAddUserOrder_Click);
            // 
            // btnEliminateUserOrder
            // 
            this.btnEliminateUserOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminateUserOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminateUserOrder.FlatAppearance.BorderSize = 0;
            this.btnEliminateUserOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminateUserOrder.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEliminateUserOrder.ForeColor = System.Drawing.Color.White;
            this.btnEliminateUserOrder.Location = new System.Drawing.Point(272, 3);
            this.btnEliminateUserOrder.Name = "btnEliminateUserOrder";
            this.btnEliminateUserOrder.Size = new System.Drawing.Size(263, 77);
            this.btnEliminateUserOrder.TabIndex = 3;
            this.btnEliminateUserOrder.Text = "Eliminar Orden";
            this.btnEliminateUserOrder.UseVisualStyleBackColor = false;
            this.btnEliminateUserOrder.Click += new System.EventHandler(this.btnEliminateUserOrder_Click);
            // 
            // btnViewUserOrders
            // 
            this.btnViewUserOrders.BackColor = System.Drawing.Color.Transparent;
            this.btnViewUserOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnViewUserOrders.FlatAppearance.BorderSize = 0;
            this.btnViewUserOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewUserOrders.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnViewUserOrders.ForeColor = System.Drawing.Color.White;
            this.btnViewUserOrders.Location = new System.Drawing.Point(541, 3);
            this.btnViewUserOrders.Name = "btnViewUserOrders";
            this.btnViewUserOrders.Size = new System.Drawing.Size(263, 77);
            this.btnViewUserOrders.TabIndex = 4;
            this.btnViewUserOrders.Text = "Ver Ordenes";
            this.btnViewUserOrders.UseVisualStyleBackColor = false;
            this.btnViewUserOrders.Click += new System.EventHandler(this.btnViewUserOrders_Click);
            // 
            // ManageUserOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ManageUserOrders";
            this.Size = new System.Drawing.Size(807, 418);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAddUserOrder;
        private System.Windows.Forms.Button btnEliminateUserOrder;
        private System.Windows.Forms.Button btnViewUserOrders;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}