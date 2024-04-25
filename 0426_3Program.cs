internal class Program
{
    class Cal
    {
        private int num1;
        private int num2;
        private char op;

        public Cal(int num1, int num2, char op)
        {
            Num1 = num1;
            Num2 = num2;
            Op = op;
        }

        public int Num1
        {
            get { return num1; }
            set { num1 = value; }
        }

        public int Num2
        {
            get { return num2; }
            set { num2 = value; }
        }

        public char Op
        {
            get { return op; }
            set { op = value; }
        }

        public int Calcul()
        {


            if (this.op == '+')
            {
                return this.num1 + this.num2;
            }

            else if (this.op == '-')
            {
                return this.num1 - this.num2;
            }

            else if (this.op == '*')
            {
                return this.num1 - this.num2;
            }

            else if (this.op == '/')
            {
                if (num2 == 0)
                {
                    Console.WriteLine("0으로 나눌수 없습니다");
                    return 0;
                }
                else
                {
                    return num1 / num2;
                }
            }

            else
            {
                Console.WriteLine("연산자를 잘못입력하셨습니다.");
                return 0;
            }
        }

    }
    private static void Main(string[] args)
    {
        Cal cal = new Cal(2, 3, '-');

        Console.Write("첫번째 숫자를 입력하시오 : ");
        cal.Num1 = int.Parse(Console.ReadLine());

        Console.Write("두번째 숫자를 입력하시오 : ");
        cal.Num2 = int.Parse(Console.ReadLine());

        Console.Write("연산자를 입력하시오 : ");
        cal.Op = char.Parse(Console.ReadLine());

        Console.WriteLine($"입력하신 수식의 값은 : {cal.Calcul()}");



    }
}