using System;
using UWHousing.Enum;

namespace UWHousing.Entities.Persistence
{
    /// <summary>
    /// DTO used for studenrts being persisted
    /// </summary>
    public class StudentDTO
    {

        public static StudentDTO NOTFOUND = new StudentDTO
        {
            StudentID = -1,
            Firstname = 'a',
            Lastname = 'b',
            Buildingname = 'c',
            Roomnumber = -1,

        };

        public int StudentID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Buildingname { get; set; }
        public int Roomnumber { get; set; }


        //implementing a VERY rudimentary Equals method.  Only taking into account the student number
        //should PROBABLY include all fields.  Saving time by just comparing order number
        public override bool Equals(object obj)
        {
            var item = obj as StudentDTO;

            if (item == null)
            {
                return false;
            }

            return this.student_id.Equals(item.StudentID);
        }

        public override int GetHashCode()
        {
            return this.student_id.GetHashCode();
        }
    }
}
