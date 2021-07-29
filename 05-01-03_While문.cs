using System;
class _03_While문
{
	static void Main()
	{
		int A = 0;
		// > A의 값이 3 미만이라면 반복시킵니다.
		while (A < 3)
		{
			int B = 0;
			Console.WriteLine("A = " + A);
			// > B의 값이 3 미만이라면 반복시킵니다.
			while (B < 3)
			{
				Console.WriteLine("		B = " + B);
				++B;
			}
			A++;
		}
	}
}
