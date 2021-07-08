using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 다음과 같은 변수를 선언하고 초기화하여 출력해보세요.
// - int 자료형 A를 선언하고 100을 설정하여 출력
// - char 자료형 B를 선언하고 ★을 설정하여 출력
// - double 자료형 변수 C를 선언하고 3.14를 설정하여 출력
// - bool 자료형 변수 D를 선언하고 "거짓"을 설정하여 출력
// - string 자료형 변수 E를 선언하고 "안녕하세요?"를 설정하여 출력

namespace _02_변수._01_기본데이터
{
	class _07_기본데이터_문제
	{
		static void Main()
		{
			int		A = 100;
			char	B = '★';
			double	C = 3.14D;
			bool	D = false;
			string	E = "안녕하세요?";

			Console.WriteLine("A = " + A);
			Console.WriteLine("B = " + B);
			Console.WriteLine("C = " + C);
			Console.WriteLine("D = " + D);
			Console.WriteLine("E = " + E);
		}
	}
}
