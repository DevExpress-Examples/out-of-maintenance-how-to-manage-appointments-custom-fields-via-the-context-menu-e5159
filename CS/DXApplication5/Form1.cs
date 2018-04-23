using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;


namespace DXApplication5
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            schedulerControl.Start = System.DateTime.Now;
            schedulerControl.GroupType = SchedulerGroupType.Resource;
            schedulerControl.OptionsBehavior.SelectOnRightClick = true;
            InitResources();
            InitAppointments();
        }

        BindingList<CustomResource> resources = new BindingList<CustomResource>();
        BindingList<CustomAppointment> eventList = new BindingList<CustomAppointment>();
        List<Priority> priorities = new List<Priority>();
        private void InitResources()
        {
            ResourceMappingInfo mappings = this.schedulerStorage.Resources.Mappings;
            mappings.Caption = "Name";
            mappings.Id = "ResourceID";
            
            DataHelper.FillResources(resources, 5);
            this.schedulerStorage.Resources.DataSource = resources;
        }
        private static void InitPriorities(List<Priority> m_Priority)
        {
            m_Priority.Add(new Priority() { Type = PriorityStatus.High, DisplayName = "High" });
            m_Priority.Add(new Priority() { Type = PriorityStatus.Low, DisplayName = "Low" });
            m_Priority.Add(new Priority() { Type = PriorityStatus.Medium, DisplayName = "Medium" });
        }

        void InitAppointments()
        {
            AppointmentMappingInfo mappings = this.schedulerStorage.Appointments.Mappings;
            mappings.Start = "StartTime";
            mappings.End = "EndTime";
            mappings.Subject = "Subject";
            mappings.AllDay = "AllDay";
            mappings.Description = "Description";
            mappings.Label = "Label";
            mappings.Location = "Location";
            mappings.RecurrenceInfo = "RecurrenceInfo";
            mappings.ReminderInfo = "ReminderInfo";
            mappings.ResourceId = "OwnerId";
            mappings.Status = "Status";
            mappings.Type = "EventType";

            schedulerStorage.Appointments.CustomFieldMappings.Add(new AppointmentCustomFieldMapping("Priority", "PriorityId"));
            
            int count = schedulerStorage.Resources.Count;
            DataHelper.GenerateEvents(eventList, count, resources);
            this.schedulerStorage.Appointments.DataSource = eventList;
            InitPriorities(priorities);
        }


        Appointment appt = null;
        private void schedulerControl_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
             if (e.Menu.Id == SchedulerMenuItemId.AppointmentMenu){
               
                 SchedulerPopupMenu myMenu = new SchedulerPopupMenu();
                 myMenu.Caption = "Priority";
                 appt = schedulerControl.SelectedAppointments[0];
                 for (int i = 0; i < priorities.Count; i++)
                 {
                     SchedulerMenuCheckItem item = new SchedulerMenuCheckItem(priorities[i].DisplayName, false);
                     item.Tag = i;
                     if (Convert.ToInt32(appt.CustomFields["Priority"]) == i)
                         item.Checked = true;
                     item.CheckedChanged += new EventHandler(item_CheckedChanged);
                     myMenu.Items.Add(item);
                 }
               
                 e.Menu.Items.Add(myMenu);
                 
             }
            
        }

        void item_CheckedChanged(object sender, EventArgs e)
        {
            SchedulerMenuCheckItem item = sender as SchedulerMenuCheckItem;
            if (appt != null)
                appt.CustomFields["Priority"] = (int)item.Tag;
         
            
        }
    
        private void schedulerControl_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            DevExpress.XtraScheduler.SchedulerControl scheduler = ((DevExpress.XtraScheduler.SchedulerControl)(sender));
            DXApplication5.CustomAppointmentForm form = new DXApplication5.CustomAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm);
            form.AvailablePriorities = priorities;
            try
            {
                e.DialogResult = form.ShowDialog();
                e.Handled = true;
            }
            finally
            {
                form.Dispose();
            }

        }



    }


}