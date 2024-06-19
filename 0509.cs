class Animal
{
    public int Age { get; set; }
    public Animal() { this.Age = 0; }

    public void Eat() { Console.WriteLine("냠냠 먹습니다"); }
    public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다"); }
}

class Dog : Animal
{
    public string Color { get; set; }
    public void Bark() { Console.WriteLine("왈왈 짖습니다."); }
}

class Cat : Animal
{
    public void Meow() { Console.WriteLine("냥냥 웁니다."); }
}

internal class Program
{
    private static void Main(string[] args)
    {
        List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() } ;
        List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };

        

        foreach(var item in Dogs)
        {
            Console.Write("강아지 나이를 입력하시오 : ");
            int age = int.Parse(Console.ReadLine());
            item.Age = age;

            Console.Write("강아지 색을 입력하시오 : ");
            string color = Console.ReadLine();
            item.Color = color;
            
        }

        foreach(var item in Cats)
        {
            Console.Write("고양이 나이를 입력하시오 : ");
            int age = int.Parse(Console.ReadLine());
            item.Age = age;
        }

        foreach (var item in Dogs)
        {
            Console.WriteLine($"강아지의 나이는 {item.Age}  색깔은 {item.Color}");
            item.Eat();
            item.Sleep();
            item.Bark();
        }

        
        foreach (var item in Cats)
        {
            Console.WriteLine($"고양이의 나이는 {item.Age}");
            item.Eat();
            item.Sleep();
            item.Meow();

        }
    }
}