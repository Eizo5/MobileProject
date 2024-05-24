using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Az.Models
{
    public class Enroll
    {
        [PrimaryKey, AutoIncrement]
        public int Enroll_ID { get; set; }
        public int Student_ID { get; set; }
        public int Course_ID { get; set; }

    }
}
