using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Berkan.App.ViewModels
{
    public class CustomerListModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Customer List Name Required")]
        public string Name { get; set; }
    }
}
