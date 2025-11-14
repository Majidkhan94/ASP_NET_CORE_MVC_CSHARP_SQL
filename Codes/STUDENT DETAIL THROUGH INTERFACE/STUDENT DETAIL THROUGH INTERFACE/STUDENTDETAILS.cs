using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT_DETAIL_THROUGH_INTERFACE
{
   public class STUDENTBASEDETAIL
    {
        public String ID {  get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
    }

    public class STUDENTADMINDETAILS : STUDENTBASEDETAIL, ISTUDENTADMIN
    {
        public String Department { get; set; }
        public String Semester { get; set; }

        public string ADMIN()
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
        

    }
    public class STUDENTHRDETAILS : STUDENTBASEDETAIL, ISTUDENTHR
    {
        public String Resume { get; set; }
        public String Performance { get; set; }

        public string HRDEPARTMENT()
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
    }

}
