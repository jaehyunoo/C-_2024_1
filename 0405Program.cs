using System.Runtime.InteropServices;

internal class Program
{
    /*
    class Car // 하나의 자료형
    {
        // 멤버변수 3개생성.
        public string carNumber;  // 앞에 public을 붙이면 전역변수가 됨
        public DateTime inTime;
        public DateTime outTime;
        

        // Car클래스 안에있는 메소드 2개
        // void => 형(데이터 타입)이없다(return값이 없다)

        public void SetInTime()
        {
            // 어떤 변수(지역 or 전역)를 사용하는지 알기위해서 this를 사용한다.
            this.inTime = DateTime.Now;
            Console.WriteLine(inTime.ToString());
        }

        public void SetOutTime()
        {
            this.outTime = DateTime.Now;
            Console.WriteLine(outTime);

        }
    }
    */

    private static void Main(string[] args)
    {
        // 4월 5일 수업

        // 객체변수 선언(배열 또는 하나의 객체로 사용가능)
        // Car[] cars = new Car[10];

        /*
        Console.Write("입출차 시간을 알고싶은 차량번호를 입력하시오 : ");
        Car car = new Car() { carNumber = Console.ReadLine() };    // car라는 새로운 객체(인스턴스)를 선언 , Read만 쓰는경우는 한문자입력할 때 사용
        // Car=클래스 car=인스턴스 new=new키워드 Car()=생성자(클래스이름과 같은 메서드[클래스이름 뒤 괄호가 붙은 것])

        

        Console.Write(car.carNumber + " 차량의 입차시간은 ");
        car.SetInTime();
        Console.WriteLine(car.inTime);

        Console.Write(car.carNumber + " 차량의 출차시간은 ");
        car.SetOutTime();
        Console.WriteLine(car.outTime);
        */
    

        // Random random = new Random() random이라는 변수에 임의의 숫자 생성시 사용한다.
        Random random = new Random();
        //Console.WriteLine(random.Next(1,10)); // 1부터 9사이의 랜덤숫자 1개 생성
        //Console.WriteLine(random.NextDouble()); // 0.0 ~ 1.0 사이의 실수 난수생성
        //Console.WriteLine(random.NextDouble() * 10); // 0.0 ~ 10.0 사이의 실수 난수생성

        


        // List 클래스의 인스턴스 생성
        // 배열과 다르게 사이즈가 없음 추가하면 추가되는대로 삭제하면 삭제하는대로 크기가 정해진다.

        // 변수선언
        List<int> list = new List<int>();

        Console.Write("랜덤 수를 몇개 입력받을지 입력하시오 : ");
        int size = int.Parse(Console.ReadLine());

        for (int i = 1; i <= size; i++)
        {
            list.Add(random.Next(1,100));
        }

        Console.WriteLine("\n리스트의 길이는 : " + list.Count + "\n");

        int k = 0;
        
        foreach (int value in list) // var은 모든 데이터형 사용가능
        {
            Console.WriteLine($"리스트의 {k}번지 인덱스의 요소의 값은 : " + value);
            k++;
        }
        
        // 리스트에 요소를 추가
        //list.Add(1);
        //list.Add(2);
        //list.Add(3);

        // 리스트에 요소를 삭제 Remove는 값을적어 삭제, RemoveAt(int index)는 인덱스에서 List<T> 항목을제거
        // RemoveRange(int index, int count) 지정한 인덱스에서 count 개수만큼 제거
        //list.Remove(3);

        list.RemoveAt(0); // 리스트의 인덱스 0번지 제거
        list.RemoveRange(0, 2); // 리스트의 인덱스 0번지부터 2만큼 제거

        Console.WriteLine("\n요소들을 제거한 후 리스트의 길이는 : " + list.Count + "\n");

        k = 0;

        foreach (int value in list) // var은 모든 데이터형 사용가능
        {
            Console.WriteLine($"요소들이 제거 된 후 리스트의 {k}번지 인덱스의 요소의 값은 : " + value);
            k++;
        }


        Console.WriteLine(Math.Abs(-3)); // -3의 절대값을 출력
        Console.WriteLine(Math.Ceiling(4.2)); // 지정된 숫자보다 크거나 같은 최소 정수를 구합니다
        Console.WriteLine(Math.Floor(4.7)); // 지정된 숫자보다  작거나 같은 최대 정수를 구합니다
        Console.WriteLine(Math.Max(10,13)); // 두개의 매개변수중 큰값을구함
        Console.WriteLine(Math.Min(5,7)); // 두개의 매개변수중 작은값을구함
        Console.WriteLine(Math.Round(3.1264, 2)); // 3.1264를 소수점 2자리까지 반올림함.
    }
}

