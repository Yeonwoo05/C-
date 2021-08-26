using System;
// 매개변수
/// - 메서드에서 사용할 데이터를 전달받는 일을 하는 변수입니다.
/// - 메서드 외부에서는 사용을 할 수 없습니다.
class _03_메서드
{
	// birthYear 전달된 데이터를 이용해서
	// 나이를 출력할 메서드를 만듭니다.
	static int PrintAge(int birthYear, bool print)
	{
		// 현재 년도를 저장할 변수
		int year = DateTime.Now.Year;
		// DateTime : 날짜오하 시간 데이터를 제공하는 구조체
		// DateTime.Now : 현재 현지 위치의 날짜와 시간을 가져옵니다.
		// DateTime.Now.Year : 현재 년도를 가져옵니다.

		// 내 나이를 구해서 저장할 변수
		int yourage = year - birthYear + 1;
		if(print) Console.WriteLine("당신의 나이는 " + yourage + "살 입니다.");
		return yourage;
	}
	static void Main()
	{
		Console.Write("태어난 년도를 입력하세요.\n입력 : ");
		int year = int.Parse(Console.ReadLine());

		PrintAge(year, true);
	}

	// 매개 변수가 2개 이상인 경우
	// 어떤 매개 변수에 데이터를 어떤 형식으로 할당할 것인지를 지정하는 순서입니다.
	// printAge(year, true);
	// birthYear = year
	// print = true


}
