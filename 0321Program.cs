internal class Program
{

    private static void Main(string[] args)
    {
        // 3월 21일 수업


        /*
        // long자료형을 int 자료형으로 변환합니다.
        long longNumber = 2147483647L + 2147483647L;
        int longToInt = (int)longNumber;
        Console.WriteLine(longToInt);

        // double자료형을 int자료형으로 변환합니다.
        double doubleNumber = 52.27310332;
        int doubleToInt = (int)doubleNumber;
        Console.WriteLine(doubleToInt);


        Console.WriteLine(int.Parse("52"));
        Console.WriteLine(long.Parse("273"));
        Console.WriteLine(float.Parse("52.273"));
        Console.WriteLine(double.Parse("103.32"));
        Console.WriteLine(bool.Parse("TRUE"));

        Console.WriteLine(int.Parse("52").GetType());
        Console.WriteLine(long.Parse("273").GetType());
        Console.WriteLine(float.Parse("52.273").GetType());
        Console.WriteLine(double.Parse("103.32").GetType());
        Console.WriteLine(bool.Parse("TRUE").GetType());

        Console.WriteLine(52 + 273);
        Console.WriteLine("52" + 273);
        Console.WriteLine(52 + "273");
        Console.WriteLine("52" + "273");

        int number = 52273;
        string outputA = number + "!";
        Console.WriteLine(outputA);

        char character = 'a';
        string outputB = character + "?";
        Console.WriteLine(outputB);
        */


        Console.Write("첫 번째 숫자 입력 : ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("두 번째 숫자 입력 : ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
        Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
        Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
        Console.WriteLine(num1 + " / " + num2 + " = " + ((float)num1 / num2).ToString("0.00")); // 0.00대신 F2 집어넣어도됨.
        Console.WriteLine(num1 + " % " + num2 + " = " + (num1 % num2));

        // int Console.Read() : 한개의 문자만 리턴된다. 입력값이 abcde이던 aaaaa이던 제일 앞의 a만 리턴
        // 정수형 아스키코드로 리턴 ConvertToChar() 메소드를 사용하여 문자로 변환 Convert.ToChar(65)는 'A'를 반환


    }



}
