using System.Collections.Generic;

namespace Lab_4_task1
{
    public class Shop: ISearchable
    {
        private List<User> Users { get; set; }
        private List<Product> Products { get; set; }
        private List<Order> Orders { get; set; }

        public List<Product> SearchByPrice(double price)
        {
            List<Product> result = new List<Product>();
            foreach (var product in Products)
            {
                if (product.Price == price)
                {
                    result.Add(product);
                }
            }
            return result;
        }

        public List<Product> SearchByCategory(string category)
        {
            List<Product> result = new List<Product>();
            foreach (var product in Products)
            {
                if (product.Category == category)
                {
                    result.Add(product);
                }
            }
            return result;
        }

        public List<Product> SearchByRating(double rating)
        {
            List<Product> result = new List<Product>();
            return result;
        }
    }
}