// seal는 클래스에 적용하면 절대 상속하지 말라는의미, 메서드에 적용하면 더이상 오버라이딩 하지말라는 의미
// abstract =>  반드시 상속해서 써라. 해당 클래스 자체는 인스턴스를 만들 수 없다.
internal class Program
{
    class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("냠냠 먹습니다");
        }
    }
    class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("개가 먹습니다");
        }
    }
    class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("고양이가 먹습니다");
        }
    }
    private static void Main(string[] args)
    {
        List<Animal> Animals = new List<Animal>()
        {
            new Dog(),
            new Cat(),
            new Dog(),
            new Cat()
        };

        foreach (var item in Animals) 
        {
            item.Eat();
        }
    }
}
