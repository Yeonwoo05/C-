using System;

// > 부동 소수점?
// - 소수점이 고정되어있지 않고 움직이면서 수를 표현한다는 뜻에서 지어진 이름
// [데이터 형식]    [크기 (byte) ]   [설명]
//		float			4			단일 정밀도 부동 소수점 형식 / 유효자리(7자리)
//		double			8			복수 정밀도 부동 소수점 형식 / 유효자리(15~16자리)
//		decimal			16			유효자리(29)

namespace _02_변수._01_기본데이터
{
	class _03_기본데이터
	{
		static void Main()
		{
			// float
			// > 값 뒤에 'f', 'F'를 붙여서 float형 데이터를 표현합니다.
			float MyFloat = 3.14f;
			Console.WriteLine("MyFloat = " + MyFloat);

			// > double
			// double 'd', 'D'를 붙여서 표현을 해도 되지만
			// 굳이 작성하지 않아도 double데이터로 인식합니다.
			double MyDouble = 123.4567;
			Console.WriteLine("MyDouble = " + MyDouble);

			// > Decimal
			// decimal은 'm', 'M'을 붙여서 표현합니다.
			decimal MyDecimal = 0.1234567890m;
			Console.WriteLine("MyDecimal = " + MyDecimal);
		}
	}
}
