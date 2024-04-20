internal class Program
{
    class Student
    {
        public string name;
        public int grade;
    }
    private static void Main(string[] args)
    {

        List<Student> students = new List<Student>();
        students.Add(new Student { name = "윤인성", grade = 1 });
        students.Add(new Student { name = "연하진", grade = 2 });
        students.Add(new Student { name = "윤아린", grade = 3 });
        students.Add(new Student { name = "윤명월", grade = 4 });
        students.Add(new Student { name = "구지연", grade = 1 });
        students.Add(new Student { name = "김연화", grade = 2 });

        Console.Write("몇 학년 학생을 찾으시고 싶으십니까 ? ");
        int number = int.Parse(Console.ReadLine());

      
        /*
         *new student(){name="윤인성", grade=1},
         *new student(){name="연하진", grade=2}, 
         *new student(){name="윤아린", grade=3}, 
         *new student(){name="윤명월", grade=4}, 
         *new student(){name="구지연", grade=1}, 
         *new student(){name="김연화", grade=2}
         */

       
        Show2List(students,number);
        

        /*
        foreach (var  student in students)
        {
            Console.WriteLine($"{student.name} : {student.grade}학년");
        }
        */
    }

    private static void ShowList(List<Student> list) // ShowList함수 안에 리스트이름과 형식을 ()안에 넣는다.
    {
        foreach (var student in list)
        {
            Console.WriteLine($"{student.name} : {student.grade}학년");
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
            if(student.grade == num)
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