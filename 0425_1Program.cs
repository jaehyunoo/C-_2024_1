internal class Program
{
    class Score
    {
        private int kor;
        private int eng;
        private int math;
        private string name;

        public Score(string name, int kor, int eng, int math)
        {
            Name = name;
            Kor = kor;
            Eng = eng;
            Math = math;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Kor
        {
            get { return kor; }
            set { kor = value; }
        }
        public int Eng
        {
            get { return eng; }
            set { eng = value; }
        }
        public int Math
        {
            get { return math; }
            set { math = value; }
        }

        public double Aver()
        {
            return (kor + eng + math) / (double)3;
        }
    }
    private static void Main(string[] args)
    {
        List<Score> scores = new List<Score>();

        while (true)
        {
            Console.Write("이름을 입력하시오(종료 : exit) : ");
            string name = Console.ReadLine();
            int kor, eng, math;
            if (name == "exit")
            {
                foreach (var value in scores)
                {
                    Console.WriteLine($"{value.Name}의 평균은 {value.Aver().ToString("0.00")}");
                }
                break;
            }

            while (true)
            {
                Console.Write($"{name}님의 국어점수 : ");
                kor = int.Parse(Console.ReadLine());
                if (kor >= 0 && kor <= 100) break;
                Console.WriteLine("다시 입력하세요.");
            }


            while (true)
            {
                Console.Write($"{name}님의 영어점수 : ");
                eng = int.Parse(Console.ReadLine());
                if (eng >= 0 && eng <= 100) break;
                Console.WriteLine("다시 입력하세요.");
            }

            while (true)
            {
                Console.Write($"{name}님의 수학점수 : ");
                math = int.Parse(Console.ReadLine());
                if (math >= 0 && math <= 100) break;
                Console.WriteLine("다시 입력하세요.");
            }

            scores.Add(new Score(name, kor, eng, math));

        }
    }
}