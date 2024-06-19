// 추상 클래스(abstract)는 반드시 상속을 받아야하고 메소드는 반드시 재정의(virtual,override)가 되어야만한다.
internal class Program
{
    abstract class Parent
    {
        public abstract void Test(); 
    }

    class Child : Parent
    {
        public override void Test()
        {
            Console.WriteLine("test");
        }
    }
    private static void Main(string[] args)
    {
       // Parent parent = new Parent();
       Child child = new Child();
       
       // parent.Test();
       child.Test();
    }
}