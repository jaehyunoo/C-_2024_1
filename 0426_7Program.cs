internal class Program
{
    class Student
    {
        public string Name;
        public int Score;
        public char Alpa;
    }

    private static void Main(string[] args)
    {

        List<Student> students = new List<Student>();

        while (true)
        {
            

            Console.Write("학생의 수를 입력하시오(종료 : 0) : ");
            int num = int.Parse(Console.ReadLine());
            
            
            if (num == 0)
            {
                Console.WriteLine("프로그램 종료 !");
                break;
            }
            else
            {
                for (int i = 0; i < num; i++)
                {
                    Console.Write($"{i + 1}번째 학생의 이름은 : ");
                    string name = Console.ReadLine();
                    
                    Console.Write($"{name}의 성적은 : ");
                    int score = int.Parse(Console.ReadLine());
                    char alpa;

                    if (score >= 0 && score <= 100)
                    {
                        switch (score / 10)
                        {
                            case 10:
                            case 9:
                                alpa = 'A';
                                break;

                            case 8:
                                alpa = 'B';
                                break;
                            case 7:
                                alpa = 'C';
                                break;
                            case 6:
                                alpa = 'D';
                                break;

                            default:
                                alpa = 'F';
                                break;
                        }

                        students.Add(new Student { Name = name, Score = score, Alpa = alpa });
                    }
                    
                    
                }
            }

            foreach(var student in students)
            {
                Console.WriteLine($"{student.Name} : {student.Score} , {student.Alpa}");
            }

            students.RemoveRange(0, num); // 출력시킨 후 리스트 초기화

        }





    }
}