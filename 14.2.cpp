#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]) {
	int row, col;
	int *ptr;
	printf("\nEnter input row: "); 
	scanf("%d", &row);
	printf("\nEnter input col: \n"); 
	scanf("%d", &col);
	int i, j;  
	int max = 0; 
	ptr = (int*)malloc(row * col * sizeof(int)); 
	for (i = 0; i < row; i++)  
	{
		int sum = 0; 
		for(j = 0; j < col; j++)
		{
			scanf("%d", (ptr + col * i + j)); 
			sum = sum + *(ptr + col * i + j); 
		}
		if(sum > max) 
		{
			max = sum; 
		}
	}
	printf("Tong la : %d\n", max); 
	return 0;
}
