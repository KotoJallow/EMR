using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;

namespace BLL
{
    public class Patient : User<Patient>
    {
        private int patientID;
        string bloodGroup;
        int age; //Be Carefull
        double weight;
        double height;
        DateTime DOB;
        string address;
        string nextOfKin;
        string numNextOfKin;

        public Patient()
        {

        }

        public Patient(string username, string password, string firstName, string middleName, string lastName, string gender, string phoneNumber,Permission.perm permission, uType.userTypes userType, string bloodGroup, int age, double weight, double height, DateTime dOB, string address, string nextOfKin, string numNextOfKin)
            :base(username,password, firstName,middleName,lastName,gender,phoneNumber,permission,userType)
        {
            this.patientID = AutoIncrementValue.authID("patientID", "patient");
            this.bloodGroup = bloodGroup;
            this.age = age;
            this.weight = weight;
            this.height = height;
            DOB = dOB;
            this.address = address;
            this.nextOfKin = nextOfKin;
            this.numNextOfKin = numNextOfKin;
            this.setType(uType.userTypes.PATIENT);
            this.setPermission(Permission.perm.READ);
        }

        #region
        public int PatientID { get => patientID; set => patientID = value; }
        public string BloodGroup { get => bloodGroup; set => bloodGroup = value; }
        public int Age { get => age; set => age = value; }
        public double Weight { get => weight; set => weight = value; }
        public double Height { get => height; set => height = value; }
        public DateTime DOB1 { get => DOB; set => DOB = value; }
        public string Address { get => address; set => address = value; }
        public string NextOfKin { get => nextOfKin; set => nextOfKin = value; }
        public string NumNextOfKin { get => numNextOfKin; set => numNextOfKin = value; }

        public override bool login(string username, string password)
        {
            string query = string.Format(DBQueries.Qlogin, username);
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
        #endregion

        public override Patient getUser(int userID)
        {
            string query = string.Format(DBQueries.QgetUserPatient,userID);
            DataAccess db = new DataAccess();
            try
            {
                DataTable result = db.ExecuteQuery(query);
                Patient patient = new Patient(
                    result.Rows[0]["username"].ToString(),
                    result.Rows[0]["password"].ToString(),
                    result.Rows[0]["firstName"].ToString(),
                    result.Rows[0]["middleName"].ToString(),
                    result.Rows[0]["lastName"].ToString(),
                    result.Rows[0]["gender"].ToString(),
                    result.Rows[0]["PhoneNumber"].ToString(),
                    (Permission.perm)Convert.ToInt32(result.Rows[0]["userPerm"]),
                    (uType.userTypes)Convert.ToInt32(result.Rows[0]["userType"]),
                    result.Rows[0]["bloodGroup"].ToString(),
                    AppFunctions.getAge(result.Rows[0]["DOB"].ToString()),
                    Convert.ToDouble(result.Rows[0]["weight"].ToString()),
                    Convert.ToDouble(result.Rows[0]["height"].ToString()),
                    DateTime.Parse(result.Rows[0]["DOB"].ToString()),
                    result.Rows[0]["address"].ToString(),
                    result.Rows[0]["nextOfKin"].ToString(),
                    result.Rows[0]["numNextOfKin"].ToString()
                    );
                patient.PatientID = Convert.ToInt32(result.Rows[0]["patientID"]);//set patientID to avoid access authIncrement Index value;
                return patient;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public DataTable listDoctors()
        {
            string query = string.Format(DBQueries.QlistDoctorsPatient, this.PatientID);
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

        public int setAppointment(int doctorID,string period)
        {
            try
            {
                Appointment app = new Appointment();
                app.Period = period;
                DataAccess db = new DataAccess();
                string query = string.Format(DBQueries.QsetAppointmentPatient,app.AppointmentID,this.PatientID,doctorID,app.Period);

                return db.ExecuteNonQuery(query);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }

        public DataTable queryMedicalRecords()
        {
            string query = string.Format(DBQueries.QqueryMedicalRecordsPatient,this.PatientID
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

        public int printMedicalRecords()
        {
            return 1;
        }

        public int askMedicalAdvice(int doctorID)
        {
           
            NTBDiagnosis d = new NTBDiagnosis();

            try
            {
                DataAccess db = new DataAccess();
                string query = string.Format(DBQueries.QaskMedicalAdvice, d.DiagnosisID, this.PatientID, doctorID,
                    d.NTBDiagnosisID, d.DiagnosisID, d.PatientSymptoms
                    );

                return db.ExecuteNonQuery(query);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        
        public DataTable queryMedicalAdvice()
        {
            string query = string.Format(DBQueries.QqueryMedicalAdvice, this.PatientID
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

        public int printMedicalAdvice()
        {
            return 1;
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
                this.Password = SecureData.password_hash(this.Password);//password modified too
                string query = string.Format(DBQueries.QmanageAccountPatient, this.Username, this.Password, this.LoginID,
                this.FirstName, this.MiddleName, this.LastName, this.Gender, this.PhoneNumber, this.Permission.PermissionType,
                this.Weight, this.Height, this.Address, this.NextOfKin, this.NumNextOfKin, this.UserID);

                return db.ExecuteNonQuery(query);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool sendReminders(string receiver,string subject,string message)
        {
            try
            {
                return Mailer.sendMail(receiver,subject,message);
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public DataTable viewAppointments()
        {
            try
            {
                
                DataAccess db = new DataAccess();
                string query = string.Format(DBQueries.QviewAppointmentsPatient,this.patientID
                    );

                return db.ExecuteQuery(query);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        
    }
}
