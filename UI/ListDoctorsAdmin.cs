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
    public partial class ListDoctorsAdmin : UserControl
    {
        private DataTable dataTable;
        public ListDoctorsAdmin(DataTable dataTable = null)
        {
            InitializeComponent();
            if (dataTable == null)
            {
                this.dataTable = Admin.listDoctors();
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


        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int doctorID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["uID"].Value.ToString());
                DataTable doctorDataTable = Admin.queryDoctorInfo(doctorID);
                UpdateDoctorAdmin updateDoctorAdmin = new UpdateDoctorAdmin(doctorDataTable, this);
                updateDoctorAdmin.ShowDialog();
            }
            else
            {
                MessageBox.Show("A row should be selected.");
            }
        }

        private void ListDoctorsAdmin_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dataTable;
        }

        public void updateGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = Admin.listDoctors();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int doctorID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["uID"].Value.ToString());
                int loginID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["uLoginID"].Value.ToString());
                DialogResult dialogResult = MessageBox.Show("Do you want to delete doctor?", "Warning", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    int result = Admin.deleteDoctorAccount(loginID, doctorID);
                    if (result > 0)
                    {
                        this.updateGridView(); //refresh the admin list
                        MessageBox.Show("Deleted Successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Error in deleting doctor.");
                    }
                }
            }
            else
            {
                MessageBox.Show("A row should be selected.");
            }
        }
    }
}
