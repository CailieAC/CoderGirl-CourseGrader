using System;

namespace CourseGrader
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a method named GradeTestScores that takes an array of test scores as its parameter and returns a string
            // GradeTestScores will add up these test scores and calculate an average score. 
            // It should then return a message of "pass" or "fail" depending on these two conditions:
            // If the average score is greater than or equal to 70 and no single test score is below 50, then return a message of "pass".
            // If the average score is lower than 70 or at least one test score is below 50, then return a message of "fail".
            Console.Write("Enter number of test scores: ");
            int numberOfScores = int.Parse(Console.ReadLine());

            int[] testScores = new int[numberOfScores];

            for (int i = 0; i < numberOfScores; i++)
            {
                Console.Write("Enter Test Score: ");

                testScores[i] = int.Parse(Console.ReadLine());
            }

            //testScores = { 50, 80, 90, 100, 100, 100 };

            string testResult;
            testResult = GradeTestScores(testScores);
            Console.WriteLine(testResult);
            Console.ReadLine();
        }

        public static string GradeTestScores(int[] testScores)
        {
            string testResult = "error";
            int average = 0;
            int total = 0;

            foreach (int testScore in testScores)
            {
                total += testScore;
                if (testScore < 50)
                {
                    testResult = "fail";
                }
            }
            average = total / testScores.Length;
            if (average >= 70 && testResult != "fail")
            {
                testResult = "pass";
            }
            else if (average <70 || testResult == "fail")
            {
                testResult = "fail";
            }

            return testResult;
        }
    }
}
