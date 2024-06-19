using static System.Net.Mime.MediaTypeNames;

internal partial class Program
{
    class Monster : IUpgradable, ISellable
    {
        public int Level { get; set; }
        public int Price { get; set; }
        public void Upgrade()
        {
            this.Level = this.Level + 1;
            this.Price = this.Price + 1000;

            Console.WriteLine($"Monster Level : {this.Level}");
        }
        public void Sell()
        {
            Console.WriteLine($"Sell Monster : ${this.Price}");
        }
    }

    class Item :  ISellable
    {
        public int Price { get; set; }
     
        public void Sell()
        {
            Console.WriteLine($"Sell Item : ${this.Price}");
        }
    }
    private static void Main(string[] args)
    {
        Monster monster = new Monster();
        monster.Level = 3;
        monster.Price = 2000;

        monster.Upgrade();
        monster.Sell();

        Item item = new Item();
        item.Price = 500;
        item.Sell();

        using (StreamWriter w = new StreamWriter(@"C:\Users\82105\Desktop\2024 1학기\test.txt"))
        {
            w.WriteLine("안녕하세요");
            w.WriteLine("StreamWriter 클래스를 사용해");
            w.WriteLine("글자를 여러 줄 입력해봅니다");

            for(int i = 0; i < 10;i++)
            {
                w.WriteLine($"반복문 : {i}");
            }
        }
        

    }
}