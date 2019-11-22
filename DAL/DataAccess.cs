using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SQLite;



namespace DAL
{
    public class DataAccess
    {
        /*GET DATABASE MANAGEMENT SYSTEM*/
        public enum DMS_{
            SQLITE,MYSQL
        }
        public static DMS_  DMS = DMS_.SQLITE;
        /*END DMS*/

        private SQLiteConnection conn;
        private SQLiteCommand cmd;
        
        public DataAccess()
        {
            string connString = @"Data Source = ..\..\..\DAL\DB\emr.db";
            conn = new SQLiteConnection(connString);
            cmd = new SQLiteCommand(conn);
        }
        public DataAccess(string connString)
        {
            conn = new SQLiteConnection(connString);
            cmd = new SQLiteCommand(conn);
        }
        public DataTable ExecuteQuery(string query)
        {
            try
            {
                conn.Open();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;

                SQLiteDataAdapter ad = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);

                return dt;

            }catch(Exception e)
            {
                throw new Exception(e.Message+"Error in EQ");
            }
        }
        public int ExecuteNonQuery(string query)
        {
            try
            {
                conn.Open();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;

                return cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message + "Error in ENQ");
            }
        }
    }
}
