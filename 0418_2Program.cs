


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

        public int GetId() { return id; }
        public string GetName() { return name; }
        public int GetPrice() { return price; }

        public static void ResetCounter()
        {
            counter = 1;
        }
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
                if (products.Count == 0)
                {
                    Console.WriteLine("입력된 제품이 없습니다. 프로그램을 종료합니다.");
                    break;
                }
                else
                {
                    Console.WriteLine("입력된 제품 목록:");
                    foreach (var product in products)
                    {
                        Console.WriteLine($"{product.GetId()} - {product.GetName()} : {product.GetPrice()}");
                    }

                    Console.WriteLine($"총 {products.Count}개의 제품이 생성되었습니다.");

                    Console.Write("리스트를 초기화하여 새로운 제품을 추가하시겠습니까?(계속 = 0 종료 = 1) : ");
                    int number = int.Parse(Console.ReadLine());
                    if (number == 0)
                    {
                        products.RemoveRange(0, products.Count); // 리스트를 초기화하여 새로운 제품을 추가할 수 있도록 합니다.
                        Product.ResetCounter();
                    }
                    else if (number == 1)
                    {
                        Console.WriteLine("프로그램 종료 !!");
                        break;
                    }
                }
            }
            else
            {
                Console.Write("상품의 가격을 입력하시오 : ");
                int price = int.Parse(Console.ReadLine());

                products.Add(new Product(pname, price));
            }
        }
    }
}