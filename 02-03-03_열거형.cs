using System;
namespace _02_변수._03_상수와열거형
{
	class _03_열거형
	{
		// > 열거형에 기반 형식으로 설정을 할 수도 있습니다.
		// - 기반 자료형 지정을 하지 않는다면 int 형식으로 설정된다.
		enum classes : sbyte 
		{
			AClass = 10,
			BClass = 20,
			CClass = 30
		}
		static void Main()
		{
			classes aClass = classes.AClass;
			classes bClass = classes.BClass;
			classes cClass = classes.CClass;

			Console.WriteLine("aClass = " + (int)aClass);
			Console.WriteLine("bClass = " + (int)bClass);
			Console.WriteLine("cClass = " + (int)cClass);
		}
	}
}
