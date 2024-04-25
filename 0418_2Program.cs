


internal class Program
{
     class Product
    {
        private static int counter = 1;
        private int id;
        private string name;
        private int price;

        public Product(string name, int price)
        {
            this.id = counter++;          
            this.name = name;
            this.price = price;
        }

        public int getId() { return id; }
        public string getName() { return name; }
        public int getPrice() { return price; }



    }



    private static void Main(string[] args)
    {
        List<Product> products = new List<Product>();

        while (true)
        {
            Console.Write("상품 이름을 입력하시오 (종료 : exit) : ");
            string pname = Console.ReadLine();
            if (pname == "exit")
            {
                Console.WriteLine("프로그램 종료");
                break;
            }
            Console.Write("상품의 가격을 입력하시오 : ");
            int price = int.Parse(Console.ReadLine());

            products.Add(new Product(pname, price));
        }

        Console.WriteLine("\n입력된 제품 목록:");
        foreach (var product in products)
        {
            Console.WriteLine($"{product.getId()} - {product.getName()} : {product.getPrice()}");
        }

        Console.WriteLine($"\n총 {products.Count}개의 제품이 생성되었습니다.");
    }
}