using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ChangePermissionAdmin : Form
    {
        Admin user; /*virtually represents a user 
                        Admin has equally the same properties as User
                        but User is Abstract and Admin is Concrete.
                        */
        Admin adminHomeCurrentUser;
       
        public ChangePermissionAdmin(Admin user, Admin adminHomeCurrentUser)
        {
            InitializeComponent();
            this.user = user;
            this.adminHomeCurrentUser = adminHomeCurrentUser;
        }

        private void ChangePermissionAdmin_Load(object sender, EventArgs e)
        {
            txtID.Text = AppFunctions.getUserIDorType("userID", user.Username).ToString(); //USERID gives authID
            cbPerm.SelectedIndex = (int) user.Permission.PermissionType;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user.setPermission((Permission.perm)cbPerm.SelectedIndex);
            adminHomeCurrentUser.authorisationManagement(int.Parse(txtID.Text), user.Permission.PermissionType);
            MessageBox.Show("Permissions successfully updated.");
            this.Close();
        }
    }
}
