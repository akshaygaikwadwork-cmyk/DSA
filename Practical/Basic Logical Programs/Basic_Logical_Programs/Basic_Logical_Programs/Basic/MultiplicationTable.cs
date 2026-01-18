namespace Basic_Logical_Programs.Basic
{
    internal class MultiplicationTable
    {
        public static void PrintMultiplicationTable(int input)
        {
            Console.WriteLine("\n---First way : With Iterative/Loop-----\n");
            
            Console.WriteLine($"\nMultiplication Table of {input} is:\n");
            for (int i=1; i<=10; i++)
            {
                Console.WriteLine($"{input} * {i} = {input * i}"); 
            }

            Console.WriteLine("\n---Second way : With Recursion-----\n");

            Console.WriteLine($"\nMultiplication Table of {input} is:\n");
            PrintTableRecursively(input, 1);
        }
        private static void PrintTableRecursively(int input, int multiplier)
        {
            if (multiplier > 10)
            {
                return;
            }
            Console.WriteLine($"{input} * {multiplier} = {input * multiplier}");
            PrintTableRecursively(input, multiplier + 1);
        }
    }
}
