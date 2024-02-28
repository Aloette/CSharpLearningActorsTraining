namespace MyErp.Application.Models
{
    public record Order
    {
        public int OrderId { get; init; }
        public string? OrderName { get; init; }

        //public Order(int orderId, string? orderName)
        //{
        //    OrderId = orderId;
        //    OrderName = orderName;
        //}
    }
}