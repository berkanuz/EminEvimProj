using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Berkan.Model
{
    [Table("CustomerItems")]
    public class CustomerItem
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime EndDate { get; set; }
        public virtual CustomerList CustomerList { get; set; }
        public int CustomerListId { get; set; }
        public bool Completed { get; set; }
    }
}
