public static class Arrays
{
    
    public static double[] MultiplesOf(double number, int length)
    {
        //create an array the length of 'int length' to store results
        var results = new double[length];

        //loop and add 1 until the length of 'int length' is reached
        for (int i = 0; i < length; i++)
        {
            //use index + 1 to multiply the number since the 0th index would be 1 times, 1st index would be 2 times, and so on.
            results[i] = (i + 1) * number;
        }

        //return the results
        return results;
    }

    public static void RotateListRight(List<int> data, int amount)
    {
        // I didn't assign data.Count to a variable to increase visual clarity since it's a small snippet

        //get the remainder of amount divided by count
        int rotations = amount % data.Count;

        //make sure that the remainder isn't negative
        if (rotations < 0) {
            rotations += data.Count;
        }

        //create a list the length of data to store the results in since size does not need to change.
        var result = new List<int>(new int[data.Count]);

        //if i hasn't reached the length of the list yet, re enter the loop and recalculate the new index you need the data placed in results using the remainder of i + rotations divided by the length 
        for (int i = 0; i < data.Count; i++) {
            int targetPos = (i + rotations) % data.Count;

            //use the targetPos to place the data into the correct position in the results array
            result[targetPos] = data[i];
        }

        data.Clear(); //make sure data is empty
        data.AddRange(result);

    }
}

