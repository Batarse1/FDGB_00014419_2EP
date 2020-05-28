using System.ComponentModel;

namespace SourceCode
{
    partial class EliminateUser
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
            this.tableLayoutPanelUser = new System.Windows.Forms.TableLayoutPanel();
            this.lblUserIdDB = new System.Windows.Forms.Label();
            this.btnEliminateUser = new System.Windows.Forms.Button();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelUser
            // 
            this.tableLayoutPanelUser.ColumnCount = 4;
            this.tableLayoutPanelUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelUser.Controls.Add(this.lblUserIdDB, 1, 1);
            this.tableLayoutPanelUser.Controls.Add(this.btnEliminateUser, 1, 3);
            this.tableLayoutPanelUser.Controls.Add(this.comboBoxUsers, 2, 1);
            this.tableLayoutPanelUser.Location = new System.Drawing.Point(84, 0);
            this.tableLayoutPanelUser.Name = "tableLayoutPanelUser";
            this.tableLayoutPanelUser.RowCount = 5;
            this.tableLayoutPanelUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.33F));
            this.tableLayoutPanelUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanelUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.34F));
            this.tableLayoutPanelUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.33F));
            this.tableLayoutPanelUser.Size = new System.Drawing.Size(640, 371);
            this.tableLayoutPanelUser.TabIndex = 0;
            // 
            // lblUserIdDB
            // 
            this.lblUserIdDB.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUserIdDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblUserIdDB.ForeColor = System.Drawing.Color.White;
            this.lblUserIdDB.Location = new System.Drawing.Point(35, 90);
            this.lblUserIdDB.Name = "lblUserIdDB";
            this.lblUserIdDB.Size = new System.Drawing.Size(186, 25);
            this.lblUserIdDB.TabIndex = 0;
            this.lblUserIdDB.Text = "Usuario";
            this.lblUserIdDB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEliminateUser
            // 
            this.tableLayoutPanelUser.SetColumnSpan(this.btnEliminateUser, 2);
            this.btnEliminateUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminateUser.FlatAppearance.BorderSize = 0;
            this.btnEliminateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminateUser.ForeColor = System.Drawing.Color.White;
            this.btnEliminateUser.Location = new System.Drawing.Point(35, 208);
            this.btnEliminateUser.Name = "btnEliminateUser";
            this.btnEliminateUser.Size = new System.Drawing.Size(570, 68);
            this.btnEliminateUser.TabIndex = 1;
            this.btnEliminateUser.Text = "Eliminar Usuario";
            this.btnEliminateUser.UseVisualStyleBackColor = true;
            this.btnEliminateUser.Click += new System.EventHandler(this.btnEliminateUser_Click);
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(227, 93);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(378, 24);
            this.comboBoxUsers.TabIndex = 2;
            // 
            // EliminateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanelUser);
            this.Name = "EliminateUser";
            this.Size = new System.Drawing.Size(724, 441);
            this.Load += new System.EventHandler(this.EliminateUser_Load);
            this.tableLayoutPanelUser.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnEliminateUser;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.Label lblUserIdDB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUser;

        #endregion
    }
}