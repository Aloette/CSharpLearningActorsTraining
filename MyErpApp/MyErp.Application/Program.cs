using MyErp.Business;
//using MyErp.Business.Interfaces;
//using MyErp.DAL;
using MyErp.PrintService;
using MyErp.Application.Models;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        // Create repositories
        OrderRepository orderRepository = new OrderRepository();
        CustomerRepository customerRepository = new CustomerRepository();

        // Create 5 orders and customers
        for (int i = 0; i < 5; i++)
        {
            var order = new Order
            {
                OrderId = i,
                OrderName = $"OrderName{i}"
            };
            Console.WriteLine(order);
            orderRepository.Create(order);

            var customer = new Customer
            {
                CustomerId = i,
                CustomerName = $"CustomerName{i}",
                CustomerSurname = $"CustomerSurname{i}"
            };
            Console.WriteLine(customer);
            customerRepository.Create(customer);
        }

        // Retrieve all orders and customers
        var allOrders = orderRepository.GetAll();
        var allCustomers = customerRepository.GetAll();

        // Print the first order and customer
        var printingService = new PrintingService();
        printingService.Print(allOrders.FirstOrDefault());
        printingService.Print(allCustomers.FirstOrDefault());

        //Console.WriteLine("First Order (as JSON):");
        //Console.WriteLine(jsonOrder);

        //Console.WriteLine("\nFirst Customer (as JSON):");
        //Console.WriteLine(jsonCustomer);

        // Lesson 3 - Assignment 3

        // Make the user insert a search parameter from the console
        Console.WriteLine("Enter search parameter:");
        string searchParameter = Console.ReadLine();

        // Use LINQ to filter out customers based on the search parameter
        var filteredCustomers = allCustomers.Where(c =>
            c.CustomerName.Contains(searchParameter, StringComparison.OrdinalIgnoreCase) ||
            c.CustomerSurname.Contains(searchParameter, StringComparison.OrdinalIgnoreCase)
        ).ToList();

        // Map
        var mappedCustomers = filteredCustomers
                .Select(customer => new Customer
                {
                    CustomerId = customer.CustomerId,
                    CustomerName = customer.CustomerName,
                    CustomerSurname = customer.CustomerSurname
                })
                .ToList();

        // Print the filtered and mapped customers
            foreach (var mappedCustomer in mappedCustomers)
        {
            InvokePrintServiceReflection(mappedCustomer);
        }
    }
    private static void InvokePrintServiceReflection<T>(T item)
    {
        // Use reflection to create an instance of PrintingService
        var printingServiceInstance = Activator.CreateInstance(typeof(PrintingService));
        // Use reflection to get and invoke the Print<T> method
        MethodInfo printMethod = printingServiceInstance
            .GetType()
            .GetMethod("Print")
            .MakeGenericMethod(typeof(T));
        printMethod.Invoke(printingServiceInstance, new object[] { item });
    }
}