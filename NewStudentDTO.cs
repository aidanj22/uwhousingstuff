using System;
using System.Collections.Generic;
using System.Text;

namespace UWHousing.Entities.DTO
{
    /// <summary>
    /// DTO for transferring new student info from presentation layer
    /// </summary>
    public class NewStudentDTO
    {
        public NewStudentDTO()
        {

        }

        /// <summary>
        /// Student ID
        /// </summary>
        public int student_id { get; set; }

        /// <summary>
        /// Student Name
        /// </summary>
        public string first_name { get; set; }
        public string last_name { get; set; }

        /// <summary>
        /// Building/room
        /// </summary>
        public string building_name { get; set; }
        public int room_number { get; set; }

        /// <summary>
        /// Meal plan info
        /// </summary>
       
        public string meal_plan { get; set; }

    }
}
