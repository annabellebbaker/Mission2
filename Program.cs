// Annabelle Baker, 2-10

// Write a .NET console application using C# that simulates the rolling of two 6-sided dice (NOTE:
// NOT a one 12-sided die.)
// Use an array to keep track of the number of times that each combination is thrown.
// Allow the user to choose how many times the “dice” will be thrown

// ask the user for how many times to roll the dice
// write down how many times they need to roll
// for the number of times the user said
//      roll die 1 and collect that result
//      roll die 2 and collect that result
//      add together and store result

// for each number possible to be rolled
//      print the number
//      calculate the percentage of the times it was rolled
//      print an asterisk for each percent it was rolled
// the random number should be a combination of the two die
// use an array to store it (how do I want to store it?) 
// use a for loop to print out the number of ***
   
using System;

namespace DiceSimulation; // calling the project to get the contents of the other file
internal class Program // container
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");

        Console.WriteLine("How many dice rolls would you like to simulate?");

        int input = int.Parse(Console.ReadLine()); // reading this line of whatever the user is inputting and converting to integer

        DiceSimulation simulation = new DiceSimulation(); // creation of this instance

        int[] displayResults = simulation.DiceResults(input); // pulling from the method of the DiceSimulation class

        Console.WriteLine("DICE ROLLING SIMULATION RESULTS"); // printing all of the sample session lines
        
        Console.WriteLine("Each '*' represents 1% of the total number of rolls. ");

        Console.WriteLine("Total number of rolls = " + input); // total number that a user inputs

        PrintHistogram(displayResults, input);

        Console.WriteLine("Thank you for using the dice throwing simulator. Simulator out!");
    }

    private static void PrintHistogram(int[] results, int totalRolls)
    {
        for (int iCount = 2; iCount <= 12; iCount++)
        {
            int percentage = results[iCount] * 100 / totalRolls;

            string asterisk = new string('*', percentage); // creating a variable called asterisk and the percentage

            Console.WriteLine($"{iCount}: {asterisk}"); // I chose to do f-string here because of the 2+ variables
        }
    }
}