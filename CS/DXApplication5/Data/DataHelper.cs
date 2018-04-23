using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace DXApplication5
{
    public static class DataHelper
    {


        private static string[] Users = new string[] { "Peter Dolan", "Ryan Fischer", "Andrew Miller", "Tom Hamlett",
                                                            "Jerry Campbell", "Carl Lucas", "Mark Hamilton", "Steve Lee" };

        public static void FillResources( BindingList<CustomResource> resources, int count)
        {
           
            int cnt = Math.Min(count, Users.Length);
            Random random= new Random();
            for (int i = 1; i <= cnt; i++)
            {
                CustomResource resource = new CustomResource();
                resource.Name = Users[i - 1];
                resource.ResourceID = i;
                resources.Add(resource);
            }
        }

        public static void GenerateEvents(BindingList<CustomAppointment> eventList, int count, BindingList<CustomResource> resources)
        {

            for (int i = 0; i < count; i++)
            {
                CustomResource resource = resources[i];
                string subjPrefix = resource.Name + "'s ";
                eventList.Add(CreateEvent(subjPrefix + "meeting", resource.ResourceID, 2, 5, (int)(PriorityStatus.High),0));
                eventList.Add(CreateEvent(subjPrefix + "travel", resource.ResourceID, 3, 6, (int)PriorityStatus.Low, 1));
                eventList.Add(CreateEvent(subjPrefix + "phone call", resource.ResourceID, 0, 10, (int)PriorityStatus.Medium, 2));
            }
        }

        private static CustomAppointment CreateEvent(string subject, object resourceId, int status, int label, int priority, int shift)
        {
            CustomAppointment apt = new CustomAppointment();
            apt.Subject = subject;
            apt.OwnerId = resourceId;
            apt.PriorityId = priority;
            Random rnd = new Random();
            int rangeInHours = 24;
            apt.StartTime = DateTime.Today + TimeSpan.FromHours((int)resourceId) + TimeSpan.FromDays(shift);
            apt.EndTime = apt.StartTime + TimeSpan.FromHours(rnd.Next(shift, rangeInHours / 4));
            apt.Status = status;
            apt.Label = label;
            return apt;
        }
    }
}
