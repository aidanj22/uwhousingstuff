using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWHousing.Entities.ViewModels
{
    /// <summary>
    /// View model for buildings
    /// </summary>
    public class BuildingViewModel
    {
            public string Buildingname {get; set;}

        public override string ToString()
        {
            if (Buildingname == String.Empty)
                return base.ToString();
            else
                return string.Format("{0}", Buildingname);
        }
    }
}
