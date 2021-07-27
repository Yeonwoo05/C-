using System;

// > when : 추가적인 조건 검사를 수행할 때 사용합니다.

class _03_Switch문
{
	static void Main()
	{
		string name = "짱구";
		uint age = 5;

		switch (name)
		{
			/// - name의값은 [철수]이며, age가 5살 초과 일때
			case "짱구" when age > 5:
				Console.WriteLine("짱구의 나이는 5살이 넘습니다.");
				break;
			/// - name의값은 [철수]이며, age가 5살 이하 일때
			case "짱구" when age <= 5:
				Console.WriteLine("짱구의 나이는 5살 아래 입니다.");
				break;
			case "철수":
				Console.WriteLine("짱구가 아닌 철수입니다.");
				break;

		}
	}
}

