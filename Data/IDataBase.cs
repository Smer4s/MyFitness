using MyFitness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFitness.Data
{
    public interface IDataBase
    {
        public List<Dish> ReadDishes();
        public void WriteDish();
        public void UpdateDish();
        public void DeleteDish();
    }
}
