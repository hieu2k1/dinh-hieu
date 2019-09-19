#include <stdio.h>
#include <conio.h>
#include <string.h>
void main(){
	char s[50];
	printf("nhap s:");
	gets(s);
	for(int i=0;i<strlen(s);i++){
		if(s[i]>='A'&&s[i]<'Z')
		s[i]=s[i]+32;
		if else(s[i]>='a'&&s[i]<'z')
		s[i]=s[i]-32;
	}printf("\n mang sau khi doi la:");

	return 0;
}
