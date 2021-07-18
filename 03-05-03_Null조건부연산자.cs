using System;

// > Null 조건부 연산자?
/// - 접근하려는 값이 null 인지 검사하여 그 결과가 null 이라면 null을 반환
///   null 이 아니라면 접근하려는 값을 반환하는 연산자입니다.

namespace _03_연산자._05_조건연산자
{
	class _03_Null조건부연산자
	{
		static void Main()
		{
			int a = 10;
			object nullObject = null;
			object myObject = a;/*nullObject?.ToString();*/

			Console.WriteLine("myObject is Not Value ? " +
				((myObject == null) ? "YES" : "No, my ObjectValue =" +
				myObject));
		}
	}
}
