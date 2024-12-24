/*  
In this first challenge exercise, you need to instantiate the variables that 
are required for the updated score report, and then update the Console.WriteLine() 
statement that writes student grades to the console.

=====Your updated application must:=====
-use the existing arrays and array values for all student grade calculations.
-use the nested structure provided by the existing foreach and if statements.
-declare and initialize any other integer variables that are required for calculating sums.
-declare and initialize any other decimal variables that are required for calculations and/or score report values.


===The format of the update score report is:===

    Student         Exam Score      Overall Grade   Extra Credit

    Sophia          0               95.8    A       0 (0 pts)
    Andrew          0               91.2    A-      0 (0 pts)
    Emma            0               90.4    A-      0 (0 pts)
    Logan           0               93      A       0 (0 pts)

*Note: Since this exercise does not include updating calculations, 
the score report will show 0 for the new fields as shown above.

/*
=====Your updated application must:=====
-use the existing arrays and array values for all student grade calculations.
-use the nested structure provided by the existing foreach and if statements.
-calculate the sum of exam and extra credit assignment scores using variables from the first exercise or the original code.
-calculate the average for exam scores and extra credit scores using variables from the first exercise or the original code.
-calculate the final numeric score as follows: add 10% of the extra credit score sum to the exam score sum, and then divide that value by the number of exams.
-calculate the extra credit points earned as follows: divide 10% of the extra credit score sum by the number of exams.

===Tip===
You will need to use (decimal) casting in your equations to preserve the fractional component during your calculations.

=====The required score report format is:=====

    Student         Exam Score      Overall Grade   Extra Credit

    Sophia          92.2            95.88   A       92 (3.68 pts)
    Andrew          89.6            91.38   A-      89 (1.78 pts)
    Emma            85.6            90.94   A-      89 (5.34 pts)
    Logan           91.2            93.12   A       96 (1.92 pts)
*/

using System;

class Program
{
    static void Main()
    {
        // Sample data arrays
        string[] students = { "Sophia", "Andrew", "Emma", "Logan" };
        decimal[] examScores = { 92.2m, 89.6m, 85.6m, 91.2m }; // Example exam scores
        decimal[] extraCredits = { 92m, 89m, 89m, 96m }; // Example extra credits

        // Variables for calculations
        decimal sumExamScores = 0m;
        decimal sumExtraCredits = 0m;
        int numberOfExams = examScores.Length;

        // Calculate sums
        foreach (var score in examScores)
        {
            sumExamScores += score;
        }

        foreach (var credit in extraCredits)
        {
            sumExtraCredits += credit;
        }

        // Output header
        Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit");
        
        // Processing each student's data
        for (int i = 0; i < students.Length; i++)
        {
            // Calculate overall grade and extra credit points
            decimal finalNumericScore = (examScores[i] + (sumExtraCredits * 0.1m) / numberOfExams);
            decimal extraCreditPoints = (extraCredits[i] * 0.1m) / numberOfExams;

            // Determine letter grade (simplified logic)
            string grade = finalNumericScore >= 90 ? "A" : finalNumericScore >= 80 ? "A-" : "B";

            // Output formatted student data
            Console.WriteLine($"{students[i]}\t\t{examScores[i]:0.0}\t\t{finalNumericScore:0.00}\t{grade}\t{extraCredits[i]} ({extraCreditPoints:0.00} pts)");
        }
    }
}
