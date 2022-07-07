using Berkan.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Berkan.Engines.Interfaces
{
    public interface ICustomerItemEngine
    {
        CustomerItem CreateCustomerItem(CustomerItem item);
        CustomerItem UpdateCustomerItem(CustomerItem item);
        CustomerItem GetItemById(int itemId);
        bool DeleteCustomerItem(int itemId);
    }
}
