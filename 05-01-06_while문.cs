using System;

// > 구구단을 1단부터 9단까지 출력해주세요
						/// - 1단 - 
						/// 1 X 1 = 1
						/// 1 X 2 = 2
						/// ...
						/// 1 X 9 = 9
						/// - 2단 -
						/// 2 X 1 = 2
						/// 2 X 2 = 4
						/// ....
						/// - 9단 -
						/// 9 X 1 = 9
						/// 9 X 2 = 18
						/// ...
						/// 9 X 9 = 81

class _06_While문
{
	static void Main()
	{
		int N = 1;
		while (N < 10)
		{
			Console.WriteLine($" - {N}단 - ");
			int M = 1;
			while (M < 10)
				Console.WriteLine($"{N} X {M} = {(N * M++)}");
			N++;

			Console.WriteLine();
		}
	}
}