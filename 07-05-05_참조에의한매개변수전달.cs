using System;
// > 출력 전용 매개 변수 out
// - out은 ref 처럼 참조 전달을 한다는 것을 동일하지만
// out은 매개 변수에 전달되는 인수가 메서드 내부에서 할당됨을 보장받습니다.
class _05_참조에의한매개변수전달
{
	static void DivideRef(int a, int b, ref int q, ref int r) {
		q = a / b;
		r = a % b;
	}

	static void DivideOut(int a, int b, out int q, out int r)
	{
		q = a / b;
		r = a % b;
	}

	static void Main()
	{
		Console.Write("A : ");
		int A = int.Parse(Console.ReadLine());
		Console.Write("B : ");
		int B = int.Parse(Console.ReadLine());
		int Q, R;

		// ref를 사용한다면 ref에 전달된 변수는 
		// 꼭 초기화가 되어 있어야 합니다.
		//DivideRef(A, B, ref Q, ref R);

		DivideOut(A, B, out Q, out R);

		Console.WriteLine();
		Console.WriteLine("A % B : ");
		Console.WriteLine("몫 : " + Q);
		Console.WriteLine("나머지 : " + R);

	}
}