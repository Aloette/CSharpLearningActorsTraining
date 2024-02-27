using MyErp.Business;
using MyErp.Business.Interfaces;
using MyErp.DAL;
using MyErp.PrintService;

class Program
{
    static void Main(string[] args)
    {
        // Create repositories
        IGenericRepository<Order> orderRepository = new OrderRepository();
        IGenericRepository<Customer> customerRepository = new CustomerRepository();

        // Create 5 orders and customers
        for (int i = 0; i < 5; i++)
        {
            var order = new Order();
            orderRepository.Create(order);

            var customer = new Customer();
            customerRepository.Create(customer);
        }

        // Retrieve all orders and customers
        var allOrders = orderRepository.GetAll();
        var allCustomers = customerRepository.GetAll();

        // Print the first order and customer
        var printingService = new PrintingService();
        var jsonOrder = printingService.Print(allOrders.FirstOrDefault());
        var jsonCustomer = printingService.Print(allCustomers.FirstOrDefault());

        Console.WriteLine("First Order (as JSON):");
        Console.WriteLine(jsonOrder);

        Console.WriteLine("\nFirst Customer (as JSON):");
        Console.WriteLine(jsonCustomer);
    }
}