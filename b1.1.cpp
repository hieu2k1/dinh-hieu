#include <stdio.h>

int main()
{
	int n;
	printf ("nhap so nguyen n: ");
	scanf("%d",&n);
	if(n>0){
		printf("%d la so nguyen duong\n",n);
	}
	if(n<0){
		printf("%d la so nguyen am\n",n);
	}
	if(n==0){
		printf("%d la so khong duong khong am\n",n);
	}
	
	return 0;
}
