using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWHousing.Entities.ViewModels
{
    /// <summary>
    /// View model for payments
    /// </summary>
    public class PaymentViewModel
    {
        public int StudentID { get; set; } //probably dont need this
        public int PaymentAmount { get; set; }
        public DateTime PaymentDate { get; set; }

        public override string ToString()
        {
            if (StudentID == string.Empty)
                return base.ToString();
            else
                return Name;

        }
    }
}
