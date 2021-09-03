using System;

// > 학생 정보 출력 프로그램을 작성합니다.
/// - 학생 클래스 : Student
/// 학생의 필드 : 국어 점수, 영어 점수, 수학 점수
/// 학생의 기능 : 세 과목의 총점 구하기
///				 세 과목의 평균 구하기
///				 세 과목중 최고 점수 구하기
///				 세 과목중 최저 점수 구하기
///	** 주의점 **
///	모든 기능들은 void 형태가 아닙니다.
///	

// 실행 순서
// - 학생의 과목 점수를 모두 입력받고 모든 점수를 출력합니다.
// - 총점, 평균, 최고 점수, 최점점수 출력해주세요.

class Student
{
	// 점수 받을 변수
	public int kor, eng, math;

	// 총점 메서드
	public int GetTotal()
	{
		return kor + eng + math;
	}
	// 평균 메서드
	public double GetAvg()
	{
		return GetTotal() / 3.0;
	}
	// 최고 점수
	public int GetBest()
	{
		int best = (kor > eng) ? kor : eng;
		return (best > math) ? best : math;
	}
	// 최저 점수
	public int GetWorst()
	{
		int worst = (kor < eng) ? kor : eng;
		return (worst < math) ? worst : math;
	}

	public void PrintScores()
	{
		Console.WriteLine("국어 : " + kor);
		Console.WriteLine("영어 : " + eng);
		Console.WriteLine("수학 : " + math);
		Console.WriteLine();
	}
}

class _04_클래스
{
	static void Main()
	{
		Student st = new Student();
		Console.Write("국어 점수 : ");
		st.kor = int.Parse(Console.ReadLine());
		Console.Write("영어 점수 : ");
		st.eng = int.Parse(Console.ReadLine());
		Console.Write("수학 점수 : ");
		st.math = int.Parse(Console.ReadLine());
		Console.WriteLine();
		// 모든 점수를 출력
		st.PrintScores();

		// 총점, 평균, 최고, 최저 점수 출력
		Console.WriteLine("총점 : " + st.GetTotal());
		Console.WriteLine("평균 : " + st.GetAvg());
		Console.WriteLine("최고 : " + st.GetBest());
		Console.WriteLine("최저 : " + st.GetWorst());


	}
}