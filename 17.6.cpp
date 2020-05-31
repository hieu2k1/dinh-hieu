#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]) {
	char hotelname1[15] = "Sea View";
	char hotelname2[15] = "Sea Breeze";
	printf("The old name is %s\n", hotelname1);
	strcpy(hotelname1, hotelname2);
	/*Changes the hotel name*/
	printf("The new name is %s\n", hotelname1);
	/*Displays the new name*/
	return 0;
}
