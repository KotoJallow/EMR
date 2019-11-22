using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AutoIncrementValue
    {
        public static int authID(string authIncID, string tableName)
        {
            try
            {
                string query = string.Format(DBQueries.QauthID, authIncID, tableName);
                DataAccess da = new DataAccess();
                DataTable dt = da.ExecuteQuery(query);
                int val = 0;
                Int32.TryParse(dt.Rows[0][0].ToString(), out val);
                return (val + 1);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
