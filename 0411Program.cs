using date0411;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Product> products = new List<Product>();
        Console.Write("몇개의 물품을 입력하시겠습니까 ? ");
        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            Console.Write($"{i + 1}번째 물품의 이름을 입력하시오 : ");
            string name = Console.ReadLine();

            Console.Write("가격을 입력하시오 : ");
            int price = int.Parse(Console.ReadLine());

            products.Add(new Product { Name = name, Price = price });
        }
        /*
        for (int j = 0; j < products.Count; j++)
        {
            Console.WriteLine($"{products[j].Name} {products[j].Price}");
        }
        */
        foreach(var product in products)
        {
            Console.WriteLine($"{product.Name} : {product.Price}원");
        }
        products.RemoveRange(0, num);


        
        
        
       
        Product productA = new Product() { Name = "감자", Price = 2000 } ;
        Product productB = new Product() { Name = "고구마", Price = 3000};

        // 인스턴스.클래스안의 메서드
        productA.print();
        productB.print();
        
    }

}