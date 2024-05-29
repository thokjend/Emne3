namespace CalculateShapes
{
    internal class Shape
    {
        private readonly string _name;
        private readonly int _width;
        private readonly int _height;

        public Shape(string name, int width, int height)
        {
            _name = name;
            _width = width;
            _height = height;
        }

        public int CalculateArea()
        {
            if (_name == "triangle")
            {
                return TriangleArea();
            }
            if (_name == "square")
            {
                return SquareArea();
            }

            return 0;
        }

        private int TriangleArea()
        {
            var area = (_width * _height) / 2;
            return area;
        }

        private int SquareArea()
        {
            var area = _width * _height;
            return area;
        }
    
    }
}
