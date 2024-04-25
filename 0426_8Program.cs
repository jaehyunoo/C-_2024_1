/*
 사용자로부터 이름을 입력 받아 다음과 같이 환영 메시지를 출력하는 프로그램을 작성하시오.
arduino
Copy code
"안녕하세요 [사용자이름]님! 숫자 추측 게임에 오신 것을 환영합니다."
1부터 100 사이의 랜덤한 숫자를 생성하고, 사용자로부터 이 숫자를 맞추는 게임을 시작하시오. 사용자에게 힌트를 제공하여 입력한 숫자가 생성된 숫자보다 큰지, 작은지를 알려줘야 합니다.

사용자가 숫자를 맞출 때까지 계속해서 입력을 받아야 합니다. 사용자가 숫자를 맞추면 몇 번만에 맞췄는지를 출력하고 게임을 종료합니다.

사용자가 게임을 종료한 후에 다시 게임을 하고 싶은지 묻고, 'yes'를 입력하면 게임을 다시 시작하고, 'no'를 입력하면 프로그램을 종료합니다.

arduino
Copy code
"게임을 다시 시작하시겠습니까? (yes/no):"
모든 기능은 적절한 메서드로 나누어 작성되어야 하며, 가능한 클래스를 사용하여 구현해야 합니다.

Math 클래스를 사용하여 랜덤한 숫자를 생성하고, 사용자가 입력한 숫자의 제곱근을 계산하여 출력해야 합니다.
*/

class MathGame
{
    public Random r = new Random();
    public int num;

    public MathGame()
    {
        num = r.Next(1, 99);
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("이름을 입력하시오 : ");
        string person = Console.ReadLine();

        Console.WriteLine($"안녕하세요 [{person}]님! 숫자 추측 게임에 오신 것을 환영합니다.");


        while (true)
        {
            int i = 1;
            MathGame game = new MathGame();

            while (true)
            {
                Console.Write("숫자를 입력하시오 : ");
                int number = int.Parse(Console.ReadLine());

                if (number > 0 && number < 100)
                {
                    if (number == game.num)
                    {
                        Console.WriteLine($"{i}번째 만에 정답을 맞추셨습니다.");
                        break;
                    }
                    else if (number > game.num)
                    {
                        Console.WriteLine("입력하신 숫자가 정답보다 큽니다.");
                        i++;
                    }
                    else if (number < game.num)
                    {
                        Console.WriteLine("입력하신 숫자가 정답보다 작습니다.");
                        i++;
                    }
                }
                else
                {
                    Console.WriteLine("1부터 99사이의 숫자만 입력해주세요");
                }
                
            }
            Console.Write("게임을 다시시작하시겠습니까 ? (yes/no)");
            string answer = Console.ReadLine();

            if (answer == "yes")
            {
                Console.WriteLine("게임을 다시시작하겠습니다");
            }
            else if (answer == "no")
            {
                Console.WriteLine("게임종료 ! ");
                break;
            }
        }

    }
}