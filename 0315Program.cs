using System.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        // 2024 / 3 /14 / 목 / 첫 번째 수업

        // Line은 줄바꿈 Line을 적지않고 줄바꿈을 원할경우 출력할 문장에 \n 추가.
        Console.Write("Hello, World!\n");
        Console.WriteLine("Hello, World!");
        Console.WriteLine(-4 % 3); // 나머지 연산자의 부호는 왼쪽 피연산자의 부호를 따름  // 출력값 -1
        Console.WriteLine(-4 % -3);// 출력값 -1
        Console.WriteLine(4 % -3); // 출력값 1
        // 실수와 정수를 연산할 때 큰쪽을 따라간다. 실수냐 정수냐. 실수가 크면 답이 실수 정수가 크면 답이 정수.
        Console.WriteLine(4.0 + 3);
        Console.WriteLine("\"\"\""); // 큰따옴표 출력 역슬래시 "
        Console.WriteLine("한빛\t아카데미");// 탭으로 띄우기

        // 문자 선택 ( C#에만 있음)
        Console.WriteLine("안녕하세요"[0]); // 안출력
        Console.WriteLine("안녕하세요"[3]); // 세출력

        // 문자열("하")은 + 연산자로 연결 가능, 문자('이')는 불가능

    }
}