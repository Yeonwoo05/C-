using System;

// 문자 형식에는 char 타입을 사용합니다.
// - 문자의 앞 뒤에는 작은 따옴표(') 를 사용해서 char형 데이터임을 표현합니다.
namespace _02_변수._01_기본데이터
{
	class _04_기본데이터
	{
		static void Main()
		{
			char MyCharacter1 = '문';
			char MyCharacter2 = '자';
			Console.WriteLine("MyCharacter1 = " + MyCharacter1);
			Console.WriteLine("MyCharacter2 = " + MyCharacter2);

			Console.WriteLine("MyCharacter1 to int = " + (int)MyCharacter1);
			Console.WriteLine("MyCharacter2 to int = " + (int)MyCharacter2);

			// > string
			// - 문자들이 연속해서 가지런히 놓여있는 줄을 의미합니다.
			// - 문자열이라고 합니다.
			// - 문자열은 큰 따옴표(")를 사용해서 string형 데이터를 표현합니다.

			string MyString1 = "안녕하세요.";
			string MyString2 = "재밌는 C#입니다.";

			Console.WriteLine("MyString1 = " + MyString1);
			Console.WriteLine("MyString2 = " + MyString2);

		}
	}
}
