internal class Program
{
    class Circle
    {
        public double pi = 3.14;
        public int r;

        public double GetArea()
        {
            return this.r * this.r * pi;
        }

        public int R
        {
            get { return this.r; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("양수를 입력해 주세요");
                }
                else
                {
                    this.r = value;
                }

            }
        }


    }
    private static void Main(string[] args)
    {
        Circle circle = new Circle();

        Console.Write("숫자를 입력해 주세요 : ");
        circle.r = int.Parse(Console.ReadLine());

        Console.WriteLine($"원의 넓이는 {circle.GetArea()}");


    }
}