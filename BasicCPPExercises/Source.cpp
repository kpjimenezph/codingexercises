
// Jumpstart your C++ skills (hopefully) using these simple exercises
// Kirk Jimenez


#include <stdio.h>
#include <string>
#include <iostream>
#include <fstream>

using namespace std;
int TestLog(string TestNum);

bool IfFunction(string in, string out);
bool ForLoop(string in, string fnd, int num);
bool Arrays(string in, string result);
bool AreaOfTriangle(double base, double height, double result);
bool CheckFileContent(string file, string str);

bool bResult = false;
const string TestF = "Test Failed";
const string TestP = "Test Passed";

int main() {
	string Input = "Resist";

	//Excercise #1 - If statements -> Should return true if input is 'Resist', else return false
	bResult = IfFunction(Input, "Resist");
	TestLog("Test #1 - ");

	//Exercise #2 - For Loops - count the number of char 's' from Input - return true if 2
	bResult = ForLoop(Input, "s", 2);
	TestLog("Test #2 - ");

	//Exercise #3 - Arrays - Parse Input into an Array, then reverse the string value using the parsed array - return true if 'tsiseR'
	bResult = Arrays(Input, "tsiseR");
	TestLog("Test #3 - ");

	//Exercise 4 - Math - Calculate the area of a triangle base = 3, height = 4, return true if result is 6
	bResult = AreaOfTriangle(3, 4, 6.0);
	TestLog("Test #4 - ");

	//Exercise 5 - Open file and check content - return true if file first line is equal to Input
	bResult = CheckFileContent("C:/Users/user/Downloads/cppfilesample.txt", Input);
	TestLog("Test #5 - ");

	//End of Test
	cout << "\n\n" << "End of Test" << "\n\n";

	return 0; // each function should have a return value
}

// Test datalog
int TestLog(string TestNum) {
	if (bResult == false) {cout << TestNum << TestF << endl;}
	else {cout << TestNum << TestP << endl;}
	return 0;
}


/* - - - - - - Answers - - - - - - - - */

// Exercise 1
bool IfFunction(string in, string out) {
	if (in == out) {return true;}
	return false;
}

// Exercise 2
bool ForLoop(string in, string fnd, int num) {
	int numOfStr = 0;
	string nowStr = "";
#pragma warning(suppress:4018)
	for (int i = 0; i < in.length(); i++) {
		nowStr = in.at(i);
		if (nowStr == fnd) {numOfStr++;}
	}
	if (numOfStr == num) {return true;}
	return false;
}

//Exercise 3
bool Arrays(string in, string result) {
	string* inArr = new string[in.length() + 1];
#pragma warning(suppress:4018)
	for (int i = 0; i < in.length(); i++) {inArr[i] = in.at(i);}
	string myResult = "";
#pragma warning(suppress:6385)
	for (int i = sizeof(inArr) + 1; i >= 0; i--) {myResult = myResult + inArr[i];}
	if (result == myResult) {return true;}
	return false;
}

// Exercise 4
bool AreaOfTriangle(double b, double h, double a) {
	double res = 0.5 * b * h;
	if (res == a) {return true;}	
	return false;
}

// Exercise 5
bool CheckFileContent(string file, string str) {
	string myLine = "";
	ifstream readFile(file);

	while (getline(readFile, myLine)) {break;}
	readFile.close();

	if (str == myLine) {return true;}
	return false;
}

