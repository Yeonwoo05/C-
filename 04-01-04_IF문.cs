using System;

// 영희는 아르바이트를 하고 있습니다.
/// 영희는 일한 시간을 입력받고 영희의 임금을 출력하는 프로그램을 작성하세요!
/// - 영희가 일한 시간이 8시간을 초과한 경우, 초과한 시간은 최저임금 * 1.5배로 계산합니다.
///   8시간을 초과한 경우
///   8시간 = 최저시급으로 계산
///   초과한 시간 = 최저 시금 * 1.5
///   임금 = (8시간) + (초과한시간)

///   최저 시급 = 8590

class _04_IF문
{
	static void Main()
	{
		// 최저 임금
		const int RATE = 8590;

		// 일한 시간, 임금
		int hours, pay;

		// 일한 시간을 입력받습니다.
		Console.Write("영희가 일한 시간 : ");
		hours = int.Parse(Console.ReadLine());

		// 8시간을 초과하지 않은 경우
		if (hours <= 8) pay = (RATE * hours);


		// 8시간을 초과한 경우
		else pay = (int)((RATE*8) + ((RATE * 1.5) * (hours - 8)));

		// 결과 출력
		Console.WriteLine($"임금은 {pay}원 입니다.");


	}
}
