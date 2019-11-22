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
    public partial class UpdateUserAdmin : Form
    {
        Admin admin; /*virtually represents a user 
                        Admin has equally the same properties as User
                        but User is Abstract and Admin is Concrete.
                        */
        ListUsers listUsers; //To refresh datagridview in AdminHome Page
        public UpdateUserAdmin(Admin admin, ListUsers listUsers)
        {
            InitializeComponent();
            this.admin = admin;
            this.listUsers = listUsers;
        }

        private void UpdateUserAdmin_Load(object sender, EventArgs e)
        {
            textBox1.Text = AppFunctions.getUserIDorType("userID",admin.Username).ToString(); //USERID gives authID
            textBox2.Text = admin.FirstName;
            textBox3.Text = admin.MiddleName;
            textBox4.Text = admin.LastName;
            textBox5.Text = admin.PhoneNumber;
            textBox6.Text = admin.Gender;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin.FirstName = textBox2.Text;
            admin.MiddleName = textBox3.Text;
            admin.LastName = textBox4.Text;
            admin.PhoneNumber = textBox5.Text;
            AppFunctions.updateUser(admin,int.Parse(textBox1.Text));
            listUsers.updateGridView();
            this.Close();
        }
    }
}
