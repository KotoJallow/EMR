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
    public partial class AddDoctor : UserControl
    {
        AdminHome adminHome;
        public AddDoctor(AdminHome adminHome = null)
        {
            InitializeComponent();
            this.adminHome = adminHome;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor(
                addUserDoctor.Username,addUserDoctor.Password,
                addUserDoctor.Firstname,addUserDoctor.Middlename,
                addUserDoctor.Lastname,addUserDoctor.Gender,
                addUserDoctor.PhoneNumber,addUserDoctor.Permission,
                addUserDoctor.UType,txtSpecialisation.Text
                );
            Admin admin = new Admin();
            int result = admin.addDoctorAccount(doctor);
            if(result > 0)
            {
                MessageBox.Show("Doctor successfully added");
            }
            else if(result == -1)
            {
                MessageBox.Show(string.Format(
                    "Username {0} already exist", addUserDoctor.Username));
            }
            else
            {
                MessageBox.Show("Error in adding doctor");
            }
            if (result != -1) adminHome.resetAdminHome();
        }
    }
}
