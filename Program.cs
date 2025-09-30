/* 
For The Love of Products
Created by finn gilbert on 9/30/2025
*/
using System.Globalization;
// Set the maximum value for the multiplication table
int max = 12;
// Outer loop controls the rows 1 through max
for (int i = 1; i <= max; i++)
{
    // Inner loop controls the columns 1 through max
    for (int j = 1; j <= max; j++)
    {
        // Multiply row number i by column number j to get the product
        int ResultColumn = j * i;
        // Print the product inside vertical bars with tab spacing for alignment
        Console.Write("|" + ResultColumn + "|" + "\t");
        // When the last column is reached, move to a new line and print a separator
        if (j == 12)
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine();
        }
    }
}
// Indicate the program has finished running
Console.WriteLine("Program ended");
