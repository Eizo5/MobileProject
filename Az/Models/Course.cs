using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Az.Models
{
    public class Course
    {
        [PrimaryKey , AutoIncrement]
        public int Course_ID { get; set; }
        public string Course_Code { get; set; }
        public string Course_Name { get; set; }
      

    }
}
