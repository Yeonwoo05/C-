using System;
class _05_For문
{
	// 유클리드 호제법
	// > 주어진 두 수의 최대 공약수를 구하는 알고리즘

	// > 순서
	/// - N 과 M을 입력받습니다.
	/// - M의 값이 0이라면 N은 최대공약수입니다.
	/// - temp에 N을 M으로 나눈 나머지를 입력합니다.
	/// - N에는 M, M에는 temp를 넣습니다.
	/// - 다시 2번으로 돌아가 5번까지 반복합니다.
	/// 
	static void Main()
	{
		int N, M;
		Console.Write("N ? ");
		N = int.Parse(Console.ReadLine());
		Console.Write("M ? ");
		M = int.Parse(Console.ReadLine());

		for (; M != 0;)
		{
			// temp에 N을 M으로 나눈 나머지를 입력
			int temp = N % M;

			// N = M, M = temp
			N = M;
			M = temp;
		}
		Console.WriteLine($"최대 공약수는 {N} 입니다.");
	}
}