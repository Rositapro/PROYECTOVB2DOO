Imports DocumentFormat.OpenXml.Drawing.Diagrams
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Friend Class Persona
        ' Propiedades
        Public Property Name As String
        Public Property LastNameP As String
        Public Property LastNameM As String
        Public Property CURP As String
        Public Property Age As Integer
        Public Property HoursWorked As Integer

        ' Constructor sin parámetros
        Public Sub New()
            Name = ""
            LastNameP = ""
            LastNameM = ""
            CURP = ""
            Age = 0
            HoursWorked = 0
        End Sub

        ' Constructor con parámetros
        Public Sub New(name As String, lastnamep As String, lastnamem As String, curp As String, age As Integer, hoursworked As Integer)
            Me.New()
            Me.Name = name
            Me.LastNameP = lastnamep
            Me.LastNameM = lastnamem
            Me.CURP = curp
            Me.Age = age
            Me.HoursWorked = hoursworked
        End Sub

        ' Método estático
        Public Shared Sub ShowMessage()
            MessageBox.Show("Good morning dear employee.")
        End Sub

        Public Overridable Function Saludate() As String
            Return "Hello " & Name
        End Function
    End Class


