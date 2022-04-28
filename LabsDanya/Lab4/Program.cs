namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var apexA = new Apex()
            {
                CoordinateX = InputCoordinates("x", "A"),
                CoordinateY = InputCoordinates("y", "A")
            };

            var apexB = new Apex()
            {
                CoordinateX = InputCoordinates("x", "B"),
                CoordinateY = InputCoordinates("y", "B")
            };

            var apexC = new Apex()
            {
                CoordinateX = InputCoordinates("x", "C"),
                CoordinateY = InputCoordinates("y", "C")
            };

            var triangle = new Triangle();
            triangle.SetLength(apexA, apexB, nameof(triangle.Length1));
            triangle.SetLength(apexB, apexC, nameof(triangle.Length2));
            triangle.SetLength(apexC, apexA, nameof(triangle.Length3));

            Console.WriteLine($"Периметр треугольника:{triangle.GetPerimeter()}\r\n" +
                $"Площадь треугольника: {triangle.GetSquare()}");

            Console.ReadKey();
        }

        private static double InputCoordinates(string cordinate, string point)
        {
            double coordinatePoint = 0;
            Console.WriteLine($"Введите координаты вершины {point}:\r\nкоордината {cordinate} точки {point}:");
            while (!Double.TryParse(Console.ReadLine(), out coordinatePoint))
                Console.WriteLine($"Координаты задаются числами\r\nВведите координаты {cordinate} точки {point}:");

            return coordinatePoint;
        }
    }

    public class Apex
    {
        public double CoordinateX { get; set; }
        public double CoordinateY { get; set; }
    }

    public class Triangle
    {
        public double Length1 { get; private set; }
        public double Length2 { get; private set; }
        public double Length3 { get; private set; }

        public void SetLength(Apex apex1, Apex apex2, string property)
        {
            switch (property)
            {
                case "Length1":
                    Length1 = GetLength(apex1, apex2);
                    break;
                case "Length2":
                    Length2 = GetLength(apex1, apex2);
                    break;
                case "Length3":
                    Length3 = GetLength(apex1, apex2);
                    break;
                default: throw new Exception("Свойство не найдено");
            }
        }

        private double GetLength(Apex apex1, Apex apex2)
            => Math.Sqrt(Math.Pow(apex1.CoordinateY - apex2.CoordinateY, 2) + Math.Pow(apex1.CoordinateX - apex2.CoordinateX, 2));

        public double GetPerimeter() => Length1 + Length2 + Length3;
        public double GetSquare()
        {
            if (!CanCalculateSquare())
                throw new Exception("По заданным координатам нельзя вычислить площадь");

            return 0.25 * Math.Sqrt((Length1 + Length2 + Length3)
                * (Length2 + Length3 - Length1)
                * (Length1 + Length3 - Length2)
                * (Length1 + Length2 - Length3));
        }

        public bool CanCalculateSquare()
            => (Length2 + Length3 - Length1) > 0 && (Length1 + Length3 - Length2) > 0
            && (Length1 + Length3 - Length2) > 0;
    }
}