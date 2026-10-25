using System;
using System.Collections.Generic;

namespace CampusLaundry.Core
{
    public class Receipt
    {
        public string ReceiptNo { get; private set; }
        public Payment Payment { get; private set; }
        public Student IssuedTo { get; private set; }
        public WashingMachine Machine { get; private set; }
        public decimal Amount { get; private set; }
        public DateTime IssuedAt { get; private set; }
        private readonly Booking booking;
        public Receipt(Booking b)
        {
        
        }
        public void Generate(Payment p, DateTime now)
        {
        
        }
        public void Send()
        {
        
        }
        public string Print()
        {
            
        }
    }
}
