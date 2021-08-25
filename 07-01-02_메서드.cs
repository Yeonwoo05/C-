using System;
class _02_메서드
{
	// > 반환형식이 void 가 아닌 메서드
	/// - 반환형식이 void 가 아닌 다른 자료형이라면
	/// 반드시 return문을 사용해서 어떠한 값을 반환해야 합니다.
	
	// return ?
	// - 메서드의 실행을 종료하고 프로그램의 흐름을 사용자에게 돌려놓는것을 의미합니다.
	// - 반환형식이 void 형식이 아닌 메서드에서는 return 반환 값; 로 어떤 값을 반환해야합니다.
	// - 반환형식이 void라면 return; 사용해서 메서드의 실행을 종료할 수 있습니다.

	// int형식을 반환하는 GetLuckyNumber 메서드를 정의합니다.
	static int GetLuckyNumber()
	{
		int LuckNumber = 7;
		Console.WriteLine("행운의 번호는 " + LuckNumber + "입니다.");

		return LuckNumber;
	}

	static void Input()
	{
		Console.Write("짱구를 입력해주세요. : ");
		string name = Console.ReadLine();

		// 입력한 문자열이 "짱구"인지 검사합니다.
		if (name.Equals("짱구"))
		{
			Console.WriteLine("입력한 문자열 \"짱구\"와 일치합니다.");
		}
		else
		{
			Console.WriteLine("입력한 문자열 \"짱구\"와 일치하지 않습니다.");
			Console.WriteLine("입력을 종료합니다.");
			return;
		}
		Console.Write(name + "의 나이는 몇살 입니까? : ");
		int age = int.Parse(Console.ReadLine());
		Console.WriteLine(name + "의 나이는 " + age + "살 입니다.");
	}

	static void Main()
	{
		GetLuckyNumber();
		// 변수안에다가 메서드의 반환값을 넣을 수 있습니다.
		int Lucky = GetLuckyNumber();
		Console.WriteLine("Lucky = " + Lucky);

		Input();
	}
}