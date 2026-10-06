namespace OddEvenNumbersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            PrintNumbers("Numbers", numbers);
            PrintNumbers("Even Number", numbers.Where(x => IsEven(x)));
            PrintNumbers("Odd Numbers", numbers.Where(x => IsOdd(x)));
        }

        static void PrintNumbers (string title, IEnumerable<int> numbers)
        {
            Console.Write($"{title}: [");

            foreach (var number in numbers)
            {
                Console.Write($" {number}");
            }

            Console.WriteLine($" ]");
            Console.WriteLine();
        }

        static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsOdd(int number)
        {
            if (number % 2 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}