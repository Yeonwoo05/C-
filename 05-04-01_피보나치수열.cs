using System;
class _01_피보나치수열
{
	// 피보나치 숭려
	// A = 0, B = 1
	// temp = A + B
	// a = B, B = temp
	// A는 다음 항입니다.

	// 몇번재 항까지 출력할까요 ? 5
	// 1 1 2 3 5

	// 몇번째 항까지 출력할까요 ? 7
	// 1 1 2 3 5 8 13

	static void Main()
	{
		ulong A = 0, B = 1, temp, count;

		Console.Write("몇번째 항까지 출력?");
		count = ulong.Parse(Console.ReadLine());

		for(ulong i = 0; i < count; i++)
		{
			temp = A + B;
			A = B;
			B = temp;

			// 다음 항이 A
			Console.Write(A + " ");
		}
	}


}


