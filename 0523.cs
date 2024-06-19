using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;


internal class Program
{
    class Product : IComparable

    {
        public string Name { get; set; } 
        public int Price { get; set; }

        public int CompareTo(object? obj)
        {
            return this.Name.CompareTo((obj as Product).Name);
        }

        public override string ToString()
        {
            return Name + " : " + Price + "원";
        }



        
    }

    class Student : IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int CompareTo(object? obj)
        {
            if (obj is Student otherStudent)
            {
                return this.Age.CompareTo(otherStudent.Age);
            }
            throw new ArgumentException("Object is not Student");
        }

        //public override string ToString()
        //{
        //    return Name + " : " + Age + "살";
        //}

    }
    private static void Main(string[] args)
    {
        List<Product> products = new List<Product>()
        {
            new Product() { Name = "고구마", Price = 1500 },
            new Product() { Name = "사과", Price = 2400 },
            new Product() { Name = "바나나", Price = 1000 },
            new Product() { Name = "배", Price = 3000 }
        };
        products.Sort();

        foreach (var item in products)
        {
            Console.WriteLine(item);
        }

        List<Student> list = new List<Student>()
        {
            new Student() { Name = "Mike", Age = 15 },
            new Student() { Name = "Kim", Age = 13 },
            new Student() { Name = "Lee", Age = 18}
        };
        list.Sort();

        foreach (var item in list)
        {
            Console.WriteLine(item.Name + " : " + item.Age);
        }

    }

}