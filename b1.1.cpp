#include <stdio.h>

int main()
{
	char abc;
	printf("gia tri cua abc: ");
	scanf("%c",&abc);
	int xyz;
	printf("gia tri cua xyz: ");
	scanf("%d",&xyz);
	float length;
	printf("gia tri cua length: ");
	scanf("%f",&length);
	double area;
	printf("gia tri cua area: ");
	scanf("%lf",&area);
	long liteyrs;
	printf("gia tri cua liteyrs: ");
	scanf("%d",&liteyrs);
	short arm;
	printf("gia tri cua arm: ");
	scanf("%d",&arm);
	
	printf("\ngtri char la %c");
	printf("\ngtri xyz la %d");
	printf("\ngtri length la%f");
	printf("\ngtri aea la %lf");
	printf("\ngtri liteyrs la %d");
	printf("\ngtri arm la %d");
	return 0;
	
}
