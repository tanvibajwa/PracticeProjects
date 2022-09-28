using System;
using System.Collections.Generic;
using System.Text;

namespace MockingDemo1
{
    public class LogInManager
    {
        public string ExpectedUserID { get; set; }

        public LogInManager(string expected_user_id)
        {
            ExpectedUserID = expected_user_id;
        }


        public bool CheckCredentials()
        {
            BarcodeScanner scanner = new BarcodeScanner();

            var read_id = scanner.DoScan();

            return read_id == ExpectedUserID;
        }
    }
}
