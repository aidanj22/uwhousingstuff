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
            student_id = -1,
            first_name = 'a',
            last_name = 'b',
            building = 'c',
            room_number = -1,
            meal_plan = 'y',

        };

        public int student_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string building { get; set; }
        public int room_number { get; set; }
        public string meal_plan { get; set; }


        //implementing a VERY rudimentary Equals method.  Only taking into account the student number
        //should PROBABLY include all fields.  Saving time by just comparing order number
        public override bool Equals(object obj)
        {
            var item = obj as StudentDTO;

            if (item == null)
            {
                return false;
            }

            return this.student_id.Equals(item.student_id);
        }

        public override int GetHashCode()
        {
            return this.student_id.GetHashCode();
        }
    }
}
