using System;
class _03_For문
{ 
	// For문을 이용해서 10!의 결과문을 출력해주세요.

	static void Main()
	{
		int res = 1;
		for (int i = 1; i < 11; i++)
			res *= i;

		Console.WriteLine("10! = " + res);
	}
}