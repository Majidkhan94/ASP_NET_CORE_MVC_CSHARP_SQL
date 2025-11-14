using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT_DETAILS_THROUGH_STATIC
{
    internal class STATICCLASS
    {
        public static int ID;
        public string NAME;


        public void STUDENT(String SNAME)
        {
            STATICCLASS.ID++;
            NAME = SNAME;
        }
        public string SHOWINFO()
        {
            return $"ID:{ID.ToString()}{Environment.NewLine}Name: {NAME}{Environment.NewLine}";
        }
    }
}
