/*
You're developing a Student Grading application that automates the calculation of grades for each student in a class. 
The parameters for your application are:

-----Create a C# console application.
-----Start with four students. Each student has five exam scores.
-----Each exam score is an integer value, 0-100, where 100 represents 100% correct.
-----A student's overall exam score is the average of their five exam scores.

-----Criteria for extra credit assignments:
    ===Include extra credit assignment scores in the student's scores array.
    ===Extra credit assignments are worth 10% of an exam score (when calculating the final numeric grade).
    ===Add extra credit assignment scores to the student's total exam score before calculating the final numeric grade.

-----Your application needs to automatically assign letter grades based on the calculated final score for each student.
-----Your application needs to output/display each student’s name and formatted grade.
-----Your application needs to support adding other students and scores with minimal impact to the code.

You've already completed an initial version of the application. The Starter code project for this Guided project 
module includes a Program.cs file that provides the following code features:
-----The code declares variables used to define student names and individual exam scores for each student.
-----The code includes the variables and algorithms used to sum the exam scores and calculate the average exam score for each student.
-----The code includes a hard coded letter grade that the developer must apply manually.
-----The code includes Console.WriteLine() statements to display the student grading report.

Your goal is to update the existing code to include the following features:
-----Use arrays to store student names and assignment scores.
-----Use a foreach statement to iterate through the student names as an outer program loop.
-----Use an if statement within the outer loop to identify the current student name and access that student's assignment scores.
-----Use a foreach statement within the outer loop to iterate through the assignment scores array and sum the values.
-----Use an updated algorithm within the outer loop to calculate the average exam score for each student.
-----Use an if-elseif-else construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
-----Integrate extra credit scores when calculating the student's final score and letter grade as follows:
     =Your code must detect extra credit assignments based on the number of elements in the student's scores array.
     =Your code must apply the 10% weighting factor to extra credit assignments before adding extra credit scores to the sum of exam scores.

The following list shows the letter grade that corresponds to numeric scores:

Output:

97 - 100   A+
93 - 96    A
90 - 92    A-
87 - 89    B+
83 - 86    B
80 - 82    B-
77 - 79    C+
73 - 76    C
70 - 72    C-
67 - 69    D+
63 - 66    D
60 - 62    D-
0  - 59    F

The update application needs to produce a formatted student grading report that appears as follows:

Output:

Student         Grade

Sophia:         92.2    A-
Andrew:         89.6    B+
Emma:           85.6    B
Logan:          91.2    A-
*/

/*  This code below is to be updated to meet the requirements of the challenge above.
    - Use arrays to store student names and assignment scores.
    - Use a foreach statement to iterate through the student names as an outer program loop.
    - Use an if statement within the outer loop to identify the current student name and access that student's assignment scores.
    - Use a foreach statement within the outer loop to iterate through the assignment scores array and sum the values.
    - Use an updated algorithm within the outer loop to calculate the average exam score for each student.
    - Use an if-elseif-else construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
    - Integrate extra credit scores when calculating the student's final score and letter grade as follows:
        - Your code must detect extra credit assignments based on the number of elements in the student's scores array.
        - Your code must apply the 10% weighting factor to extra credit assignments before adding extra credit scores to the sum of exam scores.
    - The output should be in the format:
        Student         Grade
        Sophia:         92.2    A-
        Andrew:         89.6    B+
        Emma:           85.6    B
        Logan:          91.2    A-
*/

// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

// Solution #1

// using System;

// public class GradingApp
// {
//     public static void Main(string[] args)
//     {
//         int examAssignments = 5;

//         string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

//         int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
//         int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
//         int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
//         int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

//         Console.Clear();
//         Console.WriteLine("Student\t\tGrade\n");

//         foreach (string name in studentNames)
//         {
//             int[] studentScores = new int[0]; 

//             if (name == "Sophia")
//                 studentScores = sophiaScores;
//             else if (name == "Andrew")
//                 studentScores = andrewScores;
//             else if (name == "Emma")
//                 studentScores = emmaScores;
//             else if (name == "Logan")
//                 studentScores = loganScores;

//             int totalScore = 0;
//             int extraCreditScore = 0;
//             int numberOfExtraCreditAssignments = 0;

//             for (int i = 0; i < studentScores.Length; i++)
//             {
//                 if (i < examAssignments)
//                 {
//                     totalScore += studentScores[i];
//                 }
//                 else
//                 {
//                     extraCreditScore += studentScores[i];
//                     numberOfExtraCreditAssignments++;
//                 }
//             }

//             double averageScore = (totalScore + (extraCreditScore * 0.1)) / examAssignments;
//             string letterGrade;

//             if (averageScore >= 97)
//                 letterGrade = "A+";
//             else if (averageScore >= 93)
//                 letterGrade = "A";
//             else if (averageScore >= 90)
//                 letterGrade = "A-";
//             else if (averageScore >= 87)
//                 letterGrade = "B+";
//             else if (averageScore >= 83)
//                 letterGrade = "B";
//             else if (averageScore >= 80)
//                 letterGrade = "B-";
//             else if (averageScore >= 77)
//                 letterGrade = "C+";
//             else if (averageScore >= 73)
//                 letterGrade = "C";
//             else if (averageScore >= 70)
//                 letterGrade = "C-";
//             else if (averageScore >= 67)
//                 letterGrade = "D+";
//             else if (averageScore >= 63)
//                 letterGrade = "D";
//             else if (averageScore >= 60)
//                 letterGrade = "D-";
//             else
//                 letterGrade = "F";

//             Console.WriteLine($"{name}:\t\t{averageScore:F1}\t{letterGrade}");
//         }
//         Console.WriteLine("\n\rPress the Enter key to continue");
//         Console.ReadLine();
//     }
// }

// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

// Solution #2 - Using a Dictionary to store student names and their scores
/*
    This refactored code has the grade calculation logic encapsulated in a helper function
    'CalculateGrade'. This function calculates the average score and letter grade for a student.

    The letter grade determination is further abstracted into a helper function 'GetLetterGrade'.
    - Modular design improves readability and maintainability.
    - Reduces duplication and makes the code easier to debug or extend

    The use of Dictionaries
    - Using a dictionary 'studentScores' to store student names and their scores streamlines access
      to student scores and makes the code more readable.
    - Makes adding or removing students and their scores easier and less error-prone.

    Single Responsibility Principle (SRP)
    - SRP is adhered to by separating the logic for calculating grades and determining letter grades
      into separate functions. It makes the code easier to understand. SRP seeks to ensure that each
      function or class has a single responsibility and that responsibility is encapsulated within the
      function or class.

    Time and Space Complexity
    - The Time Complexity of the code is O(n) where n is the number of students. The code iterates
      through each student to calculate their grade.
    - The Space Complexity of the code is O(n) where n is the number of students. The code stores
      student names and scores in a dictionary. Minimal memory is used for other variables.

    This refactored version is a well-designed solution that adheres to the principles of clean code-
    modularity, readability, and scalability.
*/

using System;
using System.Collections.Generic;

public class GradingApp
{
    public static void Main(string[] args)
    {
        int examAssignments = 5;

        // Store student names and their scores using a dictionary
        Dictionary<string, int[]> studentScores = new Dictionary<string, int[]>()
        {
            { "Sophia", new int[] { 90, 86, 87, 98, 100, 94, 90 } },
            { "Andrew", new int[] { 92, 89, 81, 96, 90, 89 } },
            { "Emma", new int[] { 90, 85, 87, 98, 68, 89, 89, 89 } },
            { "Logan", new int[] { 90, 95, 87, 88, 96, 96 } }
        };

        Console.Clear();
        Console.WriteLine("Student\t\tGrade\n");

        foreach (var student in studentScores)
        {
            string studentName = student.Key;
            int[] scores = student.Value;
            
            var gradeInfo = CalculateGrade(scores, examAssignments);
            
            Console.WriteLine($"{studentName}:\t\t{gradeInfo.AverageScore:F1}\t{gradeInfo.LetterGrade}");
        }
        
        Console.WriteLine("\n\rPress the Enter key to continue");
        Console.ReadLine();
    }
    
    // Helper function to encapsulate grade calculation
    public static (double AverageScore, string LetterGrade) CalculateGrade(int[] scores, int examAssignments)
    {
       int totalScore = 0;
        int extraCreditScore = 0;
        int numberOfExtraCreditAssignments = 0;

        for (int i = 0; i < scores.Length; i++)
        {
            if (i < examAssignments)
            {
                totalScore += scores[i];
            }
            else
            {
                extraCreditScore += scores[i];
                numberOfExtraCreditAssignments++;
            }
        }
        
        double averageScore = (totalScore + (extraCreditScore * 0.1)) / examAssignments;
        string letterGrade = GetLetterGrade(averageScore);

        return (averageScore, letterGrade);
    }
    
    
    // Helper function to determine letter grade based on score
     private static string GetLetterGrade(double averageScore)
        {
            if (averageScore >= 97) return "A+";
            if (averageScore >= 93) return "A";
            if (averageScore >= 90) return "A-";
            if (averageScore >= 87) return "B+";
            if (averageScore >= 83) return "B";
            if (averageScore >= 80) return "B-";
            if (averageScore >= 77) return "C+";
            if (averageScore >= 73) return "C";
            if (averageScore >= 70) return "C-";
            if (averageScore >= 67) return "D+";
            if (averageScore >= 63) return "D";
            if (averageScore >= 60) return "D-";
            return "F";
        }
}

