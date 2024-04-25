using System.Net.Http.Headers;

internal class Program
{
    class Account
    {
        private string accountid;
        private int price;

        public Account(string accountid, int price)
            {
                AccountId = accountid;
                Price = price;
            }

        public string AccountId{
            get {  
                return accountid;
            }
            set { 

                accountid = value; 
            }
        }

        public int Price
        {
            get {
                return price; 
            }

            set
            {
                while (value < 0)
                {
                    Console.Write("0원 이상 입력해 주십시오 : ");
                    value = int.Parse(Console.ReadLine());
                }
                price = value;
            }
        }

    }
    private static void Main(string[] args)
    {
        List<Account> accounts = new List<Account>();

        while (true) {
            Console.Write("계좌를입력하시오(종료 : exit) : ");
            string id = Console.ReadLine();
            if(id == "exit")
            {
                Console.WriteLine("계좌 입력을 종료하겠습니다");
                break;
            }

            Console.Write("잔고를 입력하시오 : ");
            int price = int.Parse(Console.ReadLine());

            accounts.Add(new Account(id, price));
        }




        int sum = 0;
        foreach(var account in accounts)
        {
            Console.WriteLine($"계좌 번호 출력 : {account.AccountId}");
            Console.WriteLine($"금액 출력 : {account.Price}");
            sum += account.Price;
        }

        Console.WriteLine("계좌들의 총 금액 출력 : " + sum);
       


    }
}