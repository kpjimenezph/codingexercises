'Author: Kirk Jimenez

Option Explicit On
Option Strict On

Imports System

Module Program

    Dim bResult As Boolean
    Const Input = "Resist"
    Const bStopOnFail = True

    <Obsolete>
    Sub Main(args As String())

        Try
            bResult = False
            ' Test #1 - If statements -> Should return true if input is 'Resist', else return false
            bResult = FuncIf(Input, "Resist")
            TestLog("Test # 1 - ")

            'Test #2 - For Loops - count the number of char 's' from Input - return true if 2
            bResult = FuncForLoop(Input, "s", 2)
            TestLog("Test # 2 - ")

            'Test #3 - Arrays - Parse Input into an Array, then reverse the string value using the parsed array - return true if 'tsiseR'
            bResult = FuncArrays(Input, "tsiseR")
            TestLog("Test # 3 - ")

            'Test #4 - Math - Calculate the area of a triangle base = 3, height = 4, return true if result is 6
            bResult = AreaOfTriangle(3, 4, 6)
            TestLog("Test # 4 - ")

            'Test #5 - Open file and check content - return true if file first line is equal to Input
            bResult = CheckFileContent("C:/Users/user/Downloads/cppfilesample.txt", Input, 0)
            TestLog("Test # 5 - ")

            Console.WriteLine(vbNewLine)
            Console.WriteLine("End of Test")
            Console.WriteLine(vbNewLine)
        Catch e As Exception
            Console.WriteLine(e)
        End Try
    End Sub

    Function TestLog(str As String) As Integer
        Console.WriteLine(str + CStr(bResult))

        Try
            If bStopOnFail And Not bResult Then
                Console.WriteLine("Test stopped on fail")
                End
            End If
            Return 0
        Catch e As Exception
            Console.WriteLine(e)
            Return 0
        End Try
    End Function

    ' Test #1
    Function FuncIf(inp As String, str As String) As Boolean
        Try
            If inp = str Then Return True
            Return False
        Catch e As Exception
            Console.WriteLine(e)
            Return False
        End Try
    End Function

    ' Test #2
    Function FuncForLoop(inp As String, str As String, i As Integer) As Boolean
        Dim myStr() As Char
        Dim a As Integer
        Dim count As Integer = 0

        Try
            myStr = inp.ToCharArray

            For a = 0 To UBound(myStr)
                If CStr(myStr(a)) = str Then count += 1
            Next

            If i = count Then Return True
            Return False
        Catch e As Exception
            Console.WriteLine(e)
            Return False
        End Try

    End Function

    ' Test #3
    Function FuncArrays(inp As String, str As String) As Boolean
        Dim myStr() As Char = inp.ToCharArray
        Dim res As String = ""
        Dim i As Integer

        Try
            For i = UBound(myStr) To LBound(myStr) Step -1
                res += CStr(myStr(i))
            Next

            If str = res Then Return True
            Return False
        Catch e As Exception
            Console.WriteLine(e)
            Return False
        End Try
    End Function

    ' Test #4
    Function AreaOfTriangle(b As Double, h As Double, a As Double) As Boolean
        Dim area As Double

        Try
            area = 0.5 * b * h
            If a = area Then Return True
            Return False
        Catch e As Exception
            Console.WriteLine(e)
            Return False
        End Try
    End Function

    ' Test #5
    Function CheckFileContent(fileDir As String, str As String, l As Integer) As Boolean
        Dim lines() As String = IO.File.ReadAllLines(fileDir)
        Dim myStr As String

        Try
            myStr = lines(l)
            If str = myStr Then Return True
            Return False
        Catch e As Exception
            Console.WriteLine(e)
            Return False
        End Try
    End Function

End Module
