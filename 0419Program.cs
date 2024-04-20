internal class Program
{
    class Box
    {
        private int width;
        private int height;

        public Box(int width, int height)
        {
            Width = width;
            Height = height;

        }

        public int Area() { 
            return this.width * this.height;
        }


        public int Width {
            
            get { return width; }

            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("너비는 자연수를 입력해주세요");
                }
            }
        }

        public int Height
        {

            get { return height; }

            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("높이는 자연수를 입력해주세요");
                }
            }
        }

        private static void Main(string[] args)
        {
            Box box = new Box(5, 5);

            Console.Write("너비를 입력해주세요 ");
            box.Width = int.Parse(Console.ReadLine());

            Console.Write("높이를 입력해주세요 ");
            box.Height = int.Parse(Console.ReadLine());
            //box.SetHeight(height);
            //box.SetHeigth(int.Parse(Console.ReadLine())); 도 가능

            Console.WriteLine($"면적 : {box.Area()}");
        }
    }
}
