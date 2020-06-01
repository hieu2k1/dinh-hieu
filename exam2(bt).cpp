#include<stdio.h>
#include<string.h>

void lowerCase(char s[]){
	for(int i = 1;i<strlen(s);i++){
		if(s[i]>32 && s[i]<90){
		    s[i]+=32;
		}
	}
}

int main(){
	char s[100];
	printf("nhap chuoi: ");
	scanf("%s",s);
    lowerCase(s);	
    printf("thanh chu thuong: %s ",s);
}
