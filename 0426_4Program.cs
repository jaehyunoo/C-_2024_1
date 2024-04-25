internal class Program
{
    class Student
    {
        private string name;
        private string studentNumber;
        private int grade;

        public Student(string name, string studentNumber, int grade)
        {
            Name = name;
            Number = studentNumber;
            Grade = grade;
        }


        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }

        }

        public string Number
        {
            get { return studentNumber; }
            set
            {
                studentNumber = value;
            }
        }

        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }
    }
    private static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        Console.Write("몇명의 학생을 입력하시겠습니까 : ");
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine($"{i}번째 학생의 정보를 입력하세요:");

            Console.Write("이름: ");
            string name = Console.ReadLine();

            Console.Write("학번: ");
            string studentNumber = Console.ReadLine();

            Console.Write("학년: ");
            int grade = int.Parse(Console.ReadLine());

            students.Add(new Student(name, studentNumber, grade));
        }

        Console.WriteLine("정보 출력");

        foreach (var student in students)
        {
            Console.WriteLine($"이름: {student.Name}, 학번: {student.Number}, 학년: {student.Grade}");
        }
    }
}