using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Az.Models
{
    public class Student
    {
        [PrimaryKey , AutoIncrement]
        public int Student_ID { get; set; }
        public string Student_Name { get; set; }
        public string Student_Department { get; set; }

        public bool IsSelected { get; set; }
    }
}
