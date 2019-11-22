using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            lblErrorMsg.Text = "";
            //later ensure valid is entered
            int userID, userType;
            try
            {
                userID = AppFunctions.getUserIDorType("userID", username);
                userType = AppFunctions.getUserIDorType("userType", username);

                switch ((uType.userTypes)userType)
                {
                    case uType.userTypes.ADMIN:
                        Admin admin = new Admin();
                        admin = admin.getUser(userID);
                        if (admin.login(username, password))
                        {
                            AdminHome adminHome = new AdminHome(admin,this);
                            adminHome.Show();
                            this.Hide();
                        }
                        else
                        {
                            lblErrorMsg.Text = "Invalid Logging";
                            lblErrorMsg.ForeColor = Color.Red;
                        }
                        break;
                    case uType.userTypes.DOCTOR:
                        Doctor doctor = new Doctor();
                        doctor = doctor.getUser(userID);
                        if (doctor.login(username, password))
                        {
                            DoctorHome doctorHome = new DoctorHome(doctor,this);
                            doctorHome.Show();
                            this.Hide();
                        }
                        else
                        {
                            lblErrorMsg.Text = "Invalid Logging";
                            lblErrorMsg.ForeColor = Color.Red;
                        }
                        break;
                    case uType.userTypes.PATIENT:
                        Patient patient = new Patient();
                        patient = patient.getUser(userID);
                        if (patient.login(username, password))
                        {
                            PatientHome patientHome = new PatientHome(patient,this);
                            patientHome.Show();
                            this.Hide();
                        }
                        else
                        {
                            lblErrorMsg.Text = "Invalid Logging";
                            lblErrorMsg.ForeColor = Color.Red;
                        }
                        break;
                }
                txtPassword.Text = "";txtUsername.Text = "";
            }
            catch (Exception exp)
            {

                lblErrorMsg.Text = "Invalid logging";
                lblErrorMsg.ForeColor = Color.Red;
                
                txtUsername.Focus();
            }   
        
        }

        private void Home_VisibleChanged(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }
    }
}
