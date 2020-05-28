using System;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class ManageUsers : UserControl
    {
        private UserControl current = null;
        public ManageUsers()
        {
            InitializeComponent();
            current = addUser1;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (!(current is AddUser))
            {
                tableLayoutPanelUsers.Controls.Remove(current);
                current = new AddUser();
                current.Dock = DockStyle.Fill;
                tableLayoutPanelUsers.Controls.Add(current, 0,1);
                tableLayoutPanelUsers.SetColumnSpan(current, 3);
            }
        }

        private void btnEliminateUser_Click(object sender, EventArgs e)
        {
            if (!(current is EliminateUser))
            {
                tableLayoutPanelUsers.Controls.Remove(current);
                current = new EliminateUser();
                current.Dock = DockStyle.Fill;
                tableLayoutPanelUsers.Controls.Add(current, 0,1);
                tableLayoutPanelUsers.SetColumnSpan(current, 3);
            }
        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            if (!(current is ViewUsers))
            {
                tableLayoutPanelUsers.Controls.Remove(current);
                current = new ViewUsers();
                current.Dock = DockStyle.Fill;
                tableLayoutPanelUsers.Controls.Add(current, 0,1);
                tableLayoutPanelUsers.SetColumnSpan(current, 3);
            }
        }
    }
}