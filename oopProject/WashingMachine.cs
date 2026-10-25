using System;
using System.Collections.Generic;

namespace CampusLaundry.Core
{
    public class WashingMachine
    {
        public int MachineID { get; private set; }
        public MachineStatus WashingMachineStatus { get; private set; }
        public Booking CurrentBooking { get; private set; }
        public DateTime? EndsAt { get; private set; }
        public WashingMachine(int id) { MachineID = id; WashingMachineStatus = MachineStatus.Available; }
        public void Reserve(Booking b)
        {
            
        }
        public void Start(Booking b, DateTime now, int minutes)
        {
            
        }
        public void Finish()
        {
            
        }
        public void ReleaseReservation(Booking b)
        {
            
        }
        public void MarkOutOfOrder()
        {
        
        }
        public void Repair()
        {
            
        }
    }
}
