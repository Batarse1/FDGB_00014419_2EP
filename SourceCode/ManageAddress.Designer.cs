using System.ComponentModel;

namespace SourceCode
{
    partial class ManageAddress
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
            this.tableLayoutPanelAddress = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.btnEliminateAddress = new System.Windows.Forms.Button();
            this.btnChangeAddress = new System.Windows.Forms.Button();
            this.btnViewAddress = new System.Windows.Forms.Button();
            this.tableLayoutPanelAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelAddress
            // 
            this.tableLayoutPanelAddress.ColumnCount = 4;
            this.tableLayoutPanelAddress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelAddress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelAddress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelAddress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelAddress.Controls.Add(this.btnAddAddress, 0, 0);
            this.tableLayoutPanelAddress.Controls.Add(this.btnEliminateAddress, 1, 0);
            this.tableLayoutPanelAddress.Controls.Add(this.btnChangeAddress, 2, 0);
            this.tableLayoutPanelAddress.Controls.Add(this.btnViewAddress, 3, 0);
            this.tableLayoutPanelAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAddress.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelAddress.Name = "tableLayoutPanelAddress";
            this.tableLayoutPanelAddress.RowCount = 2;
            this.tableLayoutPanelAddress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelAddress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelAddress.Size = new System.Drawing.Size(714, 482);
            this.tableLayoutPanelAddress.TabIndex = 0;
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddAddress.FlatAppearance.BorderSize = 0;
            this.btnAddAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAddress.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAddAddress.ForeColor = System.Drawing.Color.White;
            this.btnAddAddress.Location = new System.Drawing.Point(3, 3);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(172, 90);
            this.btnAddAddress.TabIndex = 3;
            this.btnAddAddress.Text = "Añadir Dirección";
            this.btnAddAddress.UseVisualStyleBackColor = false;
            this.btnAddAddress.Click += new System.EventHandler(this.btnAddAddress_Click);
            // 
            // btnEliminateAddress
            // 
            this.btnEliminateAddress.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminateAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminateAddress.FlatAppearance.BorderSize = 0;
            this.btnEliminateAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminateAddress.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEliminateAddress.ForeColor = System.Drawing.Color.White;
            this.btnEliminateAddress.Location = new System.Drawing.Point(181, 3);
            this.btnEliminateAddress.Name = "btnEliminateAddress";
            this.btnEliminateAddress.Size = new System.Drawing.Size(172, 90);
            this.btnEliminateAddress.TabIndex = 4;
            this.btnEliminateAddress.Text = "Eliminar Dirección";
            this.btnEliminateAddress.UseVisualStyleBackColor = false;
            this.btnEliminateAddress.Click += new System.EventHandler(this.btnEliminateAddress_Click);
            // 
            // btnChangeAddress
            // 
            this.btnChangeAddress.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChangeAddress.FlatAppearance.BorderSize = 0;
            this.btnChangeAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeAddress.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnChangeAddress.ForeColor = System.Drawing.Color.White;
            this.btnChangeAddress.Location = new System.Drawing.Point(359, 3);
            this.btnChangeAddress.Name = "btnChangeAddress";
            this.btnChangeAddress.Size = new System.Drawing.Size(172, 90);
            this.btnChangeAddress.TabIndex = 5;
            this.btnChangeAddress.Text = "Cambiar Dirección";
            this.btnChangeAddress.UseVisualStyleBackColor = false;
            this.btnChangeAddress.Click += new System.EventHandler(this.btnChangeAddress_Click);
            // 
            // btnViewAddress
            // 
            this.btnViewAddress.BackColor = System.Drawing.Color.Transparent;
            this.btnViewAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnViewAddress.FlatAppearance.BorderSize = 0;
            this.btnViewAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAddress.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnViewAddress.ForeColor = System.Drawing.Color.White;
            this.btnViewAddress.Location = new System.Drawing.Point(537, 3);
            this.btnViewAddress.Name = "btnViewAddress";
            this.btnViewAddress.Size = new System.Drawing.Size(174, 90);
            this.btnViewAddress.TabIndex = 6;
            this.btnViewAddress.Text = "Ver Direcciones";
            this.btnViewAddress.UseVisualStyleBackColor = false;
            this.btnViewAddress.Click += new System.EventHandler(this.btnViewAddress_Click);
            // 
            // ManageAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanelAddress);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ManageAddress";
            this.Size = new System.Drawing.Size(714, 482);
            this.tableLayoutPanelAddress.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAddAddress;
        private System.Windows.Forms.Button btnChangeAddress;
        private System.Windows.Forms.Button btnEliminateAddress;
        private System.Windows.Forms.Button btnViewAddress;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAddress;

        #endregion
    }
}