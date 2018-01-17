Module Module1
    'Program: Retirement Benefits
    'Programmer: Ryan Roque
    'Date:  Feburary 13, 2017
    'Purpose: Request name, date of birth, and years with company. Calculate age and determine notification based on age and years with company.


    Const intCURRENT_YEAR As Integer = 2012
    Sub Main()

        'Declare and Initalize
        Dim strFullName As String = ""
        Dim intBirthYear As Integer = 0
        Dim intWorkYears As Integer = 0
        Dim intCurrentAge As Integer = 0

        'Input
        getInfo(strFullName, intBirthYear, intWorkYears)

        'Process
        calcAge(intBirthYear, intCurrentAge)

        'Output
        sendNotification(strFullName, intCurrentAge)
        alertFull(intCurrentAge, intWorkYears)
        alertWait(intCurrentAge, intWorkYears)

        'Hold Console Window Open
        terminateProgram()


    End Sub

    Private Sub getInfo(ByRef strName As String, ByRef intYear As Integer, ByRef intCoYears As Integer)

        Console.WriteLine("Enter employee's year of birth: ")
        strName = Console.ReadLine()

        Console.Write("Enter employee's year of birth: ")
        intYear = CInt(Console.ReadLine())

        Console.Write("Enter employee's years with the company: ")
        intCoYears = CInt(Console.ReadLine())

    End Sub

    Private Sub calcAge(ByVal intYear As Integer, ByRef intAge As Integer)

        intAge = intCURRENT_YEAR - intYear

    End Sub

    Private Sub sendNotification(ByVal strName As String, ByVal intAge As Integer)

        Console.Clear()

        If intAge >= 55 Then
            Console.WriteLine(strName & " must recieve a notification of retirement benfits.")
        Else
            Console.WriteLine(strName & " does not need to be notified at this time.")
        End If

    End Sub

    Private Sub alertFull(ByVal intAge As Integer, ByVal intCoYears As Integer)

        If (intAge >= 62 And intCoYears > 10) Or (intAge >= 30) Or (intAge >= 65) Then
            Console.WriteLine("The employee is eligible for full retirement benfits.")
        End If

    End Sub

    Private Sub alertWait(ByVal intAge As Integer, ByVal intCoYears As Integer)

        If (intAge >= 62 And intAge < 65) And intCoYears <= 10 Then
            Console.WriteLine("The employee must wait for full retirement benefits.")
        End If

    End Sub

    Private Sub terminateProgram()
        Console.WriteLine()
        Console.Write("Press the enter key to terminate the Program.")
        Console.Read()

    End Sub

End Module
