internal class Program
{
    private static void Main(string[] args)
    {
        // 3월 22일 수업

        // int변수명 = Console.Read() : 한개의 문자만 리턴된다. 입력값이 abcde이던 aaaaa이던 제일 앞의 a만 리턴
        // 정수형 아스키코드로 리턴 ConvertToChar() 메소드를 사용하여 문자로 변환 Convert.ToChar(65)는 'A'를 반환
        /*
        Console.Write("한 문자 입력 : ");
        int a = Console.Read();

        Console.WriteLine("1. 연산 수행 전");
        Console.WriteLine("아스키코드 값 : " + a + "\n" + "변환된 문자 : " + Convert.ToChar(a)); 
        Console.WriteLine("\n2.연산 수행 후");
        Console.WriteLine("아스키코드 값 : " + (a + 5) + "\n" + "변환된 문자 : " + (char)(a+5));//ConvertTochar(변수명)도 가능


        Console.WriteLine("값 : {0}", a + 5);
        */
        /*
        Console.Write("나이 입력 : ");
        int age = int.Parse(Console.ReadLine());

        if (age < 9)
        {
            Console.WriteLine("입장 불가 !");
        }
        else
        {
            Console.Write("키 입력 : ");
            int height = int.Parse(Console.ReadLine());

            if (height >= 130)
            {
                Console.WriteLine("고속 롤러코스터 입장 가능");
            }
            else
            {
                Console.WriteLine("저속 롤러코스터 입장 가능");
            }
        }
        */
        /*
        Console.Write("2자리의 정수입력(10~99) : ");
        int num = int.Parse(Console.ReadLine());

        if (num < 10)
        {
            Console.WriteLine("10 ~ 99 사이의 정수만 입력하시오");
        }
        else
        {
            if ((num / 10) == (num % 10))
            {
                Console.WriteLine("Yes! 10의 자리와 1의자리가 같습니다.");
            }
            else
            {
                Console.WriteLine("No! 10의 자리와 1의 자리가 다릅니다.");
            }
        }
        */
        while (true)
        {
            Console.Write("정수 3개입력 : ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num1 == 0)
                break;

            if (num1 > num2)
            {
                if (num2 > num3)
                {
                    Console.WriteLine("중간값 : " + num2);
                }
                else
                {
                    if (num1 > num3)
                        Console.WriteLine("중간값 : " + num3);

                    else
                    {
                        Console.WriteLine("중간 값은 : " + num1);
                    }

                }
            }

            else {
                if (num2 > num3)
                {
                    if (num1 > num3)
                    {
                        Console.WriteLine("중간 값은 : " + num1);
                    }
                    else
                    {
                        Console.WriteLine("중간 값은 : " + num3);
                    }
                }
                else
                {
                    Console.WriteLine("중간 값은 : " + num2);
                }

            }
          
        }



    }
}