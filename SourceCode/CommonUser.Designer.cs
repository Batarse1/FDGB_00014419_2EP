using System.ComponentModel;

namespace SourceCode
{
    partial class CommonUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommonUser));
            this.tableLayoutPanelCommonUser = new System.Windows.Forms.TableLayoutPanel();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.tableLayoutPanelCommonUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelCommonUser
            // 
            this.tableLayoutPanelCommonUser.ColumnCount = 2;
            this.tableLayoutPanelCommonUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCommonUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCommonUser.Controls.Add(this.btnUsers, 0, 0);
            this.tableLayoutPanelCommonUser.Controls.Add(this.btnConfig, 1, 0);
            this.tableLayoutPanelCommonUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCommonUser.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelCommonUser.Name = "tableLayoutPanelCommonUser";
            this.tableLayoutPanelCommonUser.RowCount = 2;
            this.tableLayoutPanelCommonUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelCommonUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelCommonUser.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanelCommonUser.TabIndex = 0;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.BlueViolet;
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Location = new System.Drawing.Point(0, 0);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(0);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(400, 90);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "Ordenar";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.BlueViolet;
            this.btnConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.Location = new System.Drawing.Point(400, 0);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(400, 90);
            this.btnConfig.TabIndex = 2;
            this.btnConfig.Text = "Direcciones";
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // CommonUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanelCommonUser);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "CommonUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido a Hugo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CommonUser_FormClosing);
            this.tableLayoutPanelCommonUser.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCommonUser;

        #endregion
    }
}