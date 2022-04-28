namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину куба:");

            double edgeLength = 0;

            while (!double.TryParse(Console.ReadLine(), out edgeLength))
                Console.WriteLine("Длина куба задается числом!\r\nВведите длину куба:");

            var cube = new Cube() { EdgeLength = edgeLength };
            Console.WriteLine($"Объем куба: {cube.GetCubeVolume()}\r\n" +
                $"Площадь боковой поверхности куба: {cube.GetSideSurfaceArea()}");

            Console.ReadKey();
        }
    }

    public class Cube
    {
        public double EdgeLength { get; set; }

        public double GetCubeVolume() => Math.Pow(EdgeLength, 3);

        public double GetSideSurfaceArea() => 4 * Math.Pow(EdgeLength, 2);
    }
}