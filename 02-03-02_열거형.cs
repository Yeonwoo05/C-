using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_변수._03_상수와열거형
{
	class _02_열거형
	{
		// 열거형이란?
		// 서로 연관된 상수들의 집합을 의미합니다.
		// -enum 키워드 사용합니다.

		enum ButtonTypes { Yes=20, No, Ok, Cancel };
		static void Main()
		{
			ButtonTypes btn1 = ButtonTypes.Yes;
			ButtonTypes btn2 = ButtonTypes.No;
			ButtonTypes btn3 = ButtonTypes.Ok;
			ButtonTypes btn4 = ButtonTypes.Cancel;

			Console.WriteLine($"btn1 = {btn1}");
			Console.WriteLine($"btn2 = {btn2}");
			Console.WriteLine($"btn3 = {btn3}");
			Console.WriteLine($"btn4 = {btn4}");
		}
	}
}
