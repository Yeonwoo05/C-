using System;

class _02_While문
{
	static void Main()
	{
		// 1 ~ 10까지 수를 출력하는 반복문
		int count = 1;
		while (count <= 10) Console.WriteLine(count++);

		Console.WriteLine();
		// 1 ~ 50까지 짝수만 출력
		count = 1;
		while(count <= 50)
		{
			if (count % 2 == 0) Console.WriteLine("count = " + count);
			count++;
		}

	}
}