using System;
class _01_Goto
{
	// Goto문
	// - 지정한 레이블 위치로 한번에 프로그램의 흐름을 도약시키는 점프문입니다.
	//  레이블 ? 코드 안에 위치를 나타내는 표지판

	static void Main()
	{
		int A = 0;
		while (true)
		{
			if (A == 5) goto Port;
			Console.WriteLine($"A의 값은 {(A++)}입니다.");
		}
	// > 레이블 Port를 선언합니다.
	Port:
		Console.WriteLine("Port!");
		
	}
}