using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLesson_0107
{
    abstract class Fruit
    {
        public string _name;
        public int _calories;

        public abstract bool IsThisMyFavorite();

        public override string ToString()
        {
            return $"{base.ToString()}\n Fruit name: {_name} Calories: {_calories}";
        }
    }
}
