Module Module1

    Sub Main()
        Dim answer As Char
        Dim boat1location, boat2location, boat3location, boat4location, userGuess, restart As String
        Dim guessAmount As Integer = 30
        Dim boat1X, boat2X, boat3X, boat4X, boat1Y, boat2Y, boat3Y, boat4Y As Single
        Dim boat1destroyed, boat2destroyed, boat3destroyed, boat4destroyed As Integer
        Dim hit As Integer = 0
Start:
        'The IF statement is used to ask if they would like the instructions so that if the person has played it before they dont need the instructions so makes the game quicker for them.
        Console.WriteLine("Welcome To Battleships")
        Console.WriteLine("Do You Want To Know How To Play? (Y/N)")
        answer = Console.ReadLine.ToUpper()
        If answer = "Y" Then
            Console.WriteLine("The Board Is A 10x10 Board" & vbCrLf & "There is 4 Boat and all are 1x1" & vbCrLf & "When you are asked for your coordinates please enter them in a X,Y format" & vbCrLf & "Where X and Y are integers." & vbCrLf & "You get 30 guesses to discover and destroy the battleships." & vbCrLf & "Thank You and Good Luck!")
            Console.ReadLine()
        End If
        Randomize()

        'Gives the boats 2 random numbers for the x and y coordinates
        boat1X = Int(Rnd() * 9)
        boat1Y = Int(Rnd() * 9)
        boat2X = Int(Rnd() * 9)
        boat2Y = Int(Rnd() * 9)
        boat3X = Int(Rnd() * 9)
        boat3Y = Int(Rnd() * 9)
        boat4X = Int(Rnd() * 9)
        boat4Y = Int(Rnd() * 9)

        'Is the board1X = boat1X needed??
        boat1location = (boat1X & "," & boat1Y)
        boat2location = (boat2X & "," & boat2Y)
        boat3location = (boat3X & "," & boat3Y)
        boat4location = (boat4X & "," & boat4Y)

        'Console.WriteLine(boat1location)
        Do Until hit = 4 Or guessAmount = 0
            Console.WriteLine("Enter The Coordinates")
            userGuess = Console.ReadLine()
            guessAmount = guessAmount - 1
            Console.WriteLine("You have: " & guessAmount & " Guesses Left")
            If userGuess = boat1location Then
                Console.WriteLine("You Sunk The Enemy Ship!" & vbCrLf & "Well Done! (Press Enter To Try Again)")
                Console.ReadLine()
                hit += 1
                boat1location = boat1destroyed
                Console.Clear()
            ElseIf userGuess = boat2location Then
                Console.WriteLine("You Sunk The Enemy Ship!" & vbCrLf & "Well Done! (Press Enter To Try Again)")
                hit += 1
                boat2location = boat2destroyed
                Console.Clear()
            ElseIf userGuess = boat3location Then
                Console.WriteLine("You Sunk The Enemy Ship!" & vbCrLf & "Well Done! (Press Enter To Try Again)")
                Console.ReadLine()
                hit += 1
                boat3location = boat3destroyed
                Console.Clear()
            ElseIf userGuess = boat4location Then
                Console.WriteLine("You Sunk The Enemy Ship!" & vbCrLf & "Well Done! (Press Enter To Try Again)")
                Console.ReadLine()
                hit += 1
                boat4location = boat4destroyed
                Console.Clear()
            Else
                Console.Write("Guess Again! (Press Enter To Try Again)")
                Console.ReadLine()
                Console.Clear()
            End If
        Loop
        Console.WriteLine("Would you like to play again. (Yes/No)")
        restart = Console.ReadLine.ToUpper
        If restart = "YES" Then
            hit = Nothing
            guessAmount = 30
            GoTo Start
        Else
            End
        End If
        Console.ReadLine()
    End Sub

End Module
