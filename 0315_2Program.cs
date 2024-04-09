internal class Program
{
    private static void Main(string[] args)
    {
        // 2024 / 3 / 15 / 금 / 2번째 수업
        // 논리 부정 연산자 = ! , 논리합 연산자 = || , 논리곱 연산자 = &&

        Console.WriteLine("현재 Hour : " + DateTime.Now.Hour);
        Console.WriteLine(DateTime.Now.Hour < 3 || 8 < DateTime.Now.Hour);
        Console.WriteLine(3 < DateTime.Now.Hour && DateTime.Now.Hour < 8);

        // int = 4바이트 정수 , long = 8바이트 정수
        // 부호가없는 정수 = uint = usigned int = (2 ** 32) -1 , int = (-2 ** 31) ~ (2 ** 31) -1

        // 오버플로우 : int 자료형의 범위를 넘는 현상 , 언더플로우 : 범위내의 음수중 가장낮은 숫자보다 낮을 경우
        // ex
        int a = -2147483648;
        int b = -1;

        Console.WriteLine((a + b) + "\n");

        Console.WriteLine("int자료형의 최대값 최소값 출력");
        // int 자료형의 최대값 최소값
        Console.WriteLine("최대 값 : " + int.MaxValue);
        Console.WriteLine("최소 값 : " + int.MinValue + "\n");
        Console.WriteLine("long자료형의 최대값 최소값 출력");
        // long 자료형의 최대값 최소값
        Console.WriteLine("최대 값 : " + long.MaxValue);
        Console.WriteLine("최소 값 : " + long.MinValue + "\n");

        int 한글변수;
        한글변수 = 2;
        Console.WriteLine(한글변수 + "\n");

        // 강제로 자료형을 바꾸는법 = 캐스트연산 => (바꾸자하는자료형)값
        int x = 10, y = 6;
        Console.WriteLine(x + " + " + y + " = "+ (x + y));
        Console.WriteLine(x + " - " + y + " = " + (x - y));
        Console.WriteLine(x + " * " + y + " = " + (x * y));
        Console.WriteLine(x + " / " + y + " = " + ((float)x / y));
        Console.WriteLine(x + " % " + y + " = " + (x % y));

        // char자료형에 문자뿐만 아니라 양의 정수도 가능함 => 아스키코드 때문
        // C에서는 한글 출력이 안되는데 C#에서는 가능함 왜냐하면 char자료형의 크기는 C에서는 1바이트인데 C#,JAVA에서는 2바이트다
        char e = 'a';
        Console.WriteLine(e + "\n");

        char c = 'a', d = 'b';
        Console.WriteLine(c + d);
        Console.WriteLine(c - d);
        Console.WriteLine(c * d);
        Console.WriteLine(c / d);
        Console.WriteLine(c % d);
    }
}