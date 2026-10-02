using task_14.Data;
using task_14.Entities;

namespace task_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new AppDbContext();
            List<Category> categories = new List<Category>()
            {
                new Category {  Name = "Electronics" },
                new Category {  Name = "Clothes" },
                new Category {  Name = "Books" }
            };

            //context.Set<Category>().AddRange(categories);
            //context.SaveChanges();



            List<Product> products = new List<Product>() 
            {
                new Product {  Name = "Laptop", Price = 25000, CategoryId = 1 },
                new Product {  Name = "Headphones", Price = 1500, CategoryId = 1 },
                new Product {  Name = "T-Shirt", Price = 700, CategoryId = 2 },
                new Product {  Name = "C# Book", Price = 500, CategoryId = 3 }
            };

            //context.Set<Product>().AddRange(products);
            //context.SaveChanges();


            List<Customer> customers = new List<Customer>()
            {
                new Customer {  Name = "Ahmed Ali", Email = "ahmed@gmail.com" },
                new Customer {  Name = "Mona Hassan", Email = "mona@gmail.com" },
                new Customer {  Name = "Omar Mohamed", Email = "omar@gmail.com" }
            };

            //context.Set<Customer>().AddRange(customers);
            //context.SaveChanges();



            List<Order> orders = new List<Order>()
            {
                new Order {  OrderDate = new DateTime(2026, 9, 25), CustomerId = 1 },
                new Order {  OrderDate = new DateTime(2026, 9, 26), CustomerId = 2 },
                new Order {  OrderDate = new DateTime(2026, 9, 27), CustomerId = 1 }
            };


            //context.Set<Order>().AddRange(orders);
            //context.SaveChanges();



            List<OrderDetail> ordersDetail = new List<OrderDetail>()
            {
                new OrderDetail { OrderId = 1, ProductId = 1, Quantity = 1 },
                new OrderDetail { OrderId = 1, ProductId = 2, Quantity = 2 },
                
                new OrderDetail { OrderId = 2, ProductId = 3, Quantity = 3 },
                
                new OrderDetail { OrderId = 3, ProductId = 1, Quantity = 1 },
                new OrderDetail { OrderId = 3, ProductId = 4, Quantity = 2 }
            };

            context.Set<OrderDetail>().AddRange(ordersDetail);
            context.SaveChanges();
        }
    }
}
