using Berkan.Engines.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Berkan.App.ViewComponents
{
    public class SideBarMenu : ViewComponent
    {
        private ICustomerEngine _customerEngine;
        public SideBarMenu(ICustomerEngine customerEngine)
        {
            _customerEngine = customerEngine;
        }
        public IViewComponentResult Invoke()
        {
            var CustomerLists = _customerEngine.GetAllLists();
            return View("/Views/Shared/SideBarMenu.cshtml", CustomerLists);
        }
    }
}
