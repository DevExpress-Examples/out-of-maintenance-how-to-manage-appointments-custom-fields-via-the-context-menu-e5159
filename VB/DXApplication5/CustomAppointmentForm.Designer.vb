Imports Microsoft.VisualBasic
Imports System
Namespace DXApplication5
	Partial Public Class CustomAppointmentForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.icbPriority = New DevExpress.XtraEditors.ImageComboBoxEdit()
			CType(Me.chkAllDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtStartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtEndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtStartTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtEndTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtLabel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtShowTimeAs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbSubject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtResource.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtResources.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtResources.ResourcesCheckedListBoxControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkReminder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbReminder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			Me.progressPanel.SuspendLayout()
			CType(Me.tbProgress, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbProgress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbPriority.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' lblLabel
			' 
			Me.lblLabel.Appearance.BackColor = System.Drawing.Color.Transparent
			' 
			' chkAllDay
			' 
			' 
			' btnOk
			' 
			Me.btnOk.Location = New System.Drawing.Point(16, 549)
			' 
			' btnCancel
			' 
			Me.btnCancel.Location = New System.Drawing.Point(104, 549)
			' 
			' btnDelete
			' 
			Me.btnDelete.Location = New System.Drawing.Point(192, 549)
			' 
			' btnRecurrence
			' 
			Me.btnRecurrence.Location = New System.Drawing.Point(280, 549)
			' 
			' edtStartDate
			' 
			Me.edtStartDate.EditValue = New System.DateTime(2005, 3, 31, 0, 0, 0, 0)
			Me.edtStartDate.Size = New System.Drawing.Size(247, 20)
			' 
			' edtEndDate
			' 
			Me.edtEndDate.EditValue = New System.DateTime(2005, 3, 31, 0, 0, 0, 0)
			Me.edtEndDate.Size = New System.Drawing.Size(247, 20)
			' 
			' edtStartTime
			' 
			Me.edtStartTime.EditValue = New System.DateTime(2005, 3, 31, 0, 0, 0, 0)
			Me.edtStartTime.Location = New System.Drawing.Point(351, 79)
			' 
			' edtEndTime
			' 
			Me.edtEndTime.EditValue = New System.DateTime(2005, 3, 31, 0, 0, 0, 0)
			Me.edtEndTime.Location = New System.Drawing.Point(351, 103)
			' 
			' edtLabel
			' 
			' 
			' edtShowTimeAs
			' 
			Me.edtShowTimeAs.Size = New System.Drawing.Size(343, 20)
			' 
			' tbSubject
			' 
			Me.tbSubject.Size = New System.Drawing.Size(543, 20)
			' 
			' edtResource
			' 
			' 
			' edtResources
			' 
			' 
			' 
			' 
			Me.edtResources.ResourcesCheckedListBoxControl.CheckOnClick = True
			Me.edtResources.ResourcesCheckedListBoxControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.edtResources.ResourcesCheckedListBoxControl.Location = New System.Drawing.Point(0, 0)
			Me.edtResources.ResourcesCheckedListBoxControl.Name = ""
			Me.edtResources.ResourcesCheckedListBoxControl.Size = New System.Drawing.Size(200, 100)
			Me.edtResources.ResourcesCheckedListBoxControl.TabIndex = 0
			' 
			' chkReminder
			' 
			' 
			' tbDescription
			' 
			Me.tbDescription.Location = New System.Drawing.Point(16, 259)
			Me.tbDescription.Size = New System.Drawing.Size(623, 281)
			' 
			' cbReminder
			' 
			' 
			' tbLocation
			' 
			Me.tbLocation.Size = New System.Drawing.Size(343, 20)
			' 
			' panel1
			' 
			Me.panel1.Location = New System.Drawing.Point(452, 41)
			' 
			' progressPanel
			' 
			Me.progressPanel.Size = New System.Drawing.Size(623, 30)
			' 
			' tbProgress
			' 
			Me.tbProgress.Properties.LabelAppearance.Options.UseTextOptions = True
			Me.tbProgress.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.tbProgress.Size = New System.Drawing.Size(514, 27)
			' 
			' lblPercentComplete
			' 
			Me.lblPercentComplete.Appearance.BackColor = System.Drawing.Color.Transparent
			' 
			' lblPercentCompleteValue
			' 
			Me.lblPercentCompleteValue.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.lblPercentCompleteValue.Location = New System.Drawing.Point(605, 10)
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(16, 202)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(38, 13)
			Me.labelControl1.TabIndex = 30
			Me.labelControl1.Text = "Priority:"
			' 
			' icbPriority
			' 
			Me.icbPriority.Location = New System.Drawing.Point(96, 203)
			Me.icbPriority.Name = "icbPriority"
			Me.icbPriority.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbPriority.Size = New System.Drawing.Size(343, 20)
			Me.icbPriority.TabIndex = 31
			' 
			' CustomAppointmentForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.ClientSize = New System.Drawing.Size(655, 583)
			Me.Controls.Add(Me.icbPriority)
			Me.Controls.Add(Me.labelControl1)
			Me.Name = "CustomAppointmentForm"
			Me.Controls.SetChildIndex(Me.edtShowTimeAs, 0)
			Me.Controls.SetChildIndex(Me.edtEndTime, 0)
			Me.Controls.SetChildIndex(Me.edtEndDate, 0)
			Me.Controls.SetChildIndex(Me.btnRecurrence, 0)
			Me.Controls.SetChildIndex(Me.btnDelete, 0)
			Me.Controls.SetChildIndex(Me.btnCancel, 0)
			Me.Controls.SetChildIndex(Me.lblShowTimeAs, 0)
			Me.Controls.SetChildIndex(Me.lblEndTime, 0)
			Me.Controls.SetChildIndex(Me.tbLocation, 0)
			Me.Controls.SetChildIndex(Me.lblSubject, 0)
			Me.Controls.SetChildIndex(Me.lblLocation, 0)
			Me.Controls.SetChildIndex(Me.tbSubject, 0)
			Me.Controls.SetChildIndex(Me.lblStartTime, 0)
			Me.Controls.SetChildIndex(Me.btnOk, 0)
			Me.Controls.SetChildIndex(Me.edtStartDate, 0)
			Me.Controls.SetChildIndex(Me.edtStartTime, 0)
			Me.Controls.SetChildIndex(Me.panel1, 0)
			Me.Controls.SetChildIndex(Me.progressPanel, 0)
			Me.Controls.SetChildIndex(Me.tbDescription, 0)
			Me.Controls.SetChildIndex(Me.labelControl1, 0)
			Me.Controls.SetChildIndex(Me.icbPriority, 0)
			CType(Me.chkAllDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtStartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtEndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtStartTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtEndTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtLabel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtShowTimeAs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbSubject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtResource.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtResources.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtResources.ResourcesCheckedListBoxControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkReminder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbReminder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			Me.progressPanel.ResumeLayout(False)
			Me.progressPanel.PerformLayout()
			CType(Me.tbProgress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbProgress, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbPriority.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private icbPriority As DevExpress.XtraEditors.ImageComboBoxEdit
	End Class
End Namespace
