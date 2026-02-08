using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AirportTestSimulator
{
    internal class Data
    {
        // data
        public string destination;
        public int hour = 12;
        public int minute = 00;
        public string status = "Active";

        // constructors
        public void SetFlightDetails(string d, int h, int m)
        {
            destination = d;
            hour = h;
            minute = m;
        }

        public string GetStatus()
        {
            return status;
        }

        public void SetStatus(string s)
        {
            if (s == "Active" || s == "Cancelled")
            {
                status = s;
            }
            else if (s =="Delayed")
            {
                status = s;
            }
        }

        
    }

    internal class ToEdit
    {
        // data
        int position = 0;

        public void setPosition(int n)
        {
            position = n;
        }
    }
}
