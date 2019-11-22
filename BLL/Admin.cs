using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Admin : User<Admin>
    {
        private int adminID;

        public Admin()
        {

        }

        public Admin(string username, string password, string firstName, string middleName, string lastName, string gender, string phoneNumber,Permission.perm permission, uType.userTypes userType)
            : base(username,password,firstName, middleName, lastName, gender,phoneNumber,permission,userType)
        {
            this.adminID = AutoIncrementValue.authID("adminID", "admin");
            this.setType(uType.userTypes.ADMIN);
        }

        public int AdminID { get => adminID; set => adminID = value; }

        public override bool login(string username, string password)
        {
            string query = string.Format(DBQueries.Qlogin, username);
            DataAccess db = new DataAccess();
            try
            {
                DataTable dt = db.ExecuteQuery(query);
                return SecureData.password_verify(password,dt.Rows[0]["password"].ToString());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static DataTable listDoctors()
        {
            string query = string.Format(DBQueries.QlistDoctorsAdmin);
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

        public int addDoctorAccount(Doctor d)
        {
            
            DataAccess db = new DataAccess();
            try
            {
                if (userExist("login","username",d.Username))
                {
                    return -1;
                }
                d.Password = SecureData.password_hash(d.Password);
                string query = string.Format(DBQueries.QaddDoctorAccount, d.LoginID,d.Username,d.Password,
                d.UserID,d.FirstName,d.MiddleName,d.LastName,d.Gender,d.PhoneNumber,d.LoginID,
                (int)d.Permission.PermissionType,(int)d.UserType.UserType,
                d.DoctorID,d.UserID,d.Specialisation
                );

                return db.ExecuteNonQuery(query);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static int deleteDoctorAccount(int loginID,int doctorID)
        {

            DataAccess db = new DataAccess();
            try
            {

                int start = 5 * doctorID - 4;
                int end = start + 4;
                //userId and loginID are the same
                string query = string.Format(DBQueries.QdeleteDoctorAccount,loginID,loginID,doctorID,start,end);

                return db.ExecuteNonQuery(query);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static int modifyDoctorAccount(Doctor d,int loginID)
        {

            DataAccess db = new DataAccess();
            try
            {
                /*d.Password = SecureData.password_hash(d.Password)*//*;NO NEED*///the password too is changed
                string query = string.Format(DBQueries.QmodifyDoctorAccount, d.Username, d.Password,loginID,
                d.FirstName,d.MiddleName,d.LastName,d.Gender,d.PhoneNumber,
                (int)d.Permission.PermissionType,
                loginID, d.Specialisation,loginID);

                return db.ExecuteNonQuery(query);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static Doctor getDoctor(DataTable dataTable)
        {
            DataRow dataRow = dataTable.Rows[0];
            Doctor doctor = new Doctor(
                dataRow["username"].ToString(), dataRow["password"].ToString(), dataRow["firstName"].ToString(), dataRow["middleName"].ToString(), 
                dataRow["lastName"].ToString(), dataRow["gender"].ToString(), dataRow["phoneNumber"].ToString(),
                (Permission.perm)int.Parse(dataRow["userPerm"].ToString()),(uType.userTypes)int.Parse(dataRow["userType"].ToString()),
                dataRow["specialisation"].ToString()
                );
            return doctor;
        }
        
        public static DataTable listPatients()
        {
            string query = string.Format(DBQueries.QlistPatientsAdmin);
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

        public int addPatientAccount(Patient p)
        {

            DataAccess db = new DataAccess();
            try
            {
                if (userExist("login", "username",p.Username))
                {
                    return -1;
                }
                p.Password = SecureData.password_hash(p.Password);
                string query = string.Format(DBQueries.QaddPatientAccount, p.LoginID, p.Username, p.Password,
                p.UserID, p.FirstName, p.MiddleName, p.LastName, p.Gender, p.PhoneNumber,
                p.LoginID, (int)p.Permission.PermissionType, (int)p.UserType.UserType,
                p.PatientID, p.UserID, p.BloodGroup,p.Weight,p.Height,p.DOB1.ToString("yyyy-MM-dd"),p.Address,
                p.NextOfKin,p.NumNextOfKin
                );

                return db.ExecuteNonQuery(query);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static int deletePatientAccount(int loginID,int patientID)
        {

            DataAccess db = new DataAccess();
            try
            {
                string query = string.Format(DBQueries.QdeletePatientAccount, loginID, loginID, patientID);

                return db.ExecuteNonQuery(query);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static int modifyPatientAccount(Patient p,int loginID)
        {

            DataAccess db = new DataAccess();
            try
            {
                /*p.Password = SecureData.password_hash(p.Password)*//*;NO NEED*///password modified too
                string query = string.Format(DBQueries.QmodifyPatientAccount,p.Username,p.Password,loginID,/*Login not updated irrelevant as of now*/
                p.FirstName,p.MiddleName,p.LastName,p.Gender,p.PhoneNumber,
                (int)p.Permission.PermissionType,loginID,
                p.Weight,p.Height,p.Address,p.NextOfKin,p.NumNextOfKin,loginID);

                return db.ExecuteNonQuery(query);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public static Patient getPatient(DataTable dataTable)
        {
            DataRow dataRow = dataTable.Rows[0];
            Patient patient = new Patient(
                dataRow["username"].ToString(), dataRow["password"].ToString(), dataRow["firstName"].ToString(), dataRow["middleName"].ToString(),
                dataRow["lastName"].ToString(), dataRow["gender"].ToString(), dataRow["phoneNumber"].ToString(),
                (Permission.perm)int.Parse(dataRow["userPerm"].ToString()), (uType.userTypes)int.Parse(dataRow["userType"].ToString()),
                dataRow["bloodGroup"].ToString(), AppFunctions.getAge(dataRow["DOB"].ToString()),
                Convert.ToDouble(dataRow["weight"].ToString()),Convert.ToDouble(dataRow["height"].ToString()),DateTime.Parse(dataRow["DOB"].ToString()),
                dataRow["address"].ToString(),dataRow["nextOfKin"].ToString(), dataRow["numNextOfKin"].ToString()
                );
            return patient;
        }

        public int addAdmin(Admin a)
        {
            if(this.permission.PermissionType != Permission.perm.ALL)
            {
                return -2;
            }

            DataAccess db = new DataAccess();
            try
            {
                if (userExist("login", "username",a.Username))
                {
                    return -1;
                }
                a.Password = SecureData.password_hash(a.Password);
                string query = string.Format(DBQueries.QaddAdmin, a.LoginID, a.Username, a.Password,
                a.UserID, a.FirstName, a.MiddleName, a.LastName, a.Gender, a.PhoneNumber,
                a.LoginID, (int)a.Permission.PermissionType, (int)a.UserType.UserType,
                a.AdminID, a.UserID
                );

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
                this.Password = SecureData.password_hash(this.Password);//password may be changed too
                string query = string.Format(DBQueries.QmanageAccountAdmin, this.Username, this.Password, this.LoginID,
                this.FirstName, this.MiddleName, this.LastName, this.Gender, this.PhoneNumber,
                (int)this.Permission.PermissionType,this.UserID);

                return db.ExecuteNonQuery(query);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public  int authorisationManagement(int userID,Permission.perm perm)
        {
            if (this.permission.PermissionType != Permission.perm.ALL)
            {
                return -2;
            }

            try
            {
                DataAccess db = new DataAccess();
                string query = string.Format(DBQueries.QauthorisationManagement,(int)perm,userID);

                return db.ExecuteNonQuery(query);

            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //super useful it help in modifying patient easily via datatable
        public static DataTable queryDoctorInfo(int doctorID)
        {
            string query = string.Format(DBQueries.QqueryDoctorInfo,doctorID);
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

        //super useful it help in modifying patient easily via datatable
        public static DataTable queryPatientInfo(int patientID)
        {
            string query = string.Format(DBQueries.QqueryPatientInfo,patientID
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

        public override Admin getUser(int userID)
        {
            string query = string.Format(DBQueries.QgetUserAdmin, userID
             );
            DataAccess db = new DataAccess();
            try
            {
                DataTable result = db.ExecuteQuery(query);
                Admin admin = new Admin(
                    result.Rows[0]["username"].ToString(),
                    result.Rows[0]["password"].ToString(),
                    result.Rows[0]["firstName"].ToString(),
                    result.Rows[0]["middleName"].ToString(),
                    result.Rows[0]["lastName"].ToString(),
                    result.Rows[0]["gender"].ToString(),
                    result.Rows[0]["PhoneNumber"].ToString(),
                    (Permission.perm)Convert.ToInt32(result.Rows[0]["userPerm"]),
                    (uType.userTypes)Convert.ToInt32(result.Rows[0]["userType"])
                    );
                admin.AdminID = Convert.ToInt32(result.Rows[0]["adminID"]);//set adminID to avoid access authIncrement Index value;
                return admin;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static  DataTable listUsers()
        {
            string query = string.Format(DBQueries.QlistUsersAdmin);
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
    }
}
