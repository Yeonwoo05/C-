using System;
class _04_For문
{
	// *
	// * *
	// * * *
	// * * * * 
	// * * * * *

	static void Main()
	{
		// 개행용 for문
		for (int i = 0; i < 5; i++)
		{
			// 출력용 for문
			for (int j = 0; j < i + 1; j++)
				Console.Write(" *");
			Console.WriteLine();
		}
		Console.WriteLine();

		// 2중 포문
		// * * * * *
		// * * * * 
		// * * *
		// * *
		// *
		for (int i = 0; i < 5; i++)
		{
			// 출력용 for문
			for(int j = 0; j < 5 - i; j++)
			{
				Console.Write(" *");
			}
			Console.WriteLine();
		}
		Console.WriteLine();



		// 2중 포문(개행 포문 안에 포문이 2개가 들어있음)
		//         *
		//       * * *
		//     * * * * *
		//   * * * * * * *
		// * * * * * * * * *
		
		// 개행용 for문
		for(int i =0;i < 5; i++)
		{
			// 공백용
			for (int j = 1; j < 5 - i; j++)
				Console.Write("  ");
			//출력용
			for (int k = 0; k < (i * 2) + 1; k++)
				Console.Write(" *");
			Console.WriteLine();
		}
	}
}