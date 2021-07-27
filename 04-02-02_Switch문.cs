
using System;

// > switch case문을 이용해서 데이터의 형식에 따라 분기를 만들 수 있습니다.
// - 이 때 case문에서는 꼭 식별자를 붙여줘야 합니다.

class _02_Switch문
{
	static void Main()
	{
		object obj = 3.0;

		switch (obj)
		{
			case int i:
				Console.WriteLine("obj는 int 형식 입니다.");
				break;
			case double d:
				Console.WriteLine("obj는 double 형식 입니다.");
				break;
			case float f:
				Console.WriteLine("obj는 float 형식 입니다.");
				break;
		}

		switch (obj.GetType().Name)
		{
			// obj가 int형식 일 때
			case "Int32":
				Console.WriteLine("obj는 int 형식 입니다.");
				break;
			case "Double":
				Console.WriteLine("obj는 double 형식 입니다.");
				break;
			case "Single":
				Console.WriteLine("obj는 float 형식 입니다.");
				break;
		}

	}
}
