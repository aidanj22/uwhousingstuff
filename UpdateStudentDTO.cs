using System;
using System.Collections.Generic;
using System.Text;

namespace UWHousing.Entities.DTO
{
    /// <summary>
    /// DTO for transferring updated student info from presentation layer
    /// </summary>
    public class UpdateStudentDTO
    {
        public UpdateStudentDTO()
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
        /// Address/Building
        /// </summary>
        public string Address { get; set; }
        public string Buildingname { get; set; }

    }
}
