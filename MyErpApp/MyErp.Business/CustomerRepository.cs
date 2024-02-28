using MyErp.Business.Interfaces;
using MyErp.DAL;
using MyErp.Application.Models;

namespace MyErp.Business
{
    public class CustomerRepository : IGenericRepository<Customer>
    {
        public void Create(Customer entity)
        {
            ErpDB.Customers.Add(entity);
        }

        public List<Customer> GetAll()
        {
            //return new List<Customer>();
            return ErpDB.Customers;
        }
    }
}
