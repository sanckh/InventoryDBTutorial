using Antra.Training.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antra.Training.Data.Repository;

namespace Antra.Training.Data.Services
{
    public class SupplierService : ISupplierService
    {
        IRepository<Supplier> _repository;
        public SupplierService()
        {
            _repository = new SupplierRepository();
        }
        public int DeleteSupplier(int id)
        {
            return _repository.Delete(id);
        }

        public IEnumerable<Supplier> GetAll()
        {
            return _repository.GetAll();
        }

        public Supplier GetSupplier(int id)
        {
            return _repository.Get(id);
        }

        public int InsertSupplier(Supplier supplier)
        {
            return _repository.Insert(supplier);
        }

        public int UpdateSupplier(Supplier supplier)
        {
            return _repository.Update(supplier);
        }
    }
}
