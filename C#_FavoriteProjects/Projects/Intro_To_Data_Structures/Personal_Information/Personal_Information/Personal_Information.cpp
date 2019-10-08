
#include "headers.h"
#include <iostream>
#include <iomanip>

using namespace std;

int main(int argc, char * argv[])
{
	//	Initialize and Declare Variable
	string your_name = "Chris Carrier";;
	string address = "Mackenzie North";;
	string city = "Alfred State";
	string state = "New York";
	int zip_code = 14802;
	string telepone_number = "607-555-555";  //	I won't give out legit number sorry. If you need it though let me know.
	string college_major = "Information Technology Web Development";

	//	Input

	cout << "\n" << "Please provide your personal information below: " << "\n\n"

		//	Hard code
		<< "Hard Code" << "\n"
		<< "Chris Carrier" << "\n"
		<< "Mackenzie North, Alfred State, New York, 14802" << "\n"
		<< "607-555-5555" << " (I won't give out the real one sorry!) \n" //	I won't give out legit number sorry. If you need it though let me know.
		<< "Information Technology Web Development" << "\n" << "\n"

		<< "Variable Substitution Code" << "\n"

		<< your_name << "\n"
		<< address << ", " << city << ", " << state << ", and " << zip_code << "\n"
		<< telepone_number << " (I won't give out the real one sorry!) \n"
		<< college_major << endl;


	return 0;
}