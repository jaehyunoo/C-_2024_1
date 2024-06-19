internal class Program
{
    private static void Main(string[] args)
    {
        using (StreamReader r = new StreamReader(@"C:\Users\82105\Desktop\2024 1학기\test.txt"))
        {
            string line;

            while ((line = r.ReadLine()) != null)
            {
                
                if (line.Equals("반복문 : 1"))
                    Console.WriteLine(line);
                if (line.Equals("반복문 : 2"))
                    Console.WriteLine(line);
                if (line.Equals("반복문 : 3"))
                    Console.WriteLine(line);
                if (line.Equals("반복문 : 4"))
                    Console.WriteLine(line);
                if (line.Equals("반복문 : 5"))
                    Console.WriteLine(line);
            }
        }

    }
}