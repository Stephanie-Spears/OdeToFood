using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using OdeToFood.Data.Models;

namespace OdeToFood.Data.Services
{
	// This is the gateway to the database, we can configure which database we want to point to by adding a connection string in web.config
	public class OdeToFoodDbContext :DbContext
	{
		public DbSet<Restaurant> Restaurants { get; set; }
	}
}
