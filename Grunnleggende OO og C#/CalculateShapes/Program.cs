namespace CalculateShapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shape = new Shapes();
            var triangle = shape.AddShape("triangle", 10, 5);
            var square = shape.AddShape("square", 4, 4);

            var triangleArea = triangle.CalculateArea();
            var squareArea = square.CalculateArea();

            Console.WriteLine(triangleArea);
            Console.WriteLine(squareArea);
        }
    }
}
