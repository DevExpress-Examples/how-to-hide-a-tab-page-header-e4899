﻿Imports Microsoft.VisualBasic
Imports DevExpress.XtraTab.Registrator
Imports DevExpress.XtraTab.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Example_HidePageHeader
	Public Class MyRegistrator
		Inherits SkinViewInfoRegistrator
		Public Sub New()
		End Sub
		Public Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyStyle"
			End Get
		End Property
		Public Overrides Function CreateHeaderViewInfo(ByVal viewInfo As BaseTabControlViewInfo) As BaseTabHeaderViewInfo
			Return New MySkinTabHeaderViewInfo(viewInfo)
		End Function
		Public Overrides Function CreatePainter(ByVal tabControl As DevExpress.XtraTab.IXtraTab) As DevExpress.XtraTab.Drawing.BaseTabPainter
			Return New MySkinTabPainter(tabControl)
		End Function
	End Class
End Namespace
