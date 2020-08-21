using Entity;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class LoginRepo : ILoginRepo
    {
        DatabaseConnectionClass dcc;

        public LoginRepo() { dcc = new DatabaseConnectionClass(); }

        public bool InsertUser(Login l)
        {

            string query = "INSERT into Logins VALUES('" + l.Id + "', '" + l.Password + "', " + l.Role + ")";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);
                return true;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.StackTrace);
                return false;
            }
            finally
            {
                dcc.CloseConnection();
            }

        }

        public bool DeleteUser(Login l)
        {
            string query = "DELETE from Logins WHERE id = '" + l.Id + "'";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
        }

        public Login GetUser(string id, string password)
        {
            Login l = null;
            string query = "SELECT * from Logins WHERE id = '" + id + "' AND password ='" + password + "'";
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                l = new Login();
                l.Id = sdr["id"].ToString();
                l.Password = sdr["password"].ToString();
                l.Role = Convert.ToInt32(sdr["role"]);
            }
            dcc.CloseConnection();
            return l;
        }

    }
}
