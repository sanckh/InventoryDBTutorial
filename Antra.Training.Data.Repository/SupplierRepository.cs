using System;
using System.Data;
using Dapper;
using System.Data.SqlClient;
using Antra.Training.Data.Entity;

namespace Antra.Training.Data.Repository
{
    public class SupplierRepository : IRepository<Supplier>
    {
        IDbConnection dbConnection;
        public SupplierRepository()
        {
            dbConnection = new SqlConnection("Data Source=desktop-ejshkkp;Initial Catalog=InventoryDB;Integrated Security=True");
        }
        public int Delete(int id)
        {
            return dbConnection.Execute("Delete from Supplier where Id=@pid", new { pid = id });
        }

        public Supplier Get(int id)
        {
            return dbConnection.QueryFirstOrDefault<Supplier>("Select Id, SupplierName, SupplierAddress, Mobile, EmailId from Supplier where id=@pid", new { pid = id });
        }

        public IEnumerable<Supplier> GetAll()
        {
            return dbConnection.Query<Supplier>("Select Id, SupplierName, SupplierAddress, Mobile, EmailId from Supplier");
        }

        public int Insert(Supplier entity)
        {
            return dbConnection.Execute("Insert into Supplier values (@Id, @SupplierName, @SupplierAddress, @Mobile, @EmailId)", entity);
        }

        public int Update(Supplier entity)
        {
            return dbConnection.Execute(@"Update Supplier set Id = @Id, SupplierName = @SupplierName, SupplierAddress = @SupplierAddress, Mobile = @Mobile, EmailId = EmailId 
                                          where Id = @Id", entity);
        }
    }
}
