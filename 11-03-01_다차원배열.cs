using System;

// > 다차원 배열이란?
/// - 배열을 요소로 갖는 배열을 말합니다.

class _01_다차원배열
{
	private static void Main()
	{
		// > 2차원 배열
		/// - 각각의 엘리먼트가 1차원 배열을 하나씩 갖습니다.
		/// - [] , [,]로 2차원 배열을 선언을 합니다.
		/// - new 자료형[2차원길이, 1차원길이]로 메모리 할당을 한다.
		///
		// 길이가 4인 배열을 원소로 3개 갖는 2차원 배열을 선언해주세요.
		int[,] myArray = new int[3, 4];
		/// [ㅁㅁㅁㅁ]
		/// [ㅁㅁㅁㅁ]
		/// [ㅁㅁㅁㅁ]
		int len2 = myArray.GetLength(0);
		int len1 = myArray.GetLength(1);

		// 배열의 값을 초기화할 때 사용할 변수
		int count = 0;

		// 2차원 배열을 순회할 for문을 작성을 합니다.
		// - 2차원 배열의 모든 요소들의 데이터 형식은 "int[]"입니다.
		for (int i = 0; i < len2; i++)
		{
			for(int j = 0;j < len1; j++)
			{
				myArray[i, j] = ++count;
			}
		}

		for (int i = 0;i < len2; i++)
		{
			for (int j = 0;j < len1; j++)
			{
				int elemvalue = myArray[i, j];
				Console.Write("[ " + (elemvalue < 10 ? " " : "") + elemvalue + " ]");

			}
			Console.WriteLine();
		}
	}
}

