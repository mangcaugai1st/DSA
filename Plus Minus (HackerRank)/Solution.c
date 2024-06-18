#include <stdio.h>
#include <stdlib.h>
#include <string.h>

void plusMinus(void);

int main()
{
	int myArr[] = { 1, 1, 0, -1, -1 };
	int* arr = myArr;
	int arr_count = sizeof(myArr) / sizeof(myArr[0]);
	plusMinus(arr_count, arr);
	return 0;
}

void plusMinus(int arr_count, int* arr)
{
	int positive = 0;
	int negative = 0;
	int zero = 0;
	for (int i = 0; i < arr_count; i++)
	{
		if (*(arr + i) > 0)
		{
			positive += 1;
		}
		else if (*(arr + i) < 0)
		{
			negative += 1;
		}
		else if (*(arr + i) == 0)
		{
			zero += 1;
		}
	}
	printf("%.6lf\n", (double)positive / arr_count);
	printf("%.6lf\n", (double)negative / arr_count);
	printf("%.6lf\n", (double)zero / arr_count);
}




