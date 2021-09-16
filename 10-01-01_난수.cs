using System;
class _01_난수
{
	private static void Main()
	{
		// 난수란?
		// - 특정한 배열 순서나, 규칙을 가지지 않는 연속적인 임의의 수를 의미합니다.
		Random rand = new Random();

		// rand.Next(min, max) : min ~ max - 1까지의 난수를 반환
		for(int i = 0; i < 5; i++)
		{
			Console.WriteLine("뽑은 숫자 : " + rand.Next(0, 5));
		}
	}
}
