using System;
using System.Collections.Generic;
using System.Text;

namespace _01_출력
{
	class _02_출력
	{
		static void Main()
		{
			// 어떤 두개의 문자열 데이터를 이어서 표현할 때 '+' 연산자
			Console.Write("강아지" + "는 굉장히 귀엽습니다.\n");
			// 문자열에서 사용하는 "문자열 결합 연산자"라고 합니다.

			Console.WriteLine("나는" + 'C' + '#' + "프로그래밍을 하고 있다.");

			// 만약, 문자열 뒤 + 문자열이 아닌 다른 데이터가 온다면,
			// 다음에 오는 문자열이 아닌 데이터를 문자열로 변환하여 잇습니다.

			Console.WriteLine(20 + " + " + 30 + " = " + 20 + 30 + "입니다.");
			Console.WriteLine(20 + " + " + 30 + " = " + (20 + 30) + "입니다.");

			
		}
	}
}
