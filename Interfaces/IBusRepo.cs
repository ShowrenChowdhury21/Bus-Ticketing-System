using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    public interface IBusRepo
    {
        bool InsertBus(Bus b);
        bool DeleteBus(Bus b);
        bool UpdateBus(Bus b);
        Bus GetBus(string from, string to, string date, string type);
        List<Bus> GetAllBus();
        List<Bus> GetAllBus(string from, string to, string date, string type);
        Bus GetBus(string busid, string name, string date, string time, string availableseats, string fare);
        bool UpdateSeat(Bus b, string seatname);
        bool UpdateNumberSeat(Bus b);
        Bus GetBus(string busid, string date, string time);
        bool updatefordelete(Bus b, string seatname);
    }
}
