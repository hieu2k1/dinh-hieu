#include <stdio.h>
#include <string.h>
int main(){
	int n;
	scanf("%d",&n);
	char ary[n][50];// mang n chuoi toi da 50 ki tu.
	for(int i=0;i<n;i++){
		printf("nhap chuoi thu %d:\n",i);
		scanf("%d",ary[i]);
	}
	char s[50];
	printf("nhap chuoi can tim kiem:\n");
	scanf("%s",s);
	int i;
	for(int i=0;i<n;i++){
		if(strcmp(s,ary[i])==0){
			printf("chuoi %s co trong mang \n",s);
			break;
		}
	}
	if(i>=n){
		printf("khong co chuoi nay trong mang\n");
	}
	return 0;
	}
