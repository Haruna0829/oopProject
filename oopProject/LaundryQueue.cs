using System;
using System.Collections.Generic;

namespace CampusLaundry.Core
{
    public class LaundryQueue
    {
        private readonly List<Booking> waiting = new List<Booking>();
        public int Count
        {
            get {return 0;}
        }
        public void EnQueue(Booking b)
        {
            
        }
        public Booking DeQueue()
        {
            
            return null;
        }
        public bool Remove(Booking b)
        {
            return false;
        }
        public int PositionOf(Booking b)
        {
        
            return -1;
        }
    }
}
