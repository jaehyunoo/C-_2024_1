using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        // 3월 28일 첫번째 수업


        // if elseif 문을 switch문으로 바꾸는 연습하기. 반대로 switch문도 if else if 문으로 바꾸는 연습하기 100프로 바꿀 수 있음.
        /*
        while (true)
        {
            Console.Write("이번 달은 몇 월인가요 ? : ");
            int input = int.Parse(Console.ReadLine());


            if (input == 12 || input == 1 || input == 2)
            {
                Console.WriteLine("겨울입니다");
            }
            else if (input == 3 || input == 4 || input == 5)
            {
                Console.WriteLine("봄입니다");
            }
            else if (input == 6 || input == 7 || input == 8)
            {
                Console.WriteLine("여름입니다");
            }
            else if (input == 9 || input == 10 || input == 11)
            {
                Console.WriteLine("가을입니다");
            }
            else
            {
                Console.WriteLine("입력한 달은 존재하지않습니다");
                break;
            }
        }
        */


        Console.Write("점수를 입력하시오 : ");
        int score = int.Parse(Console.ReadLine());


        switch (score / 10) {
            case 9: case 10:
                Console.WriteLine("A학점");
                break;

            case 8:
                Console.WriteLine("B학점");
                break;
            case 7:
                Console.WriteLine("C학점");
                break;
            case 6:
                Console.WriteLine("D학점");
                break;
            default:
                Console.WriteLine("재수강으로 분발하세요");
                break;
        }


        Console.Write("숫자하나 연산자하나 숫자하나를 순서대로 입력하시오 : ");
        int num1 = int.Parse(Console.ReadLine());
        string op = Console.ReadLine();
        int num2 = int.Parse(Console.ReadLine());
        double result = 0;

        switch (op)
        {
            case "+":
                result = num1 + num2;
                Console.WriteLine($"{num1} {op} {num2} = {result}");
                break;
            case "-":
                result = num1 - num2;
                Console.WriteLine("{0} {1} {2} = {3}", num1, op, num2, result);
                break;
            case "*":
                result = num1 * num2;
                Console.WriteLine("{0} {1} {2} = {3}", num1, op, num2, result);
                break;
            case "/":
                result = (float)num1 / num2;
                Console.WriteLine("{0} {1} {2} = {3}", num1, op, num2, result.ToString("0.00"));
                Console.WriteLine("{0} {1} {2} = {3:F3}", num1, op, num2, result);
                Console.WriteLine($"{num1} {op} {num2} = {result:F3}");
                break;
            case "%":
                result = num1 % num2;
                Console.WriteLine("{0} {1} {2} = {3}", num1, op, num2, result);
                break;
        }
    }
}