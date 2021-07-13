using System;

// 약한 형식 검사란?
/// - 들어간 값에 따라 컴파일러가 자료형을 알아서 추론해주는 것을 의미
/// - 반드시 선언시 초기화를 해야합니다.
/// - 지역 변수로만 사용을 할 수 있습니다.
///		지역변수 ?
///			- 메서드나, 함수의 코드 블록 내부에서 선언되는 변수를 의미합니다.
///			- 코드 블록을 벗어나게 되면 사라집니다.

namespace _02_변수._05_약한형식검사
{
	class _01_약한형식검사
	{
		static void Main()
		{
			var myInt = 10;
			Console.WriteLine(myInt.GetType());
			// object는 객체의 타입을 알 수 있도록 GetType을 제공합니다.

			var string1 = "강아지는 너무 귀엽습니다.";
			Console.WriteLine(string1.GetType());

			// var 와 object 차이?
			// var : 들어간 값의 형태를 추론해서 자료형을 지정
			// object : 모든 형식의 기반 형태
		}
	}
}
