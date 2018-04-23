#region Note
/*
{**************************************************************************************************************}
{  This file is automatically created when you open the Scheduler Control smart tag                            }
{  *and click Create Customizable Appointment Dialog.                                                          }
{  It contains a a descendant of the default appointment editing form created by visual inheritance.           }
{  In Visual Studio Designer add an editor that is required to edit your appointment custom field.             }
{  Modify the LoadFormData method to get data from a custom field and fill your editor with data.              }
{  Modify the SaveFormData method to retrieve data from the editor and set the appointment custom field value. }
{  The code that displays this form is automatically inserted                                                  }
{  *in the EditAppointmentFormShowing event handler of the SchedulerControl.                                   }
{                                                                                                              }
{**************************************************************************************************************}
*/
#endregion Note

using System;
using System.Collections.Generic;

namespace DXApplication5
{
    public partial class CustomAppointmentForm : DevExpress.XtraScheduler.UI.AppointmentForm
    {
        private List<Priority> _AvailablePriorities;
        private int priorityIndex = -1;

        public List<Priority> AvailablePriorities
        {
            get { return _AvailablePriorities; }
            set
            {
                _AvailablePriorities = value;
            }
        }
       
        public CustomAppointmentForm()
        {
            InitializeComponent();
        }
        public CustomAppointmentForm(DevExpress.XtraScheduler.SchedulerControl control, DevExpress.XtraScheduler.Appointment apt)
            : base(control, apt)
        {
            InitializeComponent();
        }
        public CustomAppointmentForm(DevExpress.XtraScheduler.SchedulerControl control, DevExpress.XtraScheduler.Appointment apt, bool openRecurrenceForm)
            : base(control, apt, openRecurrenceForm)
        {
            InitializeComponent();
        }

        private void FillComboBox(DevExpress.XtraScheduler.Appointment appointment)
        {
            for (int i = 0; i < AvailablePriorities.Count; i++)
            {
                icbPriority.Properties.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(AvailablePriorities[i].DisplayName, AvailablePriorities[i].Type));
            }
        }
        /// <summary>
        /// Add your code to obtain a custom field value and fill the editor with data.
        /// </summary>
        public override void LoadFormData(DevExpress.XtraScheduler.Appointment appointment)
        {
            FillComboBox(appointment);
            if (appointment.CustomFields["Priority"] == null)
                icbPriority.Text = "";
            else
            {
                priorityIndex = Convert.ToInt32(appointment.CustomFields["Priority"]);
                if (AvailablePriorities.Count > 0 && priorityIndex < AvailablePriorities.Count)
                    icbPriority.EditValue = icbPriority.Properties.Items[priorityIndex].Value;
            }
            base.LoadFormData(appointment);
        }
        /// <summary>
        /// Add your code to retrieve a value from the editor and set the custom appointment field.
        /// </summary>
        public override bool SaveFormData(DevExpress.XtraScheduler.Appointment appointment)
        {
            appointment.CustomFields["Priority"] = icbPriority.SelectedIndex;
            return base.SaveFormData(appointment);
        }
        /// <summary>
        /// Add your code to notify that any custom field is changed. Return true if a custom field is changed, otherwise false.
        /// </summary>
        public override bool IsAppointmentChanged(DevExpress.XtraScheduler.Appointment appointment)
        {
            if (priorityIndex == Convert.ToInt32(appointment.CustomFields["Priority"]))
                return false;
            else
                return true;
        }
    }
}
