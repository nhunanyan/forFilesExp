namespace ExpTest3
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException()
        {
        }

        public InvalidAgeException(string message) : base(message)
        {
        }
    }

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (IsEnoughAge(age))
                {
                    Console.WriteLine("You can enter");
                }
                else
                {
                    Console.WriteLine("You can not enter");
                }
            }
            catch (InvalidAgeException)
            {
                Console.WriteLine("The age is not correct");
            }
            finally
            {
                Console.WriteLine("OK!");
            }
        }

        public static bool IsEnoughAge(int age)
        {
            if (age < 0 || age > 100)
            {
                throw new InvalidAgeException();
            }

            if (age < 18) return false;
            return true;
        }
    }
}