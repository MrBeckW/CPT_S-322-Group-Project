using System.Runtime.CompilerServices;
using RoommateFinderEngine;

namespace graderTest
{
   public static class graderTest
   {
        public static void grader_CalculateMatches_returnsMacthesArray()
        {
            try
            {
                //Arrange
                string filePath = "roomates.csv";
                string mockAnswers = "dcabbadcaddbccdbbcad";
                Grader grader1 = new Grader(mockAnswers);
                //Act
                grader1.CalculateMatches(filePath);
                int result1 = grader1.matchIndicies[0];
                int result2 = grader1.matchIndicies[1];
                int result3 = grader1.matchIndicies[2];
                //Assert
                Console.WriteLine("1st" + result1);
                Console.WriteLine("2nd" + result2);
                Console.WriteLine("3rd" + result3);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
   }
}