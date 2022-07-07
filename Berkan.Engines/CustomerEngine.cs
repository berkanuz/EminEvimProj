using Berkan.Data;
using Berkan.Engines.Interfaces;
using Berkan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Berkan.Engines
{
    public class CustomerEngine : ICustomerEngine
    {
        private DAL _dal;
        public CustomerEngine(DAL dal)
        {
            _dal = dal;
        }
        public List<CustomerList> GetAllLists()
        {
            var lists = _dal.CustomerLists.ToList();
            return lists;
        }

        public CustomerList GetListById(int id)
        {
            var list = _dal.CustomerLists.Where(list => list.Id == id).FirstOrDefault();
            return list;
        }

        public CustomerList UpdateCustomerList(CustomerList item)
        {
            _dal.CustomerLists.Update(item);
            var result = _dal.SaveChanges();
            if (result != 1)
            {
                item = null;
            }
            return item;
        }

        public bool DeleteCustomerList(int id)
        {
            var list = GetListById(id);
            if (list == null)
            {
                return false;
            }
            _dal.CustomerLists.Remove(list);
            var result = _dal.SaveChanges();
            return true;
        }

        public CustomerList CreateCustomerList(CustomerList item)
        {
            _dal.CustomerLists.Add(item);
            var result = _dal.SaveChanges();
            if (result != 1)
            {
                item = null;
            }
            return item;
        }
    }
}
