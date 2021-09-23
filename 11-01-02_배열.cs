using System;


class _02_배열
{
	// for문을 이용해서 각 배열의 인덱스에 접근 해 봅시다.

	private static void Main() { new _02_배열().Entry(); }

	private void Entry()
	{
		// 요소의 개수가 10개인 배열을 선언하며, 요소들을 집어 넣습니다.
		int[] myArray = new int[10] {1,2,3,4,5,6,7,8,9,10};

		// for문을 이용해서 myArray의 모든 엘리먼트 순회
		for(int i = 0;  // 각각의 엘리먼트에 인덱스 번호에 사용될 변수 i를 선언합니다.
						/// - 배열의 인덱스는 번호 0부터 시작하기 때문에 0으로 초기화
						 
			i < 10;		// - 배열의 i의 값이 9까지 증가했을 때만 반복하도록 설정
						/// 배열의 마지막 인덱스가 9이기 떄문에
						
			++i)		// - 한번씩 반복할때마다 i의 값을 증가시켜
						//   다음 엘리먼트에 접근할 인덱스 번호로 변경합니다.
		{
			Console.WriteLine("myArray[" + i + "] = " + myArray[i]);
		}
		Console.WriteLine();
		// > foreach문
		/// - 배열 또는 컬렉션을 순회하며, 각 데이터 요소에 차례대로 접근하도록 하는 반복문입니다.
		/// - 배열 또는 컬렉션을 반복하는 단순하고 깔끔한 방법으로 제공합니다.
		/// - 끝 엘리먼트에 도달하면 자동으로 반복이 종료됩니다.
		///
		/// - foreach(형식 변수명 in 배열 또는 컬렉션){ 코드... }
		
		foreach(int i in myArray)		
			Console.WriteLine("[foreach] myArray[" + i + "] = " + myArray[i]);
		Console.WriteLine();

		
	}
}