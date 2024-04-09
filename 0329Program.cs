internal class Program
{
    private static void Main(string[] args)
    {
        // 3월 29일 첫번째 수업

        // for문 (초기값;조건식;증감식)
        // while 문은 초기값은 while문 시작전 위에 선언하고 증감식은 while문 안에 작성한다.
        
        int i = 0;
        int[] intArray = new int[5];

        // i가 5보다 작을때 까지 반복
        while (i < 5) // for문은 for(int i =0; i < intArray.Length; i++)
        {
            Console.Write($"{i+1}번째 숫자를 입력하시오 : ");
            intArray[i] = int.Parse(Console.ReadLine());
            i++;
        }

        for(i = 0; i < intArray.Length; i++) // while문은 while(i < intArray.Length)
        {
            Console.WriteLine($"배열의 인덱스 {i}번째 숫자는{intArray[i]}");
        }


        string input;
        do
        {
            Console.Write("입력(exit를 입력하면 종료) : ");
            input = Console.ReadLine();
        }while (input != "exit"); // exit가 아닐때 까지 반복
        


        /*
        int[] a = new int[2];
        Console.Write("첫 번째 글자를 입력하시오 : ");
        a[0] = char.Parse(Console.ReadLine());
        Console.Write("두 번째 글자를 입력하시오 : ");
        a[1] = char.Parse(Console.ReadLine());
        */

        Console.Write("첫 번째 글자를 입력하시오 : ");
        int han1 = char.Parse(Console.ReadLine());
        Console.Write("두 번째 글자를 입력하시오 : ");
        int han2 = char.Parse(Console.ReadLine());

        for (i = han1; i <= han2;  i++)
        {

            Console.WriteLine($"{(char)i, 3}");
        }
        
    }
}