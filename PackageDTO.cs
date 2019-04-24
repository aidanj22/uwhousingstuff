
using System;

namespace Housing.Entities.Persistence
{
    /// <summary>
    /// DTO used for packages being persisted
    /// </summary>
    public class PackageDTO
    {

        public long TrackingNum { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }


    }
}
