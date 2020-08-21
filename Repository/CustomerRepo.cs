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
    public class CustomerRepo
    {
        DatabaseConnectionClass dcc;


        public CustomerRepo()
        {
            dcc = new DatabaseConnectionClass();

        }



        public bool InsertCustomer(Customer cm)
        {
            string query = "INSERT into customers VALUES('" + cm.Name + "', '" + cm.PhoneNumber + "', '" + cm.From + "', '" + cm.To + "', '" + cm.BusId + "', '" + cm.Date + "', '" + cm.Time + "', '" + cm.Type + "','" + cm.SeatNumber + "', "+ cm.Fare +")";
            try
            {

                dcc.ConnectWithDB();
                dcc.ExecuteSQL(query);
                return true;
            }
            catch (Exception exp)
            {
                //throw;
                return false;
            }
            finally
            {
                dcc.CloseConnection();
            }
        }

        public bool DeleteCustomer(Customer cm)
        {
            string query = "DELETE FROM customers WHERE name = '" + cm.Name + "' AND phonenumber = "+cm.PhoneNumber+"";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);
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

        public Customer GetCustomer(string name, string phoneNumber)
        {
            Customer cm = null;
            string query = "SELECT * FROM customers WHERE name = '" + cm.Name + "', phonenumber = '"+cm.PhoneNumber+"'";
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                cm = new Customer();

                cm.Name = sdr["name"].ToString();
                cm.PhoneNumber = sdr["phonenumber"].ToString();
            }

            dcc.CloseConnection();

            return cm;
        }

        public List<Customer> GetAllCustomer()
        {
            List<Customer> listOfCustomer = new List<Customer>();
            string query = "SELECT * FROM customers";
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Customer cm = new Customer();

                cm.Name = sdr["name"].ToString();
                cm.PhoneNumber = sdr["phonenumber"].ToString(); ;
                cm.From = sdr["wherefrom"].ToString();
                cm.To = sdr["whereto"].ToString();
                cm.BusId = sdr["busid"].ToString();
                cm.Date = sdr["date"].ToString();
                cm.Time = sdr["time"].ToString();
                cm.Type = sdr["type"].ToString();            
                cm.SeatNumber = sdr["seatnumber"].ToString();
                cm.Fare = Convert.ToInt32(sdr["fare"]);


                listOfCustomer.Add(cm);
            }

            dcc.CloseConnection();

            return listOfCustomer;
        }

 
    }
}
