#include <stdio.h>
#include <conio.h>
main(){
int num1,num2;
printf("Nhap so num1 = ");
scanf("%d", &num1);

printf("Nhap so num2 = ");
scanf("%d", &num2);
int A=num1+num2;
int B=num2-num1;
int C=num1*num2;
int D=num2/num1;
printf("\nTong =%d",A);
printf("\nHieu =%d",B);
printf("\nTich =%d",C);
printf("\nThuong =%d",D);
getch();
}
