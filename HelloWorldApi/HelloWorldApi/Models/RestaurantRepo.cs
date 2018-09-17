using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorldApi.Models
{
    public class RestaurantRepo
    {
        static List<Restaurant> list = new List<Restaurant>
        {
            new Restaurant {Id=1, Title="Mogli", City="Mumbai", Rank=5 },
            new Restaurant {Id=2, Title="Haldirams", City="Noida", Rank=5 },
            new Restaurant {Id=3, Title="Pind Baluchi", City="Bangluru", Rank=5 }
        };
        public IEnumerable<Restaurant> GetAllRestaurant()
        {
            return list;
        }
        public Restaurant GetById(int id)
        {
            var res = list.Find(x => x.Id == id);
            return res;
        }
        public void AddRestaurant(Restaurant rest)
        {
            var maxID= list.Max(x => x.Id);
            rest.Id = maxID + 1;
            list.Add(rest);
        }
        public void RemoveRestaurantById(int id)
        {
            var res = GetById(id);
            if (res!=null)
            {
                list.Remove(res);
            }
        }
        public void EditRestaurant(int id, Restaurant rest)
        {
            var res = GetById(id);
            if (res != null)
            {
                res.Title = rest.Title;
                res.Rank = rest.Rank;
                res.City = rest.City;
            }
        }
    }
}