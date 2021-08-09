using System;

class _02_For문
{
	// for문을 이용해서 1 ~ 20까지의 합을 구해보세요.

	static void Main()
	{
		// 합계를 저장할 변수
		int result = 0;

		// for문을 통해서 1 ~ 20까지 값을 더합니다.
		for(int num = 0; num < 21; num++)
		{
			result += num;
			// result = result + num
		}
			Console.WriteLine("1 ~ 20까지의 합 : " + result);
	}
}
