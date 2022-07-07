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
    public class CustomerController : BaseController
    {
        private ICustomerEngine _customerEngine;
        public CustomerController(ICustomerEngine customerEngine)
        {
            _customerEngine = customerEngine;
        }

        public IActionResult ListDetails(int listId)
        {
            var operationMessage = (TempData["OperationMessage"] ?? "").ToString();

            if (!string.IsNullOrWhiteSpace(operationMessage))
            {
                ViewBag.OperationMessage = operationMessage;
            }
            var list = _customerEngine.GetListById(listId);
            return View(list);
        }

        public IActionResult CreateList()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateList(CustomerListModel model)
        {
            if (ModelState.IsValid)
            {
                var customerList = new CustomerList()
                {
                    Name = model.Name
                };
                var result = _customerEngine.CreateCustomerList(customerList);
                if (result != null)
                {
                    ViewBag.OperationMessage = "List Created! | " + model.Name;
                    model.Id = result.Id;
                }
                else
                {
                    ModelState.AddModelError("", "An Error occurred when list attempting to create");
                }
            }
            return View(model);
        }

        public IActionResult UpdateList(int listId)
        {
            var list = _customerEngine.GetListById(listId);
            var listModel = new CustomerListModel()
            {
                Name = list.Name,
                Id = list.Id
            };
            return View(listModel);
        }

        [HttpPost]
        public IActionResult UpdateList(CustomerListModel model)
        {
            if (ModelState.IsValid)
            {
                var list = _customerEngine.GetListById(model.Id);
                if (list != null)
                {
                    list.Name = model.Name;
                    var result = _customerEngine.UpdateCustomerList(list);
                    if (result != null)
                    {
                        ViewBag.OperationMessage = model.Name + " List Updated!";
                        model.Id = result.Id;
                    }
                    else
                    {
                        ModelState.AddModelError("", "An Error occurred when list attempting to update");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Customer list not found!");
                }
            }
            return View(model);
        }

        public IActionResult DeleteList(int listId)
        {
            var list = _customerEngine.GetListById(listId);
            string listName = list.Name;
            _customerEngine.DeleteCustomerList(listId);
            var operationMessage = listName + " List deleted successfully!";
            TempData["OperationMessage"] = operationMessage;
            return RedirectToAction("index", "home");
        }
    }
}
