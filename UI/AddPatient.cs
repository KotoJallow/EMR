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
    public partial class AddPatient : UserControl
    {
        private AdminHome adminHome;

        public AddPatient(AdminHome adminHome = null)
        {
            InitializeComponent();
            this.adminHome = adminHome;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age = AppFunctions.getAge(dtpDOB.Text);
            Patient patient = new Patient(
                addUserPatient.Username,addUserPatient.Password,addUserPatient.Firstname,
                addUserPatient.Middlename,addUserPatient.Lastname,addUserPatient.Gender,
                addUserPatient.PhoneNumber,addUserPatient.Permission,addUserPatient.UType,
                txtBloodGroup.Text,age,
                Convert.ToDouble(txtWeight.Text),Convert.ToDouble(txtHeight.Text),
                DateTime.Parse(dtpDOB.Text),rtbAddress.Text,
                txtNextOfKin.Text,txtNextOfKinNum.Text
                );
            Admin admin = new Admin();
            int result = admin.addPatientAccount(patient);
            if (result > 0)
            {
                MessageBox.Show("Patient successfully added");
            }
            else if (result == -1)
            {
                MessageBox.Show(string.Format(
                    "Username {0} already exist", addUserPatient.Username));
            }
            else
            {
                MessageBox.Show("Error in adding patient");
            }
            if (result != -1) adminHome.resetAdminHome();
        }
    }
}
