
#include "stdio.h"

void main()
{

	int x;
	int y;
	char z;
	int list[5];

	printf("The address of x is: **%u**\n", &x);
	printf("The address of y is: **%u**\n", &y);
	printf("The address of z is: **%u**\n", &z);
	for(int j = 0; j<5; j++)
		printf("The address of list[%u] = **%u**\n", j, &list[j]);

	printf("The size of a char is %u\n", sizeof(z));
	printf("The size of an int is %u\n", sizeof(x));
}
