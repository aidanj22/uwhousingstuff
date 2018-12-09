using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWHousing.Entities.ViewModels
{
    /// <summary>
    /// View model for a student
    /// </summary>
    public class StudentViewModel
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BuildingName { get; set; }
        public string RoomNumber { get; set; }

        public override string ToString()
        {
            if (FirstName == string.Empty || LastName == string.Empty)
                return base.ToString();
            else
                return string.Format("{0}, {1}", LastName, FirstName);

        }
    }
}
