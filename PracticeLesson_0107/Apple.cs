using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLesson_0107
{
    class Apple : Fruit
    {
        public string _color;
        public bool _pinkLady = true;
        public override bool IsThisMyFavorite()
        {
            return _pinkLady;
        }

        public override string ToString()
        {
            return $"{base.ToString()} {_color} {_pinkLady}";
        }
    }
}
