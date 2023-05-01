namespace primary_constructors
{
    public abstract class Figure(double x, double y)
    {
        public double X { get; } = x;
        public double Y { get; } = y;
    }

    public class Rectangle(double x, double y, double width, double height) : Figure(x, y)
    {
        public double Width { get; } = width;
        public double Height { get; } = height;
    }

    public class Circle(double x, double y, double radius) : Figure(x, y)
    {
        public double Radius { get; } = radius;
    }

}
//https://github.com/dotnet/csharplang/issues/7047
//https://github.com/dotnet/docs/issues/34529