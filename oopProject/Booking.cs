using System;

namespace CampusLaundry.Core
{
    public class Booking
    {
        public int BookingID { get; set; }
        public BookingStatus BookingStatus { get; set; }
        public DateTime JoinedAt { get; set; }
        public DateTime? StartedAt { get; set; }
        public Student Student { get; set; }
        public WashingMachine AssignedMachine { get; set; }
        public Payment ConfirmedPayment { get; set; }

        public bool IsActive { get; set; }
        public double WaitMinutes { get; set; }

        public Booking(int id, Student student, DateTime now)
        {
            BookingID = id;
            Student = student;
            JoinedAt = now;
            BookingStatus = BookingStatus.Waiting;
        }

        public void AwaitPayment()
        {
            
        }
        public void ConfirmPayment(Payment p)
        {
            
        }
        public void Start(DateTime now)
        {
            
        }
        public void Complete()
        {
            
        }
        public void Cancel()
        {
            
        }
    }
}