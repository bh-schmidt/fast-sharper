using System.Collections.Generic;

namespace FastSharper.Tests
{
    public class Cart
    {
        public string? CartId { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();
        public List<Customer> Customers { get; set; } = new List<Customer>();
    }
}
