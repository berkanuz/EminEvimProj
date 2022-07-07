using Berkan.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Berkan.Engines.Interfaces
{
    public interface ICustomerEngine
    {
        List<CustomerList> GetAllLists();
        CustomerList GetListById(int id);

        CustomerList CreateCustomerList(CustomerList item);
        CustomerList UpdateCustomerList(CustomerList item);
        bool DeleteCustomerList(int id);
    }
}
