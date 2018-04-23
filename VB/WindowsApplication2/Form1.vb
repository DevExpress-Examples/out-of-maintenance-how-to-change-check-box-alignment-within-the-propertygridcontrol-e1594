Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Repository

Namespace WindowsApplication2
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim edit As New RepositoryItemCheckEdit()
			edit.Caption = ""
			edit.GlyphAlignment = DevExpress.Utils.HorzAlignment.Near
			propertyGridControl1.RepositoryItems.Add(edit)
			propertyGridControl1.DefaultEditors.Add(GetType(Boolean), edit)
			propertyGridControl1.SelectedObject = New [MyClass]()
		End Sub
	End Class

	Friend Class [MyClass]
		Private myVar As Boolean

		Public Property MyProperty() As Boolean
			Get
				Return myVar
			End Get
			Set(ByVal value As Boolean)
				myVar = value
			End Set
		End Property

	End Class
End Namespace