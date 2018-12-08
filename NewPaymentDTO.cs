using System;
using System.Collections.Generic;
using System.Text;

namespace UWHousing.Entities.DTO
{
    /// <summary>
    /// DTO for transfering new payment information from the presentation layer
    /// </summary>
    public class NewStudentPaymentDTO
    {
        public int StudentID { get; set; }
        public int Paymentamount { get; set; }
        public DateTime Paymentdate { get; set; } //could generate in business layer
    }
}
