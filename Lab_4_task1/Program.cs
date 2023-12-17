using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_4_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            
            List<Product> results = shop.SearchByPrice(100.0);
            Console.WriteLine("Products with price 100.0: " + string.Join(", ", results.Select(p => p.Name)));

            results = shop.SearchByCategory("Electronics");
            Console.WriteLine("Products in category 'Electronics': " + string.Join(", ", results.Select(p => p.Name)));

            results = shop.SearchByRating(4.5);
            Console.WriteLine("Products with rating 4.5: " + string.Join(", ", results.Select(p => p.Name)));
        }
        }
    }