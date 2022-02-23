using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.Training.Data.Entity
{
    public  class Supplier
    {
        //Id, SupplierName, SupplierAddress, Mobile, EmailId
        public int Id { get; set; }
        public string SupplierName { get; set; }
        public string SupplierAddress { get; set; }
        public string Mobile { get; set; }
        public string? EmailId { get; set; }
    }
}
