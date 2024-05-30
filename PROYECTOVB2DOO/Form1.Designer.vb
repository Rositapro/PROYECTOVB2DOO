<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        lblName = New Label()
        lboLastName = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        txtName = New TextBox()
        txtSalary = New TextBox()
        txtHoursWorked = New TextBox()
        txtAge = New TextBox()
        txtCurp = New TextBox()
        txtMaternal = New TextBox()
        txtPaternal = New TextBox()
        lvDatos = New ListView()
        txtContent = New TextBox()
        cmbTipoTrabajador = New ComboBox()
        btnSavePdf = New FontAwesome.Sharp.IconButton()
        btnSaveJson = New FontAwesome.Sharp.IconButton()
        btnSavetxt = New FontAwesome.Sharp.IconButton()
        btnSaveExcel = New FontAwesome.Sharp.IconButton()
        btnSaveXml = New FontAwesome.Sharp.IconButton()
        btnSaveWord = New FontAwesome.Sharp.IconButton()
        btnFillMatrix = New Button()
        btnShowMatrix = New Button()
        btnSaveNewTxt = New Button()
        btnOpenTxt = New Button()
        btnSave = New FontAwesome.Sharp.IconButton()
        btnCalculateSalary = New FontAwesome.Sharp.IconButton()
        btnClearTxt = New FontAwesome.Sharp.IconButton()
        btnClear = New FontAwesome.Sharp.IconButton()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(88, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 15)
        Label1.TabIndex = 0
        Label1.Text = "Welcome Employee"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(41, 90)
        lblName.Name = "lblName"
        lblName.Size = New Size(39, 15)
        lblName.TabIndex = 1
        lblName.Text = "Name"
        ' 
        ' lboLastName
        ' 
        lboLastName.AutoSize = True
        lboLastName.Location = New Point(24, 138)
        lboLastName.Name = "lboLastName"
        lboLastName.Size = New Size(58, 15)
        lboLastName.TabIndex = 2
        lboLastName.Text = "Lastname"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(194, 117)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 15)
        Label4.TabIndex = 3
        Label4.Text = "Maternal"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(88, 117)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 15)
        Label5.TabIndex = 4
        Label5.Text = "Paternal"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(41, 196)
        Label6.Name = "Label6"
        Label6.Size = New Size(28, 15)
        Label6.TabIndex = 5
        Label6.Text = "Age"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 225)
        Label7.Name = "Label7"
        Label7.Size = New Size(71, 15)
        Label7.TabIndex = 6
        Label7.Text = "Workstation"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(2, 266)
        Label8.Name = "Label8"
        Label8.Size = New Size(81, 15)
        Label8.TabIndex = 7
        Label8.Text = "Hours worked"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(41, 299)
        Label9.Name = "Label9"
        Label9.Size = New Size(38, 15)
        Label9.TabIndex = 8
        Label9.Text = "Salary"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(41, 167)
        Label10.Name = "Label10"
        Label10.Size = New Size(33, 15)
        Label10.TabIndex = 9
        Label10.Text = "Curp"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(88, 87)
        txtName.Name = "txtName"
        txtName.Size = New Size(100, 23)
        txtName.TabIndex = 10
        ' 
        ' txtSalary
        ' 
        txtSalary.Location = New Point(88, 296)
        txtSalary.Name = "txtSalary"
        txtSalary.ReadOnly = True
        txtSalary.Size = New Size(100, 23)
        txtSalary.TabIndex = 11
        ' 
        ' txtHoursWorked
        ' 
        txtHoursWorked.Location = New Point(88, 258)
        txtHoursWorked.Name = "txtHoursWorked"
        txtHoursWorked.Size = New Size(100, 23)
        txtHoursWorked.TabIndex = 12
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(88, 193)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(100, 23)
        txtAge.TabIndex = 14
        ' 
        ' txtCurp
        ' 
        txtCurp.Location = New Point(88, 164)
        txtCurp.Name = "txtCurp"
        txtCurp.Size = New Size(100, 23)
        txtCurp.TabIndex = 15
        ' 
        ' txtMaternal
        ' 
        txtMaternal.Location = New Point(194, 135)
        txtMaternal.Name = "txtMaternal"
        txtMaternal.Size = New Size(100, 23)
        txtMaternal.TabIndex = 16
        ' 
        ' txtPaternal
        ' 
        txtPaternal.Location = New Point(88, 135)
        txtPaternal.Name = "txtPaternal"
        txtPaternal.Size = New Size(100, 23)
        txtPaternal.TabIndex = 17
        ' 
        ' lvDatos
        ' 
        lvDatos.Location = New Point(421, 13)
        lvDatos.Name = "lvDatos"
        lvDatos.Size = New Size(309, 231)
        lvDatos.TabIndex = 18
        lvDatos.UseCompatibleStateImageBehavior = False
        ' 
        ' txtContent
        ' 
        txtContent.Location = New Point(736, 12)
        txtContent.Multiline = True
        txtContent.Name = "txtContent"
        txtContent.Size = New Size(339, 232)
        txtContent.TabIndex = 19
        ' 
        ' cmbTipoTrabajador
        ' 
        cmbTipoTrabajador.FormattingEnabled = True
        cmbTipoTrabajador.Location = New Point(88, 222)
        cmbTipoTrabajador.Name = "cmbTipoTrabajador"
        cmbTipoTrabajador.Size = New Size(121, 23)
        cmbTipoTrabajador.TabIndex = 20
        ' 
        ' btnSavePdf
        ' 
        btnSavePdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf
        btnSavePdf.IconColor = Color.Black
        btnSavePdf.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSavePdf.Location = New Point(421, 250)
        btnSavePdf.Name = "btnSavePdf"
        btnSavePdf.Size = New Size(47, 80)
        btnSavePdf.TabIndex = 0
        btnSavePdf.UseVisualStyleBackColor = True
        ' 
        ' btnSaveJson
        ' 
        btnSaveJson.IconChar = FontAwesome.Sharp.IconChar.FileText
        btnSaveJson.IconColor = Color.Black
        btnSaveJson.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSaveJson.Location = New Point(683, 250)
        btnSaveJson.Name = "btnSaveJson"
        btnSaveJson.Size = New Size(47, 80)
        btnSaveJson.TabIndex = 21
        btnSaveJson.Text = "JSON"
        btnSaveJson.TextAlign = ContentAlignment.BottomCenter
        btnSaveJson.UseVisualStyleBackColor = True
        ' 
        ' btnSavetxt
        ' 
        btnSavetxt.IconChar = FontAwesome.Sharp.IconChar.FileText
        btnSavetxt.IconColor = Color.Black
        btnSavetxt.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSavetxt.Location = New Point(633, 250)
        btnSavetxt.Name = "btnSavetxt"
        btnSavetxt.Size = New Size(47, 80)
        btnSavetxt.TabIndex = 22
        btnSavetxt.Text = "TXT"
        btnSavetxt.TextAlign = ContentAlignment.BottomCenter
        btnSavetxt.UseVisualStyleBackColor = True
        ' 
        ' btnSaveExcel
        ' 
        btnSaveExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel
        btnSaveExcel.IconColor = Color.Black
        btnSaveExcel.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSaveExcel.Location = New Point(580, 250)
        btnSaveExcel.Name = "btnSaveExcel"
        btnSaveExcel.Size = New Size(47, 80)
        btnSaveExcel.TabIndex = 23
        btnSaveExcel.Text = "XLSX"
        btnSaveExcel.TextAlign = ContentAlignment.BottomCenter
        btnSaveExcel.UseVisualStyleBackColor = True
        ' 
        ' btnSaveXml
        ' 
        btnSaveXml.IconChar = FontAwesome.Sharp.IconChar.FileText
        btnSaveXml.IconColor = Color.Black
        btnSaveXml.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSaveXml.Location = New Point(527, 250)
        btnSaveXml.Name = "btnSaveXml"
        btnSaveXml.Size = New Size(47, 80)
        btnSaveXml.TabIndex = 24
        btnSaveXml.Text = "XML"
        btnSaveXml.TextAlign = ContentAlignment.BottomCenter
        btnSaveXml.UseVisualStyleBackColor = True
        ' 
        ' btnSaveWord
        ' 
        btnSaveWord.IconChar = FontAwesome.Sharp.IconChar.FileWord
        btnSaveWord.IconColor = Color.Black
        btnSaveWord.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSaveWord.Location = New Point(474, 250)
        btnSaveWord.Name = "btnSaveWord"
        btnSaveWord.Size = New Size(47, 80)
        btnSaveWord.TabIndex = 25
        btnSaveWord.Text = "DOCS"
        btnSaveWord.TextAlign = ContentAlignment.BottomCenter
        btnSaveWord.UseVisualStyleBackColor = True
        ' 
        ' btnFillMatrix
        ' 
        btnFillMatrix.Location = New Point(12, 337)
        btnFillMatrix.Name = "btnFillMatrix"
        btnFillMatrix.Size = New Size(75, 23)
        btnFillMatrix.TabIndex = 26
        btnFillMatrix.Text = "Fill"
        btnFillMatrix.UseVisualStyleBackColor = True
        ' 
        ' btnShowMatrix
        ' 
        btnShowMatrix.Location = New Point(93, 337)
        btnShowMatrix.Name = "btnShowMatrix"
        btnShowMatrix.Size = New Size(75, 23)
        btnShowMatrix.TabIndex = 27
        btnShowMatrix.Text = "Show"
        btnShowMatrix.UseVisualStyleBackColor = True
        ' 
        ' btnSaveNewTxt
        ' 
        btnSaveNewTxt.Location = New Point(748, 286)
        btnSaveNewTxt.Name = "btnSaveNewTxt"
        btnSaveNewTxt.Size = New Size(75, 23)
        btnSaveNewTxt.TabIndex = 28
        btnSaveNewTxt.Text = "Save TXT"
        btnSaveNewTxt.UseVisualStyleBackColor = True
        ' 
        ' btnOpenTxt
        ' 
        btnOpenTxt.Location = New Point(748, 257)
        btnOpenTxt.Name = "btnOpenTxt"
        btnOpenTxt.Size = New Size(75, 23)
        btnOpenTxt.TabIndex = 29
        btnOpenTxt.Text = "Open TXT"
        btnOpenTxt.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.IconChar = FontAwesome.Sharp.IconChar.Save
        btnSave.IconColor = Color.Black
        btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSave.Location = New Point(256, 258)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(52, 61)
        btnSave.TabIndex = 30
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnCalculateSalary
        ' 
        btnCalculateSalary.IconChar = FontAwesome.Sharp.IconChar.MoneyBill
        btnCalculateSalary.IconColor = Color.Black
        btnCalculateSalary.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnCalculateSalary.Location = New Point(256, 217)
        btnCalculateSalary.Name = "btnCalculateSalary"
        btnCalculateSalary.Size = New Size(52, 38)
        btnCalculateSalary.TabIndex = 31
        btnCalculateSalary.UseVisualStyleBackColor = True
        ' 
        ' btnClearTxt
        ' 
        btnClearTxt.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft
        btnClearTxt.IconColor = Color.Black
        btnClearTxt.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnClearTxt.Location = New Point(861, 250)
        btnClearTxt.Name = "btnClearTxt"
        btnClearTxt.Size = New Size(52, 40)
        btnClearTxt.TabIndex = 33
        btnClearTxt.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft
        btnClear.IconColor = Color.Black
        btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnClear.Location = New Point(256, 171)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(52, 40)
        btnClear.TabIndex = 34
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1238, 450)
        Controls.Add(btnClear)
        Controls.Add(btnClearTxt)
        Controls.Add(btnCalculateSalary)
        Controls.Add(btnSave)
        Controls.Add(btnOpenTxt)
        Controls.Add(btnSaveNewTxt)
        Controls.Add(btnShowMatrix)
        Controls.Add(btnFillMatrix)
        Controls.Add(btnSaveWord)
        Controls.Add(btnSaveXml)
        Controls.Add(btnSaveExcel)
        Controls.Add(btnSavetxt)
        Controls.Add(btnSaveJson)
        Controls.Add(btnSavePdf)
        Controls.Add(cmbTipoTrabajador)
        Controls.Add(txtContent)
        Controls.Add(lvDatos)
        Controls.Add(txtPaternal)
        Controls.Add(txtMaternal)
        Controls.Add(txtCurp)
        Controls.Add(txtAge)
        Controls.Add(txtHoursWorked)
        Controls.Add(txtSalary)
        Controls.Add(txtName)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(lboLastName)
        Controls.Add(lblName)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lboLastName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents txtHoursWorked As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtCurp As TextBox
    Friend WithEvents txtMaternal As TextBox
    Friend WithEvents txtPaternal As TextBox
    Friend WithEvents lvDatos As ListView
    Friend WithEvents txtContent As TextBox
    Friend WithEvents cmbTipoTrabajador As ComboBox
    Friend WithEvents btnSavePdf As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSaveJson As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSavetxt As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSaveExcel As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSaveXml As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSaveWord As FontAwesome.Sharp.IconButton
    Friend WithEvents btnFillMatrix As Button
    Friend WithEvents btnShowMatrix As Button
    Friend WithEvents btnSaveNewTxt As Button
    Friend WithEvents btnOpenTxt As Button
    Friend WithEvents btnSave As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCalculateSalary As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClearTxt As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClear As FontAwesome.Sharp.IconButton

End Class
