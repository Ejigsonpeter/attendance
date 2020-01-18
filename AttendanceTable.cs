using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace MultiFaceRec
{
    class AttendanceTable : DynamicModel
    {
        public AttendanceTable():base("DatabaseConnection", "attendance", "id")
        {
            
        }

        public bool AlreadyTaken( string date, string matricNumber )
        {
            dynamic attendance = Single( where: String.Format("matric_number='{0}' AND date_taken='{1}'", matricNumber, date));
            return attendance != null ? true : false;
        }

        public dynamic TakeAttendance( string  date, string matricNumber )
        {
            dynamic attendance = new ExpandoObject();
            attendance.matric_number = matricNumber;
            attendance.date_taken = date;

            return Insert(attendance);
        }
    }
}
