using MyErp.Business.Interfaces;
using MyErp.DAL;
using MyErp.Application.Models;

namespace MyErp.Business
{
    public class OrderRepository : IGenericRepository<Order>
    {
        public void Create(Order entity)
        {
            ErpDB.Orders.Add(entity);
        }

        public List<Order> GetAll()
        {
            //return new List<Order>();
            return ErpDB.Orders;
        }
    }
}
