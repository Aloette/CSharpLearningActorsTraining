using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyErp.DAL
{
    public static class ErpDB
    {
        public static List<Customer> Customers { get; } = new List<Customer>();
        public static List<Order> Orders { get; } = new List<Order>();
    }
}
