namespace WorkingWithFiles
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the file path");
            var path = Console.ReadLine() ?? "";
            Console.WriteLine("Enter new file path");
            string newPath = Console.ReadLine() ?? "";
            try
            {
                var text = ReadFile(path);
                text = ReverseString(text);

                File.WriteAllText(newPath, text);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
            catch (Exception)
            {
                Console.WriteLine("Path is not correct");
            }
            finally
            {
                Console.WriteLine("The file operation is attempted.");
            }
        }

        public static string ReverseString(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }

            return reverse;
        }

        public static string ReadFile(string path)
        {
            string? line;
            if (path == null)
            {
                throw new Exception();
            }

            if (!File.Exists(path))
            {
                throw new FileNotFoundException();
            }
            line = File.ReadAllText(path);
            return line;
        }
    }
}