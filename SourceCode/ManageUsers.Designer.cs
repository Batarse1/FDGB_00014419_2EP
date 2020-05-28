using System.ComponentModel;

namespace SourceCode
{
    partial class ManageUsers
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
            this.tableLayoutPanelUsers = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnEliminateUser = new System.Windows.Forms.Button();
            this.btnViewUsers = new System.Windows.Forms.Button();
            this.addUser1 = new SourceCode.AddUser();
            this.tableLayoutPanelUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelUsers
            // 
            this.tableLayoutPanelUsers.ColumnCount = 3;
            this.tableLayoutPanelUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanelUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanelUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanelUsers.Controls.Add(this.btnAddUser, 0, 0);
            this.tableLayoutPanelUsers.Controls.Add(this.btnEliminateUser, 1, 0);
            this.tableLayoutPanelUsers.Controls.Add(this.btnViewUsers, 2, 0);
            this.tableLayoutPanelUsers.Controls.Add(this.addUser1, 0, 1);
            this.tableLayoutPanelUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelUsers.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelUsers.Name = "tableLayoutPanelUsers";
            this.tableLayoutPanelUsers.RowCount = 2;
            this.tableLayoutPanelUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelUsers.Size = new System.Drawing.Size(521, 353);
            this.tableLayoutPanelUsers.TabIndex = 0;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(3, 3);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(167, 64);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Añadir";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnEliminateUser
            // 
            this.btnEliminateUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminateUser.FlatAppearance.BorderSize = 0;
            this.btnEliminateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminateUser.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEliminateUser.ForeColor = System.Drawing.Color.White;
            this.btnEliminateUser.Location = new System.Drawing.Point(176, 3);
            this.btnEliminateUser.Name = "btnEliminateUser";
            this.btnEliminateUser.Size = new System.Drawing.Size(167, 64);
            this.btnEliminateUser.TabIndex = 1;
            this.btnEliminateUser.Text = "Eliminar";
            this.btnEliminateUser.UseVisualStyleBackColor = true;
            this.btnEliminateUser.Click += new System.EventHandler(this.btnEliminateUser_Click);
            // 
            // btnViewUsers
            // 
            this.btnViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnViewUsers.FlatAppearance.BorderSize = 0;
            this.btnViewUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewUsers.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnViewUsers.ForeColor = System.Drawing.Color.White;
            this.btnViewUsers.Location = new System.Drawing.Point(349, 3);
            this.btnViewUsers.Name = "btnViewUsers";
            this.btnViewUsers.Size = new System.Drawing.Size(169, 64);
            this.btnViewUsers.TabIndex = 2;
            this.btnViewUsers.Text = "Visualizar";
            this.btnViewUsers.UseVisualStyleBackColor = true;
            this.btnViewUsers.Click += new System.EventHandler(this.btnViewUsers_Click);
            // 
            // addUser1
            // 
            this.tableLayoutPanelUsers.SetColumnSpan(this.addUser1, 3);
            this.addUser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addUser1.Location = new System.Drawing.Point(3, 73);
            this.addUser1.Name = "addUser1";
            this.addUser1.Size = new System.Drawing.Size(515, 277);
            this.addUser1.TabIndex = 3;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanelUsers);
            this.Name = "ManageUsers";
            this.Size = new System.Drawing.Size(521, 353);
            this.tableLayoutPanelUsers.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private SourceCode.AddUser addUser1;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEliminateUser;
        private System.Windows.Forms.Button btnViewUsers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUsers;

        #endregion
    }
}