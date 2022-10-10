using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Class1
    {
        public int Room_no { get; set; }
        public int class_strength { get; set; }
    }
    public class student
    {
        //student_id int primary key,student_name varchar(25),student_class int
        public int student_id { get; set; }
        public string student_name { get; set; }

        public int student_class { get; set; }
    }

    public class subjects
    {
       // subjects_id int primary key,subjects_name
       public int subjects_id { get; set; }
        public string subjects_name { get; set; }
    }
}
