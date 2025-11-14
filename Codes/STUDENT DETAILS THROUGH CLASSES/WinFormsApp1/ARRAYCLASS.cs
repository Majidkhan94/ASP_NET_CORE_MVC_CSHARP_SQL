using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1;

namespace WinFormsApp1
{
    internal class ARRAYCLASS
    {
        public string ID { get; set; }
        public string NAME { get; set; }
        public string EMAIL { get; set; }
        public string PHONE { get; set; }

            public ARRAYCLASS[] students = new ARRAYCLASS[3];
            public string Showinfo()
            {
            
            students[0] = new ARRAYCLASS { ID = "100", NAME = "Student1", EMAIL = "Student1@example.com", PHONE = "0000000000" };
            students[1] = new ARRAYCLASS { ID = "101", NAME = "Student2", EMAIL = "Student2@example.com", PHONE = "1111111111" };
            students[2] = new ARRAYCLASS { ID = "102", NAME = "Student3", EMAIL = "Student3@example.com", PHONE = "2222222222" };

            string result = "";
            for (int i = 0; i < students.Length; i++)
            {
                result += $"ID: {students[i].ID}, Name: {students[i].NAME}, Email: {students[i].EMAIL}, Phone: {students[i].PHONE} {Environment.NewLine}";
            }

            return result;
        }
    }








}


