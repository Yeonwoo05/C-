using System;

namespace _04_분기문._01_IF문
{
	class _02_IF문
	{
		static void Main()
		{
			// > else 문 : 상단의 if문의 조건식이 거짓일 경우 사용을 합니다.
			/// - else만 사용할 수 없고 무조건 if, else if 다음에 사용되어야 합니다.

			int result = 2;

			// > result가 5이상인지 검사합니다.
			if (result >= 5) Console.WriteLine("Result는 5 이상입니다.");
			else Console.WriteLine("result는 5 미만입니다.");
		}
	}
}
