using System;

class Program
{
    static void Main()
    {
        // Define a rectangular array to store test marks
        int[,] testMarks = new int[5, 10];

        // Populate the array with sample test marks (you can replace these with actual values)
        InitializeTestMarks(testMarks);

        // Display the test marks
        DisplayTestMarks(testMarks);

        // You can also access individual elements of the array like this:
        int course = 2; // Course 2 (0-based index)
        int student = 4; // Student 4 (0-based index)
        int mark = testMarks[course, student];
        Console.WriteLine($"Test mark for course {course + 1}, student {student + 1}: {mark}");
    }

    static void InitializeTestMarks(int[,] marks)
    {
        // Replace these values with your actual test marks
        for (int course = 0; course < 5; course++)
        {
            for (int student = 0; student < 10; student++)
            {
                marks[course, student] = 80 + course * 5 + student;
            }
        }
    }

    static void DisplayTestMarks(int[,] marks)
    {
        Console.WriteLine("Test Marks:");

        for (int course = 0; course < 5; course++)
        {
            for (int student = 0; student < 10; student++)
            {
                Console.WriteLine($"Course {course + 1}, Student {student + 1}: {marks[course, student]}");
            }
        }
    }
}
