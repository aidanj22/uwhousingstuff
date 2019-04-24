using System;
using System.Collections.Generic;
using System.Text;

namespace UWHousing.Entities.DTO
{
    /// <summary>
    /// DTO for transferring new package info from presentation layer
    /// </summary>
    public class NewPackageDTO
    {
        public NewPackageDTO()
        {

        }

        /// <summary>
        /// Tracking Number
        /// </summary>
        public int TrackingNum { get; set; }

        /// <summary>
        /// Student Name
        /// </summary>
        public string Firstname { get; set; }
        public string Lastname { get; set; }


    }
}