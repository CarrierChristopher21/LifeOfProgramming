
#include "headers.h"
#include <iostream>
#include <iomanip>

using namespace std;

int main(int argc, char * argv[])
{
	//	Initialize and Declare Variable
	int travel = 0;
	int Number_of_Gallons = 20;
	double Average_Miles_Per_Gallon = 0;
	double Distance = 0;
	double town_average = 23.5;
	double highway_average = 28.9;
	//	Input
	cout << "\nEnter 1: town distance mileage and 2 : highway distance mileage. ";
	cin >> travel;
	cout << endl;

	//	Town Calculation
	if(travel == 1)
	{
		Average_Miles_Per_Gallon = town_average;
		//	Distance Calculation
		Distance = Number_of_Gallons * Average_Miles_Per_Gallon;
		//	Output
		cout << "The town distance is: " << Distance << endl;
	}	//	Highway Calculation
	else if(travel == 2)
	{
		Average_Miles_Per_Gallon = highway_average;
		//	Distance Calculation
		Distance = Number_of_Gallons * Average_Miles_Per_Gallon;
		//	Output
		cout << "The highway distance is: " << Distance << endl;
	}
	else
	{
		cout << "A Invalid Entry has been entered! Please try again!" << endl;
	}
	return 0;
}