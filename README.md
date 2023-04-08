# CSharpConsoleEasyTasks
## Several easy console tasks created by me in 2020.


# Game Task

In their free time, classmates Vasya and Petya like to play various logic games: battleship, tic-tac-toe, chess, checkers, and much more. The guys have already tried and played all sorts of classic games of this kind, including computer ones. One day, they wanted to play something new, but they couldn't find anything suitable.

Then Petya came up with the following game "Guessing Game": Two participants play. The first one thinks of any three-digit number, such that the first and last digits differ from each other by more than one. Then the player who thought of the number flips the number, swapping the first and last digits, thus obtaining another number. Then the maximum of the two obtained numbers is subtracted from the minimum. The task of the second player is to guess the number itself based on the first digit of the resulting difference.

For example, if Vasya thought of the number 487, then by swapping the first and last digits, he will get the number 784. Then he will have to subtract 487 from 784, as a result of which the number 297 will be obtained, which Petya must guess based on the specified first digit "2" taken from this number. Petya is better at math than Vasya, so he almost always wins in games of this type. But in this case, Petya cheated and deliberately came up with a game in which he will not lose to Vasya in any case. The thing is that the game invented by Petya has a winning strategy, which consists of the following: the desired number is always a three-digit number, and its second digit is always nine, and to get the value of the last digit, it is enough to subtract the first digit from nine, i.e., in the above example, the last digit is 9-2=7. Help Petya simplify the process of guessing the number based on its first digit by writing a corresponding program.

## Class description:

This code appears to be a C# console application that implements a number guessing game. The game involves a player entering a 3-digit number where the first digit is either larger or smaller than the last digit. The program then reverses the digits of the number and finds the absolute difference between the original and reversed numbers. This difference is then displayed, and the second player has to guess the original number by knowing the first digit and using the formula for the third digit. If the second player can't guess the number, the program will provide the answer.

The code consists of a single class called "GameLogic" that has four methods. The "PrintStartMenu" method prompts the user to enter a 3-digit number and checks if the first digit is larger or smaller than the last digit. The "ChangeDigits" method reverses the digits of the entered number. The "TrueDigit" method calculates the absolute difference between the original and reversed numbers. The "Game" method allows the user to guess the original number or have the computer guess it for them.

The "Main" method creates an instance of the "GameLogic" class, calls the "PrintStartMenu," "ChangeDigits," "TrueDigit," and "Game" methods to play the game, and then displays the final result.

# Sum Task

In this problem, you can use the formula for the arithmetic progression: Sn = (a1+an)*n/2. But novice programmers often forget this formula and in this case resort to computing this sum using a loop and solve this problem using the following algorithm:

read(n);
s=0;
for i=1..n{ s=s+i; }
write(s);

But the complexity of this problem is not in computing this sum and the above algorithm fails the test! It turns out that you need to read the problem statement very carefully, especially the constraints on the number N. The thing is that this number can be negative!!!

## Class description:

This is a C# console application that generates a random integer within a range of -10,000 to 10,000, writes it to a file named "Input.txt", reads the integer from the file, calculates the sum of all integers between 1 and the read integer (inclusive), writes the result to a file named "Output.txt", and displays the sum on the console.

Here's a breakdown of what the code is doing:

Declare and initialize variables: sumRange, readedFile, convertedIntFile, and answer.
Create variables inputFilePath and outputFilePath for the input and output file paths respectively.
Create a new instance of the Random class and generate a random integer between -10,000 and 10,000, and assign it to sumRange.
Check if the files inputFilePath and outputFilePath already exist, and if they do, delete them.
Open a new FileStream and write sumRange to the inputFilePath.
Display the range of integers that will be summed on the console.
Open the inputFilePath FileStream and read the integer value from it.
Convert the read string value to an integer and assign it to convertedIntFile.
Calculate the sum of integers between 1 and convertedIntFile, and assign it to answer.
Open a new FileStream and write answer to the outputFilePath.
Display the calculated sum on the console.
The program uses the using statement to ensure that the file streams are properly disposed of when they are no longer needed, which helps to prevent resource leaks.
