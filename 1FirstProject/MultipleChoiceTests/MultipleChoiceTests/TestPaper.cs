using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleChoiceTests
{
    public class TestPaper : ITestPaper
    {
        public string Subject { get; private set; }
        public string[] MarkScheme { get; private set; }
        public string PassMark { get; private set; }

        public TestPaper(string subject, string[] markScheme, string passMark)
        {
            Subject = subject;
            MarkScheme = markScheme;
            PassMark = passMark;
        }
    }
}
