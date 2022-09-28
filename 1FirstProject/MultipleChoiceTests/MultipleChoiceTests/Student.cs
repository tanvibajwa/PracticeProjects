using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MultipleChoiceTests
{
    public class Student : IStudent
    {
        private List<TestResult> TestsTakenResults;

        public string[] TestsTaken
        {
            get
            {
                if (TestsTakenResults.Count == 0)
                {
                    return new string[] { "No tests taken" };
                }
                else
                {
                    string[] results_collection = new string[TestsTakenResults.Count];
                    for (int i = 0; i < TestsTakenResults.Count; i++)
                    {
                        results_collection[i] = TestsTakenResults[i].ToString();
                    }
                    return results_collection;
                }                    
            }
        }

        public Student()
        {
            TestsTakenResults = new List<TestResult>();
        }


        public void TakeTest(ITestPaper paper, string[] answers)
        {
            string str_pass_mark = paper.PassMark;
            float pass_mark = float.Parse(str_pass_mark.Remove(str_pass_mark.Length - 1));
            float total_percentage = 0;
            
            if (answers.Length > 0)
            {
                for (int i = 0; i < answers.Length; i++)
                {
                    if (answers[i] == paper.MarkScheme[i])
                        total_percentage += 100 / paper.MarkScheme.Length;
                }

                TestResult result = new TestResult();
                result.subject = paper.Subject;
                result.percentage = total_percentage;

                if (Math.Round(total_percentage) < pass_mark)                
                    result.status = "Failed";
                else                
                    result.status = "Passed";
                
                TestsTakenResults.Add(result);
            }
        }

        public static void sort_descending(int input)
        {
            for (int i = 0; i < number_array.Length; i++)
            {
                for (int j = i + 1; j < number_array.Length; j++)
                {
                    if (number_array[j] > number_array[i])
                    {
                        int temp = number_array[j];
                        number_array[j] = number_array[i];
                        number_array[i] = temp;
                    }
                }
            }
        }


    }
}
