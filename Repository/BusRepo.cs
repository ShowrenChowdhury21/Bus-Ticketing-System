using Entity;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Repository
{
    public class BusRepo : IBusRepo
    {
        DatabaseConnectionClass dcc;

        public BusRepo()
        {
            dcc = new DatabaseConnectionClass();
        }

        public bool InsertBus(Bus b)
        {
            string query = "INSERT into buses VALUES('" + b.BusId + "', '" + b.BusName + "', '" + b.From + "', '" + b.To + "', '" + b.Date + "' ,'" + b.Time + "' , '" + b.Type + "', " + b.NumberOfSeats + ", " + b.Fare + ", " + b.A1 + "," + b.A2 + "," + b.A3 + "," + b.A4 + ", " + b.B1 + "," + b.B2 + "," + b.B3 + "," + b.B4 + ", " + b.C1 + "," + b.C2 + "," + b.C3 + "," + b.C4 + ", " + b.D1 + "," + b.D2 + "," + b.D3 + "," + b.D4 + ", " + b.E1 + "," + b.E2 + "," + b.E3 + "," + b.E4 + ", " + b.F1 + "," + b.F2 + "," + b.F3 + "," + b.F4 + ", " + b.G1 + "," + b.G2 + "," + b.G3 + "," + b.G4 + ", " + b.H1 + "," + b.H2 + "," + b.H3 + "," + b.H4 + ")";
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

        public bool DeleteBus(Bus b)
        {
            string query = "DELETE from buses WHERE id = '" + b.BusId + "'";
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

        public bool UpdateBus(Bus b)
        {
            string query = "UPDATE buses SET  name = '" + b.BusName + "' WHERE name = '" + b.BusName + "'";
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

        public Bus GetBus(string from, string to, string date, string type)
        {
            Bus b = null;
            string query = "SELECT * from buses WHERE wherefrom = '" + from + "' AND whereto = '" + to + "' AND date = '" + date + "' AND type'" + type + "'";
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                b = new Bus();

                b.BusId = sdr["id"].ToString();
                b.BusName = sdr["name"].ToString();
                b.From = sdr["wherefrom"].ToString();
                b.To = sdr["whereto"].ToString();
                b.Date = sdr["date"].ToString();
                b.Time = sdr["time"].ToString();
                b.Type = sdr["type"].ToString();
                b.NumberOfSeats = Convert.ToInt32(sdr["seatsavailable"]);
                b.Fare = Convert.ToDouble(sdr["fare"]);
            }

            dcc.CloseConnection();
            return b;
        }

        public List<Bus> GetAllBus()
        {
            List<Bus> listOfBus = new List<Bus>();
            string query = "SELECT * FROM buses";
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Bus b = new Bus();

                b.BusId = sdr["id"].ToString();
                b.BusName = sdr["name"].ToString();
                b.From = sdr["wherefrom"].ToString();
                b.To = sdr["whereto"].ToString();
                b.Date = sdr["date"].ToString();
                b.Time = sdr["time"].ToString();
                b.Type = sdr["type"].ToString();
                b.NumberOfSeats = Convert.ToInt32(sdr["seatsavailable"]);
                b.Fare = Convert.ToDouble(sdr["fare"]);

                listOfBus.Add(b);
            }
            dcc.CloseConnection();

            return listOfBus;
        }

        public List<Bus> GetAllBus(string from, string to, string date, string type)
        {
            Bus b = null;
            List<Bus> listOfBus = new List<Bus>();
            string query = "SELECT * FROM buses WHERE wherefrom = '" + from + "' AND whereto = '" + to + "' AND date = '" + date + "' AND type = '" + type + "'";
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                b = new Bus();

                b.BusId = sdr["id"].ToString();
                b.BusName = sdr["name"].ToString();
                b.From = sdr["wherefrom"].ToString();
                b.To = sdr["whereto"].ToString();
                b.Date = sdr["date"].ToString();
                b.Time = sdr["time"].ToString();
                b.Type = sdr["type"].ToString();
                b.NumberOfSeats = Convert.ToInt32(sdr["seatsavailable"]);
                b.Fare = Convert.ToDouble(sdr["fare"]);
                b.A1 = Convert.ToInt32(sdr["A1"]);
                b.A2 = Convert.ToInt32(sdr["A2"]);
                b.A3 = Convert.ToInt32(sdr["A3"]);
                b.A4 = Convert.ToInt32(sdr["A4"]);
                b.B1 = Convert.ToInt32(sdr["B1"]);
                b.B2 = Convert.ToInt32(sdr["B2"]);
                b.B3 = Convert.ToInt32(sdr["B3"]);
                b.B4 = Convert.ToInt32(sdr["B4"]);
                b.C1 = Convert.ToInt32(sdr["C1"]);
                b.C2 = Convert.ToInt32(sdr["C2"]);
                b.C3 = Convert.ToInt32(sdr["C3"]);
                b.C4 = Convert.ToInt32(sdr["C4"]);
                b.D1 = Convert.ToInt32(sdr["D1"]);
                b.D2 = Convert.ToInt32(sdr["D2"]);
                b.D3 = Convert.ToInt32(sdr["D3"]);
                b.D4 = Convert.ToInt32(sdr["D4"]);
                b.E1 = Convert.ToInt32(sdr["E1"]);
                b.E2 = Convert.ToInt32(sdr["E2"]);
                b.E3 = Convert.ToInt32(sdr["E3"]);
                b.E4 = Convert.ToInt32(sdr["E4"]);
                b.F1 = Convert.ToInt32(sdr["F1"]);
                b.F2 = Convert.ToInt32(sdr["F2"]);
                b.F3 = Convert.ToInt32(sdr["F3"]);
                b.F4 = Convert.ToInt32(sdr["F4"]);
                b.G1 = Convert.ToInt32(sdr["G1"]);
                b.G2 = Convert.ToInt32(sdr["G2"]);
                b.G3 = Convert.ToInt32(sdr["G3"]);
                b.G4 = Convert.ToInt32(sdr["G4"]);
                b.H1 = Convert.ToInt32(sdr["H1"]);
                b.H2 = Convert.ToInt32(sdr["H2"]);
                b.H3 = Convert.ToInt32(sdr["H3"]);
                b.H4 = Convert.ToInt32(sdr["H4"]);

                listOfBus.Add(b);
            }
            dcc.CloseConnection();

            return listOfBus;
        }

        public Bus GetBus(string busid, string name, string date, string time, string availableseats, string fare)
        {
            Bus b = null;
            string query = "SELECT * FROM buses WHERE id = '" + busid + "' AND name = '" + name + "' AND date = '" + date + "' AND time = '" + time + "' AND seatsavailable = " + availableseats + " AND fare = " + fare + "";
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                b = new Bus();

                b.BusId = sdr["id"].ToString();
                b.BusName = sdr["name"].ToString();
                b.From = sdr["wherefrom"].ToString();
                b.To = sdr["whereto"].ToString();
                b.Date = sdr["date"].ToString();
                b.Time = sdr["time"].ToString();
                b.Type = sdr["type"].ToString();
                b.NumberOfSeats = Convert.ToInt32(sdr["seatsavailable"]);
                b.Fare = Convert.ToDouble(sdr["fare"]);
                b.A1 = Convert.ToInt32(sdr["A1"]);
                b.A2 = Convert.ToInt32(sdr["A2"]);
                b.A3 = Convert.ToInt32(sdr["A3"]);
                b.A4 = Convert.ToInt32(sdr["A4"]);
                b.B1 = Convert.ToInt32(sdr["B1"]);
                b.B2 = Convert.ToInt32(sdr["B2"]);
                b.B3 = Convert.ToInt32(sdr["B3"]);
                b.B4 = Convert.ToInt32(sdr["B4"]);
                b.C1 = Convert.ToInt32(sdr["C1"]);
                b.C2 = Convert.ToInt32(sdr["C2"]);
                b.C3 = Convert.ToInt32(sdr["C3"]);
                b.C4 = Convert.ToInt32(sdr["C4"]);
                b.D1 = Convert.ToInt32(sdr["D1"]);
                b.D2 = Convert.ToInt32(sdr["D2"]);
                b.D3 = Convert.ToInt32(sdr["D3"]);
                b.D4 = Convert.ToInt32(sdr["D4"]);
                b.E1 = Convert.ToInt32(sdr["E1"]);
                b.E2 = Convert.ToInt32(sdr["E2"]);
                b.E3 = Convert.ToInt32(sdr["E3"]);
                b.E4 = Convert.ToInt32(sdr["E4"]);
                b.F1 = Convert.ToInt32(sdr["F1"]);
                b.F2 = Convert.ToInt32(sdr["F2"]);
                b.F3 = Convert.ToInt32(sdr["F3"]);
                b.F4 = Convert.ToInt32(sdr["F4"]);
                b.G1 = Convert.ToInt32(sdr["G1"]);
                b.G2 = Convert.ToInt32(sdr["G2"]);
                b.G3 = Convert.ToInt32(sdr["G3"]);
                b.G4 = Convert.ToInt32(sdr["G4"]);
                b.H1 = Convert.ToInt32(sdr["H1"]);
                b.H2 = Convert.ToInt32(sdr["H2"]);
                b.H3 = Convert.ToInt32(sdr["H3"]);
                b.H4 = Convert.ToInt32(sdr["H4"]);

            }

            dcc.CloseConnection();
            return b;
        }
        public bool UpdateSeat(Bus b, string seatname)
        {
            if (seatname == "A1")
            {
                string query = "UPDATE buses SET  A1 = '1' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "A2")
            {
                string query = "UPDATE buses SET  A2 = '1' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "A3")
            {
                string query = "UPDATE buses SET  A3 = '1' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "A4")
            {
                string query = "UPDATE buses SET  A4 = '1' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "B1")
            {
                string query = "UPDATE buses SET  B1 = '1' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "B2")
            {
                string query = "UPDATE buses SET  B2 = '1' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "B3")
            {
                string query = "UPDATE buses SET  B3 = '1' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "B4")
            {
                string query = "UPDATE buses SET  B4 = '1' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "C1")
            {
                string query = "UPDATE buses SET  C1 = '1' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "C2")
            {
                string query = "UPDATE buses SET  C2 = '1' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "C3")
            {
                string query = "UPDATE buses SET  C3 = '1' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "C4")
            {
                string query = "UPDATE buses SET  C4 = '1' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "D1")
            {
                string query = "UPDATE buses SET  D1 = '1' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "D2")
            {
                string query = "UPDATE buses SET  D2 = '1' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "D3")
            {
                string query = "UPDATE buses SET  D3 = '1' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "D4")
            {
                string query = "UPDATE buses SET  D4 = '1' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "E1")
            {
                string query = "UPDATE buses SET  E1 = '1' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "E2")
            {
                string query = "UPDATE buses SET  E2 = '1' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "E3")
            {
                string query = "UPDATE buses SET  E3 = '1' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "E4")
            {
                string query = "UPDATE buses SET  E4 = '1' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "F1")
            {
                string query = "UPDATE buses SET  F1 = '1' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "F2")
            {
                string query = "UPDATE buses SET  F2 = '1' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "F3")
            {
                string query = "UPDATE buses SET  F3 = '1' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "F4")
            {
                string query = "UPDATE buses SET  F4 = '1' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "G1")
            {
                string query = "UPDATE buses SET  G1 = '1' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "G2")
            {
                string query = "UPDATE buses SET  G2 = '1' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "G3")
            {
                string query = "UPDATE buses SET  G3 = '1' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "G4")
            {
                string query = "UPDATE buses SET  G4 = '1' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "H1")
            {
                string query = "UPDATE buses SET  H1 = '1' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "H2")
            {
                string query = "UPDATE buses SET  H2 = '1' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "H3")
            {
                string query = "UPDATE buses SET  H3 = '1' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "H4")
            {
                string query = "UPDATE buses SET  H4 = '1' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else { return false; }

        }

        public bool UpdateNumberSeat(Bus b)
        {
            string query = "UPDATE buses SET  seatsavailable = " + b.NumberOfSeats + " WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
        public Bus GetBus(string busid, string date, string time)
        {
            Bus b = null;
            string query = "SELECT * FROM buses WHERE id = '" + busid + "' AND date = '" + date + "' AND time = '" + time + "'";
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                b = new Bus();

                b.BusId = sdr["id"].ToString();
                b.BusName = sdr["name"].ToString();
                b.From = sdr["wherefrom"].ToString();
                b.To = sdr["whereto"].ToString();
                b.Date = sdr["date"].ToString();
                b.Time = sdr["time"].ToString();
                b.Type = sdr["type"].ToString();
                b.NumberOfSeats = Convert.ToInt32(sdr["seatsavailable"]);
                b.Fare = Convert.ToDouble(sdr["fare"]);
                b.A1 = Convert.ToInt32(sdr["A1"]);
                b.A2 = Convert.ToInt32(sdr["A2"]);
                b.A3 = Convert.ToInt32(sdr["A3"]);
                b.A4 = Convert.ToInt32(sdr["A4"]);
                b.B1 = Convert.ToInt32(sdr["B1"]);
                b.B2 = Convert.ToInt32(sdr["B2"]);
                b.B3 = Convert.ToInt32(sdr["B3"]);
                b.B4 = Convert.ToInt32(sdr["B4"]);
                b.C1 = Convert.ToInt32(sdr["C1"]);
                b.C2 = Convert.ToInt32(sdr["C2"]);
                b.C3 = Convert.ToInt32(sdr["C3"]);
                b.C4 = Convert.ToInt32(sdr["C4"]);
                b.D1 = Convert.ToInt32(sdr["D1"]);
                b.D2 = Convert.ToInt32(sdr["D2"]);
                b.D3 = Convert.ToInt32(sdr["D3"]);
                b.D4 = Convert.ToInt32(sdr["D4"]);
                b.E1 = Convert.ToInt32(sdr["E1"]);
                b.E2 = Convert.ToInt32(sdr["E2"]);
                b.E3 = Convert.ToInt32(sdr["E3"]);
                b.E4 = Convert.ToInt32(sdr["E4"]);
                b.F1 = Convert.ToInt32(sdr["F1"]);
                b.F2 = Convert.ToInt32(sdr["F2"]);
                b.F3 = Convert.ToInt32(sdr["F3"]);
                b.F4 = Convert.ToInt32(sdr["F4"]);
                b.G1 = Convert.ToInt32(sdr["G1"]);
                b.G2 = Convert.ToInt32(sdr["G2"]);
                b.G3 = Convert.ToInt32(sdr["G3"]);
                b.G4 = Convert.ToInt32(sdr["G4"]);
                b.H1 = Convert.ToInt32(sdr["H1"]);
                b.H2 = Convert.ToInt32(sdr["H2"]);
                b.H3 = Convert.ToInt32(sdr["H3"]);
                b.H4 = Convert.ToInt32(sdr["H4"]);
            }

            dcc.CloseConnection();
            return b;
        }
        public bool updatefordelete(Bus b, string seatname)
        {
            if (seatname == "A1")
            {
                string query = "UPDATE buses SET  A1 = '0' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "A2")
            {
                string query = "UPDATE buses SET  A2 = '0' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "A3")
            {
                string query = "UPDATE buses SET  A3 = '0' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "A4")
            {
                string query = "UPDATE buses SET  A4 = '0' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "B1")
            {
                string query = "UPDATE buses SET  B1 = '0' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "B2")
            {
                string query = "UPDATE buses SET  B2 = '0' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "B3")
            {
                string query = "UPDATE buses SET  B3 = '0' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "B4")
            {
                string query = "UPDATE buses SET  B4 = '0' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "C1")
            {
                string query = "UPDATE buses SET  C1 = '0' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "C2")
            {
                string query = "UPDATE buses SET  C2 = '0' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "C3")
            {
                string query = "UPDATE buses SET  C3 = '0' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "C4")
            {
                string query = "UPDATE buses SET  C4 = '0' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "D1")
            {
                string query = "UPDATE buses SET  D1 = '0' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "D2")
            {
                string query = "UPDATE buses SET  D2 = '0' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "D3")
            {
                string query = "UPDATE buses SET  D3 = '0' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "D4")
            {
                string query = "UPDATE buses SET  D4 = '0' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "E1")
            {
                string query = "UPDATE buses SET  E1 = '0' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "E2")
            {
                string query = "UPDATE buses SET  E2 = '0' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "E3")
            {
                string query = "UPDATE buses SET  E3 = '0' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "E4")
            {
                string query = "UPDATE buses SET  E4 = '0' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "F1")
            {
                string query = "UPDATE buses SET  F1 = '0' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "F2")
            {
                string query = "UPDATE buses SET  F2 = '0' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "F3")
            {
                string query = "UPDATE buses SET  F3 = '0' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "F4")
            {
                string query = "UPDATE buses SET  F4 = '0' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "G1")
            {
                string query = "UPDATE buses SET  G1 = '0' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "G2")
            {
                string query = "UPDATE buses SET  G2 = '0' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "G3")
            {
                string query = "UPDATE buses SET  G3 = '0' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "G4")
            {
                string query = "UPDATE buses SET  G4 = '0' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "H1")
            {
                string query = "UPDATE buses SET  H1 = '0' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "H2")
            {
                string query = "UPDATE buses SET  H2 = '0' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "H3")
            {
                string query = "UPDATE buses SET  H3 = '0' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else if (seatname == "H4")
            {
                string query = "UPDATE buses SET  H4 = '0' WHERE id = '" + b.BusId + "' AND name = '" + b.BusName + "' AND date = '" + b.Date + "' AND time = '" + b.Time + "'";
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
            else { return false; }

        }
    }


}
