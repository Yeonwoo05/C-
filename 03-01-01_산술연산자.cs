using System;

namespace _03_연산자._01_산술연산자
{
	// > 연산자란?
	/// - 연산을 수행하는 기호를 의미합니다.
	/// - 연산자는 항상 어떠한 결과를 반환을 합니다.
	class _01_산술연산자
	{
		// 산술연산자?
		/// - 수치 형식의 데이터를 다루는 연산자
		/// - 수치 형식 : 정수, 부동 소수점 형식
		/// +		덧셈 연산자
		/// -		뺄셈 연산자
		/// *		곱셈 연산자
		/// /		나눗셈 연산자
		/// %		나머지 연산자


		static void Main()
		{
			int A = 3, B = 2;

			// 어떤 변수안에 이 사칙연산자를 넣어두면 편리합니다.
			double add = A + B;
			double sub = A - B;
			double mul = A * B;
			double div = A / B;
			double rem = A % B;

			Console.WriteLine("add = " + add);
			Console.WriteLine("sub = " + sub);
			Console.WriteLine("mul = " + mul);
			Console.WriteLine("div = " + div);
			Console.WriteLine("rem = " + rem);
			Console.WriteLine();

			// 정수와 정수간의 연산 = 정수
			// 실수와 정수간의 연산 = 실수
			div = (double)A / B;
			Console.WriteLine("div = " + div);
			// 정수와 실수간의 연산 = 실수
			div = A / (double)B;
			Console.WriteLine("div = " + div);
			// 실수와 실수간의 연산 = 실수
			div = ((double)A / (double)B);
			Console.WriteLine("div = " + div);
		}
	}
}
