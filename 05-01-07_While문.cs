using System;

class _07_While문
{
    static void Main()
    {
        // while문을 이용해서
        // - 다음과 같은 구구단을 출력해주세요.
        // [1단] [2단] [3단]
        // [4단] [5단] [6단]
        // [7단] [8단] [9단]

        // 큰 한줄을 구분할 변수
        int BigLine = 1;

        while(BigLine < 4)
        {
            // 큰 한줄에서 출력될 한줄을 구분하기 위한 변수
            int smallLine = 1;

            // N X M 을 출력할때 M에 사용될 변수
            int count = 1;

            while(smallLine < 10)
            {
                int number = (BigLine * 3) - 2;
                int endnumber = number + 3;

                // > 작은줄을 출력합니다.
                while(number < endnumber)
                {
                    Console.Write(number + " X " + count + " = " + (number * count) +
                        (((number * count) < 10) ? " " : "") + "     ");

                    // 증감식
                    ++number;
                }
                ++count;

                // 작은 줄 개행
                ++smallLine;
                Console.WriteLine();
            }
            ++BigLine;
            Console.WriteLine();
        }
    }
}