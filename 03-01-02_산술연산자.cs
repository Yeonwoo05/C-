using System;

// int 형 N, M을 입력받고 덧셈, 뺄셈, 곱셈, 나눗셈 결과를 일회만
// 출력하는 계산기 프로그램을 작성해주세요.

/// input
///  N을 입력하세요 : 7
///  M을 입력하세요 : 7

/// output
/// 덧셈 : 14
/// 뺄셈 : 0
/// 곱셈 : 49
/// 나눗셈 : 1
/// ** 주의 : 나눗셈 결과값은 소수로 표현하게 해주세요. 
/// (정수로 딱 떨어지는 경우는 제외)



namespace _03_연산자._01_산술연산자
{
	class _02_산술연산자
	{
		static void Main()
		{
			int N, M;
			Console.Write("N을 입력하세요 : ");
			N = int.Parse(Console.ReadLine());
			Console.Write("M을 입력하세요 : ");
			M = int.Parse(Console.ReadLine());

			Console.WriteLine($"덧셈 : { (N + M) }");
			Console.WriteLine($"뺄셈 : { (N - M) }");
			Console.WriteLine($"곱셈 : { (N * M) }");
			Console.WriteLine($"나눗셈 : { ((float)N / M) }");
		}
	}
}
