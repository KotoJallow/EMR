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
    public partial class PatientHome : Form
    {
        private Home home;
        private Patient patient = null;
        private Dictionary<string, string> appointmentSchedule;

        public Dictionary<string, string> AppointmentSchedule { get => appointmentSchedule; set => appointmentSchedule = value; }
        public int PatientID { get => patient.PatientID; }
        public Patient Patient { get => patient; }

        public PatientHome(Patient patient = null,Home home = null)
        {
            
            InitializeComponent();
            this.patient = patient;
            this.home = home;
        }

        private void PatientHome_Load(object sender, EventArgs e)
        {
            //lblWelcomeMsg.Text = string.Format(" Welcome: {0}", patient.FirstName);
            
            try
            {
                List<string> data = new List<string>();
                DataTable dataTable = Admin.listDoctors();
                int length = dataTable.Rows.Count;
                for (int i = 0; i < length; i++)
                {
                    data.Add(string.Format("{0}:\t{1}",dataTable.Rows[i]["lastname"],dataTable.Rows[i]["specialisation"]));
                }
                toolStripComboBoxDoctorsList.Items.AddRange(data.ToArray());
                toolStripComboBoxDoctorsList.Text = "Select A Doctor";
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message);
            }
        }

        private void nav(UserControl userControl, Panel panel)
        {
            panel.Controls.Clear();
            this.Width = userControl.Width; //set parent width to usercontrol width
            userControl.Dock = DockStyle.Fill; //fill the parent container in this case panel
            panel.Controls.Add(userControl);
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Hide();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dataTable = patient.listDoctors();
            ListDoctorsAdmin listDoctors = new ListDoctorsAdmin(dataTable);
            listDoctors.ButtonDeleteButton = false;
            listDoctors.ButtonUpdateButton = false;
            nav(listDoctors, context);
        }



        private void addDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = toolStripComboBoxDoctorsList.SelectedIndex;
            if (index > 0) 
            {

                int result = DoctorPatient.insertDoctorPatient(PatientID, index);
                if(result > 0)
                {
                    MessageBox.Show("Doctor successfully added.\nSet Appointment.");
                    getDoctorsSchedule();
                }
                else if (result == -1)
                {
                    MessageBox.Show("Doctor already added.\nSet Appointment.");
                    getDoctorsSchedule();
                }
                else
                {
                    MessageBox.Show("Doctor could not be added");
                }
            }
        }

        private void getDoctorsSchedule()
        {

            int index = toolStripComboBoxDoctorsList.SelectedIndex;
            WeeklyScheduleUI weeklyScheduleUI = new WeeklyScheduleUI(null, this, index);
            weeklyScheduleUI.ShowDialog();
        }

        private void PatientHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                home.Close();
            }
        }
    }
}
