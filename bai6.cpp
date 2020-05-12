#include <stdio.h>
#include <conio.h>

int main()
{
	int a,b,c,d,f,g;

	printf("\nnhap so thu 1: ");
	scanf("%d",&a);
	printf("\nnhap so thu 2: ");
	scanf("%d",&b);

	
	c=a+b;
	printf("\ntong = %d",c);
	
	d=b-a;
	printf("\nhieu = %d",d);
	
	f=a*b;
	printf("\ntich = %d",f);
	
	g=b/a;
	printf("\nthuong  =%d",g);
    getch();
}
