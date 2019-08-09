using Model.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExample.Repositories
{
    public class CustomerRepository : Repository<Customer>
    {
        public override Customer PopulateRecord(IDataReader reader)
        {
            return new Customer(reader);
        }

        public IEnumerable<Customer> Get()
        {
            var sqlCommand = "SELECT ID, FName, LName "
                            + ", [Address], [Email], Telephone"
                            + " FROM dbo.Customers";

            return base.Get(sqlCommand);
        }

        public IEnumerable<Customer> Get(string customerId)
        {
            var sqlCommand = "SELECT ID, FName, LName "
                            + ", [Address], [Email], Telephone "
                            + " FROM dbo.Customers WHERE ID = @ID";
            var parameters = new SqlParameter[] { new SqlParameter("@ID", customerId) };

            return base.Get(sqlCommand, parameters);
        }

        public void Add(Customer customer)
        {
            var sqlCommand = "IF NOT EXISTS(SELECT 1 FROM dbo.Customers WHERE CustomerID = @CustomerID)"
                            + "INSERT INTO dbo.Customers "
                            + " (CustomerID, CompanyName, ContactName, ContactTitle "
                            + ", [Address], City, Region, PostalCode, Country, Phone, Fax) "
                            + "VALUES(@CustomerID, @CompanyName, @ContactName, @ContactTitle "
                            + ", @Address, @City, @Region, @PostalCode, @Country, @Phone, @Fax) ";

            base.ExecuteNonQuery(sqlCommand, customer.ToParameterArray());
        }

       
       
    }
}

