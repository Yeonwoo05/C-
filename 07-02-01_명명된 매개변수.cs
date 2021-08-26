using System;
class _01_명명된_매개변수
{
	// 전달 된 두개의 데이터의 크기를 비교해서 더 큰 수를 반환하는 메서드
	static int GetBest(int n1, int n2)
	{
		Console.WriteLine("number1 =" + n1);
		Console.WriteLine("number2 =" + n2);

		return (n1 > n2) ? n1 : n2;
	}
	static void Main()
	{
		Console.Write("비교할 첫번째 숫자 : ");
		int A = int.Parse(Console.ReadLine());
		Console.Write("비교할 두번째 숫자 : ");
		int B = int.Parse(Console.ReadLine());

		Console.WriteLine();

		// 명명된 매개변수를 사용하는 방법?
		// - 메서드를 호출할때 할당할 매개변수의 이름 뒤에 :콜론 을 붙인 뒤
		// 할당할 데이터를 지정을 하면 되면 된다.
		int best = GetBest(n1: A, n2: B);
		Console.WriteLine();
		Console.WriteLine("더 큰수는 : " + best);
	}

}
