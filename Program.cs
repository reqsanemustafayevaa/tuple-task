namespace tuple_task
{
   
      using System;

class Program
    {
        static Tuple<int, int> Sum(int[] numbers)
        {
            int sumOdd = 0;
            int sumEven = 0;

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    sumEven += num;
                }
                else
                {
                    sumOdd += num;
                }
            }

            return Tuple.Create(sumOdd, sumEven);
        }

        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var result = Sum(numbers);

            Console.WriteLine("tek ededlerin cemi: " + result.Item1);
            Console.WriteLine("cut ededlerin cemi: " + result.Item2);
        }
    }

}