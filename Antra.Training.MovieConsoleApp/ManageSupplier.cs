using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antra.Training.Data.Services;
using Antra.Training.Data.Entity;

namespace Antra.Training.MovieConsoleApp
{
    class ManageSupplier
    {
        ISupplierService supplierService;
        public ManageSupplier()
        {
            supplierService = new SupplierService();
        }
        void PrintAllSuppliers()
        {
            var collection = supplierService.GetAll();
            if(collection != null)
            {
                foreach(var item in collection)
                {
                    Console.WriteLine($"{item.Id} \t {item.SupplierName} \t {item.SupplierAddress} \t {item.EmailId}");
                }
            }
        }
        void InsertSupplier()
        {
            Supplier supplier = new Supplier() { SupplierName = "Corey Sutton", SupplierAddress = "Chicago", Mobile = "7086551888", EmailId = null };
            if(supplierService.InsertSupplier(supplier) > 0)
            {
                Console.WriteLine("Person Added Successfully");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        void UpdateSupplier()
        {
            Supplier supplier = new Supplier() { Id= 2, SupplierName = "Corey Sutton", SupplierAddress = "Chicago", Mobile = "7086551888", EmailId = "corey@antra.com" };
            if (supplierService.UpdateSupplier(supplier) > 0)
            {
                Console.WriteLine("Person Updated Successfully");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        void DeleteSupplier()
        {
            if(supplierService.DeleteSupplier(2) > 0)
            {
                Console.WriteLine("Person Deleted Successfully");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        public void Run()
        {
            PrintAllSuppliers();
            InsertSupplier();
            UpdateSupplier();
        }
    }
}
