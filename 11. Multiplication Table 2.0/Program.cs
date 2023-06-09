namespace _10._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());

            if (times > 10)
            {
                Console.WriteLine($"{num} X {times} = {num * times}");
                return;
            }

            while (times <= 10)
            {
                Console.WriteLine($"{num} X {times} = {num * times}");
                times++;
            }
        }
    }
}