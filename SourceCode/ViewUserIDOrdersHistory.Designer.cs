using System.ComponentModel;

namespace SourceCode
{
    partial class ViewUserIDOrdersHistory
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
            this.tableLayoutPanelOrdersUserHistory = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewUserOrders = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelOrdersUserHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewUserOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelOrdersUserHistory
            // 
            this.tableLayoutPanelOrdersUserHistory.ColumnCount = 3;
            this.tableLayoutPanelOrdersUserHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelOrdersUserHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanelOrdersUserHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelOrdersUserHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelOrdersUserHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelOrdersUserHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelOrdersUserHistory.Controls.Add(this.dataGridViewUserOrders, 1, 1);
            this.tableLayoutPanelOrdersUserHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelOrdersUserHistory.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelOrdersUserHistory.Name = "tableLayoutPanelOrdersUserHistory";
            this.tableLayoutPanelOrdersUserHistory.RowCount = 3;
            this.tableLayoutPanelOrdersUserHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelOrdersUserHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanelOrdersUserHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelOrdersUserHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelOrdersUserHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelOrdersUserHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelOrdersUserHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelOrdersUserHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelOrdersUserHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelOrdersUserHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelOrdersUserHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelOrdersUserHistory.Size = new System.Drawing.Size(622, 432);
            this.tableLayoutPanelOrdersUserHistory.TabIndex = 0;
            // 
            // dataGridViewUserOrders
            // 
            this.dataGridViewUserOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUserOrders.BackgroundColor = System.Drawing.Color.Indigo;
            this.dataGridViewUserOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUserOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUserOrders.Location = new System.Drawing.Point(34, 24);
            this.dataGridViewUserOrders.Name = "dataGridViewUserOrders";
            this.dataGridViewUserOrders.ReadOnly = true;
            this.dataGridViewUserOrders.RowTemplate.Height = 24;
            this.dataGridViewUserOrders.Size = new System.Drawing.Size(553, 382);
            this.dataGridViewUserOrders.TabIndex = 0;
            // 
            // ViewUserIDOrdersHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanelOrdersUserHistory);
            this.Name = "ViewUserIDOrdersHistory";
            this.Size = new System.Drawing.Size(622, 432);
            this.Load += new System.EventHandler(this.ViewUserIDOrdersHistory_Load);
            this.tableLayoutPanelOrdersUserHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewUserOrders)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridViewUserOrders;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOrdersUserHistory;

        #endregion
    }
}