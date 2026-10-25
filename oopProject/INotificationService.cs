using System;

namespace CampusLaundry.Core
{
    public interface INotificationService
    {
        void Notify(Student s, string message);
    }
}
