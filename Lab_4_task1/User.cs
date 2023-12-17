using System.Collections.Generic;

namespace Lab_4_task1
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public List<Order> PurchaseHistory { get; set; }
    }
}