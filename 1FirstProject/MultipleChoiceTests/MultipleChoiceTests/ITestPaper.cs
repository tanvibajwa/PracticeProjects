using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleChoiceTests
{
    public interface ITestPaper
    {
        string Subject { get; }
        string[] MarkScheme { get; }
        string PassMark { get; }
    }
}
