using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_변수._02_형식변환
{
	class _02_입력
	{
		static void Main()
		{
			// > 입력할 값을 저장할 변수를 선언
			string InputName;

			Console.Write("문자열을 입력해주세요 : ");
			// > 사용자 입력을 받아야 한다.
			// - Console.ReadLine()
			// - 사용자의 입력을 받아 입력한 값을 문자열 형식으로 반환합니다.
			// - string형이 아닌 다른 데이터형의 변환 .Parse()을 사용해서 반환
			InputName = Console.ReadLine();

			Console.WriteLine("InputName = " + InputName);

			Console.Write("나이를 입력하세요 : ");
			int MyAge = int.Parse(Console.ReadLine());

			Console.WriteLine("나이 : " + MyAge);
			Console.WriteLine($"당신의 나이 : {MyAge} 입니다.");

		}
	}
}
