using MyErp.Business.Interfaces;
using MyErp.DAL;

namespace MyErp.Business
{
    public class OrderRepository : IGenericRepository<Order>
    {
        public void Create(Order entity)
        {
            ErpDB.Orders.Add(entity);
        }

        public IEnumerable<Order> GetAll()
        {
            return new List<Order>();
        }
    }
}
