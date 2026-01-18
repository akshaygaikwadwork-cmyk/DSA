using Basic_Logical_Programs.Basic;

namespace Basic_Logical_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nEnter a number :\n");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n------- Even or Odd Number -------\n");
            CheckEvenOdd.CheckEvenOddNumber(input);

            Console.WriteLine("\n------- Multiplication of Table ---------\n");
            MultiplicationTable.PrintMultiplicationTable(input);
        }
    }
}
