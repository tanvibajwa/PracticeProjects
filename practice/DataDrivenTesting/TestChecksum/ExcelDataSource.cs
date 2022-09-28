using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestChecksum
{
    class ExcelDataSource : ITestDataSource
    {
        public List<int[]> GetIntDataSet()
        {
            ExcelPackage package = new ExcelPackage(@"../../../../DataSource/checksum.xlsx");
            
            ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];

            return null;
        }
    }
}
