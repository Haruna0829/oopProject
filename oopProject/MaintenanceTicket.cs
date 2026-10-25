using System;
using System.Collections.Generic;

namespace CampusLaundry.Core
{
    public class MaintenanceTicket
    {
        public int TicketID { get; private set; }
        public WashingMachine Machine { get; private set; }
        public Technician AssignedTo { get; private set; }
        public TicketStatus Status { get; private set; }
        public string IssueDescription { get; private set; }
        public DateTime ReportedAt { get; private set; }
        public DateTime? ResolvedAt { get; private set; }
        private DateTime? startedAt;
        public MaintenanceTicket(int id, WashingMachine machine, string issue, DateTime now)
        {
        
        }
        public void Assign(Technician t)
        {
            
        }
        public void Start(DateTime now)
        {
        
        }
        public void Resolve(DateTime now, string notes)
        {
            
        }
    }
}
