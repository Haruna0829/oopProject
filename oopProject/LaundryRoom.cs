using System;
using System.Collections.Generic;

namespace CampusLaundry.Core
{
    public class LaundryRoom
    {
        public int RoomID { get; private set; }
        public int CycleMinutes { get; private set; }
        public LaundryQueue Queue { get; private set; }

        private readonly List<WashingMachine> machines = new List<WashingMachine>();
        public IList<WashingMachine> Machines { get { return machines.AsReadOnly(); } }

        private readonly List<Booking> Bookings = new List<Booking>();
        private readonly INotificationService notifier;
        
        public LaundryRoom(int id, int minutes, INotificationService service)
        {
            RoomID = id; 
            CycleMinutes = minutes; 
            notifier = service; 
            Queue = new LaundryQueue();
        }
        public void AddMachine(WashingMachine m)
        {
            
        }
        public Booking JoinQueue(Student s, DateTime now)
        {
            
        }
        public void Cancel(Booking b)
        {
            
        }
        public void Ticker(DateTime now)
        {
            
        }
        public int EstWaitTime(Booking b, DateTime now)
        {
            
        }
        public double AvgWaitTime()
        {
            
        }
        private void AssignMachines(DateTime now)
        {
            
        
        }
    }
}
