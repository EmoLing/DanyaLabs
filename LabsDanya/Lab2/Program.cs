namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double resistance1, resistance2, resistance3 = 0;

            Console.WriteLine("Введите сопротивление R1:");
            while (!double.TryParse(Console.ReadLine(), out resistance1))
                Console.WriteLine("Сопротивление задается числом!\r\nВведите сопротивление R1:");

            Console.WriteLine("Введите сопротивление R2:");
            while (!double.TryParse(Console.ReadLine(), out resistance2))
                Console.WriteLine("Сопротивление задается числом!\r\nВведите сопротивление R2:");

            Console.WriteLine("Введите сопротивление R3:");
            while (!double.TryParse(Console.ReadLine(), out resistance3))
                Console.WriteLine("Сопротивление задается числом!\r\nВведите сопротивление R3:");

            Console.WriteLine($"Сопротивление соединения(1/R): {1 / resistance1 + 1 / resistance2 + 1 / resistance3}");
        }
    }
}