using MyErp.Business.Interfaces;
using MyErp.DAL;

namespace MyErp.Business
{
    public class CustomerRepository : IGenericRepository<Customer>
    {
        public void Create(Customer entity)
        {
            ErpDB.Customers.Add(entity);
        }

        public IEnumerable<Customer> GetAll()
        {
            return new List<Customer>();
        }
    }
}
