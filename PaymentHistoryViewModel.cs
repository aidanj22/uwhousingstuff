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
    public class OrderItemViewModel //iList of payments within
    {
        public PaymentVieweModel StudentID { get; set; }
        //join in data code to join student table with payment table, dapper multiplemapping
            public PaymentViewModel PaymentAmount { get; set; }
            public DateTime RequestDate { get; set; }
    }
}
