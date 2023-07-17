using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFitness.Models
{
    internal class DayOfWeek : INotifyPropertyChanged
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Dish> Dishes { get; set; }

        public int TotalCalories { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
