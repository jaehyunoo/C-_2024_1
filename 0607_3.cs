﻿internal class Program
{
    class Product : IComparable
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return Name + " = " + Price + "원";
        }

        public int CompareTo(object obj)
        {
            return this.Price.CompareTo((obj as Product).Price);
        }
    }
    private static void Main(string[] args)
    {
        List<Product> products = new List<Product>()
        {
            new Product() {Name = "감자", Price = 500},
            new Product() {Name = "사과", Price = 700},
            new Product() {Name = "고구마", Price = 400},
            new Product() {Name = "배추", Price = 600},
            new Product() {Name = "상추", Price = 300}
        };

        products.Sort();

        foreach (var item in products)
        {
            Console.WriteLine(item.Name + " = " + item.Price);
        }
    }
}