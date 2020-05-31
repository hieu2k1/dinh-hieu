#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]) {
	char string[100]; 
	int i, n; 
	printf("\nEnter string: "); 
	gets(string);
	n = strlen(string) - 1; 
	for(i = n; i >= 0; i--) 
	{
		printf("%c", string[i]); 
	}
	getch();
	return 0;
}
