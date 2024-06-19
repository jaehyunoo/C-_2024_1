internal class Program
{
    abstract class Shape
    {
        public abstract double CalculateArea();
        public void Display()
        {
            Console.WriteLine("This is Shape");
        }
    }

    class Circle : Shape
    {
        private int r;
        
        public int R
        {
            get { return r; }
            set 
            {
                while (true)
                {
                    if (value <= 0)
                    {
                        Console.Write("반지름을 자연수로 다시 입력해주세요 : ");
                        value = int.Parse(Console.ReadLine());
                    }

                    else
                    {
                        r = value;
                        break;
                    }
                }
            }
        }
        
        public Circle (int r)
        {
            R = r;
        }
        public override double CalculateArea()
        {
           return Math.PI * r * r;
        }



    }

    class Rectangle : Shape
    {
        private int num1;
        private int num2;
        public int Num1
        {
            get { return num1; }
            set
            {
                while (true)
                {
                    if (value <= 0)
                    {
                        Console.Write("밑변을 자연수로 다시 입력해주세요 : ");
                        value = int.Parse(Console.ReadLine());
                    }

                    else
                    {
                        num1 = value;
                        break;
                    }
                }
            }
        }
        public int Num2
        {
            get { return num2; }
            set
            {
                while (true)
                {
                    if (value <= 0)
                    {
                        Console.Write("높이를 자연수로 다시 입력하시오 : ");
                        value = int.Parse(Console.ReadLine());
                    }

                    else
                    {
                        num2 = value;
                        break;
                    }
                }
            }
        }

        public Rectangle(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }
        public override double CalculateArea()
        {
            return num1 * num2;
        }
    }

    private static void Main(string[] args)
    {
        Console.Write("반지름을 입력하시오 : ");
        Circle circle = new Circle(int.Parse(Console.ReadLine()));
        Console.Write("밑변을 입력하시오 : ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("높이를 입력하시오 : ");
        int num2 = int.Parse(Console.ReadLine());
        Rectangle rectangle = new Rectangle(num1, num2);

        circle.Display();
        Console.WriteLine($"Circle Area : {circle.CalculateArea().ToString("0.00")}");
        rectangle.Display();
        Console.WriteLine($"Rectangle Area : {rectangle.CalculateArea()}");



    }
}