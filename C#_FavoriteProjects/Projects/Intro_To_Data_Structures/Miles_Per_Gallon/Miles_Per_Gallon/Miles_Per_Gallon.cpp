
#include "headers.h"
#include <iostream>
#include <iomanip>

using namespace std;

int main(int argc, char * argv[])
{
	//	Initialize and Declare Variable
	int Miles_Driven = 375;
	int Gallons_of_Gas_Used = 15;
	double MPG = 0;

	//	Distance Calculation
	MPG = Miles_Driven / Gallons_of_Gas_Used;
	//	Output
	cout << "The miles per gallon is: " << MPG << endl;

	return 0;
}