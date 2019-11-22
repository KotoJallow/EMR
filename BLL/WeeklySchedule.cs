using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class WeeklySchedule
    {
       
        public enum WeekDays
        {
            Monday=1,Tuesday,Wednesday,Thursday,Friday
        }
        public enum Status
        {
            Free,Busy
        }

        public static string[] times = {
            "`08:30-09:30`","`09:30-10:30`","`10:30-11:30`","`11:30-12:30`",
            "`12:30-13:30`","`13:30-14:30`","`14:30-15:30`","`15:30-16:30`",
            "`16:30-17:30`"
        };

        public static DataTable getWeeklySchedule(int doctorID)
        {
            
            try
            {
                int start = 5 * doctorID - 4;
                int end = start + 4;
                string query = string.Format(DBQueries.QgetWeeklySchedule, start, end);
                DataAccess da = new DataAccess();
                return da.ExecuteQuery(query);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static int updateWeeklySchedule(int doctorID,int row,int col,string status)
        {
            try
            {
                int start = 5 * doctorID - 4;
                col += start;  
                string query = string.Format(DBQueries.QUpdateWeeklySchedule, times[row-1], status, col-1);
                DataAccess da = new DataAccess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static int setDefaultWeeklySchedule(int doctorID)
        {
            try
            {
                int start = 5 * doctorID - 4;
                
                string query = string.Format(DBQueries.QsetDefaultWeeklySchedule,"FREE",start,start+1,start+2,start+3,start+4);
                DataAccess da = new DataAccess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //Admin will delete the weekly schedule;

    }
}
