using System;

// > int형 변수 A와 B에 값을 입력받고
// 어떤 값이 더 큰지 검사하여 더 큰값을 출력해주세요.

// > input
/// A를 입력해주세요 : 10
/// B를 입력해주세요 : 20

// > output
/// 더 큰값은 20 입니다.


namespace _03_연산자._05_조건연산자
{
	class _02_조건연산자
	{
		static void Main()
		{
			Console.Write("A를 입력해주세요.");
			int A = int.Parse(Console.ReadLine());
			Console.Write("B를 입력해주세요.");
			int B = int.Parse(Console.ReadLine());

			Console.WriteLine("더 큰 값은 " + ((A > B) ? A : B) + "입니다");
		}
	}
}
