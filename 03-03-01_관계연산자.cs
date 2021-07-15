using System;

// > 관계연산자

/// - 두 피연산자간의 관계를 확인하는 연산자입니다.
/// - 두 피연산자 같은지? 다른지? 큰지 ? 작은지? 등을 비교할 때 사용합니다.
/// - 모두 bool 형식의 데이터를 리턴합니다.

// > 사용되는 연산자들의 종류?
///	- '=='			: A와 B가 서로 같은 경우 true를 리턴합니다.
///	- '!='			: A와 B가 서로 다를 경우 true를 리턴합니다.
///	- '>','<'		: A와 B의 크기를 비교하며, 초과와 미만을 나타냅니다.
/// - '>=', "<="	: A와 B의 크기를 비교하며, 이상과 이하를 나타냅니다.

namespace _03_연산자._03_관계연산자
{
	class _01_관계연산자
	{
		static void Main()
		{
			// 비교할 변수를 선언
			int a = 10,
				b = 10,
				c = 20;

			// a와 b가 가진 값이서로 같은지검사합니다.
			Console.WriteLine($"(a == b) = { (a == b) }");
			// a와 b가 가진 값이 서로 다른지 검사합니다.
			Console.WriteLine($"(a != b) = { (a != b) }");
			// a의 값이 c를 초과하는지 검사합니다.
			Console.WriteLine($"(a > c) = { (a > c) }");
			// a의 값이 b 이상인지 검사합니다.
			Console.WriteLine($"(a >= b) = { (a >= b) }");

			// 문자열 타입을 할때는 어떻게 할까?
			string mystr1 = "Hello";
			string mystr2 = "Hello";

			Console.WriteLine($"mystr1 == mystr2 = {(mystr1 == mystr2)}");

			// Object와 string 형식을 비교할때는 어떻게 할까?
			// Equals()
			object obj1 = "Hello";
			Console.WriteLine($"mystr1 == obj1 = {mystr1.Equals(obj1)}");
		}
	}
}
