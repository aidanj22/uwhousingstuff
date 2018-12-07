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
        public int student_id { get; set; }
        public int payment_amount { get; set; }
        public DateTime payment_date { get; set; } //could generate in business layer
    }
}
