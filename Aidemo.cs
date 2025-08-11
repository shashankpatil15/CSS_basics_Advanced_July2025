using System;

public class AIdemo
{
    // Linear search method
    public static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                return i; // Return the index if found
            }
        }
        return -1; // Return -1 if not found
    }

    public static void Main(string[] args)
    {
        int[] array = { 10, 23, 45, 70, 11, 15 };
        int target = 70;
        int result = LinearSearch(array, target);
        if (result != -1)
        {
            Console.WriteLine($"Element {target} found at index {result}");
        }
        else
        {
            Console.WriteLine($"Element {target} not found in the array");
        }
    }
}
