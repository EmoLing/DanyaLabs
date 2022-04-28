namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = 0;

            Console.WriteLine("Введите длину окружности:");
            while (!double.TryParse(Console.ReadLine(), out length))
                Console.WriteLine("Длина окружности задается числом!\r\nВведите длину окружности:");

            var circle = new Cicrle() { Length = length };
            Console.WriteLine($"Площадь круга, ограниченного этой окружностью: {circle.GetAreaCircleBoundedThisCircle()}");
        }
    }

    public class Cicrle
    {
        public double Length { get; set; }

        public double Radius => Length / 2 * Math.PI;

        public double GetAreaCircleBoundedThisCircle() => Math.PI * Math.Pow(Radius, 2);
    }
}