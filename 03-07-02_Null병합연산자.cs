using System;

// > Null병합연산자?
/// - Null 조건부 연산자 처럼 변수나 객체의 null 검사를 간결하게 만들어주는 연산자입니다.
/// - 왼쪽 피연산자의 값을 검사하여 null 이라면 오른쪽 피연산자의 값을 넣어주고, 
///   null이 아니라면 피연산자의 값을 반환하는 연산자입니다.


namespace _03_연산자
{
	class _02_Null병합연산자
	{
		static void Main()
		{
			object A = 10;
			object B = A ?? 100;
			// object B = (A != null) ? A : 100;

			Console.WriteLine("B = " + B);
		}
	}
}
