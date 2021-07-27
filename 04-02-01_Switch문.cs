using System;

//Switch문?
/// - 조건식의 결과가 가질수 잇는 다양한 경우를 한번에 평가하고
///   프로그램의 흐름을 가를 때 사용하는 분기문입니다.

// > Switch문의 사용방법?
// - switch()에 결과를 검사할 값을 넣습니다.
// - case문을 사용해서 경우의 수를 추가합니다.
// - 하나의 case문이 끝나면 break, return을 사용해서 마무리 합니다.
// - 모든 경우가 아니라면 default를 사용합니다.
// - case문은 정수, 문자열의 형식의 상수, 데이터 형식만 지원합니다.

/// switch(검사할 값) {
///
///		case 상수 1:
///			실행시킬 코드;
///			break;
///		case 상수 2:
///			실행시킬 코드;
///			break;
///		default:
///			실행시킬 코드;
///			break;
/// }

class _01_Switch문
{
	static void Main()
	{
		int number = 20;

		switch (number)
		{
			case 10:
				Console.WriteLine("number는 10입니다.");
				break;
			case 20:
				Console.WriteLine("number는 20입니다.");
				break;
			case 30:
				Console.WriteLine("number는 30입니다.");
				break;
			default:
				Console.WriteLine("number는 10, 20, 30이 아닙니다.");
				break;

		}
	}
}
