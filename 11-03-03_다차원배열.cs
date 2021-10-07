using System;

// 3차원 배열을 하나 만든 뒤
// 1 ~ 24까지 출력해주세요
class _03_다차원배열
{
	private static void Main() { new _03_다차원배열().Entry(); }
	private void Entry()
	{
		int[,,] MyArray = new int[2, 3, 4];
		int count = 0;
		for(int i = 0;i < MyArray.GetLength(0); i++)
		{
			for(int j = 0; j < MyArray.GetLength(1); j++)
			{
				for(int k = 0; k < MyArray.GetLength(2); k++)
				{
					MyArray[i, j, k] = ++count;
					int elemvalue = MyArray[i, j, k];
					Console.Write("[ " + (elemvalue < 10 ? " " : "") + elemvalue + " ] ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}


	}
}

