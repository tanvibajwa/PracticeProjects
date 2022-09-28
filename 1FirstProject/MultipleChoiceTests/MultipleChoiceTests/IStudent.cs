using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleChoiceTests
{
    public interface IStudent
    {
        string[] TestsTaken { get; }

        void TakeTest(ITestPaper paper, string[] answers);
    }
}
