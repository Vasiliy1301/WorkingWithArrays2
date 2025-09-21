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
    
    int[,] arrays =
    {
        { 44, 5, 86, 23, 99, 12, 100, 1 },
        { 11, 9, 56, 26, 76, 14, 111, 4 },
        { 66, 2, 90, 29, 101, 15, 95, 3 },
    };

    int rows = arrays.GetLength(0);
    int cols = arrays.GetLength(1);

    int[] temp = new int [rows * cols];
    int index = 0;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            temp[index++] = arrays[i, j];
        }
    }

    Array.Sort(temp);

    index = 0;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            arrays[i, j] = temp[index++];
        }
    }

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write($"{arrays[i, j]}\t");
        }
        Console.WriteLine();
    }
    
    #endregion

    #region Task 3

    

    #endregion

    #region Task 4

    int[,] arrays =
    {
        { 10, 5, 86, 23 },
        { 11, 20, 56, 26 },
        { 66, 2, 30, 29 },
        { 54, 3, 62, 40 }
    };

    int rows = arrays.GetLength(0);
    int cols = arrays.GetLength(1);

    int length;

    if (rows < cols)
        length = rows;
    else
        length = cols;

    int sumDiagonal = 0;

    for (int i = 0; i < length; i++)
    {
        sumDiagonal += arrays[i, i];
    }

    Console.WriteLine($"Sum of the diagona - {sumDiagonal}.");

    #endregion
}