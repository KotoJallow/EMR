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
    public partial class UpdateDoctorAdmin : Form
    {
        DataTable dataTable;//I believe it is easier to get all the data and then create a patient object here.
        ListDoctorsAdmin listDoctorsAdmin; // to refresh the datagridview in this usercontrol
        Doctor doctor;
        DataRow dataRow;
        public UpdateDoctorAdmin(DataTable dataTable, ListDoctorsAdmin listDoctorsAdmin)
        {
            InitializeComponent();
            this.dataTable = dataTable;
            this.listDoctorsAdmin = listDoctorsAdmin;
            doctor = Admin.getDoctor(dataTable);
            dataRow = dataTable.Rows[0];
        }

        private void UpdateDoctorAdmin_Load(object sender, EventArgs e)
        {
            //initialise usercontrol and other componennts
            addUserDoctor.Username = doctor.Username;
            addUserDoctor.Lastname = doctor.LastName;
            addUserDoctor.Firstname = doctor.FirstName;
            addUserDoctor.Middlename = doctor.MiddleName;
            addUserDoctor.Gender = doctor.Gender;
            addUserDoctor.PhoneNumber = doctor.PhoneNumber;
            txtSpecialisation.Text = doctor.Specialisation;

            addUserDoctor.ComboxBoxUserTypeEnable = false;
            addUserDoctor.ComboxBoxUserTypeSelectedIndex = int.Parse(dataRow["userType"].ToString());
            addUserDoctor.ComboxBoxUserPermSelectedIndex = int.Parse(dataRow["userPerm"].ToString());
            txtID.Text = dataRow["doctorID"].ToString();

            addUserDoctor.TextBoxGenderEnable = false;
            //hide password textBox and label
            addUserDoctor.TextBoxPasswordVisibility = false;
            addUserDoctor.LabelPasswordVisibility = false;
            //hide username textBox and label
            addUserDoctor.TextBoxUsernameVisibility = false;
            addUserDoctor.LabelUsernameVisibility = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int doctorID = int.Parse(dataRow["doctorID"].ToString());
            int loginID = int.Parse(dataRow["loginID"].ToString());

            //SET NEW VALUES;
            doctor.Username = addUserDoctor.Username;
            doctor.FirstName = addUserDoctor.Firstname;
            doctor.MiddleName = addUserDoctor.Middlename;
            doctor.LastName = addUserDoctor.Lastname;
            doctor.PhoneNumber = addUserDoctor.PhoneNumber;
            doctor.setPermission((Permission.perm)addUserDoctor.ComboxBoxUserPermSelectedIndex);
            doctor.Specialisation = txtSpecialisation.Text;
            //END

            int result = Admin.modifyDoctorAccount(doctor,loginID);
            if (result > 0)
            {
                MessageBox.Show("Doctor successfully Updated");
                listDoctorsAdmin.updateGridView();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error in update doctor");
            }
        }
    }
    
}
