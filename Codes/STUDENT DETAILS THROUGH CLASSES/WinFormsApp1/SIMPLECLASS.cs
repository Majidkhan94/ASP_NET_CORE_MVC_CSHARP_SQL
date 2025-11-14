using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class SIMPLECLASS
    {
       public string ID {  get; set; }
        public string NAME { get; set; }
            
        public string EMAIL { get; set; }

        public string PHONE { get; set; }
    
        public string SIMPLECLASSDETAIL()
        {
            ID = "101";
            NAME = "MAJID KHAN";
            EMAIL = "MAJIDKHAN@GMAIL.COM";
            PHONE = "0000000000";

            return $"ID: {ID}{Environment.NewLine}" +
                   $"NAME: {NAME}{Environment.NewLine}" + 
                   $"EMAIL: {EMAIL}{Environment.NewLine}" + 
                   $"PHONE: {PHONE}";
        }
    
    
    
    
    }
}
