using System;

class _04_While문
{
	// while문을 이용해서 1 ~ 100까지의 합을 구해보세요.

	static void Main()
	{
		int count = 1;

		// 결과를 저장할 변수
		int result = 0;

		while (count <= 100) result += (count++);

		Console.WriteLine("1 ~ 100까지의 합 : " + result);
	}
}
