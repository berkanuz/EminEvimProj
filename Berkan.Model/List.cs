using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Berkan.Model
{
    [Table("CustomerLists")]
    public class CustomerList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<CustomerItem> CustomerItems { get; set; }
    }
}
