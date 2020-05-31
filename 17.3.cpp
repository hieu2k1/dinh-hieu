#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]) {
	char firstname[15]; /* khai tao ten */
	char lastname[15]; /* khai bao ho */
	printf("Enter your first name: "); /* nhap ten */
	scanf("%s", firstname); /* co the thay scanf = gets */
	printf("Enter your lastname: "); /* nhap ho */
	scanf("%s", lastname); /* co the thay scanf = gets */
	strcat(firstname, lastname); /* 1 + 1 = 2 */
	printf("%s", firstname); /* kieu no phai the */
	return 0;
}
