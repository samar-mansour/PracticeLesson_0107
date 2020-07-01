using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLesson_0107
{
    class Coconut : Fruit
    {
        public float _waterInIt;
        public override bool IsThisMyFavorite()
        {
            return true;
        }

        public override string ToString()
        {
            return $"{base.ToString()} {_waterInIt}";
        }
    }
}
