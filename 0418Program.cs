internal class Program
{

    // 오버로딩의 예

    class MyMath
    {
        public int Abs(int input)
        {
            if (input < 0)
            {
                return -input;
            }
            else
            {
                return input;
            }

        }

        public double Abs(double input)
        {
            if (input < 0)
            {
                return -input;
            }
            else
            {
                return input;
            }

        }

        public long Abs(long input)
        {
            if (input < 0)
            {
                return -input;
            }
            else
            {
                return input;
            }

        }
    }
    private static void Main(string[] args) 
    {

        MyMath math = new MyMath();

        //int
        Console.WriteLine(math.Abs(52));
        Console.WriteLine(math.Abs(-273));

        // double
        Console.WriteLine(math.Abs(52.273));
        Console.WriteLine(math.Abs(-32.103));

        // long
        Console.WriteLine(math.Abs(21474836470));
        Console.WriteLine(math.Abs(-21474836470));
    }
}