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
    public partial class ListPatientsAdmin : UserControl
    {
        private DataTable dataTable;
        public ListPatientsAdmin(DataTable dataTable = null)
        {
            InitializeComponent();
            if (dataTable == null)
            {
                this.dataTable = Admin.listPatients();
            }
            else
            {
                this.dataTable = dataTable;
            }
            
        }

        public bool ButtonUpdateButton
        {
            set => btnUpdate.Visible = value;
        }

        public bool ButtonDeleteButton
        {
            set => btnDelete.Visible = value;
        }

        private void ListPatientsAdmin_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dataTable;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int patientID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["uID"].Value.ToString());
                int loginID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["uLoginID"].Value.ToString());
                DialogResult dialogResult = MessageBox.Show("Do you want to delete patient?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int result = Admin.deletePatientAccount(loginID, patientID);
                    if (result > 0)
                    {
                        updateGridView(); //refresh the admin list
                        MessageBox.Show("Deleted Successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Error in deleting patient.");
                    }
                }
               
            }
            else
            {
                MessageBox.Show("A row should be selected.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int patientID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["uID"].Value.ToString());
                DataTable doctorDataTable = Admin.queryPatientInfo(patientID);
                UpdatePatientAdmin updatePatientAdmin = new UpdatePatientAdmin(doctorDataTable, this);
                updatePatientAdmin.ShowDialog();
            }
            else
            {
                MessageBox.Show("A row should be selected.");
            }
        }

        public void updateGridView()
        {
            dataGridView1.DataSource = Admin.listPatients();
        }
    }
 }

