using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // 4월 4일 첫번째 수업

        Console.Write("입력할 숫자의 개수 : ");
        int num = int.Parse(Console.ReadLine());
        int sum = 0;
        Console.WriteLine("수 " + num + "개 입력");

        for (int i = 0; i < num; i++)
        {
            Console.Write((i + 1) + "번 째 입력(1~10 사이의 수만 입력) : ");
            int number = int.Parse(Console.ReadLine());
            if (number > 10 || number < 0)
            {
                Console.WriteLine("유효한 수 아님! 다시 입력");
                i--;
            }
            else
            {
                sum = sum + number;
            }
        }

        Console.WriteLine("합계 : " + sum);
        Console.WriteLine("평균 : " + (sum / (float)num).ToString("F2"));  //F2 == 0.00
        /*
        Random r = new Random();
        Console.Write("랜덤수를 몇개 받을지 입력하시오 : ");
        int num = int.Parse(Console.ReadLine());
        int[] intArray = new int[num];


        for (int i = 0; i < intArray.Length; i++)
        {
            intArray[i] = r.Next(0, 99); // 0~99까지 숫자
            for (int k = 0; k < i; k++)
            {
                if (intArray[k] == intArray[i])
                {
                    i--;
                }
            }
        }

        int max = intArray[0];
        int min = intArray[0];

        for (int j = 1; j < intArray.Length; j++)
        {

            if (intArray[j] > max)
            {
                max = intArray[j];
            }

            if (intArray[j] < min)
            {
                min = intArray[j];
            }
        }


        // foreach 루프는 배열의 길이에 따라 반복하며 배열의 첫번째요소부터 마지막요소까지 반복하게된다.
        foreach (int value in intArray) // intArray 배열의 요소들의 값의 출력 반복을 실행한다.
        Console.WriteLine("{0,2}",value); // 0번째 인덱스 값을 출력하고 출력된 문자열 오른쪽 정렬하여 총 2자리 공간을 차지한다는 것.
        

        Console.WriteLine("최대값 : " + max);
        Console.WriteLine("최소값 : " + min);
        */
    }
}


    /*
    Console.Write("랜덤수를 몇개 받을지 입력하시오 : ");
    int num = int.Parse(Console.ReadLine());
    int[] intArray = new int[num];



    for (int i = 0; i < intArray.Length; i++) {
       intArray[i] = r.Next(1, 46); // 1~45까지 숫자
                for (int k = 0; k < i; k++){
                        if (intArray[k] == intArray[i])
                            {
                                i--;
                            }
                }

      }

    Console.WriteLine("생성된 " + num + "개의 랜덤한 숫자 출력 : ");

    foreach(int value in intArray)
        Console.WriteLine("{0, 5}",value);
    */

        
