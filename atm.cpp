#include <stdio.h>
int main(){
	int card,passd;

	printf("\n nhap ma the : ");
    scanf("%d",&card);
    printf("\n nhap ma pin : ");
    scanf("%d",&passd);

   	int f=1;
	while(f==1){
		int menu;
	do{
		printf("1.Rut tien\n");
		printf("2.Kiem tra so du\n");
		printf("3.thoat \n");
		scanf("%d",&menu);
	   }	while(menu>3|| menu<1);
		if(menu==1){
			int rut_tien;
			do{
				printf("chon so tien can rut:\n");
				printf("1.10.0000 VND\n");
				printf("2.100.000 VND\n");
				printf("3.100.000 VND\n");
				printf("4.quay lai\n");
				scanf("%d",& rut_tien);
					
			}
		
		}
	}
		
	
	return 0;
}
