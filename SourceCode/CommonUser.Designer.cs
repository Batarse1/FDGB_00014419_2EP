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
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanelCommonUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelCommonUser
            // 
            this.tableLayoutPanelCommonUser.ColumnCount = 2;
            this.tableLayoutPanelCommonUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelCommonUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelCommonUser.Controls.Add(this.btnUsers, 0, 0);
            this.tableLayoutPanelCommonUser.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanelCommonUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCommonUser.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelCommonUser.Name = "tableLayoutPanelCommonUser";
            this.tableLayoutPanelCommonUser.RowCount = 2;
            this.tableLayoutPanelCommonUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelCommonUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelCommonUser.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanelCommonUser.TabIndex = 0;
            this.tableLayoutPanelCommonUser.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelCommonUser_Paint);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Indigo;
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Location = new System.Drawing.Point(3, 3);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(554, 84);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "Ordenar";
            this.btnUsers.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(563, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 84);
            this.button1.TabIndex = 2;
            this.button1.Text = "Configurar cuenta";
            this.button1.UseVisualStyleBackColor = false;
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
            this.tableLayoutPanelCommonUser.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCommonUser;

        #endregion
    }
}