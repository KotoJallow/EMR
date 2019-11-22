using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;

namespace BLL
{
    public abstract class User<T> : Login
    {
        private int userID;
        protected string firstName;
        protected string middleName;
        protected string lastName;
        protected string gender;
        protected string phoneNumber;
        /**#protected string username; //email basically**/
        protected Permission permission = new Permission();
        protected uType userType = new uType();

        public User()
        {

        }

        protected User(string username, string password,string firstName, string middleName, 
            string lastName, string gender,string phoneNumber, /*string username,*/ 
            Permission.perm permission, uType.userTypes userType)
            :base(username,password)
        {
            this.userID = AutoIncrementValue.authID("userID", "user");
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.gender = gender;
            this.phoneNumber = phoneNumber;
            /**#this.username = username;**/
            this.permission.PermissionType = permission;
            this.userType.UserType = userType;
        }

        //Getters and setters definition and abstract methods
        #region
        public int UserID { get => userID; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string MiddleName { get => middleName; set => middleName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Gender { get => gender; set => gender = value; }
        /**public string Username { get => username; set => username = value; }**/
        public Permission Permission { get => permission;} //only admin sets once
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public uType UserType { get => userType;} //only admin sets once

        public abstract bool login(string username, string password);
        public abstract T getUser(int userID);
        #endregion

        public void setType(uType.userTypes userType)
        {
            this.userType.UserType = userType;
        }

        public void setPermission(Permission.perm permission)
        {
            this.permission.PermissionType = permission;
        }

        public static bool userExist(string tableName,string columnName,string data)
        {
            string query = string.Format(DBQueries.QuserExist,columnName,tableName,columnName,data);
            DataAccess db = new DataAccess();
            try
            {
                DataTable dt = db.ExecuteQuery(query);
                return (dt.Rows.Count != 0);
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /*
         
         
            public int modifyMedicalAdvice(int diagnosisID,string pSymptoms)
            {
                if (this.permission.PermissionType < Permission.perm.WRITE)
                {
                    return -1;
                }

                try
                {
                    DataAccess db = new DataAccess();
                    string query = string.Format("BEGIN TRANSACTION;" +
                        "update NTBDiagnosis as ntb set patientSymptoms = {0} " +
                        "where ntb.diagnosisID = {1} ;" +
                        "COMMIT;", pSymptoms,diagnosisID
                        );

                    return db.ExecuteNonQuery(query);

                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
         
         
         */

    }
}
