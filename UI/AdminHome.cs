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
    public partial class AdminHome : Form
    {
        private Admin admin;
        private Home home;
        public static int baseWidth = 757;

        public AdminHome(Admin admin = null, Home home = null)
        {
            InitializeComponent();
            this.admin = admin;
            this.home = home;
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            //if admin permission is not ALL the admin menuitem should not be displayed
            if(admin.Permission.PermissionType != Permission.perm.ALL)
            {
                this.adminToolStripMenuItem1.Visible = false;
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }

        private void nav(UserControl userControl,Panel panel)
        {
            panel.Controls.Clear();
            this.Width = userControl.Width; //set parent width to usercontrol width
            userControl.Dock = DockStyle.Fill; //fill the parent container ,in this case, panel
            panel.Controls.Add(userControl);
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nav(new ListUsers(admin), context);
        }

        public  void resetAdminHome()
        {
            context.Controls.Clear();
            this.Width = baseWidth;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nav(new AddDoctor(this), context);
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nav(new AddPatient(this), context);
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            nav(new AddAdmin(admin,this), context);
        }

        private void listToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nav(new ListDoctorsAdmin(), context);
        }

        private void listToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            nav(new ListPatientsAdmin(), context);
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Hide();
        }

        private void AdminHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                home.Close();
            }
        }
    }
}
