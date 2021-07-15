using System;

namespace _03_연산자._03_관계연산자
{
	class _02_관계연산자
	{
		static void Main()
		{
			// 주어진 조건이 참인지 거짓인지 출력하기!
			int A = 10;
			int B = 100;


			// > A의 값이 B의 값과 동일한지?
			Console.WriteLine("(A == B) = " + (A == B));
			// > A의 값이 B의 값 이상인지?
			Console.WriteLine("(A >= B) = " + (A >= B));
			// > B의 값이 A의 값 미만한지?
			Console.WriteLine("(B < A) = " + (B < A));
			// > A의 값이 B의 값 이하한지?
			Console.WriteLine("(A <= B) = " + (A <= B));
		}
	}
}
