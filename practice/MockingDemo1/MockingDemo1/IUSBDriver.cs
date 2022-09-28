using System;
using System.Collections.Generic;
using System.Text;

namespace MockingDemo1
{
    public interface IUSBDriver
    {
        public bool Connect(string device_name);

        public char[] ReadData();
    }
}
