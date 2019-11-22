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
    public partial class DoctorHome : Form
    {
        private Home home;
        private Doctor doctor;
        public DoctorHome(Doctor doctor = null, Home home = null)
        {
            InitializeComponent();
            this.doctor = doctor;
            this.home = home;
        }

        private void DoctorHome_Load(object sender, EventArgs e)
        {

        }

        

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Hide();
        }

        private void nav(UserControl userControl, Panel panel)
        {
            panel.Controls.Clear();
            this.Width = userControl.Width; //set parent width to usercontrol width
            userControl.Dock = DockStyle.Fill; //fill the parent container in this case panel
            panel.Controls.Add(userControl);
        } 

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nav(new AddPatient(), context);
        }

        private void setToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WeeklyScheduleUI weeklyScheduleUI = new WeeklyScheduleUI(doctor);
            weeklyScheduleUI.ShowDialog();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dataTable = doctor.listPatients();
            ListPatientsAdmin listPatients = new ListPatientsAdmin(dataTable);
            listPatients.ButtonDeleteButton = false;
            listPatients.ButtonUpdateButton = false;
            nav(listPatients, context);
        }

        private void DoctorHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                home.Close();
            }
        }
    }
}
