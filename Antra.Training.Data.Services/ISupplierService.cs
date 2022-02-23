using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antra.Training.Data.Entity;

namespace Antra.Training.Data.Services
{
    public interface ISupplierService
    {
        int InsertSupplier(Supplier supplier);
        int UpdateSupplier(Supplier supplier);
        Supplier GetSupplier(int id);
        int DeleteSupplier(int id);
        IEnumerable<Supplier> GetAll();

    }
}
