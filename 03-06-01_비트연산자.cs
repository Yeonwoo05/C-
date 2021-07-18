using System;
using System.Net.Configuration;

// > 비트연산자
// 0,1 이루어진 비트를 연산을 하기 위한 연산자

// > 연산자의 종류
// - << : 왼쪽 시프트 연산자
///		  왼쪽 피연산자의 비트를 두번째 비트 연산자의 수만큼 왼쪽 이동
///		  왼쪽 피연산자는 int, uint, long, ulong을 오른쪽 피연산자는 int 형식
///		  
// - >> : 오른쪽 시프트 연산자
///		  왼쪽 피연사자의 비트를 두번째 비트 연산자의 오른쪽으로 이동
///		  왼쪽 피연산자는 int, uint, long, ulong을 오른쪽 피연산자는 int 형식
///		  
// - &  : 논리곱(AND) 연산자
///		  두 피연사자의 비트 논리곱을 수행합니다.
///		  정수와 bool 형식에 사용이 가능
///		  
// - |  : 논리합(OR) 연산자
///		  두 피연사자의 비트 논리합을 수행합니다.
///		  정수와 bool 형식에 사용이 가능
///		  
// - ^  : 베타적 논리합(XOR) 연산자
///		  두 피연산자의 비트 베타적 논리합을 수행합니다.
///		  * 두 연산자의 값이 서로 다를때만 1인 연산 *
///		  정수와 bool 형식에 사용이 가능
///		  
// - ~  : 보수(NOT) 연산자
///		  피연산자의 비트를 0은 1로 1은 0으로 반전시킵니다.
///		  정수와 bool 형식에 사용이 가능

namespace _03_연산자._06_비트연산자
{
	class _01_비트연산자
	{
		static void Main()
		{
			Console.WriteLine("※ << , >> 연산");
			int var1 = 100;
			// 왼쪽 시프트 연산 전 출력
			// - 1100100
			Console.WriteLine("var1 = " + var1);
			// Convert 클래스 : 변환 함수에 대한 정적 메서드를 제공하는 클래스
			// Convert.ToStrint(value, toBase)
			Console.WriteLine("var1 = " + Convert.ToString(var1, 2));

			// 왼쪽 시프트 연산
			var1 = var1 << 2;
			Console.WriteLine("var1 = " + Convert.ToString(var1, 2));
			Console.WriteLine("var1 = " + var1);
			var1 = var1 >> 2;
			Console.WriteLine("var1 = " + Convert.ToString(var1, 2));
			Console.WriteLine("var1 = " + var1);
			Console.WriteLine();

			Console.WriteLine("※ & 연산");
			int var2 = 12;
			int var3 = 8;
			int result = var2 & var3;
			Console.WriteLine("var2 = " + Convert.ToString(var2, 2) + " = " + var2);
			Console.WriteLine("var3 = " + Convert.ToString(var3, 2) + " = " + var3);
			Console.WriteLine("result = " + Convert.ToString(result, 2) + " = " + result);
			Console.WriteLine();

			Console.WriteLine("※ | 연산");
			result = var2 | var3;
			Console.WriteLine("var2 = " + Convert.ToString(var2, 2) + " = " + var2);
			Console.WriteLine("var3 = " + Convert.ToString(var3, 2) + " = " + var3);
			Console.WriteLine("result = " + Convert.ToString(result, 2) + " = " + result);
			Console.WriteLine();

			Console.WriteLine("※ ^ 연산");
			result = var2 ^ var3;
			Console.WriteLine("var2 = " + Convert.ToString(var2, 2) + " = " + var2);
			Console.WriteLine("var3 = " + Convert.ToString(var3, 2) + " = " + var3);
			Console.WriteLine("result = " + Convert.ToString(result, 2) + " = " + result);
			Console.WriteLine(); 
			
			Console.WriteLine("※ ~ 연산");
			result = ~result;
			Console.WriteLine("result = " + Convert.ToString(result, 2) + " = " + result);
			Console.WriteLine();

			int intMax = 0b01111111111111111111111111111111;
			// unchecked() : 정수 형식 산술 연산 및 변환에 대한 오버플로우 검사를
			// 비활성화 시킬때 사용합니다.
			int intMin = unchecked((int)0b10000000000000000000000000000000);

			Console.WriteLine("intMax = " + intMax);
			Console.WriteLine("intMin = " + intMin);
		}
	}
}
