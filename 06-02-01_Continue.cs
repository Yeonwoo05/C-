using System;

class _01_Continue
{
	// > Continue문
	/// - 현재 실행중인 반복문을 한번 건너뛰고 반복을 계속 하고자할 때 사용합니다.
	/// 
	static void Main()
	{
		for(int i = 0; i < 5; i++)
		{
			if (i == 3) continue;

			Console.WriteLine("i = " + i);
		}
	}
}