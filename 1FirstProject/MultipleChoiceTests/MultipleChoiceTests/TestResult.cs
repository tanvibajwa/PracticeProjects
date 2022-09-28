using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleChoiceTests
{
    public class TestResult
    {
        public string subject { get; set; }
        public string status { get; set; }
        public float percentage { get; set; }

        public override string ToString()
        {
            return subject + ": " + status + "!" + " (" + percentage + "%)";
        }
    }

   
}
