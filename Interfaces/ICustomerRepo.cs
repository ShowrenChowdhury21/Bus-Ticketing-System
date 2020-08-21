using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICustomerRepo
    {
        bool InsertCustomer(Customer cm);
        bool DeleteCustomer(Customer cm);
        Customer GetCustomer(string name, string phoneNumber);
        List<Customer> GetAllCustomer();

    }
}
