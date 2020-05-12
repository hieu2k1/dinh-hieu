#include<stdio.h>

int main(){
	float a,b,h;
	printf("\nnhap 3 canh hinh thang: ");
	scanf("%f%f%f",&a,&b,&h);
	if(a>0 && b>0 && h>0){
		float s=h*((a+b)/2);
		printf("\n dien tich hinh thang la %d",s);
	}
	 else {
		printf("Nhap canh > 0");
	}
	return 0;
}
