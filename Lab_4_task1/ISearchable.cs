using System.Collections.Generic;

namespace Lab_4_task1
{
    public interface ISearchable
    {
        List<Product> SearchByPrice(double price);
        List<Product> SearchByCategory(string category);
        List<Product> SearchByRating(double rating);
    }
}