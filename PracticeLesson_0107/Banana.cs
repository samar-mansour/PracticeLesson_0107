using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLesson_0107
{
    class Banana : Fruit
    {
        public bool _hasBlackSpots;
        public bool _IsGreen;
        public float _size;

        public override bool IsThisMyFavorite()
        {
            return false;
        }

        public override string ToString()
        {
            return $"{base.ToString()} {_hasBlackSpots} {_IsGreen} {_size}";
        }
    }
}
