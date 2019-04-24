using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing.Entities.ViewModels
{
    /// <summary>
    /// View model for equipment
    /// </summary>
    public class EquipmentViewModel
    {
        public long StudentID { get; set; }
        public string BuildingName { get; set; }
        public string Status { get; set; }

       /// public override string ToString()
       /// {
          ///  if (FirstName == string.Empty || LastName == string.Empty)
             ///   return base.ToString();
            ///else
               /// return string.Format("{0}, {1}", LastName, FirstName);

        ///}
    }
}
