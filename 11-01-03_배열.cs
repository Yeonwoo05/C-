using System;

class _03_배열
{
	private static void Main() { new _03_배열().Entry(); }

	private void Entry()
	{
		// 만약 배열의 범위를 초과하여 사용할 경우 
		/// IndexOutOfRangeException 예외가 발생합니다.
		/// IndexOutOfRangeException : 배열의 컬렉션 범위를 벗어난 멤버에 접근하려할때마다 발생하는 예외입니다.

		// > 예외?
		/// - 프로그래머의 실수가 아닌, 외부 시스템이나 조건들에 의해
		///   더이상 작업을 수행하지 못하는 것을 의미합니다.

		// > 예외처리
		/// - 이러한 예외가 프로그램의 오류나 다운으로 이어지지 않도록 적절히 처리하는 것을 의미합니다.

		// > 배열선언
		int[] myArray = new int[3];

		// 배열의 길이를 저장할 변수를 선언합니다.
		int myArrayLength = myArray.Length;

		// 각 엘리먼트에 값을 할당합니다.
		for (int i = 0;i < myArrayLength; i++)
		{
			myArray[i] = (i * 10) + 10;
		}

		// for (int i = 0; true; ++i)
		// {
		// 	// 예외처리
		// 	if (i == myArrayLength) break;
		// 	Console.WriteLine($"myArray[{i}] = " + myArray[i]);
		// }

		for (int i = 0; true; ++i)
		{
			// 다음 코드 블록 내부의 구문을 실행하도록 시도합니다.
			try { Console.WriteLine($"myArray[{i}] = " + myArray[i]); }

			// > 만약 "IndexOutOfRangeException" 예외가 발생한다면 프로그램을 종료시키지 않고
			// 다음 코드를 실행합니다.
			catch (IndexOutOfRangeException e)
			{
				Console.WriteLine();
				Console.WriteLine("*-- IndexOutOfRangeExceotion이 발생하였습니다. --*");
				Console.WriteLine("내용 : " + e.Message);
				Console.WriteLine();
				// e.Message : 현재 발생한 예외를 설명하는 메시지를 얻습니다.
				break;
			}


		}




	}
}

