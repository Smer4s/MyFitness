using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyFitness.Models
{
    public enum DishType { Breakfast, Lunch, Dinner }

    public class Dish : INotifyPropertyChanged
    {
        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                    OnPropertyChanged();
                }
            }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }

        private byte[] picture;
        public byte[] Picture
        {
            get { return picture; }
            set
            {
                if (picture != value)
                {
                    picture = value;
                    OnPropertyChanged();
                }
            }
        }

        private List<string> ingredients;
        public List<string> Ingredients
        {
            get { return ingredients; }
            set
            {
                if (ingredients != value)
                {
                    ingredients = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Calories));
                }
            }
        }

        private int calories;
        public int Calories
        {
            get { return calories; }
            set
            {
                if (calories != value)
                {
                    calories = value;
                    OnPropertyChanged();
                }
            }
        }

        private DishType dishType;
        public DishType DishType
        {
            get { return dishType; }
            set
            {
                if (dishType != value)
                {
                    dishType = value;
                    OnPropertyChanged();
                }
            }
        }

        public Dish(int id, string name, byte[] picture, List<string> ingredients, int calories, DishType dishType)
        {
            Id = id;
            Name = name;
            Picture = picture;
            Ingredients = ingredients;
            Calories = calories;
            DishType = dishType;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
