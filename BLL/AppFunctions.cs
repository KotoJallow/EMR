using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AppFunctions
    {
        //returns user id or type
        public static int getUserIDorType(string columnName,string username)
        {

            try
            {
                string query = string.Format(DBQueries.QgetUserIDorType,columnName,username);
                DataAccess da = new DataAccess();
                DataTable dt = da.ExecuteQuery(query);
            
                return Int32.Parse(dt.Rows[0][columnName].ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static int getAge(string DOB)
        {
            DateTime dateTime = Convert.ToDateTime(DOB);
            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;
            int currentDay = DateTime.Now.Day;
            int age = currentYear - dateTime.Year;
            if (currentMonth > dateTime.Month)
            {
                return age;
            }
            else if (currentMonth == dateTime.Month)
            {
                if (currentDay < dateTime.Day)
                {
                    return (age - 1);
                }
                else
                {
                    return age;
                }
            }
            else
            {
                return (age - 1);
            }
        }

        //takes user id because property userID returns Auto Increment Value
        public  static int  updateUser(Admin admin,int userID)
        {
            try
            {
                string query = string.Format(DBQueries.Qupdateuser,admin.FirstName,admin.MiddleName,admin.LastName,admin.PhoneNumber,userID);
                DataAccess da = new DataAccess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DataTable getUserTable(int userID)
        {
            try
            {
                string query = string.Format(DBQueries.QgetUser, userID);
                DataAccess da = new DataAccess();
                return da.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Admin getUser(DataTable dataTable)
        {
            try
            {
                Admin admin = new Admin();
                DataRow dataRow = dataTable.Rows[0];
                admin.Username = dataRow["userName"].ToString();
                admin.FirstName = dataRow["firstName"].ToString();
                admin.LastName = dataRow["lastName"].ToString();
                admin.MiddleName = dataRow["middleName"].ToString();
                admin.PhoneNumber = dataRow["phoneNumber"].ToString();
                admin.Gender = dataRow["gender"].ToString();
                admin.setPermission((Permission.perm)int.Parse(dataRow["userPerm"].ToString()));
                return admin;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string getDMSTransactionInitial
        {
            get => (DataAccess.DMS == DataAccess.DMS_.SQLITE) ? "BEGIN" : "START";
        }
    }
}
