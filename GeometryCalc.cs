namespace MyGeometry
{
    public static class GeometryCalc
    {
        public static double SquareArea(double x)
        {
            return x * x;
        }
        public static double RectangleArea(double w, double h)
        {
            return w * h;
        }
        public static double TriangleArea(double a, double h)
        {
            return 0.5 * a * h;
        }
    }
}
