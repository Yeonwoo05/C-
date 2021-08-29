using System;

// 선택적 매개변수
// - 기본 값을 가지는 매개 변수이며, 필요에 따라 데이터를 할당할 수 있는
//   매개변수를 의미합니다.
// - 선택적 매개변수는 메서드를 호출할때 데이터 할당을 생략할 수 있다.
// - 필요한 경우 특정한 데이터를 할당 시킬수도 있습니다.
// 꼭 필요 매개변수 뒤에 선언되어야 합니다.

class _01_선택적_매개변수
{
	// 계산 타입 열거형
	enum CalculateType : sbyte
	{ Addition, Subtraction, Multiplication, Division}

	static double Calculate(double A, double B,
		CalculateType type = CalculateType.Addition, bool Print = false)
	{
		// 필수 매개 변수 : A, B
		// 선택적 매개 변수 : type, print

		// 어떤 연산을 했는지 저장할 변수
		string calculateType = "";
		// 연산 결과를 저장할 변수
		double result = 0.0;

		switch (type)
		{
			case CalculateType.Addition:
				calculateType = "덧셈";
				result = A + B;
				break;
			case CalculateType.Subtraction:
				calculateType = "뺄셈";
				result = A - B;
				break;
			case CalculateType.Multiplication:
				calculateType = "곱셈";
				result = A * B;
				break;
			case CalculateType.Division:
				calculateType = "나눗셈";
				result = A / B;
				break;
			default:
				calculateType = "";
				result = 0.0;
				break;
		}
		if (Print) Console.WriteLine($"{calculateType} 결과 : {result}");

		return result;
	}
	static void Main()
	{
		Console.Write("연산형 숫자 데이터 입력 : ");
		double data1 = double.Parse(Console.ReadLine());
		Console.Write("연산형 숫자 데이터 입력 : ");
		double data2 = double.Parse(Console.ReadLine());

		Console.WriteLine();
		// 연산 고르기
		Console.WriteLine("어떤 연산을 할까요 ? ");
		Console.WriteLine("1 : 덧셈, 2 : 뺄셈, 3 : 곱셈, 4 : 나눗셈");
		Console.Write("입력 : ");

		int selectType = int.Parse(Console.ReadLine());
		CalculateType calculateType = (CalculateType)(selectType - 1);

		double result = Calculate(data1, data2, calculateType);

		Console.WriteLine("결과 = " + result);
		
	}
}