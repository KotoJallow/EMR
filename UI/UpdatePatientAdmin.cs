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
    public partial class UpdatePatientAdmin : Form
    {
        DataTable dataTable;//I believe it is easier to get all the data and then create a patient object here.
        ListPatientsAdmin listPatientsAdmin; // to refresh the datagridview in this usercontrol
        Patient patient;
        DataRow dataRow;

        public UpdatePatientAdmin(DataTable dataTable, ListPatientsAdmin listPatientsAdmin)
        {
            InitializeComponent();
            this.dataTable = dataTable;
            this.listPatientsAdmin = listPatientsAdmin;
            patient = Admin.getPatient(dataTable);
            dataRow = dataTable.Rows[0];
        }

        private void UpdatePatientAdmin_Load(object sender, EventArgs e)
        {
            //initialise usercontrol and other componennts
            addUserPatient.Username = patient.Username;
            addUserPatient.Lastname = patient.LastName;
            addUserPatient.Firstname = patient.FirstName;
            addUserPatient.Middlename = patient.MiddleName;
            addUserPatient.Gender = patient.Gender;
            addUserPatient.PhoneNumber = patient.PhoneNumber;

            addUserPatient.ComboxBoxUserTypeEnable = false;
            addUserPatient.ComboxBoxUserTypeSelectedIndex = int.Parse(dataRow["userType"].ToString());
            addUserPatient.ComboxBoxUserPermSelectedIndex = int.Parse(dataRow["userPerm"].ToString());
            txtID.Text = dataRow["patientID"].ToString();
            dtpDOB.Text = patient.DOB1.ToString("yyyy-MM-dd");
            txtWeight.Text = patient.Weight.ToString();
            txtHeight.Text = patient.Height.ToString();
            txtNextOfKin.Text = patient.NextOfKin;
            txtNextOfKinNum.Text = patient.NumNextOfKin;
            txtBloodGroup.Text = patient.BloodGroup;
            rtbAddress.Text = patient.Address;

            addUserPatient.TextBoxGenderEnable = false;
            //hide password textBox and label
            addUserPatient.TextBoxPasswordVisibility = false;
            addUserPatient.LabelPasswordVisibility = false;
            //hide username textBox and label
            addUserPatient.TextBoxUsernameVisibility = false;
            addUserPatient.LabelUsernameVisibility = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //int doctorID = int.Parse(dataRow["doctorID"].ToString());
            int loginID = int.Parse(dataRow["loginID"].ToString());

            //SET NEW VALUES;
            patient.Username = addUserPatient.Username;
            patient.FirstName = addUserPatient.Firstname;
            patient.MiddleName = addUserPatient.Middlename;
            patient.LastName = addUserPatient.Lastname;
            patient.PhoneNumber = addUserPatient.PhoneNumber;
            patient.setPermission((Permission.perm)addUserPatient.ComboxBoxUserPermSelectedIndex);
            patient.DOB1 = DateTime.Parse(dtpDOB.Text);
            patient.Weight = Convert.ToDouble(txtWeight.Text);
            patient.Height = Convert.ToDouble(txtHeight.Text);
            patient.NextOfKin = txtNextOfKin.Text;
            patient.NumNextOfKin = txtNextOfKinNum.Text;
            patient.BloodGroup = txtBloodGroup.Text;
            patient.Address = rtbAddress.Text;
            //END

            int result = Admin.modifyPatientAccount(patient, loginID);
            if (result > 0)
            {
                MessageBox.Show("Patient successfully Updated");
                listPatientsAdmin.updateGridView();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error in update patient");
            }
        }
    }
    
}
