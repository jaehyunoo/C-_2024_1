internal class Program
{
    class Student
    {
        private string name;
        private int grade;

        public Student(string name, int grade)
        {
            this.name = name;
            this.grade = grade;
        }

        public string Getname () { return name; }
        public int Getgrade () { return grade;}
    }
    private static void Main(string[] args)
    {

        List<Student> students = new List<Student>();


            students.Add(new Student("윤인성", 1)); // public 이었다면 new student{name = "윤인성", grade = 1}
            students.Add(new Student("연하진", 2));
            students.Add(new Student("윤아린", 3));
            students.Add(new Student("윤명월", 4));
            students.Add(new Student("구지연", 1));
            students.Add(new Student("김연화", 2));
        
        Console.Write("몇 학년 학생을 찾으시고 싶으십니까 ? ");
        int number = int.Parse(Console.ReadLine());

      

       
        Show2List(students,number);

    }

    private static void ShowList(List<Student> list) // ShowList함수 안에 리스트이름과 형식을 ()안에 넣는다.
    {
        foreach (var student in list)
        {
            Console.WriteLine($"{student.Getname()} : {student.Getgrade()}학년");
        }
    }

    private static  void Show2List(List<Student> list, int num)
    {
        List<Student> member = new List<Student>();
        /*
         foreach (var item in list)
        {
            if(item.grade == 2)
            {
                member.Add(new Student() {name = item.name, grade = item.grade});
            }
        }
        */

        foreach (var student in list)
        {
            if(student.Getgrade() == num)
            {
                member.Add(student);
            }
        }

        ShowList(member);

    }
    private static void RemoveList(List<Student> list)
    {       
        for (int i = list.Count-1; i >= 0; i--)
        {
            list.RemoveAt(i);
        }

    }
}