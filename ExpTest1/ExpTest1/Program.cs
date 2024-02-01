namespace ExpTest1
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter first numver");
            float num1 = float.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("Enter second numver");
            float num2 = float.Parse(Console.ReadLine() ?? "");

            try
            {
                Console.WriteLine(Divide(num1, num2));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You can't divide by Zero!");
            }
            finally
            {
                Console.WriteLine("Operation is complete.");
            }

        }

        public static float Divide(float num1, float num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException();
            }
            return num1/num2;
        }

    }
}