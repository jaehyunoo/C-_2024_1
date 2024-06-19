internal class Program
{
    static void CopyArray<T>(T[] a, T[] b) {
        for (int i = 0; i < b.Length; i++)
        {
            a[i] = b[i];
        }
    }

    class Cup<R>
    {
        public R content { get; set; }

    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName {  get; set; }
    }


    private static void Main(string[] args)
    {
        int[] source = new int[10];
        int[] target = new int[10];
        for (int i = 0; i < target.Length; i++)
        {
            target[i] = i + 1;
        }
        CopyArray<int>(source, target);

        foreach (var score in source)
        {
            Console.WriteLine(score);
        }



        List<Category> item = new List<Category>()
        {
            new Category(){CategoryId = 1, CategoryName = "좋은 책"},
            new Category(){CategoryId = 2, CategoryName = "좋은 강의"},
            new Category(){CategoryId = 3, CategoryName = "좋은 컴퓨터"}
        };

        for(int j = 0; j <  item.Count; j++)
        {
            Console.WriteLine($"{item[j].CategoryId} : {item[j].CategoryName}" );
        }

        Person person1 = new Person();
        //person1.Name = "유재현";
        //person1.Age = 24;

       

        Cup<string> cup1 = new Cup<string>();
        cup1.content = person1.Name = "유재현";
        Cup<int> cup2 = new Cup<int>();
        cup2.content = person1.Age = 24;

        Cup<Person> cup3 = new Cup<Person>();
        cup3.content = new Person() { Name = "유재현", Age = 24 };
        
        

        Console.WriteLine($"{cup1.content} : {cup2.content}");
        Console.WriteLine($"{cup3.content.Name} = {cup3.content.Age} ");

    }
}