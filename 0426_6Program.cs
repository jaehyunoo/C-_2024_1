internal class Program
{
    class Box
    {
        private int num1;
        private int num2;

        public Box(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }


        public int Plus()
        {
            return num1 + num2;
        }
        public int Minus()
        {
            return num1 - num2;
        }
        public double Divide()
        {
            if (num2 == 0) 
                return 0;
            return num1 / (double)num2;

        }

        public int Mul()
        {
            return num1 * num2;
        }

        public int Num1
        {
            get { return num1; }

            set
            {

                num1 = value;

            }
        }


        public int Num2
        {
            get { return num2; }

            set
            {

                num2 = value;

            }
        }
        private static void Main(string[] args)
        {
            Box box = new Box(2, 3);
            Console.Write("첫번째 숫자를 입력하시오 : ");
            box.Num1 = int.Parse(Console.ReadLine());
            Console.Write("두번째 숫자를 입력하시오 : ");
            box.Num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(box.Plus());
            Console.WriteLine(box.Minus());
            Console.WriteLine(box.Divide().ToString("0.00"));
            Console.WriteLine(box.Mul());


        }
    }
}