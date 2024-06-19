using System.Security.Cryptography.X509Certificates;

internal class Program
{
    class Point
    {
       -
        protected string Str {  get; set; }

        public void set(int x, int y)
        {
            this.Str = ($"({x},{y})");
        }
        public void showPoint()
        {
            Console.WriteLine(Str);
        }
    }

    class ColorPoint : Point
    {
        private string Color { get; set; }

        public void setColor(string color)
        {
            this.Color = color;
        }

        public void showColorPoint() 
        { 
            Console.WriteLine($"{Str}, {Color}");
        }
    }
    private static void Main(string[] args)
    {
        Point p = new Point();
        Console.Write("좌표를 입력하시오 : ");
        int a = int.Parse( Console.ReadLine() );
        int b = int.Parse( Console.ReadLine() );   
        p.set(a, b);
        p.showPoint();

        ColorPoint cp = new ColorPoint();
        cp.set(a,b);
        Console.Write("색을 입력하시오 : ");
        cp.setColor(Console.ReadLine());
        cp.showColorPoint();

    }
}