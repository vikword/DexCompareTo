using System;

//Реализуйте класс произвольной фигуры (треугольник, квадрат, круг),
//определите CompareTo<T>, сравнение производим по площади фигуры

namespace DexCompareTo
{
    class Triangle : IComparable<Triangle>
    {
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
            {
                throw new IsNotTriangleException("Попытка создания треугольника со стороной <= 0");
            }

            if (firstSide + secondSide <= thirdSide
                || firstSide + thirdSide <= secondSide
                || secondSide + thirdSide <= firstSide)
            {
                throw new IsNotTriangleException("Одна из сторон больше, чем сумма двух других");
            }

            this._firstSide = firstSide;
            this._secondSide = secondSide;
            this._thirdSide = thirdSide;
        }

        public double СalcPerimeter()
        {
            return _firstSide + _secondSide + _thirdSide;
        }

        override public string ToString()
        {
            return $"Треугольник со сторонами {_firstSide}, {_secondSide} и {_thirdSide}";
        }

        public int CompareTo(Triangle obj)
        {
            if (obj != null && this != null)
            {
                if (this.СalcPerimeter() < obj.СalcPerimeter())
                {
                    return -1;
                }
                else if (this.СalcPerimeter() > obj.СalcPerimeter())
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new ArgumentNullException("Эллемент должен содержать значение.");
            }
        }
    }
}
