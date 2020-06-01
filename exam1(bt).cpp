#include<stdio.h>

int main(){
	int n,m;
	printf("Enter number: ");
	scanf("%d",&n);
	int tong = 0;
	for(;n!=0;){
		m = n %10;
		tong += m;
		n /=10;
	}
	printf("Total digits: %d",tong);
	return 0;
}
