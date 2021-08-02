using System;

// Do While문?
/// - 조건식을 평가하기 전에 무조건 처음 한번 do 구문을 실행시킨 후
///   while문의 조건을 평가하는 반복문입니다.
// > Do while문의 모양
/// - do 처음 한번 실행시키고, 조건식이 참일 경우 반복시킬 코드;
///  while(조건식)

class _01_DoWhile문
{
	static void Main()
	{
		int A = 10;
		do
		{
			Console.WriteLine("A = " + A);
			A -= 2;
		} while (A != 10 && A > 0);

		Console.WriteLine();

		int i = 0;
		do
		{
			i++;
			Console.WriteLine(i);
		} while (i < 10);
	}
}