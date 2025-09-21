namespace WorkingWithArrays2;

public class Program
{
    #region Task 1

    int[] arrays = { 44, 5, 86, 23, 98, 12, 100, 120, 1, 34, 199, 187 };

    int biggestNumber = 0;
    int enultimateLargeNumber = 0;

    for (int i = 0; i < arrays.Length; i++)
    {
        if (biggestNumber < arrays[i])
        {
            enultimateLargeNumber = biggestNumber;
            biggestNumber = arrays[i];
        }
        else if (arrays[i] > enultimateLargeNumber && arrays[i] < biggestNumber)
        {
            enultimateLargeNumber = arrays[i];
        }
    }

    Console.WriteLine($"The largest number in the array is {biggestNumber}, and the second to last large number is {enultimateLargeNumber}.");

    #endregion
    
    #region Task 2
    
    
    
    #endregion
}