using System;

class _03_IF문
{
	// > 철수의 국영수 점수를 입력받고 평균을 구하여 다음과 같은 결과를 출력해주세요.
	/// - 평균이 80.5 이상이라면 "국여수의 평균은 80.5이상입니다." 출력
	/// 아니라면 "국영수의 평균은 80.5 이상이 아닙니다." 출력
	/// - 평균을 구하는 법 : (과목의 총점) / (과목 수)
	static void Main()
	{
		// 변수 선언
		int kor, eng, math;

		// 입력 
		Console.WriteLine("철수의 국어, 영어, 수학 점수를 입력해주세요.");
		Console.Write("국어 : ");
		kor = int.Parse(Console.ReadLine());
		Console.Write("영어 : ");
		eng = int.Parse(Console.ReadLine());
		Console.Write("수학 : ");
		math = int.Parse(Console.ReadLine());

		// 평균 계산
		double avg = ((kor + eng + math) / 3.0f);

		if (avg >= 80.5) Console.WriteLine("국영수의 평균은 80.5이상입니다.");
		else Console.WriteLine("국영수의 평균은 80.5이상이 아닙니다.");
	} 

}

