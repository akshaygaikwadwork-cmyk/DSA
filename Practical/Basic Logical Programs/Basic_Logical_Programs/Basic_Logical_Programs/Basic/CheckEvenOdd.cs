namespace Basic_Logical_Programs.Basic
{
    internal class CheckEvenOdd
    {
        public static void CheckEvenOddNumber(int input)
        {
            Console.WriteLine("\n--First Way : With Arithmetic operator---\n");

            if (input % 2 == 0)
            {
                Console.WriteLine($"\nEntered number {input} is even\n");
            }
            else
            {
                Console.WriteLine($"\nEntered number {input} is odd\n");
            }

            Console.WriteLine("\n--Second Way : With Bitwise operator---\n");

            if ((input & 1) == 0)
            {
                Console.WriteLine($"\nEntered number {input} is even\n");
            }
            else
            {
                Console.WriteLine($"\nEntered number {input} is odd\n");
            }
        }
    }
}
