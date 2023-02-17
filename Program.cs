internal class Program
{
    private static void Main(string[] args)
    {
        {
            Console.WriteLine("Введите положительный х меньше 1(0,1; 0,2 ...)");
            double x = Convert.ToDouble(Console.ReadLine()); 
            while (Math.Abs(x) > 1)
            {
                Console.WriteLine("Введите положительный х меньше 1");
                x = Convert.ToDouble(Console.ReadLine());
            }
            double j = x;


            Console.WriteLine("Введите целочисленный n больше 0(1, 2 ...)");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n < 1)
            {
                Console.WriteLine("Введите целочисленный n больше 0");
                n = Convert.ToInt32(Console.ReadLine());
            }

            int b = 1;
            while (b < n + 1)
            {
                j += chislitel(b) * Math.Pow(x, 2 * b + 1) / (znamenatel(b) * (2 * b + 1));
                b++;
            }
            Console.WriteLine("Результат: " + ((3.14/2)-j));
        }
    }
    public static int chislitel(int b)
    {
        int ch = 1;
        while (b != 0)
        {
            ch *= 2 * b - 1;
            b -= 1;
        }
        return ch;
    }

    public static int znamenatel(int b)
    {
        int ch1 = 1;
        while (b != 0)
        {
            ch1 *= 2 * b;
            b -= 1;
        }
        return ch1;
    }
}
