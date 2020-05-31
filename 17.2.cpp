#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]) {
	char name[20];
	printf("Enter your name: "); 
	scanf("%s", name); 
	printf("Hi there: %s", name);
	getch();
}
