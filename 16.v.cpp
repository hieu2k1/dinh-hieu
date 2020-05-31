#include <stdio.h>
#include <conio.h>

float giaithua(int n) 
{
	int i;
	float c = 1.0;
	for(i = 1; i <=n; i++) 
	c = c*i; 
	return c; 
}
void main()
{
	int n; 
	printf("Enter number(n) = ");
	scanf("%d", &n); 
	printf("\nGiai thua cua %d la %f", n, giaithua(n)); 
	getch();
}
