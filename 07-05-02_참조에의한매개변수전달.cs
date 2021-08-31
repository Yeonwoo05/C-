using System;
class _02_참조에의한매개변수전달
{
	// value에 전달한 변수에 number의 값을 더하는 메서드
	static void AddNumber( ref int value ,int number)
	{
		// ref?
		// 해당 매개 변수에 전달되는 인수는 [값]이 아닌 [참조]로 전달되는 것을
		// 의미합니다.
		// -ref로 참조 전달되는 값은 boxing 이라는 현상이 일어나지 않습니다.
		value += number;
	}
	static void Main()
	{
		Console.Write("숫자를 입력 : ");
		int A = int.Parse(Console.ReadLine());
		Console.Write($"{A}에 몇을 더할까요 : ");
		int B = int.Parse(Console.ReadLine());

		AddNumber(ref A, B);

		Console.WriteLine($"A의 값은 {A}입니다.");

	}
}