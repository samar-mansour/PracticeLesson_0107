using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLesson_0107
{
    class Program
    {
        static void PrintColor(Apple apple)
        {
            Console.WriteLine(apple._color); 
        }

        static void BananaSize(Banana banana)
        {
            Console.WriteLine(banana._size);
        }

        static void PrintCalories(FruitSalad saladCalories)
        {
            Console.WriteLine(saladCalories.GetToatalCalories()); 
        }

        static void PrintFavorite(FruitSalad fav)
        {
            for (int i = 0; i < fav._fruits.Length; i++)
            {
                if (fav.ContainsMyFavoriteFruit())
                {
                    Console.WriteLine(fav._fruits[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            FruitSalad fruitSalad = new FruitSalad()
            {
                _fruits = new Fruit[]
                {
                    new Apple
                    {
                        _name = "Granny Smith",
                        _color = "Green",
                        _calories = 58,
                        _pinkLady = false
                    },
                    new Coconut
                    {
                        _name = "Green Coconut",
                        _calories = 36,
                        _waterInIt = 0.5f
                    },
                    new Pineapple
                    {
                        _name = "Red Spanish Pinapple",
                        _calories = 82,
                        _price = 40
                    },
                    new Banana
                    {
                        _name = "Banana",
                        _calories = 30,
                        _size = 14.9f,
                        _IsGreen = true
                    }
                }
            };

            Apple a = new Apple()
            {
                _name = "Granny Smith",
                _color = "Green",
                _calories = 58,
                _pinkLady = false
            };

            Banana b = new Banana
            {
                _name = "Banana",
                _calories = 45,
                _size = 17.9f,
                _IsGreen = true
            };

            Console.WriteLine("============Apple Color=============");
            PrintColor(a);
            Console.WriteLine("============Banana Size=============");
            BananaSize(b);

            Console.WriteLine("============Fruit Salad Calories=============");
            PrintCalories(fruitSalad);
            Console.WriteLine("============Fruit Salad Favorite=============");
            PrintFavorite(fruitSalad);
        }
    }
}
