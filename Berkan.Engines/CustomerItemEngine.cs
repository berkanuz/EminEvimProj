using Berkan.Data;
using Berkan.Engines.Interfaces;
using Berkan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Berkan.Engines
{
    public class CustomerItemEngine : ICustomerItemEngine
    {
        private DAL _dal;
        public CustomerItemEngine(DAL dal)
        {
            _dal = dal;
        }

        public CustomerItem CreateCustomerItem(CustomerItem item)
        {
            _dal.CustomerItems.Add(item);
            var result = _dal.SaveChanges();
            if (result != 1)
            {
                item = null;
            }
            return item;
        }

        public CustomerItem UpdateCustomerItem(CustomerItem item)
        {
            _dal.CustomerItems.Update(item);
            var result = _dal.SaveChanges();
            if (result != 1)
            {
                item = null;
            }
            return item;
        }

        public CustomerItem GetItemById(int itemId)
        {
            var item = _dal.CustomerItems.Where(item => item.Id == itemId).FirstOrDefault();
            return item;
        }

        public bool DeleteCustomerItem(int itemId)
        {
            var item = GetItemById(itemId);
            if (item == null)
            {
                return false;
            }
            _dal.CustomerItems.Remove(item);
            var result = _dal.SaveChanges();
            return true;
        }
    }
}
