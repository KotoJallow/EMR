using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL;

namespace UI
{
    public partial class AddAdmin : UserControl
    {
        Admin superAdmin;
        AdminHome adminHome;
        public AddAdmin(Admin superAdmin = null, AdminHome adminHome = null)
        {
            InitializeComponent();
            this.superAdmin = superAdmin;
            this.adminHome = adminHome;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(
                addUserAdmin.Username, addUserAdmin.Password,
                addUserAdmin.Firstname, addUserAdmin.Middlename,
                addUserAdmin.Lastname, addUserAdmin.Gender,
                addUserAdmin.PhoneNumber, addUserAdmin.Permission,
                addUserAdmin.UType
                );
            
            int result = superAdmin.addAdmin(admin);
            if (result > 0)
            {
                MessageBox.Show("Admin successfully added");
            }
            else if (result == -2)
            {
                MessageBox.Show("Access not granted. Contact Administration for help. ");
            }
            else if (result == -1)
            {
                MessageBox.Show(string.Format(
                    "Username {0} already exist", addUserAdmin.Username));
            }
            else
            {
                MessageBox.Show("Error in adding admin");
            }

            if(result != -1)  adminHome.resetAdminHome();
        }

    }
}
