using System;

// > 단항연산자란?
// - 피연산자가 1개인 연산자입니다.
// - "증감연산자" = 증가연사자, 감소연산자
// - 전위, 후위연산자 = 전처리, 후처리
// - 수치 데이터 형식, 열거 형식이 사용이 가능합니다.

namespace _03_연산자._02_단항연산자
{
	class _01_단항연산자
	{
		static void Main()
		{
			int count = 0;

			// > 증가 연산자 : [++]
			// - 피연사자의 값을 1 증가시킵니다.
			count++;
			Console.WriteLine("++count =" + count);
			Console.WriteLine();

			// > 감소 연산자 : [--]
			// - 피연산자의 값을 1 감소시킵니다.
			count--;
			Console.WriteLine("count-- =" + count);
			Console.WriteLine();

			// 전위 연산자
			// - 연산자의 변수 앞에 사용합니다.
			// - 연산 후 결과를 반환합니다.
			Console.WriteLine("++count =" + (++count));
			Console.WriteLine();

			// 후위 연산자
			// - 연산자의 변수 뒤에 사용합니다.
			// - 연산 전 결과를 반환을 해줍니다.
			Console.WriteLine("count++ = " + (count++));
			Console.WriteLine();
			Console.WriteLine("count = " + count);
		}
	}
}
