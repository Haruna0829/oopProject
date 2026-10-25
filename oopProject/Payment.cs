using System;
using System.Collections.Generic;

namespace CampusLaundry.Core
{
    public class Payment
    {
        public int PaymentID { get; private set; }
        public int BookingID { get; private set; }
        public decimal Amount { get; private set; }
        public PaymentMethod Method { get; private set; }
        public PaymentStatus Status { get; private set; }
        public DateTime? PaidAt { get; private set; }
        public Payment(int paymentId, int bookingId, decimal amount, PaymentMethod method)
        {
            
        }

        public bool Process(DateTime now)
        {
        
        }
        public void Refund()
        {
        
        }
    }
}
