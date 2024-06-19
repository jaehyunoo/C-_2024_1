internal class Program
{
    class Parent
    {
        public int variable = 273;

        public virtual void Method()
        {
            Console.WriteLine("부모의 메서드");
        }
    }

    class Child : Parent 
    {
        public string variable = "shadowing";



        public override void Method() // new => Parent의 Method는 숨기고 Child의 Method가 새로운것임을 알림. ( 하이딩을할지 오버라이딩을할지 결정해야함 )
        {                             // overide => 부모메서드에 접근제한자 뒤 virtual을 붙여준다. 부모클래스의 메소드를 자식메서드에서 재구현
                                      // => 자식에서 다시구현하므로 부모의 메서드는 필요없어진다.
            Console.WriteLine("자식의 메서드");
        }
    }

    private static void Main(string[] args)
    {
        Child child = new Child();
        Console.WriteLine(child.variable);
        Console.WriteLine(((Parent)child).variable);

        child.Method();
        ((Parent)child).Method();
        
    }
}