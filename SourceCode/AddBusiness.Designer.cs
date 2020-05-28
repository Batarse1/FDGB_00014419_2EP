using System.ComponentModel;

namespace SourceCode
{
    partial class AddBusiness
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnAddBusinessDB = new System.Windows.Forms.Button();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanelBusiness.Controls.Add(this.lblDescription, 1, 3);
            this.tableLayoutPanelBusiness.Controls.Add(this.btnAddBusinessDB, 1, 5);
            this.tableLayoutPanelBusiness.Controls.Add(this.txtBoxName, 2, 1);
            this.tableLayoutPanelBusiness.Controls.Add(this.txtBoxDescription, 2, 3);
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
            this.tableLayoutPanelBusiness.Size = new System.Drawing.Size(592, 419);
            this.tableLayoutPanelBusiness.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(32, 69);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(171, 29);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(32, 167);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(171, 29);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Descripción";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddBusinessDB
            // 
            this.tableLayoutPanelBusiness.SetColumnSpan(this.btnAddBusinessDB, 2);
            this.btnAddBusinessDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddBusinessDB.FlatAppearance.BorderSize = 0;
            this.btnAddBusinessDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBusinessDB.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAddBusinessDB.ForeColor = System.Drawing.Color.White;
            this.btnAddBusinessDB.Location = new System.Drawing.Point(32, 268);
            this.btnAddBusinessDB.Name = "btnAddBusinessDB";
            this.btnAddBusinessDB.Size = new System.Drawing.Size(526, 77);
            this.btnAddBusinessDB.TabIndex = 6;
            this.btnAddBusinessDB.Text = "Añadir Negocio";
            this.btnAddBusinessDB.UseVisualStyleBackColor = true;
            this.btnAddBusinessDB.Click += new System.EventHandler(this.btnAddBusinessDB_Click);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxName.Location = new System.Drawing.Point(209, 72);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(349, 22);
            this.txtBoxName.TabIndex = 7;
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxDescription.Location = new System.Drawing.Point(209, 170);
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(349, 22);
            this.txtBoxDescription.TabIndex = 8;
            // 
            // AddBusiness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanelBusiness);
            this.Location = new System.Drawing.Point(19, 19);
            this.Name = "AddBusiness";
            this.Size = new System.Drawing.Size(592, 419);
            this.tableLayoutPanelBusiness.ResumeLayout(false);
            this.tableLayoutPanelBusiness.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAddBusinessDB;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBusiness;
        private System.Windows.Forms.TextBox txtBoxDescription;
        private System.Windows.Forms.TextBox txtBoxName;

        #endregion
    }
}