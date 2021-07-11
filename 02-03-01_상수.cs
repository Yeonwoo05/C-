using System;

// > 상수란?
// - 변수와는 달리 저장된 값을 절대 바꿀수 없는 메모리 공간을 뜻합니다.
// - 변수처럼 선언을 하는데, 자료형 앞에 const를 붙여서 사용합니다.

namespace _02_변수._03_상수와열거형
{
	class _01_상수
	{
		static void Main()
		{
			// 상수
			const float Pi = 3.14f;
			// 초기화를 한 뒤에는 다른 값을 가질 수 없습니다.
			//Pi = 3.14159f;

			// 값을 변경할 수 없는 것을 제외하고 변수와 똑같이 사용할 수 있다.
			Console.WriteLine("Pi = " + Pi);

			// 다른 변수에 대입도 가능합니다.
			float PiClone = Pi;
		}
	}
}
