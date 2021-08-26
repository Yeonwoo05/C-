using System;
using System.Security.Cryptography;

// 학생 성적 평가 프로그램
// - int형 Kor, Eng, Math를 각각 국어, 영어, 수학 점수를 입력받고
// 과목의 총점, 과목의 평균, 최고 점수를 출력하는 메서드를 각각 만들고
// 다음과 같이 작동하는 프로그램을 작성해보세요.

// input
// 국어 점수 : 90
// 영어 점수 : 80
// 수학 점수 : 85

// output
// 총점 : 255
// 평균 : 85
// 최고 점수 : 90
// 최고 점수 : 90

class _04_메서드
{
	// 총점을 구하는 메서드
	static int GetTotal(int S1, int S2, int S3)
	{
		return S1 + S2 + S3;
	}

	// 평균을 구하는 메서드
	static double GetAvg(int total, int num)
	{
		return ((double)total / num);
	}

	// 최고점수
	static int GetBest(int s1, int s2, int s3)
	{
		int best = (s1 > s2) ? s1 : s2;
		return (best > s3) ? best : s3;
	}

	static void Main()
	{
		Console.Write("국어 점수 : ");
		int kor = int.Parse(Console.ReadLine());
		Console.Write("수학 점수 : ");
		int math = int.Parse(Console.ReadLine());
		Console.Write("영어 점수 : ");
		int eng = int.Parse(Console.ReadLine());

		Console.WriteLine();

		int total = GetTotal(kor, math, eng);
		Console.WriteLine($"총점 : {total} 점");
		Console.WriteLine($"평균 : {GetAvg(total, 3)} 점");
		Console.WriteLine($"최고 점수 : {GetBest(kor, eng, math)} 점");


	}
}