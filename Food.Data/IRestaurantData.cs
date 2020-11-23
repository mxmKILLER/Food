using Food.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Food.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
        Restaurant GetById(int id);
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

        public Restaurant GetById(int id)
        {
            return restaurants.SingleOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
        {
            return restaurants.Where(r => string.IsNullOrEmpty(name) || r.Name.StartsWith(name)).OrderBy(x => x.Name);
        }
    }
}