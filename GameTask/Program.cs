using System;
using static System.Console;

namespace GameTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstDigit = 0, convertedDigit = 0, trueDigit = 0, finalAnswer = 0;
            GameLogic gl = new GameLogic();

            firstDigit = gl.PrintStartMenu();
            convertedDigit = gl.ChangeDigits(firstDigit);
            trueDigit = gl.TrueDigit(firstDigit, convertedDigit);
            finalAnswer = gl.Game(trueDigit);

            ForegroundColor = ConsoleColor.Green;
            WriteLine($"\nPlayer 1 number is: {trueDigit}, \nyour or computer answer is: {finalAnswer}\nCongratulation! Player 2 win!");
            ResetColor();
        }
    }

    public class GameLogic
    {
        /// <summary>
        /// Prompts the user to enter a 3-digit number, and checks if the first digit is larger or smaller than the last digit.
        /// </summary>
        /// <returns>The 3-digit number entered by the user.</returns>
        public int PrintStartMenu()
        {
            while (true)
            {
                Write("Player 1, please, write 3-digit number (first digit must be larger or smaller of the last digit): ");
                int digit = Convert.ToInt32(ReadLine());

                if ((digit > 99) && (digit < 999))
                {
                    if (digit.ToString()[0] == digit.ToString()[2])
                    {
                        ForegroundColor = ConsoleColor.DarkRed;
                        WriteLine("First digit must be larger or smaller of the last digit. Please, try again!\n");
                        ResetColor();
                    }
                    else
                    {
                        Clear();
                        return digit;
                    }
                }
                else
                {
                    ForegroundColor = ConsoleColor.DarkRed;
                    WriteLine($"numbers must be in the range: 100 - 998. Please, try again!\n");
                    ResetColor();
                }
            }
        }

        /// <summary>
        /// This method takes an integer as an argument and reverses the digits of the number.
        /// </summary>
        /// <param name="_playerOneNumber">The number to be reversed.</param>
        /// <returns>The reversed number.</returns>
        public int ChangeDigits(int _playerOneNumber)
        {
            char[] tempNum = _playerOneNumber.ToString().ToCharArray();
            Array.Reverse(tempNum);
            string answer = new string(tempNum);

            return Convert.ToInt32(answer);
        }

        /// <summary>
        /// Calculates the difference between two integers.
        /// </summary>
        /// <param name="_firstDigit">The first integer.</param>
        /// <param name="_convertedDigit">The second integer.</param>
        /// <returns>
        /// The difference between the two integers.
        /// </returns>
        public int TrueDigit(int _firstDigit, int _convertedDigit)
        {
            if (_firstDigit > _convertedDigit)
                return _firstDigit - _convertedDigit;
            else
                return _convertedDigit - _firstDigit;
        }

        /// <summary>
        /// This method allows the user to guess a 3-digit number, or have the computer guess it for them.
        /// </summary>
        /// <returns>
        /// Returns the 3-digit number that was guessed.
        /// </returns>
        public int Game(int _trueDigit)
        {
            while (true)
            {
                int userAnswer = 0;

                ForegroundColor = ConsoleColor.DarkCyan;
                WriteLine($"Guess the number by the first digit! First digit is: {_trueDigit.ToString()[0]}");
                Write($"Guess yourself? (Yes = 'Y', No = 'N') if answer 'NO', the computer will guess itself! :");
                ResetColor();

                string tempAnswer = ReadKey().KeyChar.ToString().ToLower();
                char lowerAnswer = Convert.ToChar(tempAnswer);

                switch (lowerAnswer)
                {
                    case 'y':
                        {
                            Write($"\n\nInsert full number (first digit is {_trueDigit.ToString()[0]}): ");
                            userAnswer = Convert.ToInt32(ReadLine());

                            if (userAnswer == _trueDigit)
                            {
                                return userAnswer;
                            }
                            else
                            {
                                ForegroundColor = ConsoleColor.DarkRed;
                                WriteLine($"\nWrong! Try again.\n");
                                ResetColor();
                            }

                            break;
                        }
                    case 'n':
                        {
                            ForegroundColor = ConsoleColor.DarkGreen;
                            WriteLine($"\n\n1. First digit is {_trueDigit.ToString()[0]}\n" +
                                      $"2. Second digit always matters 9\n" +
                                      $"3. Third number formula is {_trueDigit.ToString()[1]} - {_trueDigit.ToString()[0]} = {_trueDigit.ToString()[2]}\n");
                            ResetColor();

                            int computerAnswerThirdNum = Convert.ToInt32(_trueDigit.ToString()[1]) -
                                                         Convert.ToInt32(_trueDigit.ToString()[0]);
                            int compAnswer = Convert.ToInt32($"{_trueDigit.ToString()[0]}9{computerAnswerThirdNum}");

                            return compAnswer;
                        }
                    default:
                        {
                            ForegroundColor = ConsoleColor.DarkRed;
                            WriteLine($"\nError! The answer can only be 'Y' or 'N'! Try again!\n");
                            ResetColor();
                            break;
                        }
                }
            }
        }
    }
}
