using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_변수._04_NullableType
{
	class _01_NullableType
	{
		static void Main()
		{
			// Nullable Type을 사용하는 방법?
			// - 자료형 뒤에 '?'를 붙여서 사용합니다.
			// - 참조형식에는 사용할 수 없습니다.

			// a 라는 변수를 선언해서 갖는 값을 비워놓습니다.
			int? a = null;

			// NullableType을 검사하는 방법은
			// hasValue를 사용해서 검사합니다.
			// null이라면 False
			// 아니라면 True

			Console.WriteLine(a.HasValue);

			a = 10;
			Console.WriteLine(a.HasValue);
			Console.WriteLine(a);
			Console.WriteLine(a.Value);
		}
	}
}
