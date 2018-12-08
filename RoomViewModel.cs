using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWHousing.Entities.ViewModels
{
    /// <summary>
    /// View model for rooms
    /// </summary>
    public class RoomViewModel
    {
        public string Buildingname { get; set; }
        public int Roomnumber { get; set; }

        public override string ToString()
        {
            if (Roomnumber == int.Empty)
                return base.ToInt();
            else
                return int.Format("{0}", Roomnumber);
        }
    }
}
