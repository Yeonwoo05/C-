﻿using System;

// for문이란?
/// - [초기식, 조건식, 증감식] 으로 이루어진 반복문
/// while문보다 더 정교하게 제어할 수 있습니다.

/// - 초기식 : 반복을 실행하기 전에 가장 먼저 한번만 실행되는 코드입니다.
///   for문에서 사용할 변수등을 이곳에서 먼저 초기화합니다.

/// - 조건식 : 반복을 계속 수행할 것인지를 경정하는 식입니다.
///   조건식이 false라면 진행하던 반복을 중단합니다.

/// - 증감식 : 반복문이 끝날때 마다 실행합니다.
///   이곳에서 조건식에서 사용되는 변수의 값을 조정합니다.

// int i = 0; -> 초기식
// while(i != 10) -> 조건식
//  i ++ -> 증감식

// for (초기식; 조건식; 증감식) 조건식이 참일 경우 반복시킬 코드;


class _01_For문
{
	static void Main()
	{
		for(int i = 0; i < 10; i++)
		{
			Console.WriteLine($"{i + 1}번 반복했습니다.");
		}

		for (; ; ) Console.WriteLine("반복!");
	}
}