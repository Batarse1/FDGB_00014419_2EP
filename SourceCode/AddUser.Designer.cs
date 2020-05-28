using System.ComponentModel;

namespace SourceCode
{
    partial class AddUser
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
            this.lblFullname = new System.Windows.Forms.Label();
            this.txtBoxFullname = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.btnAddUserDB = new System.Windows.Forms.Button();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.comboBoxUserType = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.lblFullname, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxFullname, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblUsername, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPassword, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblUserType, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnAddUserDB, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxUsername, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxPassword, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxUserType, 2, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(388, 340);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblFullname
            // 
            this.lblFullname.BackColor = System.Drawing.Color.Transparent;
            this.lblFullname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFullname.ForeColor = System.Drawing.Color.White;
            this.lblFullname.Location = new System.Drawing.Point(22, 34);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(129, 23);
            this.lblFullname.TabIndex = 0;
            this.lblFullname.Text = "Nombre completo";
            this.lblFullname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBoxFullname
            // 
            this.txtBoxFullname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxFullname.Location = new System.Drawing.Point(157, 37);
            this.txtBoxFullname.Name = "txtBoxFullname";
            this.txtBoxFullname.Size = new System.Drawing.Size(207, 22);
            this.txtBoxFullname.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(22, 84);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(129, 23);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Nombre de usuario";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(22, 134);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(129, 23);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Contraseña";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUserType
            // 
            this.lblUserType.BackColor = System.Drawing.Color.Transparent;
            this.lblUserType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserType.ForeColor = System.Drawing.Color.White;
            this.lblUserType.Location = new System.Drawing.Point(22, 184);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(129, 23);
            this.lblUserType.TabIndex = 4;
            this.lblUserType.Text = "Tipo de usuario";
            this.lblUserType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddUserDB
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnAddUserDB, 2);
            this.btnAddUserDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddUserDB.FlatAppearance.BorderSize = 0;
            this.btnAddUserDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUserDB.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAddUserDB.ForeColor = System.Drawing.Color.White;
            this.btnAddUserDB.Location = new System.Drawing.Point(22, 237);
            this.btnAddUserDB.Name = "btnAddUserDB";
            this.btnAddUserDB.Size = new System.Drawing.Size(342, 62);
            this.btnAddUserDB.TabIndex = 5;
            this.btnAddUserDB.Text = "Añadir Usuario";
            this.btnAddUserDB.UseVisualStyleBackColor = true;
            this.btnAddUserDB.Click += new System.EventHandler(this.btnAddUserDB_Click);
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxUsername.Location = new System.Drawing.Point(157, 87);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(207, 22);
            this.txtBoxUsername.TabIndex = 6;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxPassword.Location = new System.Drawing.Point(157, 137);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(207, 22);
            this.txtBoxPassword.TabIndex = 7;
            // 
            // comboBoxUserType
            // 
            this.comboBoxUserType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxUserType.FormattingEnabled = true;
            this.comboBoxUserType.Location = new System.Drawing.Point(157, 187);
            this.comboBoxUserType.Name = "comboBoxUserType";
            this.comboBoxUserType.Size = new System.Drawing.Size(207, 24);
            this.comboBoxUserType.TabIndex = 8;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddUser";
            this.Size = new System.Drawing.Size(388, 340);
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAddUserDB;
        private System.Windows.Forms.ComboBox comboBoxUserType;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtBoxFullname;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxUsername;

        #endregion
    }
}