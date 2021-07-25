using System;

// 철수는 시험을 봤습니다.
// 철수의 시험점수를 입력받고 등급을 표시하세요
// - 철수의 시험점수는 0 ~ 100점 사이의 자연수입니다.
//	만약 범위밖의 수가 입력되었을 경우
// - 0 미만이라면 0으로 100초과라면 100으로 변경한 뒤 등급을 표시해주세요.

// 95점 이상 : A+
// 90점 이상 : A
// 85점 이상 : B+
// 80점 이상 : B
// 75점 이상 : C+
// 70점 이상 : C
// 65점 이상 : D+
// 60점 이상 : D
// 그 외의 점수 : F - 재수강

class _07_IF문
{
	static void Main()
	{
		Console.Write("철수의 시험 점수를 입력하세요 : ");
		int score = int.Parse(Console.ReadLine());

		if (score < 0) score = 0;
		else if (score > 100) score = 100;

		Console.WriteLine($"철수의 점수 : {score}");

		if (score >= 95)		Console.WriteLine("A+");
		else if (score >= 90)	Console.WriteLine("A");
		else if (score >= 85)	Console.WriteLine("B+");
		else if (score >= 80)	Console.WriteLine("B");
		else if (score >= 75)	Console.WriteLine("C+");
		else if (score >= 70)	Console.WriteLine("C");
		else if (score >= 65)	Console.WriteLine("D+");
		else if (score >= 60)	Console.WriteLine("D");
		else					Console.WriteLine("F - 재수강");
	}
}

