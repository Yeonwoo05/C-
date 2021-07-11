using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 형식 변환(Type Conversion)
// - 암시적 변환 : 작은 자료형에서 큰 자료형으로 변환하는 것처럼
///				  변환에 대한 안정성과 데이터 손실에 대한 리스크 없이 
///				  데이터 형식이 변환 되는 것을 의미합니다.

// - 명시적 변환 : 큰 자료형에서 작은 자료형으로 변환하는 것처럼
///				  변환시 값의 손시링 발생할 수 있거나, 변환이
///				  실패할 수 있는 경우 명시적 변환을 사용합니다.(캐스팅)

// > 값의 손실?
/// - 목표 자료형의 허용할 수 잇는 범위가 작은 경우에 허용할 수 없는 범위가
/// 버려지는 현상
 
// > 오버 플로우 : 자료형이 허용할 수 있는 최대 범위를 넘어서는 것
// > 언더 플로우 : 자료형이 허용할 수 있는 최소 범위를 넘어서는 것

namespace _02_변수._02_형식변환
{
	class _01_형식변환
	{
		static void Main()
		{
			int MyInt = 10;
			// 암시적 변환
			// 값의 손실이 없습니다.
			float myFloat = MyInt;
			Console.WriteLine("myFloat = " + myFloat);

			// 명시적 변환
			// 값의 손실이 발생할 수 있습니다.
			// - "목표 자료형" 앞에 작성해서 사용합니다.
			MyInt = (int)myFloat;

			double pi = 3.14;
			// pi -> 문자열형태로 바꿔보세요.
			//string piStr = (string)pi;

			// string형태로 변환을 하려면
			// ToString() 메서드를 사용해야 합니다.

			string piStr = pi.ToString();
			Console.WriteLine(piStr);

			// Parse() : 바꾸고 싶은 자료형.Parse(변수이름);
			// TryParse()
			pi = double.Parse(piStr);

			// > TryParse() ? 변환을 시도
			// - Parse와는 다르게 TryParse()는 변환의 성공 여부를 bool 형식으로 반환
			// 성공했다면 True, 실패했다면 False
			// 어떤 값을 되돌려 받는 것 : 반환(리턴)
			// - 반환 받은 데이터 : 리턴 값, 반환값
			// - 반환 값의 자료형식 : 반환형, 리턴형
			double.TryParse(piStr, out pi);
			// - 괄호의 첫번째 : 변환할 값을 가지고 잇는 문자열을 전달
			// - 괄호의 두번째 : 변환에 성공했을 경우 변환 값을 저장할 변수에 전달
			//		- out ? 출력용 매개변수라는 것을 의미합니다.
			//				메서드 / 함수 내부에서 전달한 변수에 대한 초기화를 보장
			//				이 곳에 전달시킨 변수에는 변환에 실패했을 경우 0이 저장
		}
	}
}
