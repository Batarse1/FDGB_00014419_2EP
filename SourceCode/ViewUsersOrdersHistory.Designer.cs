using System.ComponentModel;

namespace SourceCode
{
    partial class ViewUsersOrdersHistory
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
            this.tableLayoutPanelViewUsersOrdersHistory = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewUsersOrdersHistory = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelViewUsersOrdersHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewUsersOrdersHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelViewUsersOrdersHistory
            // 
            this.tableLayoutPanelViewUsersOrdersHistory.ColumnCount = 3;
            this.tableLayoutPanelViewUsersOrdersHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelViewUsersOrdersHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanelViewUsersOrdersHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelViewUsersOrdersHistory.Controls.Add(this.dataGridViewUsersOrdersHistory, 1, 1);
            this.tableLayoutPanelViewUsersOrdersHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelViewUsersOrdersHistory.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelViewUsersOrdersHistory.Name = "tableLayoutPanelViewUsersOrdersHistory";
            this.tableLayoutPanelViewUsersOrdersHistory.RowCount = 3;
            this.tableLayoutPanelViewUsersOrdersHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelViewUsersOrdersHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanelViewUsersOrdersHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelViewUsersOrdersHistory.Size = new System.Drawing.Size(618, 716);
            this.tableLayoutPanelViewUsersOrdersHistory.TabIndex = 0;
            // 
            // dataGridViewUsersOrdersHistory
            // 
            this.dataGridViewUsersOrdersHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsersOrdersHistory.BackgroundColor = System.Drawing.Color.Indigo;
            this.dataGridViewUsersOrdersHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUsersOrdersHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsersOrdersHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsersOrdersHistory.Location = new System.Drawing.Point(33, 38);
            this.dataGridViewUsersOrdersHistory.Name = "dataGridViewUsersOrdersHistory";
            this.dataGridViewUsersOrdersHistory.RowTemplate.Height = 24;
            this.dataGridViewUsersOrdersHistory.Size = new System.Drawing.Size(550, 638);
            this.dataGridViewUsersOrdersHistory.TabIndex = 0;
            // 
            // ViewUsersOrdersHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanelViewUsersOrdersHistory);
            this.Name = "ViewUsersOrdersHistory";
            this.Size = new System.Drawing.Size(618, 716);
            this.Load += new System.EventHandler(this.ViewUsersOrdersHistory_Load);
            this.tableLayoutPanelViewUsersOrdersHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewUsersOrdersHistory)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridViewUsersOrdersHistory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelViewUsersOrdersHistory;

        #endregion
    }
}