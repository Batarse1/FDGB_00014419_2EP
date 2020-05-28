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
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtBoxUserID = new System.Windows.Forms.TextBox();
            this.btnSearchUserOrders = new System.Windows.Forms.Button();
            this.dataGridViewUserOrders = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelOrdersUserHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewUserOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelOrdersUserHistory
            // 
            this.tableLayoutPanelOrdersUserHistory.ColumnCount = 4;
            this.tableLayoutPanelOrdersUserHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelOrdersUserHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelOrdersUserHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelOrdersUserHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelOrdersUserHistory.Controls.Add(this.lblUserId, 1, 1);
            this.tableLayoutPanelOrdersUserHistory.Controls.Add(this.txtBoxUserID, 2, 1);
            this.tableLayoutPanelOrdersUserHistory.Controls.Add(this.btnSearchUserOrders, 1, 3);
            this.tableLayoutPanelOrdersUserHistory.Controls.Add(this.dataGridViewUserOrders, 1, 5);
            this.tableLayoutPanelOrdersUserHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelOrdersUserHistory.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelOrdersUserHistory.Name = "tableLayoutPanelOrdersUserHistory";
            this.tableLayoutPanelOrdersUserHistory.RowCount = 7;
            this.tableLayoutPanelOrdersUserHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelOrdersUserHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanelOrdersUserHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelOrdersUserHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelOrdersUserHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelOrdersUserHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53F));
            this.tableLayoutPanelOrdersUserHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelOrdersUserHistory.Size = new System.Drawing.Size(622, 432);
            this.tableLayoutPanelOrdersUserHistory.TabIndex = 0;
            // 
            // lblUserId
            // 
            this.lblUserId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblUserId.ForeColor = System.Drawing.Color.White;
            this.lblUserId.Location = new System.Drawing.Point(34, 21);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(180, 30);
            this.lblUserId.TabIndex = 1;
            this.lblUserId.Text = "ID del usuario\r\n";
            this.lblUserId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBoxUserID
            // 
            this.txtBoxUserID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxUserID.Location = new System.Drawing.Point(220, 24);
            this.txtBoxUserID.Name = "txtBoxUserID";
            this.txtBoxUserID.Size = new System.Drawing.Size(367, 22);
            this.txtBoxUserID.TabIndex = 2;
            // 
            // btnSearchUserOrders
            // 
            this.tableLayoutPanelOrdersUserHistory.SetColumnSpan(this.btnSearchUserOrders, 2);
            this.btnSearchUserOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchUserOrders.FlatAppearance.BorderSize = 0;
            this.btnSearchUserOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchUserOrders.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSearchUserOrders.ForeColor = System.Drawing.Color.White;
            this.btnSearchUserOrders.Location = new System.Drawing.Point(34, 75);
            this.btnSearchUserOrders.Name = "btnSearchUserOrders";
            this.btnSearchUserOrders.Size = new System.Drawing.Size(553, 80);
            this.btnSearchUserOrders.TabIndex = 3;
            this.btnSearchUserOrders.Text = "Buscar";
            this.btnSearchUserOrders.UseVisualStyleBackColor = true;
            this.btnSearchUserOrders.Click += new System.EventHandler(this.btnSearchUserOrders_Click);
            // 
            // dataGridViewUserOrders
            // 
            this.dataGridViewUserOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUserOrders.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.dataGridViewUserOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanelOrdersUserHistory.SetColumnSpan(this.dataGridViewUserOrders, 2);
            this.dataGridViewUserOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUserOrders.Location = new System.Drawing.Point(34, 182);
            this.dataGridViewUserOrders.Name = "dataGridViewUserOrders";
            this.dataGridViewUserOrders.RowTemplate.Height = 24;
            this.dataGridViewUserOrders.Size = new System.Drawing.Size(553, 222);
            this.dataGridViewUserOrders.TabIndex = 4;
            // 
            // ViewUserIDOrdersHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanelOrdersUserHistory);
            this.Name = "ViewUserIDOrdersHistory";
            this.Size = new System.Drawing.Size(622, 432);
            this.tableLayoutPanelOrdersUserHistory.ResumeLayout(false);
            this.tableLayoutPanelOrdersUserHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewUserOrders)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnSearchUserOrders;
        private System.Windows.Forms.DataGridView dataGridViewUserOrders;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOrdersUserHistory;
        private System.Windows.Forms.TextBox txtBoxUserID;

        #endregion
    }
}