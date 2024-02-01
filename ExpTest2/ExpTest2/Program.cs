namespace ExpTest2
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the file path");
            string path = Console.ReadLine() ?? "";

            try
            {
                ReadFile(path);
            }
            catch (Exception e)
            {
                if (e is FileNotFoundException fileNotFoundException)
                {
                    Console.WriteLine("File not found");
                }

                if (e is DirectoryNotFoundException directoryNotFoundException)
                {
                    Console.WriteLine("Directory not found");
                }
                else
                {
                    Console.WriteLine("Path is not correct");
                }
            }
            finally 
            {
                Console.WriteLine("The file operation is attempted.");
            }


        }

        public static void ReadFile (string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new Exception();
            }

            if (!File.Exists(path))
            {
                throw new FileNotFoundException();
            }

            StreamReader sr = new StreamReader(path);
            var line = sr.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }
            sr.Close();
        }

    }
}