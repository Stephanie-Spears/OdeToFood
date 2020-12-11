using OdeToFood.Data.Models;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Services
{
	//add public to use this interface outside the odeToFood.Data Project
	public interface IRestaurantData
	{
		IEnumerable<Restaurant> GetAll();
	}
}