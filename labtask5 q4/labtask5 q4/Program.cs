using System;

public class Program
{
    public static void Main()
    {
        // Initialize the responses using random data (you can replace this with actual data if you have it)
        Random rand = new Random();
        int[] responses = new int[40];
        for (int i = 0; i < responses.Length; i++)
        {
            responses[i] = rand.Next(1, 6);  // Random number between 1 and 5 (inclusive)
        }

        // Array to store the frequency of each response
        int[] frequency = new int[5];

        // Count the frequency of each response
        foreach (int response in responses)
        {
            frequency[response - 1]++;
        }

        // Display the frequency summary
        for (int i = 0; i < frequency.Length; i++)
        {
            Console.WriteLine($"Response {i + 1} given by: {frequency[i]} people");
        }
    }
}
