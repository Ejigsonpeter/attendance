using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiFaceRec
{
    class StudentTable : DynamicModel
    {
        public StudentTable():base("DatabaseConnection", "student", "id")
        {
            
        }

        public bool RegisterStudent( dynamic student )
        {
            dynamic stud = Insert(student);

            return stud != null ? true : false;
        }

        public string GetStudentName( dynamic matricNumber )
        {
            dynamic Student = Single(where: String.Format("matric_number='{0}'", matricNumber));
            return Student.first_name + " " + Student.last_name;
        }
    }
}
