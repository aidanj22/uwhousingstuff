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
        public int StudentID { get; set; }

        /// <summary>
        /// Student Name
        /// </summary>
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        /// <summary>
        /// Building/room
        /// </summary>
        public string Buildingname { get; set; }
        public int Roomnumber { get; set; }

    }
}
