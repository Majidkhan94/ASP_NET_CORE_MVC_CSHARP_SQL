using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public abstract class STUDENTBASEDETAIL
    {
        public String ID { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }

        public abstract string STUDENTADMIN();
        public abstract string STUDENTHR();
    }

    public class STUDENTADMINDETAILS : STUDENTBASEDETAIL
    {
        public String Department { get; set; }
        public String Semester { get; set; }

        public override string STUDENTADMIN()
        {
            ID = "100";
            Name = "Majid";
            Email = "Majid@gmail.com";
            Phone = "000000000";
            Department = "ICIT";
            Semester = "4th";
            return $"ID:{ID}{Environment.NewLine}" +
                   $"NAME:{Name}{Environment.NewLine}" +
                   $"Email:{Email}{Environment.NewLine}" +
                   $"Phone:{Phone}{Environment.NewLine}" +
                   $"Department:{Department}{Environment.NewLine}" +
                   $"Semester:{Semester}{Environment.NewLine}";

        }
        public override string STUDENTHR()
        {
            return "Not Applicable for Admin.";
        }


    }
    public class STUDENTHRDETAILS : STUDENTBASEDETAIL
    {
        public String Resume { get; set; }
        public String Performance { get; set; }

        public override string STUDENTHR()
        {
            ID = "100";
            Name = "Majid";
            Email = "Majid@gmail.com";
            Phone = "000000000";
            Resume = "Resume";
            Performance = "Good";
            return $"ID:{ID}{Environment.NewLine}" +
                   $"NAME:{Name}{Environment.NewLine}" +
                   $"Email:{Email}{Environment.NewLine}" +
                   $"Phone:{Phone}{Environment.NewLine}" +
                   $"Resume:{Resume}{Environment.NewLine}" +
                   $"Performance:{Performance}{Environment.NewLine}";
        }
        public override string STUDENTADMIN()
        {
            return "Not Applicable for HR.";
        }
    }
}
