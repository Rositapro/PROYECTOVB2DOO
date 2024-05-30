Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Friend Class Empleado
        Inherits Persona

        ' Propiedad de solo escritura
        Private _Workstation As String
        Public Property Workstation() As String
            Get
                Return _Workstation
            End Get
            Set(ByVal value As String)
                _Workstation = value
            End Set
        End Property

        ' Propiedad de lectura
        Public ReadOnly Property CalculatedSalary() As Double

        Public Property Salary() As String

        ' Constructor sin parámetros
        Public Sub New()
            MyBase.New()
            Workstation = ""
        End Sub

        ' Constructor con parámetros
        Public Sub New(name As String, lastnamep As String, lastnamem As String, curp As String, age As Integer, hoursworked As Integer, workstation As String)
            MyBase.New(name, lastnamep, lastnamem, curp, age, hoursworked)
            Me.Workstation = workstation
            Me.CalculatedSalary = CalculateSalary(workstation, hoursworked)
        End Sub

        ' Método que recibe y regresa
        Private Function CalculateSalary(workstation As String, hoursWorked As Integer) As Double
            ' Definir las tarifas por hora para cada tipo de trabajo
            Dim engineerRate As Double = 250
            Dim workerRate As Double = 100

            ' Calcular el salario en función del tipo de trabajo
            Dim salary As Double = 0
            If workstation = "Engineer" Then
                salary = engineerRate * hoursWorked
            ElseIf workstation = "Worker" Then
                salary = workerRate * hoursWorked
            End If
            Return salary
        End Function

        ' Polimorfismo: Sobrescribir el método Saludar
        ' no recibe parámetros pero regresa algo
        Public Overrides Function Saludate() As String
            Return "Hello " & Name & ", don " & Workstation
        End Function
    End Class


