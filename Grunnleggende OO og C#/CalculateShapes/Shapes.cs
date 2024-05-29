namespace CalculateShapes
{
    internal class Shapes
    {
        private readonly List<Shape> _shape;

        public Shapes()
        {
            _shape = new List<Shape>();
        }

        public Shape AddShape(string name, int width, int height)
        {
            var shape = new Shape(name, width, height);
            _shape.Add(shape);
            return shape;
        }
    }
}
