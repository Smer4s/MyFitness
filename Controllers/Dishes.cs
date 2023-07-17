using MyFitness.Data;
using MyFitness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFitness.Controllers
{
    public class Dishes
    {
        public Dishes(IDataBase dataBase)
        {
            this.dishes = dataBase.ReadDishes();
        }
        List<Dish> dishes { get; set; }
    }
}
