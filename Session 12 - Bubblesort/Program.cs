

int[] talArray = { 12, 9, 5, 4, 16, 3, 8, 1 };
BubbleSort(talArray);

for (int i = 0; i < talArray.Length; i++)
{
    Console.WriteLine(talArray[i] + " ");
}



void BubbleSort(int[] t)
{
	for (int i = t.Length-1; i > 0; i--)
	{
		for (int j = 0; j < i; j++)
		{
			if (t[j] > t[j+1])
			{
				int b = t[j];
				t[j] = t[j + 1];
				t[j + 1] = b;
			}

		}
	}
}