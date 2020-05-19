#include <stdio.h>
int main(){
	int f=1;
	while(f==1){
		int menu;
	do{
		printf("chon chuc nang:\n");
		printf("1.chon do uong\n");
		printf("2.thanh toan\n");
		printf("3.thoat chuong trinh\n");
		scanf("%d",&menu);
	   }	while(menu>3|| menu<1);
		if(menu==1){
			int do_uong;
			do{
				printf("chon do uong:\n");
				printf("1.cafe\t100.000 VND\n");
				printf("2.sinh to\t100.000 VND\n");
				printf("3.tra sua\t100.000 VND\n");
				printf("4.quay lai\n");
				scanf("%d",& do_uong);
					
			}while(do_uong >4 || do_uong <1);
			if(do_uong >=1 && do_uong <=3){
				printf("cam on da chon do uong.\n");
			}else{
				printf("tro lai chuc nang.\n");
				}
			}else if(menu==2){
				printf("so tien can thanh toan: 100000\n");
				printf("cam on da den nha hang.\n");		
			}else if (menu == 3){
				printf("thoat chuong trinh....\n");
				f =0;
			
		
	}
}
	return 0;
}
