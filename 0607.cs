internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("입력 : ");
        string input = Console.ReadLine();

        try
        {
            int index = int.Parse(input);
            Console.WriteLine("입력숫자 : " + index);
        }
        catch(Exception ex) // Exception 클래스의 인스턴스로 예외 객체라고 부릅니다. // var은 사용불가.
        {
            Console.WriteLine("예외가 발생했습니다");
            Console.WriteLine(ex.GetType());
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
            // return; return키워드만났을때 finally구문이 실행이안됨
            // catch구문내부에서 return 만날때
            // catch 구문 내부에서 try catch를 사용했는데 break나 continue를 만났을 때 finally가 실행이되지않음
        }
        finally
        {
            Console.WriteLine("프로그램이 종료되었습니다");
        }
    }
}