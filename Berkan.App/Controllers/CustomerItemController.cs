using Berkan.App.ViewModels;
using Berkan.Engines.Interfaces;
using Berkan.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Berkan.App.Controllers
{
    public class CustomerItemController : BaseController
    {
        private ICustomerItemEngine _customeritemEngine;
        private ICustomerEngine _customerEngine;
        public CustomerItemController(ICustomerItemEngine customeritemEngine, ICustomerEngine customerEngine)
        {
            _customeritemEngine = customeritemEngine;
            _customerEngine = customerEngine;
        }

        public IActionResult CreateItem(int listId)
        {
            var list = _customerEngine.GetListById(listId);
            var model = new CustomerItemModel()
            {
                EndDate = DateTime.Now,
                CustomerListId = list.Id,
                CustomerListName = list.Name
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult CreateItem(CustomerItemModel model)
        {
            if (ModelState.IsValid)
            {
                var item = new CustomerItem()
                {
                    Text = model.Text,
                    EndDate = model.EndDate,
                    CustomerListId = model.CustomerListId
                };
                var result = _customeritemEngine.CreateCustomerItem(item);
                if (result != null)
                {
                    ViewBag.OperationMessage = "Item Created Successfully!";
                }
                else
                {
                    ModelState.AddModelError("", "An Error occurred when Item attempting to create");
                }
            }
            return View(model);
        }

        public IActionResult UpdateItem(int itemId)
        {
            var item = _customeritemEngine.GetItemById(itemId);
            var model = new CustomerItemModel()
            {
                Id = item.Id,
                Text = item.Text,
                EndDate = item.EndDate,
                CustomerListId = item.CustomerList.Id,
                CustomerListName = item.CustomerList.Name,
                Completed = item.Completed
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateItem(CustomerItemModel model)
        {
            if (ModelState.IsValid)
            {
                var item = _customeritemEngine.GetItemById(model.Id);
                item.Text = model.Text;
                item.EndDate = model.EndDate;
                item.Completed = model.Completed;
                var result = _customeritemEngine.UpdateCustomerItem(item);
                if (result != null)
                {
                    ViewBag.OperationMessage = "Item Updated Successfully!";
                }
                else
                {
                    ModelState.AddModelError("", "An Error occurred when Item attempting to upate");
                }
            }
            return View(model);
        }

        public IActionResult DeleteItem(int itemId)
        {
            var item = _customeritemEngine.GetItemById(itemId);
            var listId = item.CustomerListId;
            _customeritemEngine.DeleteCustomerItem(itemId);
            var operationMessage = "Item deleted successfully!";
            TempData["OperationMessage"] = operationMessage;
            return RedirectToAction("ListDetails", "Customer", new { listId = listId });
        }
    }
}
