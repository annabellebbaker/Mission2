using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceSimulation;

internal class DiceSimulation
{
    // this class will be calculating the results of the dice rolls
    private readonly Random random = new Random();

    // creating an instance of a random class
    public int[] DiceResults(int input) // want it to be public so it can be referenced later in the Program.cs
    { 
    int[] results = new int[13]; // creating an instance for the empty array to store numbers (how many of each combination is rolled)

    for (int iCount = 0; iCount < input; iCount++) // incrementor for loop., incrementing through each roll
        {
            int die1 = random.Next(1, 7); // limits of the random number generated 
            int die2 = random.Next(1, 7);
            int sum = die1 + die2; // don't forget to call what variable type it is
            results[sum]++; // coordinates in the array - put it in its spot and then putting a "tally" esssential
        }
    return results; // see the results of the dice rolls totals
    }
}
