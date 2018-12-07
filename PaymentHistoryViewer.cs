using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWHousing.Data;
using UWHousing.Entities.Persistence;
using UWHousing.Enum;
using UWHousing.Events;

namespace UWHousing.BLL
{

    /// <summary>
    /// business class for student payment summary queries
    /// </summary>
    public class PaymentHistoryViewer
    {

        private readonly PaymentHistoryDAO _paymenthistoryDAO;

        public StudentPaymentViewer()
        {
            _paymenthistoryDAO = new PaymentHistoryDAO();
        }

        ///Retrieves payment summary for student

        public IList<PaymentHistory> GetPaymentHistory(student_id) ///this seems pretty wrong
        {
            return _paymenthistoryDAO.GetPaymentHistory(student_id);
        }
    }
}

