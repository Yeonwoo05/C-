using System;

// while문을 이용해서 1부터 10까지의 곱셈값을 출력해주세요.

// 10! : 1 x 2 x 3 x 4 x 5 x 6 x 7 x 8 x 9 x 10 = 3628800

class _05_While문
{
	static void Main()
	{
		int count = 1;

		int result = 1;

		while (count < 11) result *= count++;

		Console.WriteLine("10! = " + result);
	}
}