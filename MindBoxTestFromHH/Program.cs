using MindBoxTestFromHH.Figures;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите радиус круга: ");
        int r = Convert.ToInt32(Console.ReadLine());
        Circle circle = new Circle(r);
        double square = circle.GetSquare();
        Console.WriteLine("Площадь круга равна: " + square);

        Console.WriteLine("Введите через Enter по очереди стороны треугольника: ");
        int side1 = Convert.ToInt32(Console.ReadLine());
        int side2 = Convert.ToInt32(Console.ReadLine());
        int side3 = Convert.ToInt32(Console.ReadLine());

        Triangle triangle = new Triangle(side1, side2, side3);
        square = triangle.GetSquare();
        Console.WriteLine("Площадь треугольника равна: " + square);
        triangle.GetType();

        Console.ReadKey();
    }
}