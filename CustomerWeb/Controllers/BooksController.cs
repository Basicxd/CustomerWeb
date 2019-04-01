using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using CustomerWeb.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private static readonly string MyString =
            "Server=tcp:basic1997.database.windows.net,1433;Initial Catalog=Customer;Persist Security Info=False;User ID=basic;Password=Polo1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        
        // GET: api/Books
        [HttpGet]
        //public IEnumerable<Customer> GetAll()
        //{
        //    const string selectString = "Select* from dbo.Customer";
        //    using (SqlConnection databaseConnection = new SqlConnection(MyString))
        //    {
        //        databaseConnection.Open();
        //        using (SqlCommand selectCommand = new SqlCommand(selectString, databaseConnection))
        //        {
        //            using (SqlDataReader reader = selectCommand.ExecuteReader())
        //            {

        //                List<Customer> CustomerList = new List<Customer>();
        //                while (reader.Read())
        //                {
        //                    Customer customer = ReadBook(reader);
        //                    CustomerList.Add(customer);
        //                }

        //                return CustomerList;
        //            }
        //        }

        //}

        public List<Customer> Getall()
        {
            List<Customer> customerList = new List<Customer>();

            using (SqlConnection dbConnection = new SqlConnection(MyString))
            {
                dbConnection.Open();
                using (SqlCommand command = new SqlCommand("Select* from dbo.Customer", dbConnection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            customerList.Add(new Customer(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3)));
                        }
                    }
                }
            }
        }

        

        //private static Customer ReadBook(IDataRecord reader)
        // {
        //        int customerID = reader.GetInt32(0);
        //        string firstName = reader.IsDBNull(1) ? null : reader.GetString(1);
        //        string lastName = reader.IsDBNull(2) ? null : reader.GetString(2);
        //        int year = reader.GetInt32(4);
        //        Customer customer = new Customer
        //        {
        //            CustomerID = customerID,
        //            FirstName = firstName,
        //            LastName = lastName,
        //            Year = year
                   
        //        };
        //        return customer;
        //    }

        // GET: api/Books/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Books
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Books/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
