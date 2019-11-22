using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public  class DoctorPatient
    {
        private int dPID;

        public DoctorPatient()
        {
            this.dPID = AutoIncrementValue.authID("DPID","DP");
        }

        public int DPID { get => dPID; }

        public static bool recordExist(int pID,int dID)
        {
            string query = string.Format(DBQueries.QdPrecordExist,pID,dID);
            DataAccess db = new DataAccess();
            try
            {
                DataTable dt = db.ExecuteQuery(query);
                return (dt.Rows.Count != 0);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static int insertDoctorPatient(int pID,int dID)
        {
            DoctorPatient doctorPatient = new DoctorPatient();
            string query = string.Format(DBQueries.QinsertDoctorPatient,doctorPatient.DPID, pID, dID);
            DataAccess db = new DataAccess();
            try
            {
                if (recordExist(pID, dID))
                    return -1;
                return db.ExecuteNonQuery(query);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
