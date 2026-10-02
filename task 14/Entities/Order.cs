namespace task_14.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

    }
}
