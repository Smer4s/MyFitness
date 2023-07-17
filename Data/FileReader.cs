using MyFitness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFitness.Data
{
    class FileReader : IDataBase
    {
        public void DeleteDish()
        {
            throw new NotImplementedException();
        }

        public List<Dish> ReadDishes()
        {
            List<Dish> dishes = new()
            {
                new Dish(1, "Lasania", null, new List<string>(), 200, DishType.Breakfast)
            };
            return dishes;
        }

        public void UpdateDish()
        {
            throw new NotImplementedException();
        }

        public void WriteDish()
        {
            throw new NotImplementedException();
        }
    }
}
