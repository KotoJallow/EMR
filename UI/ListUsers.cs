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
    public partial class ListUsers : UserControl
    {
        Admin adminHomeCurrentAdmin;
        public ListUsers(Admin adminHomeCurrentAdmin = null)
        {
            InitializeComponent();
            this.adminHomeCurrentAdmin = adminHomeCurrentAdmin;
        }

        public void updateGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = Admin.listUsers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int userID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["uID"].Value.ToString());
                UpdateUserAdmin updateUserAdmin = new UpdateUserAdmin(AppFunctions.getUser(
                    AppFunctions.getUserTable(userID)),
                    this);
                updateUserAdmin.ShowDialog();
            }
            else
            {
                MessageBox.Show("A row should be selected.");
            }
        }

        private void ListUsers_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = Admin.listUsers();
        }

        private void btnChangePerm_Click(object sender, EventArgs e)
        {
            if (adminHomeCurrentAdmin.Permission.PermissionType != Permission.perm.ALL)
            {
                MessageBox.Show("Access not granted. Contact Administration for help. ");
                return;
            }
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int userID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["uID"].Value.ToString());
                ChangePermissionAdmin changePermissionAdmin = new ChangePermissionAdmin(AppFunctions.getUser(
                    AppFunctions.getUserTable(userID)),
                    adminHomeCurrentAdmin);
                changePermissionAdmin.ShowDialog();
            }
            else
            {
                MessageBox.Show("A row should be selected.");
            }
        }
    }
}
