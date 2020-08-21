using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Customer
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        string phoneNumber;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        string from;

        public string From
        {
            get { return from; }
            set { from = value; }
        }
        string to;

        public string To
        {
            get { return to; }
            set { to = value; }
        }
        string busId;

        public string BusId
        {
            get { return busId; }
            set { busId = value; }
        }
        
        string time;

        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        string date;

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        string seatNumber;

        public string SeatNumber
        {
            get { return seatNumber; }
            set { seatNumber = value; }
        }
        double fare;

        public double Fare
        {
            get { return fare; }
            set { fare = value; }
        }
    }
}
