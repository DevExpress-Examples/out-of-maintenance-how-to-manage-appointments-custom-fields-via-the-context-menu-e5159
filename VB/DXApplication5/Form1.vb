Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports DevExpress.XtraEditors
Imports DevExpress.XtraScheduler


Namespace DXApplication5
	Partial Public Class Form1
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
			schedulerControl.Start = System.DateTime.Now
			schedulerControl.GroupType = SchedulerGroupType.Resource
			schedulerControl.OptionsBehavior.SelectOnRightClick = True
			InitResources()
			InitAppointments()
		End Sub

		Private resources As New BindingList(Of CustomResource)()
		Private eventList As New BindingList(Of CustomAppointment)()
		Private priorities As New List(Of Priority)()
		Private Sub InitResources()
			Dim mappings As ResourceMappingInfo = Me.schedulerStorage.Resources.Mappings
			mappings.Caption = "Name"
			mappings.Id = "ResourceID"

			DataHelper.FillResources(resources, 5)
			Me.schedulerStorage.Resources.DataSource = resources
		End Sub
		Private Shared Sub InitPriorities(ByVal m_Priority As List(Of Priority))
			m_Priority.Add(New Priority() With {.Type = PriorityStatus.High, .DisplayName = "High"})
			m_Priority.Add(New Priority() With {.Type = PriorityStatus.Low, .DisplayName = "Low"})
			m_Priority.Add(New Priority() With {.Type = PriorityStatus.Medium, .DisplayName = "Medium"})
		End Sub

		Private Sub InitAppointments()
			Dim mappings As AppointmentMappingInfo = Me.schedulerStorage.Appointments.Mappings
			mappings.Start = "StartTime"
			mappings.End = "EndTime"
			mappings.Subject = "Subject"
			mappings.AllDay = "AllDay"
			mappings.Description = "Description"
			mappings.Label = "Label"
			mappings.Location = "Location"
			mappings.RecurrenceInfo = "RecurrenceInfo"
			mappings.ReminderInfo = "ReminderInfo"
			mappings.ResourceId = "OwnerId"
			mappings.Status = "Status"
			mappings.Type = "EventType"

			schedulerStorage.Appointments.CustomFieldMappings.Add(New AppointmentCustomFieldMapping("Priority", "PriorityId"))

			Dim count As Integer = schedulerStorage.Resources.Count
			DataHelper.GenerateEvents(eventList, count, resources)
			Me.schedulerStorage.Appointments.DataSource = eventList
			InitPriorities(priorities)
		End Sub


		Private appt As Appointment = Nothing
		Private Sub schedulerControl_PopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs) Handles schedulerControl.PopupMenuShowing
			 If e.Menu.Id = SchedulerMenuItemId.AppointmentMenu Then

				 Dim myMenu As New SchedulerPopupMenu()
				 myMenu.Caption = "Priority"
				 appt = schedulerControl.SelectedAppointments(0)
				 For i As Integer = 0 To priorities.Count - 1
					 Dim item As New SchedulerMenuCheckItem(priorities(i).DisplayName, False)
					 item.Tag = i
					 If Convert.ToInt32(appt.CustomFields("Priority")) = i Then
						 item.Checked = True
					 End If
					 AddHandler item.CheckedChanged, AddressOf item_CheckedChanged
					 myMenu.Items.Add(item)
				 Next i

				 e.Menu.Items.Add(myMenu)

			 End If

		End Sub

		Private Sub item_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim item As SchedulerMenuCheckItem = TryCast(sender, SchedulerMenuCheckItem)
			If appt IsNot Nothing Then
				appt.CustomFields("Priority") = CInt(Fix(item.Tag))
			End If


		End Sub

		Private Sub schedulerControl_EditAppointmentFormShowing(ByVal sender As Object, ByVal e As AppointmentFormEventArgs) Handles schedulerControl.EditAppointmentFormShowing
			Dim scheduler As DevExpress.XtraScheduler.SchedulerControl = (CType(sender, DevExpress.XtraScheduler.SchedulerControl))
			Dim form As New DXApplication5.CustomAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm)
			form.AvailablePriorities = priorities
			Try
				e.DialogResult = form.ShowDialog()
				e.Handled = True
			Finally
				form.Dispose()
			End Try

		End Sub



	End Class


End Namespace