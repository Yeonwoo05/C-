using System;

// > 분기문?
/// - 프로그램의 흐름을 조건에 따라 여러 갈래로 나누는 흐름 제어 구문입니다.
/// - C#에서는 보통 한 번에 단 하나의 조건만 평가할 수 있는 if문과
///   한번에 여러가지의 조건을 평가할 수 있는 switch문을 제공을 하고 있습니다.

namespace _04_분기문._01_IF문
{
	class _01_IF문
	{
		static void Main()
		{
			// > if문 사용법?
			/// - if(조건식) 조건식이 참이라면 실행할 구문;
			if (true) Console.WriteLine("실행!");
			Console.WriteLine("if문 종료!");

			// 실행할 구문이 여러개라면 영역을 설정후 넣어줍니다.
			if(3 % 2 == 1)
			{
				Console.WriteLine("3이 홀수인지 검사합니다.");
				Console.WriteLine("3은 홀수입니다.");
			}
		}

	}
}
