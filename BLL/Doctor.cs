using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;

namespace BLL
{
    public class Doctor : User<Doctor>
    {
        private int doctorID;
        private string specialisation;

        public Doctor()
        {

        }

        public Doctor(string username, string password, string firstName, string middleName, string lastName, string gender, string phoneNumber, Permission.perm permission, uType.userTypes userType,string specialisation)
            : base(username,password ,firstName, middleName, lastName, gender,phoneNumber,permission,userType)
        {
            this.doctorID = AutoIncrementValue.authID("doctorID", "doctor");
            this.specialisation = specialisation;
            this.setType(uType.userTypes.DOCTOR);
            this.setPermission(Permission.perm.WRITE);
        }

        public int DoctorID { get => doctorID; set => doctorID = value; }//allow setter to enable setting it and not access AuthIncrement Data all the time
        public string Specialisation { get => specialisation; set => specialisation = value; }

        public override bool login(string username, string password)
        {
            string query = string.Format(DBQueries.Qlogin,username);
            DataAccess db = new DataAccess();
            try
            {
                DataTable dt = db.ExecuteQuery(query);
                return SecureData.password_verify(password, dt.Rows[0]["password"].ToString());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public DataTable listPatients()
        {
            string query = string.Format(DBQueries.QlistPatientsDoctor, this.DoctorID);
            DataAccess db = new DataAccess();
            try
            {
                return db.ExecuteQuery(query);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int createMedicalRecord(int diagnosisID,int patientID,string details)
        {
            if (this.permission.PermissionType < Permission.perm.WRITE)
            {
                return -1;
            }
            Prescription prescription = new Prescription();
            prescription.Details = details;
            prescription.PrescriptionType = Prescription.PrescriptionTypes.APPOINTMENT;
            try
            {
                DataAccess db = new DataAccess();
                string query = string.Format(DBQueries.QcreateMedicalAdvice,diagnosisID ,prescription.PrescriptionID,
                    (int)prescription.PrescriptionType,prescription.Details);

                return db.ExecuteNonQuery(query);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public DataTable queryMedicalRecords()
        {
            string query = string.Format(DBQueries.QqueryMedicalRecordsDoctor,this.DoctorID
                );
            DataAccess db = new DataAccess();
            try
            {
                return db.ExecuteQuery(query);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int createMedicalAdvice(int diagnosisID, int patientID, string details)
        {
            if (this.permission.PermissionType < Permission.perm.WRITE)
            {
                return -1;
            }


            Prescription prescription = new Prescription();
            prescription.Details = details;
            prescription.PrescriptionType = Prescription.PrescriptionTypes.ADVICE;
            try
            {
                DataAccess db = new DataAccess();
                string query = string.Format("BEGIN TRANSACTION;" +
                    "insert into prescription values({0},{1},{2},'{3}');" +
                    "COMMIT;", diagnosisID, prescription.PrescriptionID,
                    (int)prescription.PrescriptionType, prescription.Details);

                return db.ExecuteNonQuery(query);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int manageAccount()
        {

            DataAccess db = new DataAccess();
            try
            {
                if (userExist("login", "username",this.Username))
                {
                    return -1;
                }

                string query = string.Format(DBQueries.QmanageAccountDoctor, this.Username, this.Password, this.LoginID,
                this.FirstName, this.MiddleName, this.LastName, this.Gender, this.PhoneNumber,
                this.Permission.PermissionType,this.UserID,
                this.UserID,this.Specialisation,this.DoctorID);

                return db.ExecuteNonQuery(query);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public DataTable viewAppointments()
        {
            try
            {

                DataAccess db = new DataAccess();
                string query = string.Format(DBQueries.QviewAppointmentsDoctor, this.DoctorID
                    );

                return db.ExecuteQuery(query);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public DataTable setWeeklySchedule()
        {
            return null;
        }

        public override Doctor getUser(int userID)
        {
            string query = string.Format(DBQueries.QgetUserDoctor,userID);
            DataAccess db = new DataAccess();
            try
            {
                DataTable result =  db.ExecuteQuery(query);
                Doctor doctor = new Doctor(
                    result.Rows[0]["username"].ToString(),
                    result.Rows[0]["password"].ToString(),
                    result.Rows[0]["firstName"].ToString(),
                    result.Rows[0]["middleName"].ToString(),
                    result.Rows[0]["lastName"].ToString(),
                    result.Rows[0]["gender"].ToString(),
                    result.Rows[0]["PhoneNumber"].ToString(),
                    (Permission.perm)Convert.ToInt32(result.Rows[0]["userPerm"]),
                    (uType.userTypes)Convert.ToInt32(result.Rows[0]["userType"]),
                    result.Rows[0]["specialisation"].ToString()
                    );
                doctor.DoctorID = Convert.ToInt32(result.Rows[0]["doctorID"]);//set doctorID to avoid access authIncrement Index value;
                return doctor;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
