using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IPlacesRepo
    {
        bool InsertPlaces(Places p);
        bool DeletePlaces(Places p);
        //bool UpdatePlaces(Places p);
        //Places GetPlaces();
        List<Places> GetAllPlaces();
    }
}
