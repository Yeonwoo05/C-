using System;

// > 반복문이란?
/// - 특정 조건을 만족하는 동안 코드 또는 코드 블록을 반복하여 실행하도록 하는 문장입니다.
/// - C# 에서 총 4개의 반복문을 제공합니다.
/// - while, for, do while, foreach

// > while문 사용 방법?
/// - while(조건식) 조건식이 참일 경우 반복시킬 구문;

/// - while(조건식) {
/// 
///		조건식이 참일 경우 반복시킬 구문;
///		조건식이 참일 경우 반복시킬 구문;
///		조건식이 참일 경우 반복시킬 구문;
/// }

class _01_While문
{
	static void Main()
	{
		// 무한루프
		while (true) Console.WriteLine("Hello World!");
	}
}