using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class OVERLOADINGCLASS
    {
        public string ID { get; set; }
        public string NAME { get; set; }
        public string EMAIL { get; set; }
        public string PHONE { get; set; }


        public OVERLOADINGCLASS() 
        {
            ID = "ENTER YOUR ID:";
            NAME = "ENTER YOUR NAME:";
            EMAIL = "ENTER YOUR EMAIL:";
            PHONE = "ENTER YOUR PHONE: ";
        }

        public OVERLOADINGCLASS(string SID, string SNAME, string SEMAIL, string SPHONE)
        {
            ID = SID;
            NAME = SNAME;
            EMAIL = SEMAIL;
            PHONE = SPHONE;
        }
    }

}
