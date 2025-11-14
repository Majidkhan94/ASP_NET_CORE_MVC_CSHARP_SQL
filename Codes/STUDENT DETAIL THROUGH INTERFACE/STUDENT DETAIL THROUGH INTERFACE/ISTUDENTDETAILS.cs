using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT_DETAIL_THROUGH_INTERFACE
{
    internal interface ISTUDENTADMIN
    {
        public string ADMIN();
    }
    internal interface ISTUDENTHR
    {
        public string HRDEPARTMENT();
    }
}
