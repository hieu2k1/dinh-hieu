#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]) {
	int a[5];
	int n;
	int i;
	printf("Nhap so luong cua mang: ");
	scanf("%d", &n);
	for(i = 0; i < n; i++)
	{
		printf("so thu %d: ", i);
		scanf("%d", &a[i]);
	}
	for(i = n -1; i >= 0; i--)
	{
		printf("\nSo phan tu dao nguoc: %d", a[i]);
	}

	return 0;
}
