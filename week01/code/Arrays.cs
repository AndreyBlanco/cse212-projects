public static class Arrays
{
      /// <summary>
      /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
      /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
      /// integer greater than 0.
      /// </summary>
      /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        /* MY SOLUTION
        Declare a variable list with length equal to length variable to register the result
        Create a for loop from i = 0 while i < length
        For each iteration calculate number * (i + 1) to obtain a multiple of the number and add it to the result list
        */
        var results = new double[length];

        for (int i = 0; i < length; i++)
        {
            results[i] = number * (i + 1);
        }
        
        return results; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        /* MY SOLUTION
        Declare a variable to store de value to move.
        Create a for loop from i = 0 while i <  amount
        For each iteration:
            Store the last value from the data to a store variable.
            Remove the last value from the data
            Insert the store variable to the begin of the data
        */

        var store = 0;

        for (int i = 0; i < amount; i++)
        {
            store = data.Last();
            data.RemoveAt(data.Count - 1);
            data.Insert(0, store);
        }

    }
}
