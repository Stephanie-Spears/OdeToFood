using OdeToFood.Data.Models;

using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
	public class InMemoryRestaurantData : IRestaurantData
	{
		List<Restaurant> restaurants;

		public InMemoryRestaurantData()
		{
			restaurants = new List<Restaurant>()
			{
				new Restaurant {Id = 1, Name = "Rovente's Pizza", Cuisine = CuisineType.Italian},
				new Restaurant {Id = 2, Name = "Le Pigeon", Cuisine = CuisineType.French},
				new Restaurant {Id = 3, Name = "Bollywood Theater", Cuisine = CuisineType.Indian}
			};
		}

		public void Add(Restaurant restaurant)
		{
			restaurants.Add(restaurant);
			restaurant.Id = restaurants.Max(r => r.Id) + 1;
		}

		public void Update(Restaurant restaurant)
		{
			var existing = Get(restaurant.Id);
			if (existing != null)
			{
				existing.Name = restaurant.Name;
				existing.Cuisine = restaurant.Cuisine;
			}
		}

		public void Delete(int id)
		{
			var restaurant = Get(id);
			if (restaurant != null)
			{
				restaurants.Remove(restaurant);
			}
		}

		public Restaurant Get(int id)
		{
			return restaurants.FirstOrDefault(r => r.Id == id);
		}

		public IEnumerable<Restaurant> GetAll()
		{
			//Using LINQ OrderBy, given a restaurant r, order by restaurant name in ascending order
			return restaurants.OrderBy(r => r.Name);
		}


	}
}