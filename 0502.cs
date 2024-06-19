internal class Program
{
    public int Sum(int i)
    {
        if (i <= 0) { 
            return 0;
        }
        if (i == 1)
        {
            return 1;
        }

        return i + Sum(i - 1);


    }

    public int Fac(int j)
    {
        if (j <= 0)
        {
            return 0;
        }

        if (j == 1)
        {
            return 1;
        }

        return j * Fac(j - 1);
    }

    public int Yak(int i)
    {
        if (i <= 1)
        {
            return 0;
        }
        if (i % 2 == 1)
        {
            i = i - 1;
        }

        return i + Yak(i - 2);
       

    }

    private static void Main(string[] args)
    {
        Program p = new Program();

        Console.Write("정수를 입력하시오 : ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine(p.Sum(num));
        Console.WriteLine(p.Fac(num));
        Console.WriteLine(p.Yak(num));
        
    }
}