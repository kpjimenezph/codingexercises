# Author: Kirk Jimenez
from functions import *
import math
import sys

bResult = False
bContinueOnFail = True
Input = "Resist"

#Test #1 - If statements -> Should return true if input is 'Resist', else return false
bResult = FuncIf(Input, "Resist")
print("Test #1 - " + str(bResult))
if not bContinueOnFail  and not bResult: sys.exit(0)

#Test #2 - For Loops - count the number of char 's' from Input - return true if 2
bResult = FuncForLoop(Input, "s", 2)
print("Test #2 - " + str(bResult))
if not bContinueOnFail  and not bResult: sys.exit(0)

#Test #3 - Arrays - Parse Input into an Array, then reverse the string value using the parsed array - return true if 'tsiseR'
bResult = FuncArrays(Input, "tsiseR")
print("Test #3 - " + str(bResult))
if not bContinueOnFail  and not bResult: sys.exit(0)

# Test #4
bResult = FuncAreaOfTriangle(3, 4, 6.0)
print("Test #4 - " + str(bResult))
if not bContinueOnFail  and not bResult: sys.exit(0)

# Test #5 - Open file and check content - return true if file first line is equal to Input
bResult = FuncCheckFileContent("C:/Users/user/Downloads/cppfilesample.txt", Input)
print("Test #5 - " + str(bResult))
if not bContinueOnFail  and not bResult: sys.exit(0)

print("\n\n" + "End of Test" + "\n\n")