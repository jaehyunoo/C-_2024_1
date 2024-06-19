internal class Program
{
    class Box
    {
        // 변수와 속성
        private int width;
        private int height;

        public int Width
        {
            get { return width; }
            set 
            {
                if (value > 0) { width = value; }
                else { throw new Exception("너비는 자연수를 입력해주세요"); }
            }
        }
        
        public int Height
        {
            get { return height; }
            set
            {
                try
                {
                    if (value > 0)
                    {
                        height = value;
                    }
                    else
                    {
                        throw new Exception("높이는 자연수를 입력해주세요");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }

        public Box(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Area()
        {
            return this.width * this.height;
        }
    }
    private static void Main(string[] args)
    {
        Box box = new Box(10, -20);

        Console.WriteLine(box.Area());
    }
}