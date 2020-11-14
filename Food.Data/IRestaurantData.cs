using Food.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Food.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant {Id = 1, Name = "Garry`s Pizza", Location = "Lviv", Cuisine = CuisineType.Italian},
                new Restaurant {Id = 2, Name = "Mario`s Club", Location = "Lviv", Cuisine = CuisineType.Italian},
                new Restaurant {Id = 3, Name = "La Costa", Location = "Lviv", Cuisine = CuisineType.Mexican}
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(x => x.Name);
        }
    }
}