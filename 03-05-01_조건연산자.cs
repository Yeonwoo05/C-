using System;
using System.Reflection.Emit;

// > 조건연산자란?
// - "삼항 연산자" 라고 합니다.
// - 조건식을 검사하여 참일때와 거짓일 때의 값을 다르게 반환시켜주는 연산자
// - 형식 : 변수 = (조건식) ? 참일때의 값 : 거짓일 때의 값;

namespace _03_연산자._05_조건연산자
{
	class _01_조건연산자
	{
		static void Main()
		{
			int A = 10;

			string print = (A == 10) ? "A는 10입니다." : "A는 10이 아닙니다.";
			Console.WriteLine(print);
			Console.WriteLine();

			double x1 = 10.0;
			double y1 = 10.0;

			double x2 = 100.0;
			double y2 = 100.0;

			// 두점의 거리를 구하여 저장합니다.
			double distance = Math.Sqrt((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));
			/// Math 클래스 : 수학함수에대한 상수 및 정적 메서드를 제공
			/// Math.sqrt(value) : 루트 value에 대한 값을 구합니다.
			/// Math.pow(x,y) : x값에 대한 y 제곱을 구합니다.
			Console.WriteLine($"(10,10)과 (100,100)의 거리는 [ {distance}] 입니다.");
			Console.WriteLine("두 점의 거리가 100" + ((distance <= 100) ? "이하입니다." : "이상입니다."));
		}
	}
}
