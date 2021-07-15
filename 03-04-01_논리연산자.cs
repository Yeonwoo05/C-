using System;
// > 논리 연산자?
/// 참과 거짓으로 이루어지는 진리값이 피연산자인 연산을 의미합니다.

// > 논리 연산자에서 사용하는 연산자 종류
/// - && : AND 연산자
/// - || : OR 연산자
/// - ! : 부정연산자

namespace _03_연산자._04_논리연산자
{
	class _01_논리연산자
	{
		static void Main()
		{
			// AND 연산 (논리 곱)
			/// - 피연산자로 오는 두개의 진리값이 모두 TRUE어야 결과가 TRUE
			/// TRUE && TRUE = TRUE
			/// TRUE && FALSE = FALSE
			/// FALSE && TRUE = FALSE
			bool check1 = true && true;
			Console.WriteLine("check1 = " + check1);

			bool check2 = true && (10 > 50);
			Console.WriteLine("check2 = " + check2);

			bool check3 = (check1 && check2) && (100 == 100);
			Console.WriteLine("check3 = " + check3);

			// > OR 연산자(논리 합)
			/// - 피연산자로 오는 두개의 진리값중 하나로 TRUE라면 TRUE입니다.
			/// TRUE || TRUE = TRUE
			/// TRUE || FALSE = TRUE
			/// FALSE || FALSE = FALSE

			bool check4 = true || false; // true
			Console.WriteLine("check4 = " + check4);

			bool check5 = (false && true) || check4;
			Console.WriteLine("check5 = " + check5);

			bool check6 = (50 > 40) || (true && (100 <= 200)) || check5 && false;
			Console.WriteLine("check6 = " + check6);

			// > 부정연산
			/// - 피연산자의 진리값을 반대로 뒤집는 연산입니다.
			/// TRUE는 FALSE로 , FALSE는 TRUE로 연산합니다.
			/// !TRUE = FALSE
			/// !FALSE = TRUE

			bool check7 = !check6;
			Console.WriteLine("check7 = " + check7);
		}
	}
}
