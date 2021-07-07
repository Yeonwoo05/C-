using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_변수._01_기본데이터
{
	class _02_기본데이터
	{
		static void Main()
		{
			// 2 진수 형식 '0b' 접두사, 16진수 '0x' 접두사
			// 240 = 128 + 64 + 32 + 16 + 0 + 0 + 0 + 0
			//       2^7  2^6  2^5  2^4  2^3 2^2 2^1 2^0
			int number1 = 0b1111_0000;
			Console.WriteLine("number1 = " + number1);

			// 16진수 : 0 ~ F까지 표현
			// 0, 1, 2, 3 , 4 , 5, 6 , 7 , 8 , 9, A, B, C, D, E, F
			// 240 = F0
			int number2 = 0xF0;
			Console.WriteLine("number2 = " + number2);
		}
	}
}
