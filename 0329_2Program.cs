internal class Program
{
    private static void Main(string[] args)
    {
          // 3월 29일 두번째 수업

        for (int i = 0; i < 10; i++)
        {
                for(int j = 0; j < 10 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }

            Console.Write("\n");
        }


        int x = 1;
        while (x < 50)
        {
            //화면을 지우고 커서를 이동합니다.
            Console.Clear();
            Console.SetCursorPosition(x, 5);

            switch (x % 3) {
                // 출력합니다.
                case 0:
                    Console.WriteLine("__@");
                    break;
                case 1:
                    Console.WriteLine("_^@");
                    break;
                default:
                    Console.WriteLine("^_@");
                        break;
        }

            Thread.Sleep(500); // 0.5초 정지
            x++;
        }
    }
}