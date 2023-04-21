namespace MindBoxTestFromHH.Figures
{
    internal class Circle : IFigure
    {
        private readonly int _r;

        public Circle(int r)
        {
            _r = r;
        }

        public double GetSquare()
        {
            var square = Math.PI * Math.Pow(_r, 2);
            return square;
        }

    }
}
