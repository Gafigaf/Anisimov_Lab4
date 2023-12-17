using System.Collections.Generic;

namespace Lab_4_task1
{
    public class Order
    {
        public List<Product> Products { get; set; }
        public int Quantity { get; set; }
        public double TotalCost { get; set; }
        public string Status { get; set; }
    }
}