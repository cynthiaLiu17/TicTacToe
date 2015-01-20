 /* Name: Cynthia Liu
 * Date: Novemeber 8, 2012
 * Purpose: Assignment 2: Tic-Tac-Toe
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Title of the project
            Console.Title = "Exyz and Osyz";
            //A number of WriteLines that output the title of the game
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*****************");
            Console.WriteLine("   Welcome To");
            Console.WriteLine("* *           * *");
            Console.WriteLine("  ~TIC-TAC-TOE~");
            Console.WriteLine("*****************");
            //Chnages the colour back to normal
            Console.ResetColor();
            //Store the string variables for user1 and user2 
            string user1, user2;
            //Assigns the string returned from the Login function to the variable user1
            user1 = Login();
            //Output user prompts
            Console.WriteLine("User 1 = " + user1);
            //Output for organizational purposes
            Console.WriteLine("----------------------");
            //Assigns the string returned from the Login function to the variable user2
            user2 = Login();
            //Output user prompts
            Console.WriteLine("User 2 = " + user2);
            //Output for organizational purposes
            Console.WriteLine("----------------------");
            //Use the procedure MenuSystem. The variables user1, and user2 are passed into it. 
            MenuSystem(user1, user2);
        }
        /// <summary>
        /// Asks the user which option they would like and then calls that option's associated subprogram
        /// </summary>
        /// <param name="user1">The username assigned to the variable user1</param>
        /// <param name="user2">The username assigned to the variable user2</param>
        static void MenuSystem(string user1, string user2)
        {
            //Store the int variable for userChoice
            int userChoice;
            //Store the bool variable for repeat
            bool repeat;
            //create a do while loop that will do everything below at least once until the bool repeat is false
            do
            {
                //Output for organizational purposes
                Console.WriteLine("--------------------------------------------------------------------------");
                //Output a list of options for the user to choose from
                Console.WriteLine("Would you like to:");
                //Changes the colour of the play game option to red 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("1. Play Game ");
                //Changes the colour of the play game option to cyan
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("2. View Credits");
                //Changes the colour of the play game option to yellow
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("3. Get Help");
                //Changes the colour of the play game option to magenta
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("4. Exit The Game");
                //Changes the colour back to normal
                Console.ResetColor();
                //Outuput the user prompt to choose an option from the list above
                Console.Write("Choose an option from the list above by inputting the associated number: ");
                //Stores the user input to the variable userChoice
                userChoice = int.Parse(Console.ReadLine());
                //Output for visual effect
                Console.WriteLine("--------------------------------------------------------------------------");
                //If the user inputs 1 or 4, the bool variable repeat will equal false
                if (userChoice == 1 || userChoice == 4)
                {
                    repeat = false;
                }
                //If the user inputs 2 or 3, the bool variable repeat will equal true
                else
                {
                    repeat = true;
                }
                //If userInput is 1, the procedure PlayTicTacToe will be called
                if (userChoice == 1)
                {
                    PlayTicTacToe(user1, user2);
                }
                //If the userInput is 2, the procedure Credits will be called
                else if (userChoice == 2)
                {
                    Credits();
                }
                //If the userInput is 3, the procedure Help will be called
                else if (userChoice == 3)
                {
                    Help();
                }
                //If the userInput is 4, the procedure Exit will be called
                else if (userChoice == 4)
                {
                    Exit();
                }
                //If the user does not choose any of the numbers above, there will be an output telling the user there was an error
                else
                {
                    Console.WriteLine("Error please pick 1, 2, 3, or 4");
                }
            //Continue the loop until the user chooses option 1 or 4 (userChoice == false)
            } while (repeat == true);    
        }

        /// <summary>
        /// Asks the user to input their username and the program stores this username
        /// </summary>
        /// <returns>The username inputed by the user as a string</returns>
        static string Login()
        {
            //Store the string variable for username
            string username;
            //Asks the user for their username
            Console.Write("Please enter a username: ");
            //Stores the player's username to the variable username
            username = Console.ReadLine();
            //Returns the string variable username
            return username;
        }

        /// <summary>
        /// Creates a tic-tac-toe game board
        /// </summary>
        /// <param name="square1">The symbol that belongs in the first square on the game board</param>
        /// <param name="square2">The symbol that belongs in the second square on the game board</param>
        /// <param name="square3">The symbol that belongs in the third square on the game board</param>
        /// <param name="square4">The symbol that belongs in the fourth square on the game board</param>
        /// <param name="square5">The symbol that belongs in the fifth square on the game board</param>
        /// <param name="square6">The symbol that belongs in the sixth square on the game board</param>
        /// <param name="square7">The symbol that belongs in the seventh square on the game board</param>
        /// <param name="square8">The symbol that belongs in the eigth square on the game board</param>
        /// <param name="square9">The symbol that belongs in the ninth square on the game board</param>
        static void DrawBoard(string square1, string square2, string square3, string square4, string square5, string square6, string square7, string square8, string square9)
        {
            //Outputs the tic-tac-toe grid with the string variables
            Console.WriteLine("     │     │     ");
            Console.WriteLine("  " + square1 + "  " + "│" + "  " + square2 + "  " + "│" + "  " + square3 + "  ");
            Console.WriteLine("_____│_____│_____");
            Console.WriteLine("     │     │     ");
            Console.WriteLine("  " + square4 + "  " + "│" + "  " + square5 + "  " + "│" + "  " + square6 + "  ");
            Console.WriteLine("_____│_____│_____");
            Console.WriteLine("     │     │     ");
            Console.WriteLine("  " + square7 + "  " + "│" + "  " + square8 + "  " + "│" + "  " + square9 + "  ");
            Console.WriteLine("     │     │     ");

        }

        /// <summary>
        /// Takes the value of the spot on the board each player would like to place their symbol and checks if its valid
        /// </summary>
        /// <returns>The string playerChoice which is one of the following choices: "A", "B", "C", "D", "E", "F", "G", "H", "I"</returns>
        static string ChooseASpot()
        {
            //Store the string variable for playerChoice
            string playerChoice = "";
            //Store the bool variable for checkChoice
            bool checkChoice = true;
            //Creates a loop that wil repeat as long as checkChoice is true
            while (checkChoice == true)
            {
                //Asks the user to input the letter of the square on the grid they'd like their symbol to be placed on
                Console.Write("Choose the letter of the square you want to place your symbol: ");
                //Stores the player's choice of place to the variable playerChoice
                playerChoice = Console.ReadLine();
                //Changes the player's chosen letter to its capital
                playerChoice = playerChoice.ToUpper();
                //Output for oranizational and visual effects
                Console.WriteLine("----------------------------------------------------------------");
                //If playerChoice is one of the following letters, the variable checkChoice is false and the loop will end
                if (playerChoice == "A" || playerChoice == "B" || playerChoice == "C" || playerChoice == "D" || playerChoice == "E" || playerChoice == "F" || playerChoice == "G" || playerChoice == "H" || playerChoice == "I")
                {
                    //checkChoice is false
                    checkChoice = false;
                }
            }
            //The variable playerChoice's value is returned 
            return playerChoice;
        }

        /// <summary>
        /// Uses the values in each of the game board squares to see if there is a winner and if yes, who the winner is
        /// </summary>
        /// <param name="square1">The symbol that belongs in the first square on the game board</param>
        /// <param name="square2">The symbol that belongs in the second square on the game board</param>
        /// <param name="square3">The symbol that belongs in the third square on the game board</param>
        /// <param name="square4">The symbol that belongs in the fourth square on the game board</param>
        /// <param name="square5">The symbol that belongs in the fifth square on the game board</param>
        /// <param name="square6">The symbol that belongs in the sixth square on the game board</param>
        /// <param name="square7">The symbol that belongs in the seventh square on the game board</param>
        /// <param name="square8">The symbol that belongs in the eigth square on the game board</param>
        /// <param name="square9">The symbol that belongs in the ninth square on the game board</param>
        /// <returns>An empty string for no winner, player1 as the winner or player2 as the winner</returns>
        static string DetermineAWinner(string square1, string square2, string square3, string square4, string square5, string square6, string square7, string square8, string square9, string player1, string player2)
        {
            //If the following combinations of X occur, player1 is returned
            if (square1 == "X" && square2 == "X" && square3 == "X" || square4 == "X" && square5 == "X" && square6 == "X" || square7 == "X" && square8 == "X" && square9 == "X" || square1 == "X" && square4 == "X" && square7 == "X" || square2 == "X" && square5 == "X" && square8 == "X" || square3 == "X" && square6 == "X" && square9 == "X" || square1 == "X" && square5 == "X" && square9 == "X" || square3 == "X" && square5 == "X" && square7 == "X")
            {
                return player1; 
            }
            //If the following combinations of O occur, player2 is returned
            else if (square1 == "O" && square2 == "O" && square3 == "O" || square4 == "O" && square5 == "O" && square6 == "O" || square7 == "O" && square8 == "O" && square9 == "O" || square1 == "O" && square4 == "O" && square7 == "O" || square2 == "O" && square5 == "O" && square8 == "O" || square3 == "O" && square6 == "O" && square9 == "O" || square1 == "O" && square5 == "O" && square9 == "O" || square3 == "O" && square5 == "O" && square7 == "O")
            {
                return player2;
            }
            //If none of the following combinations occur, and empty string is returned 
            else
            {
                return "";
            }
        }
        
        /// <summary>
        /// Uses a number of other subprograms to output all the user prompts and calculations needed to play the game
        /// </summary>
        /// <param name="user1">The username entered by a user</param>
        /// <param name="user2">The username entered by the other user</param>
        static void PlayTicTacToe(string user1, string user2)
        {
            //Output user prompts
            //Changes the colour to red
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Play Tic-Tac-Toe");
            Console.WriteLine("////////////////");
            //Changes the colour back
            Console.ResetColor();
            //Store the string variables for player1, player2 and winner
            string player1, player2, winner;
            //Assigns values for the variables player1 and player2
            player1 = "";
            player2 = "";
            //Stores the int variables for user1Wins, user2Wins, and ties
            int user1Wins, user2Wins, ties;  
            //Stores the double variables for winningPercentageUser1, and winningPercentageUser2
            double winningPercentageUser1, winningPercentageUser2;
            //Assigns values to the variables user1Wins, user2Wins, ties, winningPercentageUser1, and winningPercentageUser2
            user1Wins = 0;
            user2Wins = 0;
            ties = 0;
            winningPercentageUser1 = 0;
            winningPercentageUser2 = 0;
            //Store the bool variable for endGame
            bool endGame;
            //Store the string variable for playAgain
            string playAgain;
            //Store the string varibales for player1Choice and player2Choice
            string player1Choice, player2Choice;
            //Generates random numbers
            Random numberGenerator = new Random();
            
            //Create do while loop that will continue to loop as long as the user wants to continue playing new games 
            do 
            {
                //Creates the int variable randomNumber and assigns a value of either 0 or 1 to it
                int randomNumber = numberGenerator.Next(0, 2);
                //If randomNumber is 0, user1 is player1, and user2 is player2
                if (randomNumber == 0)
                {
                    player1 = user1;
                    player2 = user2;
                }
                //If randomNumber is 1, user2 is player1 and user 1 is player2
                else if (randomNumber == 1)
                {
                    player2 = user1;
                    player1 = user2;
                }
                //Outputs information to the users that tells them who is going first and who is X and who is Y
                Console.WriteLine(player1 + " goes first (symbol = X)");
                Console.WriteLine(player2 + " goes second (symbol = O)");

                //Stores and assigns values to the string variables square1, square2, square3, square4, square5, square6, square7, square8 and square9
                string square1, square2, square3, square4, square5, square6, square7, square8, square9;
                square1 = "A";
                square2 = "B";
                square3 = "C";
                square4 = "D";
                square5 = "E";
                square6 = "F";
                square7 = "G";
                square8 = "H";
                square9 = "I";

                //Call Drawboard
                DrawBoard(square1, square2, square3, square4, square5, square6, square7, square8, square9);

                //Create a do while loop that continues to loop (the game continues)until there has been a winner or tie
                do
                {
                    //Assign the string variable returned from ChooseASpot to the string variable Player1Choice
                    player1Choice = ChooseASpot();
                    //Depending on the value of Player1Choice, the associated variable will be changed to display "X"
                    if (player1Choice == "A")
                    {
                        square1 = "X";
                    }
                    else if (player1Choice == "B")
                    {
                        square2 = "X";
                    }
                    else if (player1Choice == "C")
                    {
                        square3 = "X";
                    }
                    else if (player1Choice == "D")
                    {
                        square4 = "X";
                    }
                    else if (player1Choice == "E")
                    {
                        square5 = "X";
                    }
                    else if (player1Choice == "F")
                    {
                        square6 = "X";
                    }
                    else if (player1Choice == "G")
                    {
                        square7 = "X";
                    }
                    else if (player1Choice == "H")
                    {
                        square8 = "X";
                    }
                    else if (player1Choice == "I")
                    {
                        square9 = "X";
                    }
                    //Call Drawboard to display an updated board 
                    DrawBoard(square1, square2, square3, square4, square5, square6, square7, square8, square9);
                    //Call DetermineAWinner and assign the string returned from DetermineAWinner to the string variable winner
                    winner = DetermineAWinner(square1, square2, square3, square4, square5, square6, square7, square8, square9, player1, player2);
                    //If the string returned and assigned to the variable winner is empty, the following will happen
                    if (winner == "")
                    {
                        //if any of the squares still have their origionally assigned value, the game still continues (the board is not filled up)
                        if (square1 == "A" || square2 == "B" || square3 == "C" || square4 == "D" || square5 == "E" || square6 == "F" || square7 == "G" || square8 == "H" || square9 == "I")
                        {
                            //The variable endGame is false
                            endGame = false;
                        }
                        //However, if all the squares of the board are filled, there has been a tie
                        else
                        {
                            //Outputs the following to tell the user there has been a tie
                            Console.WriteLine("Tie! Commiserations! D:");
                            //The variable endGame is true
                            endGame = true;
                        }
                    }
                    //If the string returned and assigned to the variable winner is not empty, the following will happen
                    else
                    {
                        //Output telling the players who the winner is
                        Console.WriteLine("The Winner is: " + winner + " Congratulations! :D");
                        //The variable endGame is true
                        endGame = true;
                    }
                    //If the variable endGame is true, the loop will break 
                    if (endGame == true)
                    {
                        break;
                    }
                    //Assign the string variable returned from ChooseASpot to the string variable Player2Choice
                    player2Choice = ChooseASpot();
                    //Depending on the value of Player2Choice, the associated variable will be changed to display "O"
                    if (player2Choice == "A")
                    {
                        square1 = "O";
                    }
                    else if (player2Choice == "B")
                    {
                        square2 = "O";
                    }
                    else if (player2Choice == "C")
                    {
                        square3 = "O";
                    }
                    else if (player2Choice == "D")
                    {
                        square4 = "O";
                    }
                    else if (player2Choice == "E")
                    {
                        square5 = "O";
                    }
                    else if (player2Choice == "F")
                    {
                        square6 = "O";
                    }
                    else if (player2Choice == "G")
                    {
                        square7 = "O";
                    }
                    else if (player2Choice == "H")
                    {
                        square8 = "O";
                    }
                    else if (player2Choice == "I")
                    {
                        square9 = "O";
                    }
                    //Call Drawboard to display an updated board
                    DrawBoard(square1, square2, square3, square4, square5, square6, square7, square8, square9);
                    //Call DetermineAWinner and the returned string from it is assigned to the string variable winner
                    winner = DetermineAWinner(square1, square2, square3, square4, square5, square6, square7, square8, square9, player1, player2);
                    //If the string returned and assigned to the variable winner is empty, the following will happen
                    if (winner == "")
                    {
                        //if any of the squares still have their origionally assigned value, the game still continues (the board is not filled up)
                        if (square1 == "A" || square2 == "B" || square3 == "C" || square4 == "D" || square5 == "E" || square6 == "F" || square7 == "G" || square8 == "H" || square9 == "I")
                        {
                            //The variable endGame is false
                            endGame = false;
                        }
                        //However, if all the squares of the board are filled, there has been a tie
                        else
                        {
                            //Outputs the following to tell the user there has been a tie
                            Console.WriteLine("Tie! Commiserations! D:");
                            //The variable endGame is true
                            endGame = true;
                        }
                    }
                    else
                    {
                        //Output telling the players who the winner is
                        Console.WriteLine("The Winner is: " + winner + " Congratulations! :D");
                        //The variable endGame is true
                        endGame = true;
                    }
                //Continue the loop as long as endGame is false
                } while (endGame == false);

                //If the value of winner is the same as user1, add one to the variable user1Wins
                if (winner == user1)
                {
                    user1Wins = user1Wins + 1;
                }
                //If the value of winner is the same as user2, add one to the variable user2Wins
                else if (winner == user2)
                {
                    user2Wins = user2Wins + 1;
                }
                //If the value of winner is an empty string, add one to the variable ties
                else if (winner == "")
                {
                    ties = ties + 1;
                }
                //Calls the function WinningPercentageCalculator and assigns the returned double to the variable winningPercentage1
                winningPercentageUser1 = WinningPercentageCalculation(user1Wins, user2Wins, ties);
                //Calls the function WinningPercentageCalculator and assigns the returned double to the variable winningPercentage2
                winningPercentageUser2 = WinningPercentageCalculation(user2Wins, user1Wins, ties);
                //Call the subprogram Statistics
                Statistics(user1, user2, user1Wins, user2Wins, ties, winningPercentageUser1, winningPercentageUser2);
                //Asks the user if they would like to play the game again
                Console.WriteLine("Would you like to play the game again? Please enter yes or no. ");
                //Store the user's answer to the variable playAgain
                playAgain = Console.ReadLine();
            //The loop will end when playAgain is no
            }while (playAgain == "yes"); 
        }

        /// <summary>
        /// Calculates a player's winning percentage
        /// </summary>
        /// <param name="userWins">The amount of times the player won</param>
        /// <param name="userLosses">The amount of times the player lost</param>
        /// <param name="ties">The amount of ties</param>
        /// <returns>The calculated winning percentage</returns>
        static double WinningPercentageCalculation(int userWins, int userLosses, int ties)
        {
            //Store the double variable for winningPercentage
            double winningPercentage;
            //Calculation for winning percentage saved to the variable winningPercentage
            winningPercentage = (double)userWins / (userWins + userLosses) * 100;
            //Return the double variable winningPercentage
            return winningPercentage;
        }

        /// <summary>
        /// Outputs each user's statistics which were calculated in the playTicTacToe subprogram
        /// </summary>
        /// <param name="user1">The username that the first user entered</param>
        /// <param name="user2">The username that the second user entered</param>
        /// <param name="user1Wins">The number of times the first user won</param>
        /// <param name="user2Wins">The number of times the second user won </param>
        /// <param name="ties">The number of ties</param>
        /// <param name="winningPercentageUser1">The calculated percentage of the first user's wins/the total games</param>
        /// <param name="winningPercentageUser2">The calculated percentage of the second user's wins/the total games</param>
        static void Statistics (string user1, string user2, int user1Wins, int user2Wins, int ties, double winningPercentageUser1, double winningPercentageUser2)
        {
            //Outputs the number of ties for both players
            Console.WriteLine("Ties: " + ties);
            //Outputs the information for user1 with values from other subprograms
            Console.WriteLine(user1 + ":   " + "Wins: " + user1Wins + " Losses: " + user2Wins + " Winning Percentage: " + winningPercentageUser1 + "%");
            //Outputs the informaiton for user2 with values from other subprograms
            Console.WriteLine(user2 + ":   " + "Wins: " + user2Wins + " Losses: " + user1Wins + " Winning Percentage: " + winningPercentageUser2 + "%"); 
        }

        /// <summary>
        /// Outputs the credits 
        /// </summary>
        static void Credits()
        {
            //Changes the colour to cyan 
            Console.ForegroundColor = ConsoleColor.Cyan;
            //Outputs the title Credits
            Console.WriteLine("Credits");
            Console.WriteLine("////////////////");
            //Changes the colour back to normal
            Console.ResetColor();
            //Outputs a picture of a dog holding a sign with the credits
            Console.WriteLine("                                                 d888b");
            Console.WriteLine("                                                888888b");
            Console.WriteLine("                                                8888888");
            Console.WriteLine("                                                8888888");
            Console.WriteLine("                                                8888888");
            Console.WriteLine("                                     _          8888888");
            Console.WriteLine("                                   ,d88         8888888");
            Console.WriteLine("                            ____  d88' _,,      888888'");
            Console.WriteLine("                           (8888/ 88' d888)     Y8888P");
            Console.WriteLine("                           ___~~8 ~8  88~___    d8888");
            Console.WriteLine("  _______              ,8888888        ~ 888888_8888");
            Console.WriteLine(",8888888888===__    _,d88P~~               ~~Y88888'");
            Console.WriteLine("88888888888888888888888'                        `88b");
            Console.WriteLine("8888888888888888888888P                          Y88");
            Console.WriteLine("`~888888888888~~~~~ 88                            88");
            Console.WriteLine("    ~~~~~~~~        88                            88");
            Console.WriteLine("                    88                            88");
            Console.WriteLine("                    88                            88");
            Console.WriteLine("                    88                            88");
            Console.WriteLine("                    88    ,aa.            ,aa.    88");
            Console.WriteLine("                    88    d88b            d88b    88");
            Console.WriteLine("                  ,=88    Y88P            Y88P    88=,");
            Console.WriteLine("                ,d88P'     `'     _aa_     `'     `Y88b,");
            Console.WriteLine("                88P'             (8888)             `Y88  ad88888b");
            Console.WriteLine("                88                ~^^~                88 d88Y~~Y8b");
            Console.WriteLine("                88                ~^^~                88 d88Y~~Y8b");
            Console.WriteLine("         _______Yb._                              _.d8d8Y      88 ");
            Console.WriteLine(" ______,d88888888ba888=,.______________________.,=8888~d88_______88___");
            Console.WriteLine("|~~~~~~88P~~~~~~Y88~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|");
            Console.WriteLine("|      88        88    CREDITS:                                       |");
            Console.WriteLine("|      88        88    Jeremy's friend ~                              |");
            Console.WriteLine("|      88ba,___,d8P                                                   |");
            Console.WriteLine("|      '888888888                                                     |");
            Console.WriteLine("|          ~~~~~~                                                     |");
            Console.WriteLine("|       This is picture is completely made by Max :)99.9% of max =D   |");
            Console.WriteLine("|       And also, Jacob's idea and Jeremy's enthusiasm xD AND LINDA!  |");
            Console.WriteLine("|       Lies :P Cynthia made at least 30% of this picture             |");
            Console.WriteLine("|       ~Game created by: Cynthia Liu, on November 19, 2012           |");
            Console.WriteLine("|_____________________________________________________________________|");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }

        /// <summary>
        /// Outputs the instructions on how to play the game 
        /// </summary>
        static void Help()
        {
            //Changes the colour to yellow
            Console.ForegroundColor = ConsoleColor.Yellow;
            //Outputs the title Tic-Tac-Toe Help
            Console.WriteLine("Tic-Tac-Toe Help");
            Console.WriteLine("////////////////");
            //Changes the colour back to normal 
            Console.ResetColor();
            //Outputs the instructions for the game
            Console.WriteLine("1. Both players choose usernames");
            Console.WriteLine("2. Player 1 (randomly decided by the computer) chooses the square on the board" + "\n" + "that they would like to place their symbol");
            Console.WriteLine("3. Player 2 does the same");
            Console.WriteLine("4. Steps 2 and 3 are repeated until there is a winner or a draw");
            Console.WriteLine("* To win: a player must have their symbols fill up a row (horizontally" + "\n" + "vertically, or diagnonally)");
        }

        /// <summary>
        /// Outputs a goodbye to the users and the entire program ends 
        /// </summary>
        static void Exit()
        {
            //Changes the colour to magenta
            Console.ForegroundColor = ConsoleColor.Magenta;
            //Outputs the title 
            Console.WriteLine("~GOODBYE :) PLAY AGAIN SOON :D");
            Console.WriteLine("//////////////////////////////");
            //Changes the colour back to normal
            Console.ResetColor();
            //Outputs a picture of hello kitty 
            Console.WriteLine("                              .ZMMMMMN.     ..:+=.  ");
            Console.WriteLine("        ,NMNZ~..             .MMZZZZZMM,.ZMMMMMMMM?. ");
            Console.WriteLine("      .+MM+=ZMMMMN......,++I7MMZZZZZZZMMMM~......+M~   ");
            Console.WriteLine("      ~M8.......~MMMMMMMMMMMMMZZZZZZZZZM8.........MM  ");
            Console.WriteLine("      MM...................~MZZZZZMMMMZMM8,.......MM.  ");
            Console.WriteLine("     .MM...................NMZZZZZMZZMM8ZZMMMNMMMMMM.   ");
            Console.WriteLine("     .MN...................M8ZZZZZMMMMZZZZZZMMZZZZZMM,     ");
            Console.WriteLine("     .MM...................IMZZZZZZZMZZZZZZZMMZZZZZZMM    ");
            Console.WriteLine("      MMMM..................NMM8Z8MMM8ZZZZZZMMMMZZZZMM..        ");
            Console.WriteLine("      ,MM.....................+ZZ?,.?M8ZZZ8MMZMMZZZZMZ,,   ");
            Console.WriteLine("     .MM..............................+MMMMZZ8ZZZZZMN.M");
            Console.WriteLine("     +M7.................................~MZZZZZZMMMM.MM");
            Console.WriteLine("    .MN...................................:MMMMMMN.,MIMM");
            Console.WriteLine("    ?M~.............................................MMMM");
            Console.WriteLine("    NM..............................................MM.?Z");
            Console.WriteLine("    MM...........................................~NMMMMMMMMN8");
            Console.WriteLine("..:+IMMZI:........................................?I=MM,");
            Console.WriteLine("NN+,:MM,........~MMN.....................MMM+........MM");
            Console.WriteLine("    ,MI........ZMMM.....................MMMZ.......,MM");
            Console.WriteLine("    .MM:,,......MN..........ZDZ:........+MZ........7MMMMMM");
            Console.WriteLine("  +MMMMM,..................MIIIM+..................MM");
            Console.WriteLine("  ..  IMZ..................8MDMM................ZIMM,");
            Console.WriteLine("       ,MMMM=...................................,MMMMN");
            Console.WriteLine("     .IMMMMM...................................~MM,..7MM,");
            Console.WriteLine("   .NM?.  ,NMM7..............................ZMM+");
            Console.WriteLine("   ...      .,MMMMNI.....................IMMMM,");
            Console.WriteLine("           .:NMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM,");
            Console.WriteLine("         .NMM+ZZZMMZZZMM~~,,,,++??,M8ZZZMMZZ~7MMN,");
            Console.WriteLine("       .MMM.ZZ$,MMZZZZZM7~,,,,,,,,MMZZZZZMM.ZZ+.MMN");
            Console.WriteLine("      ~MM+MM~.ZMMZZZZZZZMMD:,,,~MM8ZZZZZZZMM+.ZMM+MM");
            Console.WriteLine("     ,M8...:MMMMZZMMMMZZZZZ8MMM8ZZZZZMMM8ZZMMMM:...8M~");
            Console.WriteLine("    ,MZ......+MZZ8+..~MZZZZZZZZZZZZZM~..M8ZZM7......MM");
            Console.WriteLine("    +M.......MMZZZM~,M8ZZZZZZZZZZZZZMM.~MZZZMM......?M");
            Console.WriteLine("    ,M~.....ZMZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ8M......MM");
            Console.WriteLine("    .NM~....MMZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZMI....+MM");
            Console.WriteLine("      8MMMMMMMZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZMMMMMMM,");
            Console.WriteLine("        ...:M8ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ8M+,,");
            Console.WriteLine("          .M8ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ8M:M8");
            Console.WriteLine("          .M8ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ8M:M8");
            Console.WriteLine("           .MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM:M7");
            Console.WriteLine("           ,MI..............7M...............+M:N,");
            Console.WriteLine("           .MD..............7M...............ZM.+");
            Console.WriteLine("           MM..............?M,.............,MZ.");
            Console.WriteLine("            ,MM.............MM7.............MM.,");
            Console.WriteLine("             .NMMMMD?7IIZNMMM7MMMNZII7ZZMMMM7.+");
            Console.WriteLine("                ..IZMNMMZ7,.....+7NMMMMZ+..MM8,");
            Console.WriteLine("                                      ..?MMMN+");
            Console.WriteLine("                                      .:NMMM8");
            Console.WriteLine("                                     ..IMMMM+");
            Console.WriteLine("                                    ..ZMMMM~");
            Console.WriteLine("                                    .,NMMMD.");
            Console.WriteLine("                                    ..ZMMMM~         -By Max Zhang :P  ");
            Console.WriteLine("                                    .,NMMMD");
            //Now the program will end
        }

    }
}                                                                                                                                                                                                                                                                                               