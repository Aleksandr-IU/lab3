using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Lab3
{
    class Square : Rectangle, IPrint
    {
        public Square(double yourlength)
        {
            _length1 = _length2 = yourlength;
        }
        public override string ToString()
        {
            return "Сторона квадрата: " + _length1.ToString() + "; Площадь: " + area.ToString() + ";";
        }
    }
}