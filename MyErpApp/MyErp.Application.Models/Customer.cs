//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace MyErp.Application.Models
{
    public record Customer
    {
        public int CustomerId { get; init; }
        public string? CustomerName { get; init; }
        public string? CustomerSurname { get; init; }

        //public Customer(int customerId, string? customerName, string? customerSurname)
        //{
        //    CustomerId = customerId;
        //    CustomerName = customerName;
        //    CustomerSurname = customerSurname;
        //}
    }
}
