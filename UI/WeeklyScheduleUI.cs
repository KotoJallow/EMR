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
    public partial class WeeklyScheduleUI : Form
    {
        private static bool scheduleStatus = false;
        private int doctorID;
        private  int row;
        private  int col;
        private ToolTip toolTip;
        private Label label;
        private DialogResult dialogResult;


        private Doctor doctor;
        PatientHome patientHome; //to get the schedule

        public WeeklyScheduleUI(Doctor doctor = null , PatientHome patientHome = null,int doctorID = 0)
        {
            InitializeComponent();
            this.doctor = doctor;
            if (doctor == null)
                this.doctorID = doctorID;
            else
                this.doctorID = doctor.DoctorID;
            this.patientHome = patientHome;
            toolTip = new ToolTip();
        }

        private void WeeklyScheduleUI_Load(object sender, EventArgs e)
        {
            DataTable dt;
            do
            {
                dt = WeeklySchedule.getWeeklySchedule(doctorID);
                if (dt.Rows.Count == 0)
                {
                    WeeklySchedule.setDefaultWeeklySchedule(doctorID);
                }
            } while (dt.Rows.Count == 0);

            for (int row = 1; row < tableLayoutPanel1.RowCount; row++)
            {
                for (int col = 1; col< tableLayoutPanel1.ColumnCount; col++)
                {
                    
                    Label label = (Label)tableLayoutPanel1.GetControlFromPosition(col,row);
                    string status = dt.Rows[col - 1][row].ToString();
                   
                    if (status == "BUSY")
                    {
                        label.BackColor = Color.Red;
                        toolTip.SetToolTip(label, "Scheduled");
                    }
                    else
                    {
                        toolTip.SetToolTip(label, "Click to Change Schedule");
                    }
                    label.Text = status;
                }
            }

            if (patientHome != null)
            {
                toolTip.SetToolTip(btnDone, "Last selected schedule will be set.");
            }
        }

        private void label_Schedule_Click(object sender, EventArgs e)
        {
            label = (Label)sender;
            TableLayoutPanelCellPosition cellPosition = tableLayoutPanel1.GetCellPosition(label);
            row = cellPosition.Row;
            col = cellPosition.Column;

            scheduleStatus ^= true;
            if (doctor != null) //only doctor and change schedule from busy to free onclick
            {
                if (scheduleStatus)
                {
                    busy(label);
                }
                else
                {
                    free(label);
                }
                int result = WeeklySchedule.updateWeeklySchedule(doctorID, row, col, label.Text);
                if (result == 0)
                {
                    MessageBox.Show("Update not successful");
                }
            }
            else
            {
                if (label.Text != "BUSY")
                {
                    dialogResult = MessageBox.Show("Do you want to set schedule?", "Question", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        label.BackColor = Color.SkyBlue;
                    }
                }
            }
                
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if(patientHome != null && dialogResult==DialogResult.Yes)
            {
                try
                {
                    patientHome.AppointmentSchedule = this.schedule();
                    string period = String.Format("Day: {0};    Time: {1}", schedule()["day"], schedule()["time"]);
                    int appointSetResult = patientHome.Patient.setAppointment(doctorID,period);
                    if(appointSetResult > 0)
                    {

                        label.Text = "BUSY";
                        int result = WeeklySchedule.updateWeeklySchedule(doctorID, row, col, label.Text);
                        if (result == 0)
                        {
                            MessageBox.Show("Update not successful");
                        }
                        else
                        {
                            MessageBox.Show("Appointment successful");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Appointment could not be set.");
                    }
                }
                catch (Exception exp)
                {

                    throw new Exception(exp.Message);
                }
            }
            this.Close();
        }

        private void busy(Label label)
        {
            label.Text = "BUSY";
            label.BackColor = Color.Red;
            toolTip.SetToolTip(label, "Scheduled");
        }
        private void free(Label label)
        {
            label.Text = "FREE";
            label.BackColor = Color.Turquoise;
            toolTip.SetToolTip(label, "Click to Change Schedule");
        }

        public  Dictionary<string,string> schedule()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("day", ""+(WeeklySchedule.WeekDays)col);
            dict.Add("time", WeeklySchedule.times[row - 1]);
            dict.Add("doctorID", doctorID.ToString());
            dict.Add("patientID", patientHome.PatientID.ToString());
            return dict;
        }
    }
}
