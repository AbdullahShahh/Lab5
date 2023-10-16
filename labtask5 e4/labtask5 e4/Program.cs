using System;

class Program
{
    static void Main(string[] args)
    {
        string[] daysOfWeek = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

        Console.WriteLine("Original Array:");
        PrintArray(daysOfWeek);

        // Call the ChangeArray method to reverse the array
        ChangeArray(daysOfWeek);
        Console.WriteLine("\nArray after reversing:");
        PrintArray(daysOfWeek);

        // Call the ChangeArrayElement method to modify specific elements
        ChangeArrayElement(daysOfWeek);
        Console.WriteLine("\nArray after changing elements:");
        PrintArray(daysOfWeek);
    }

    static void PrintArray(string[] array)
    {
        foreach (string item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    static void ChangeArray(string[] array)
    {
        Array.Reverse(array);
    }

    static void ChangeArrayElement(string[] array)
    {
        array[0] = "Sat";
        array[1] = "Fri";
        array[2] = "Thu";
    }
}
