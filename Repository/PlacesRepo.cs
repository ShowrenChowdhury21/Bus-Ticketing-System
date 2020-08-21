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
    public class PlacesRepo : IPlacesRepo
    {

        DatabaseConnectionClass dcc;

        public PlacesRepo() { dcc = new DatabaseConnectionClass(); }

        public bool InsertPlaces(Places p)
        {
            string query = "INSERT into Places VALUES('" + p.From + "', '" + p.To + "')";
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

        public bool DeletePlaces(Places p)
        {
            string query = "DELETE Places WHERE wherefrom = '" + p.From + "'";
            try
            {
                dcc.ConnectWithDB();
                dcc.ExecuteSQL(query);
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
            finally
            {
                dcc.CloseConnection();
            }
        }
        /*public bool UpdatePlaces(Places p)
        {
            string query = "UPDATE Places SET  = '" + emp.Name + "', phonenumber = '" + emp.PhnNumber + "', salary = " + emp.Salary + ", designation = '" + emp.Designation + "' WHERE id = '" + emp.Id + "'";
            try
            {
                dcc.ConnectWithDB();
                dcc.ExecuteSQL(query);
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
            finally
            {
                dcc.CloseConnection();
            }
        }*/
        public List<Places> GetAllPlaces()
        {
            List<Places> listOfPlaces = new List<Places>();
            string query = "SELECT * FROM Places";
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Places p = new Places();

                p.From = sdr["wherefrom"].ToString();
                p.To = sdr["whereto"].ToString();

                listOfPlaces.Add(p);
            }
            dcc.CloseConnection();

            return listOfPlaces;
        }
    }
}
