using MyCheckString;
using MyFio;
using MyGeometry;
namespace Dynamic_Link_Library_29._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "MyWorld";
            Console.WriteLine($"Площадь треугольника {GeometryCalc.RectangleArea(4,6)}");
            Console.WriteLine(TextCheck.ToPalindrom(text));
            Console.WriteLine(FioCheck.ValidAge("13"));
        }
    }
}
