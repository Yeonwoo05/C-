using Microsoft.SqlServer.Server;
using System;
class _02_Break
{
	static void Main()
	{
		// 사용자 의 입력을 받아 저장할 변수
		string name;
		while (true)
		{
			Console.WriteLine("\"철수\" 를 입력해주세요.");
			name = Console.ReadLine();

			// name의 값이 "철수"라면
			// if(name=="철수")
			if (name.Equals("철수"))
				break;
			// 아니라면
			else Console.WriteLine("잘못 입력했습니다.");
		}
		Console.WriteLine($"{name}를 입력하셨습니다.");
	}
}