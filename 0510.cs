internal class Program
{
     class Parent
    {
        public Parent() { Console.WriteLine("Parent()"); }
        public Parent(int param) { Console.WriteLine("Parent(int param)"); }
        public Parent(string param) { Console.WriteLine("Parent(string param)"); }
    }

    class Child : Parent
    {
        public Child()
        {
            Console.WriteLine("Child() : base(10)");
        }
        public Child(string input) 
        {
            Console.WriteLine("Child(string input) : base(input)");
        }
    }

    private static void Main(string[] args)
    {
        Child childA = new Child();
        Child childB = new Child("string");
    }
}