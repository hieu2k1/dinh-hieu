#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]) {
	char name[20];
	puts("Enter your name: "); 
	gets(name); 
	puts("Hi there: ");
	puts(name); 
	getch();
}
