using System;

// 모든 데이터 형식을 다룰 수 있는 Object 형식

// boxing, unboxing
// 값 형식을 참조 형식으로 변환하는 것 : boxing
// 참조 형식을 값 형식으로 변환하는 것 : unboxing


namespace _02_변수._01_기본데이터
{
	class _06_기본데이터
	{
		static void Main()
		{
			// myNumber에 담긴 값 1000을 stack 메모리에 저장을 합니다.
			int myNumber = 1000;

			// mynumber에 담긴 값 1000을 boxing을 통해서 heap 메모리에 저장한 뒤
			// 그 위치를 myObject가 가르키도록 합니다.
			object myObject = myNumber;

			// MyObject가 가르키고 있는 메모리에 저장된 값을 unboxing 해서
			// stack 메모리에 저장을합니다.

			myNumber = (int)myObject;
			// (int) -> Casting입니다.
			// 어떠한 데이터를 지정한 데이터 형태로 변환하라 때 사용합니다.
		}
	}
}
