using System.ComponentModel;

namespace SourceCode
{
    partial class Password
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Password));
            this.tableLayoutPanelChangePassword = new System.Windows.Forms.TableLayoutPanel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.textBoxRepeatedNewPassword = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanelChangePassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelChangePassword
            // 
            this.tableLayoutPanelChangePassword.BackColor = System.Drawing.Color.Indigo;
            this.tableLayoutPanelChangePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanelChangePassword.ColumnCount = 6;
            this.tableLayoutPanelChangePassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelChangePassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelChangePassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelChangePassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelChangePassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.5F));
            this.tableLayoutPanelChangePassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelChangePassword.Controls.Add(this.lblUsername, 1, 1);
            this.tableLayoutPanelChangePassword.Controls.Add(this.lblOldPassword, 1, 3);
            this.tableLayoutPanelChangePassword.Controls.Add(this.lblNewPassword, 1, 5);
            this.tableLayoutPanelChangePassword.Controls.Add(this.label1, 1, 7);
            this.tableLayoutPanelChangePassword.Controls.Add(this.textBoxUsername, 2, 1);
            this.tableLayoutPanelChangePassword.Controls.Add(this.textBoxOldPassword, 2, 3);
            this.tableLayoutPanelChangePassword.Controls.Add(this.textBoxNewPassword, 2, 5);
            this.tableLayoutPanelChangePassword.Controls.Add(this.textBoxRepeatedNewPassword, 2, 7);
            this.tableLayoutPanelChangePassword.Controls.Add(this.btnChangePassword, 1, 9);
            this.tableLayoutPanelChangePassword.Controls.Add(this.btnCancel, 4, 9);
            this.tableLayoutPanelChangePassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelChangePassword.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelChangePassword.Name = "tableLayoutPanelChangePassword";
            this.tableLayoutPanelChangePassword.RowCount = 11;
            this.tableLayoutPanelChangePassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.663465F));
            this.tableLayoutPanelChangePassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.002802F));
            this.tableLayoutPanelChangePassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.663465F));
            this.tableLayoutPanelChangePassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.002802F));
            this.tableLayoutPanelChangePassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.663465F));
            this.tableLayoutPanelChangePassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.002802F));
            this.tableLayoutPanelChangePassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.663465F));
            this.tableLayoutPanelChangePassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.002802F));
            this.tableLayoutPanelChangePassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.663465F));
            this.tableLayoutPanelChangePassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.008F));
            this.tableLayoutPanelChangePassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.663465F));
            this.tableLayoutPanelChangePassword.Size = new System.Drawing.Size(749, 381);
            this.tableLayoutPanelChangePassword.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(40, 33);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(218, 26);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Nombre de Usuario";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblOldPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOldPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOldPassword.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblOldPassword.ForeColor = System.Drawing.Color.White;
            this.lblOldPassword.Location = new System.Drawing.Point(40, 92);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(218, 26);
            this.lblOldPassword.TabIndex = 1;
            this.lblOldPassword.Text = "Contraseña Actual";
            this.lblOldPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblNewPassword.ForeColor = System.Drawing.Color.White;
            this.lblNewPassword.Location = new System.Drawing.Point(40, 151);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(218, 26);
            this.lblNewPassword.TabIndex = 2;
            this.lblNewPassword.Text = "Contraseña nueva";
            this.lblNewPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Repetir Contraseña nueva";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxUsername
            // 
            this.tableLayoutPanelChangePassword.SetColumnSpan(this.textBoxUsername, 3);
            this.textBoxUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUsername.Location = new System.Drawing.Point(264, 36);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(442, 22);
            this.textBoxUsername.TabIndex = 6;
            // 
            // textBoxOldPassword
            // 
            this.tableLayoutPanelChangePassword.SetColumnSpan(this.textBoxOldPassword, 3);
            this.textBoxOldPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOldPassword.Location = new System.Drawing.Point(264, 95);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.PasswordChar = '*';
            this.textBoxOldPassword.Size = new System.Drawing.Size(442, 22);
            this.textBoxOldPassword.TabIndex = 7;
            // 
            // textBoxNewPassword
            // 
            this.tableLayoutPanelChangePassword.SetColumnSpan(this.textBoxNewPassword, 3);
            this.textBoxNewPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNewPassword.Location = new System.Drawing.Point(264, 154);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '*';
            this.textBoxNewPassword.Size = new System.Drawing.Size(442, 22);
            this.textBoxNewPassword.TabIndex = 8;
            // 
            // textBoxRepeatedNewPassword
            // 
            this.tableLayoutPanelChangePassword.SetColumnSpan(this.textBoxRepeatedNewPassword, 3);
            this.textBoxRepeatedNewPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRepeatedNewPassword.Location = new System.Drawing.Point(264, 213);
            this.textBoxRepeatedNewPassword.Name = "textBoxRepeatedNewPassword";
            this.textBoxRepeatedNewPassword.PasswordChar = '*';
            this.textBoxRepeatedNewPassword.Size = new System.Drawing.Size(442, 22);
            this.textBoxRepeatedNewPassword.TabIndex = 9;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.MediumPurple;
            this.tableLayoutPanelChangePassword.SetColumnSpan(this.btnChangePassword, 2);
            this.btnChangePassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(40, 272);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(311, 70);
            this.btnChangePassword.TabIndex = 5;
            this.btnChangePassword.Text = "Cambiar Contraseña";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MediumPurple;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(394, 272);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(312, 70);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 381);
            this.Controls.Add(this.tableLayoutPanelChangePassword);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar contraseña de Hugo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Password_FormClosing);
            this.tableLayoutPanelChangePassword.ResumeLayout(false);
            this.tableLayoutPanelChangePassword.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelChangePassword;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.TextBox textBoxOldPassword;
        private System.Windows.Forms.TextBox textBoxRepeatedNewPassword;
        private System.Windows.Forms.TextBox textBoxUsername;

        #endregion
    }
}