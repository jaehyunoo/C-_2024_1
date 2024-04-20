


internal class Program
{
     class Product
    {
        private static int counter = 0;
        private int id;
        private string name;
        private int price;

        public Product(string name, int price)
        {
            Product.counter++;
            this.id = counter;          
            this.name = name;
            this.price = price;
        }

        public int getId() { return id; }
        public string getName() { return name; }
        public int getPrice() { return price; }
        public static int getCounter() { return counter; }



    }

 
    private static void Main(string[] args)
    {
        List<Product> products = new List<Product>();

        while (true)
        {
            Console.Write("상품 이름을 입력하시오 (종료 : exit) : ");
            string name = Console.ReadLine();
            if (name == "exit")
            {
                Console.WriteLine("프로그램 종료");
                break;
            }
            Console.Write("상품의 가격을 입력하시오 : ");
            int price = int.Parse(Console.ReadLine());

            products.Add(new Product(name, price));


        }

        foreach(var product  in products)
        {
            Console.WriteLine( product.getName() + " : " + product.getPrice());;
        }



        Product productA = new Product("감자",2000);
        Product productB = new Product("고구마", 3000);

        Console.WriteLine(productA.getId() + " " + productA.getName() + " = " + productA.getPrice());
        Console.WriteLine(productB.getId() + " " + productB.getName() + " = " + productB.getPrice());
        Console.WriteLine(productB.getId() + "개 생성");
        Console.WriteLine(Product.getCounter());




    }
}