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
        // 1. Create an array with the requested number of entries.
        // 2. Visit each array index from the beginning to the end.
        // 3. Store the input number multiplied by the 1-based position at that index.
        // 4. Return the completed array.

        double[] multiples = new double[length];
        for (int index = 0; index < length; index++)
        {
            multiples[index] = number * (index + 1);
        }

        return multiples;
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
        // 1. Find how many items stay at the front after the right rotation.
        // 2. Copy those front items so they are not lost when the list is changed.
        // 3. Remove the copied items from the front of the existing list.
        // 4. Append the copied items to the end of the same list.

        int frontItemCount = data.Count - amount;
        List<int> itemsToMove = data.GetRange(0, frontItemCount);
        data.RemoveRange(0, frontItemCount);
        data.AddRange(itemsToMove);
    }
}
