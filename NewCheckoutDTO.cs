using System;
using System.Collections.Generic;
using System.Text;

namespace UWHousing.Entities.DTO
{
    /// <summary>
    /// DTO for transferring new checkout info from presentation layer
    /// </summary>
    public class NewCheckout
    {
        public NewCheckoutDTO()
        {

        }

        /// <summary>
        /// Equipment ID
        /// </summary>
        public int EquipmentID { get; set; }

        /// <summary>
        /// Student Name
        /// </summary>
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        /// <summary>
        /// StudentID/Building
        /// </summary>
        public int StudentID { get; set; }
        public string Buildingname { get; set; }

    }
}
