using System;

// 만약 하나의 if문에 조건을 추가하고 싶다면
// - else if문을 사용하면 됩니다.

class _06_IF문
{
	static void Main()
	{
		int A;
		Console.Write("A의 값을 입력하세요 : ");
		A = int.Parse(Console.ReadLine());

		// A의 값이 0보다 큰지 검사합니다.
		if (A > 0) Console.WriteLine("A는 0보다 큽니다.");
		else if (A < 0) Console.WriteLine("A는 0보다 작습니다.");
		else Console.WriteLine("A는 0입니다.");
	}
}
