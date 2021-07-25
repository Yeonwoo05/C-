using System;

// if문을 중첩시켜서 프로그램의 흐름을 다르게 할수 있습니다.

class _05_IF문
{
	static void Main()
	{
		int A;
		Console.WriteLine("A의 값을 입력하세요.");
		Console.Write("A = ");
		A = int.Parse(Console.ReadLine());

		// 만약 A의 값이 0보다 크다면
		if(A > 0)
		{
			// A의 값이 짝수인지 홀수인지 검사합니다.
			if (A % 2 == 0) Console.WriteLine("A는 짝수입니다.");
			else Console.WriteLine("A는 홀수입니다.");
		}
		// 아니라면
		else
		{
			Console.WriteLine("A는 0과 같거나 0보다 작습니다.");
		}
	}
}
