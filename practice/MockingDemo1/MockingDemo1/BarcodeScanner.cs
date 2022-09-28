using System;
using System.Collections.Generic;
using System.Text;

namespace MockingDemo1
{
    public class BarcodeScanner
    {
        IUSBDriver driver;

        public string DoScan()
        {
            if (driver.Connect("login_scanner") == false)
                throw new Exception("barcode scanner not connected");

            return new string(driver.ReadData());
        }
    }
}
