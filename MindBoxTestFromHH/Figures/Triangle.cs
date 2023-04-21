namespace MindBoxTestFromHH.Figures
{
    internal class Triangle : IFigure
    {
        private readonly int _side1, _side2, _side3;


        public Triangle(int side1, int side2, int side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }
        public double GetSquare()
        {
            double halfP = (_side1 + _side2 + _side3) / 2f;
            double square = Math.Sqrt(halfP*(halfP-_side1)*(halfP-_side2)*(halfP-_side3));
            return square;
        }

        public void GetType()
        {
            if ((Math.Pow(_side1, 2) + Math.Pow(_side2, 2) == Math.Pow(_side3, 2)) ||
                (Math.Pow(_side1, 2) + Math.Pow(_side3, 2) == Math.Pow(_side2, 2)) ||
                (Math.Pow(_side3, 2) + Math.Pow(_side2, 2) == Math.Pow(_side1, 2)))
            {
                Console.WriteLine("Треугольник прямоугольный");
            }
            else
            {
                Console.WriteLine("Треугольник не прямоугольный");
            }
        }
    }
}
