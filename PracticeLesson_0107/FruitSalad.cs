using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLesson_0107
{
    class FruitSalad
    {
        public Fruit[] _fruits;

        public int GetToatalCalories()
        {
            int sum = 0;
            for (int i = 0; i < _fruits.Length; i++)
            {
                sum = sum + _fruits[i]._calories;
            }
            return sum;
        }

        public bool ContainsMyFavoriteFruit()
        {
            for (int i = 0; i < _fruits.Length; i++)
            {
                if (_fruits[i].IsThisMyFavorite())
                    return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"{base.ToString()} {ContainsMyFavoriteFruit()} {GetToatalCalories()}";
        }
    }
}
