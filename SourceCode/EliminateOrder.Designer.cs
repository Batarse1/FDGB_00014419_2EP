using System.ComponentModel;

namespace SourceCode
{
    partial class EliminateOrder
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
            this.tableLayoutPanelOrder = new System.Windows.Forms.TableLayoutPanel();
            this.lblProductOrder = new System.Windows.Forms.Label();
            this.btnEliminateOrder = new System.Windows.Forms.Button();
            this.comboBoxOrders = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelOrder
            // 
            this.tableLayoutPanelOrder.ColumnCount = 4;
            this.tableLayoutPanelOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelOrder.Controls.Add(this.lblProductOrder, 1, 1);
            this.tableLayoutPanelOrder.Controls.Add(this.btnEliminateOrder, 1, 3);
            this.tableLayoutPanelOrder.Controls.Add(this.comboBoxOrders, 2, 1);
            this.tableLayoutPanelOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelOrder.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelOrder.Name = "tableLayoutPanelOrder";
            this.tableLayoutPanelOrder.RowCount = 5;
            this.tableLayoutPanelOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.33F));
            this.tableLayoutPanelOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanelOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.34F));
            this.tableLayoutPanelOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.33F));
            this.tableLayoutPanelOrder.Size = new System.Drawing.Size(738, 452);
            this.tableLayoutPanelOrder.TabIndex = 3;
            // 
            // lblProductOrder
            // 
            this.lblProductOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProductOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblProductOrder.ForeColor = System.Drawing.Color.White;
            this.lblProductOrder.Location = new System.Drawing.Point(39, 109);
            this.lblProductOrder.Name = "lblProductOrder";
            this.lblProductOrder.Size = new System.Drawing.Size(215, 22);
            this.lblProductOrder.TabIndex = 0;
            this.lblProductOrder.Text = "ID de la Orden";
            this.lblProductOrder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEliminateOrder
            // 
            this.btnEliminateOrder.BackColor = System.Drawing.Color.MediumPurple;
            this.tableLayoutPanelOrder.SetColumnSpan(this.btnEliminateOrder, 2);
            this.btnEliminateOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminateOrder.FlatAppearance.BorderSize = 0;
            this.btnEliminateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminateOrder.ForeColor = System.Drawing.Color.White;
            this.btnEliminateOrder.Location = new System.Drawing.Point(39, 253);
            this.btnEliminateOrder.Name = "btnEliminateOrder";
            this.btnEliminateOrder.Size = new System.Drawing.Size(657, 84);
            this.btnEliminateOrder.TabIndex = 1;
            this.btnEliminateOrder.Text = "Eliminar Orden";
            this.btnEliminateOrder.UseVisualStyleBackColor = false;
            this.btnEliminateOrder.Click += new System.EventHandler(this.btnEliminateOrder_Click);
            // 
            // comboBoxOrders
            // 
            this.comboBoxOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxOrders.FormattingEnabled = true;
            this.comboBoxOrders.Location = new System.Drawing.Point(260, 112);
            this.comboBoxOrders.Name = "comboBoxOrders";
            this.comboBoxOrders.Size = new System.Drawing.Size(436, 24);
            this.comboBoxOrders.TabIndex = 2;
            // 
            // EliminateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanelOrder);
            this.Name = "EliminateOrder";
            this.Size = new System.Drawing.Size(738, 452);
            this.Load += new System.EventHandler(this.EliminateOrder_Load);
            this.tableLayoutPanelOrder.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnEliminateOrder;
        private System.Windows.Forms.ComboBox comboBoxOrders;
        private System.Windows.Forms.Label lblProductOrder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOrder;

        #endregion
    }
}