Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports System.Xml
Imports DocumentFormat.OpenXml
Imports DocumentFormat.OpenXml.Packaging
Imports Word = DocumentFormat.OpenXml.Wordprocessing
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports DocumentFormat.OpenXml.Spreadsheet
Imports Newtonsoft.Json

Public Class Form1
    Private matrixEmployees(,) As String

    Public Sub New()
        InitializeComponent()
        ConfigureComboBox()
        ConfigureListView()
        AttachKeyPressEvents()
        Persona.ShowMessage()
        DateandTime()

        matrixEmployees = New String(0, 0) {}
    End Sub

    Private Sub ConfigureComboBox()
        cmbTipoTrabajador.Items.Add("Engineer")
        cmbTipoTrabajador.Items.Add("Worker")
        cmbTipoTrabajador.SelectedIndex = 0
    End Sub

    Private Sub ConfigureListView()
        lvDatos.View = View.Details
        lvDatos.Columns.Add("Name", 100)
        lvDatos.Columns.Add("Paternal last name", 100)
        lvDatos.Columns.Add("Maternal last name", 100)
        lvDatos.Columns.Add("CURP", 100)
        lvDatos.Columns.Add("Age", 50)
        lvDatos.Columns.Add("Workstation", 100)
        lvDatos.Columns.Add("Hours Worked", 100)
        lvDatos.Columns.Add("Salary", 100)
    End Sub

    Private Sub AttachKeyPressEvents()
        AddHandler txtName.KeyPress, AddressOf TextBox_KeyPress
        AddHandler txtPaternal.KeyPress, AddressOf TextBox_KeyPress
        AddHandler txtMaternal.KeyPress, AddressOf TextBox_KeyPress
        AddHandler txtAge.KeyPress, AddressOf NumericTextBox_KeyPress
        AddHandler txtHoursWorked.KeyPress, AddressOf NumericTextBox_KeyPress
    End Sub

    ' Método que recibe parámetros pero no regresa nada
    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) AndAlso e.KeyChar <> ChrW(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub NumericTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Function ValidateCURP(curp As String) As Boolean
        Dim pattern As String = "^[A-Z]{4}\d{6}[HM][A-Z]{6}\d{1}$"
        Dim regex As New Regex(pattern)
        Return regex.IsMatch(curp)
    End Function

    Private Function ValidateFields() As Boolean
        If String.IsNullOrWhiteSpace(txtName.Text) OrElse
           String.IsNullOrWhiteSpace(txtPaternal.Text) OrElse
           String.IsNullOrWhiteSpace(txtMaternal.Text) OrElse
           String.IsNullOrWhiteSpace(txtCurp.Text) OrElse
           String.IsNullOrWhiteSpace(txtAge.Text) OrElse
           String.IsNullOrWhiteSpace(txtHoursWorked.Text) OrElse
           String.IsNullOrWhiteSpace(txtSalary.Text) Then
            Return False
        End If
        Return True
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not ValidateFields() Then
            MessageBox.Show("All fields must be completed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not ValidateCURP(txtCurp.Text) Then
            MessageBox.Show("The entered CURP is not valid. Please verify and try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim empleado As New Empleado(txtName.Text, txtPaternal.Text, txtMaternal.Text, txtCurp.Text, Integer.Parse(txtAge.Text), Integer.Parse(txtHoursWorked.Text), cmbTipoTrabajador.SelectedItem.ToString())
        empleado.Salary = txtSalary.Text

        MessageBox.Show(empleado.Saludate())

        Dim datos(8) As String
        datos(0) = txtName.Text
        datos(1) = txtPaternal.Text
        datos(2) = txtMaternal.Text
        datos(3) = txtCurp.Text
        datos(4) = txtAge.Text
        datos(5) = cmbTipoTrabajador.SelectedItem.ToString()
        datos(6) = txtHoursWorked.Text
        datos(7) = txtSalary.Text

        Dim item As New ListViewItem(datos(0))
        For i As Integer = 1 To datos.Length - 1
            item.SubItems.Add(datos(i))
        Next

        lvDatos.Items.Add(item)

        ClearTextBoxesAndComboBox()
    End Sub

    Private Sub btnCalculateSalary_Click(sender As Object, e As EventArgs) Handles btnCalculateSalary.Click
        Try
            Dim hoursWorked As Integer = Convert.ToInt32(txtHoursWorked.Text)
            Dim workstation As String = cmbTipoTrabajador.SelectedItem.ToString()

            ' Crear un objeto Empleado con los datos actuales
            Dim empleado As New Empleado(txtName.Text, txtPaternal.Text, txtMaternal.Text, txtCurp.Text, Integer.Parse(txtAge.Text), hoursWorked, workstation)

            ' Obtener el salario calculado del objeto Empleado
            Dim salary As Double = empleado.CalculatedSalary

            ' Mostrar el salario en el cuadro de texto
            txtSalary.Text = salary.ToString("F2")
        Catch ex As FormatException
            MessageBox.Show("Error: Enter valid number of hours worked.")
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Sub

    Private Sub ClearTextBoxesAndComboBox()
        txtName.Clear()
        txtPaternal.Clear()
        txtMaternal.Clear()
        txtCurp.Clear()
        txtAge.Clear()
        txtHoursWorked.Clear()
        txtSalary.Clear()
        cmbTipoTrabajador.SelectedIndex = 0
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Clear()
        txtPaternal.Clear()
        txtMaternal.Clear()
        txtCurp.Clear()
        txtAge.Clear()
        txtHoursWorked.Clear()
        txtSalary.Clear()
        cmbTipoTrabajador.SelectedIndex = 0
    End Sub

    Private Sub btnFillMatrix_Click(sender As Object, e As EventArgs) Handles btnFillMatrix.Click
        FillMatrixWithData()
        MessageBox.Show("Data loaded in the matrix.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnShowMatrix_Click(sender As Object, e As EventArgs) Handles btnShowMatrix.Click
        ShowDataMatriz()
    End Sub

    Private Sub FillMatrixWithData()
        Dim filas As Integer = lvDatos.Items.Count
        Dim columnas As Integer = lvDatos.Columns.Count
        matrixEmployees = New String(filas - 1, columnas - 1) {}

        For i As Integer = 0 To filas - 1
            For j As Integer = 0 To columnas - 1
                matrixEmployees(i, j) = lvDatos.Items(i).SubItems(j).Text
            Next
        Next
    End Sub

    Private Sub ShowDataMatriz()
        If matrixEmployees Is Nothing Then
            MessageBox.Show("No data in the matrix.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim datos As String = ""
        For i As Integer = 0 To matrixEmployees.GetLength(0) - 1
            For j As Integer = 0 To matrixEmployees.GetLength(1) - 1
                datos += matrixEmployees(i, j) & " "
            Next
            datos += Environment.NewLine
        Next

        MessageBox.Show(datos, "Matrix Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnSaveWord_Click(sender As Object, e As EventArgs) Handles btnSaveWord.Click
        ' Guardar los datos en un archivo de Word
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Archivo de Word|*.docx"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = saveFileDialog.FileName
            Using wordDoc As WordprocessingDocument = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document)
                Dim mainPart As MainDocumentPart = wordDoc.AddMainDocumentPart()
                mainPart.Document = New Word.Document()
                Dim body As New Word.Body()

                Dim table As New Word.Table()

                ' Crear una fila para los encabezados
                Dim headerRow As New Word.TableRow()
                For Each column As ColumnHeader In lvDatos.Columns
                    Dim headerCell As New Word.TableCell(New Word.Paragraph(New Word.Run(New Word.Text(column.Text))))
                    headerRow.Append(headerCell)
                Next
                table.Append(headerRow)

                ' Crear una fila para cada elemento en el ListView
                For Each item As ListViewItem In lvDatos.Items
                    Dim dataRow As New Word.TableRow()
                    For Each subItem As ListViewItem.ListViewSubItem In item.SubItems
                        Dim dataCell As New Word.TableCell(New Word.Paragraph(New Word.Run(New Word.Text(subItem.Text))))
                        dataRow.Append(dataCell)
                    Next
                    table.Append(dataRow)
                Next

                ' Agregar las propiedades de la tabla
                table.AppendChild(New Word.TableProperties(
                    New Word.TableBorders(
                        New Word.TopBorder With {.Val = New EnumValue(Of Word.BorderValues)(Word.BorderValues.Single), .Size = 6},
                        New Word.BottomBorder With {.Val = New EnumValue(Of Word.BorderValues)(Word.BorderValues.Single), .Size = 6},
                        New Word.LeftBorder With {.Val = New EnumValue(Of Word.BorderValues)(Word.BorderValues.Single), .Size = 6},
                        New Word.RightBorder With {.Val = New EnumValue(Of Word.BorderValues)(Word.BorderValues.Single), .Size = 6},
                        New Word.InsideHorizontalBorder With {.Val = New EnumValue(Of Word.BorderValues)(Word.BorderValues.Single), .Size = 6},
                        New Word.InsideVerticalBorder With {.Val = New EnumValue(Of Word.BorderValues)(Word.BorderValues.Single), .Size = 6}
                    )
                ))

                body.Append(table)
                mainPart.Document.Append(body)
                mainPart.Document.Save()
            End Using

            MessageBox.Show("File saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSaveXml_Click(sender As Object, e As EventArgs) Handles btnSaveXml.Click
        ' Guardar los datos en un archivo XML
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Archivo XML|*.xml"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = saveFileDialog.FileName
            Dim xmlDoc As New XmlDocument()
            Dim root As XmlElement = xmlDoc.CreateElement("Empleados")
            xmlDoc.AppendChild(root)

            For Each item As ListViewItem In lvDatos.Items
                Dim empleadoElement As XmlElement = xmlDoc.CreateElement("Empleado")

                For i As Integer = 0 To lvDatos.Columns.Count - 1
                    ' Reemplazar espacios en blanco y otros caracteres no permitidos en los nombres de las columnas
                    Dim columnName As String = lvDatos.Columns(i).Text.Replace(" ", "_")

                    Dim element As XmlElement = xmlDoc.CreateElement(columnName)
                    element.InnerText = item.SubItems(i).Text
                    empleadoElement.AppendChild(element)
                Next

                root.AppendChild(empleadoElement)
            Next

            xmlDoc.Save(filePath)
            MessageBox.Show("Data successfully saved to XML file.", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSaveExcel_Click(sender As Object, e As EventArgs) Handles btnSaveExcel.Click
        ' Obtener la ruta de destino para guardar el archivo Excel
        Dim filePath As String = GetFilePath("Archivo de Excel|*.xlsx")
        If filePath IsNot Nothing Then
            Try
                ' Crear un nuevo archivo Excel
                Using spreadsheetDoc As SpreadsheetDocument = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook)
                    ' Agregar el WorkbookPart al documento
                    Dim workbookPart As WorkbookPart = spreadsheetDoc.AddWorkbookPart()
                    workbookPart.Workbook = New Workbook()

                    ' Agregar el WorksheetPart al WorkbookPart
                    Dim worksheetPart As WorksheetPart = workbookPart.AddNewPart(Of WorksheetPart)()
                    worksheetPart.Worksheet = New Worksheet(New SheetData())

                    ' Agregar una hoja de cálculo al libro de trabajo
                    Dim sheets As Sheets = spreadsheetDoc.WorkbookPart.Workbook.AppendChild(New Sheets())
                    Dim sheet As Sheet = New Sheet() With {.Id = spreadsheetDoc.WorkbookPart.GetIdOfPart(worksheetPart), .SheetId = 1, .Name = "Sheet1"}
                    sheets.Append(sheet)

                    ' Obtener los datos del ListView y escribirlos en el archivo Excel
                    Dim sheetData As SheetData = worksheetPart.Worksheet.GetFirstChild(Of SheetData)()

                    ' Escribir los encabezados en la primera fila
                    Dim headerRow As New Row()
                    For Each column As ColumnHeader In lvDatos.Columns
                        Dim cell As New Cell()
                        cell.DataType = CellValues.String
                        cell.CellValue = New CellValue(column.Text)
                        headerRow.AppendChild(cell)
                    Next
                    sheetData.AppendChild(headerRow)

                    ' Escribir los datos en el resto de filas
                    For Each item As ListViewItem In lvDatos.Items
                        Dim row As New Row()
                        For Each subItem As ListViewItem.ListViewSubItem In item.SubItems
                            Dim cell As New Cell()
                            cell.DataType = CellValues.String
                            cell.CellValue = New CellValue(subItem.Text)
                            row.AppendChild(cell)
                        Next
                        sheetData.AppendChild(row)
                    Next
                End Using

                MessageBox.Show("Data successfully saved to EXCEL file.", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show($"Error saving Excel file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Function GetFilePath(filter As String) As String
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = filter
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Return saveFileDialog.FileName
        End If
        Return Nothing
    End Function

    Private Sub btnSavetxt_Click(sender As Object, e As EventArgs) Handles btnSavetxt.Click
        ' Guardar los datos en un archivo de texto
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Archivo de Texto|*.txt"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = saveFileDialog.FileName
            Using writer As New StreamWriter(filePath)
                ' Escribir encabezados de columnas
                For Each column As ColumnHeader In lvDatos.Columns
                    writer.Write(column.Text)
                    writer.Write(", ")
                Next
                writer.WriteLine() ' Salto de línea después de los encabezados

                ' Escribir datos de ListView
                For Each item As ListViewItem In lvDatos.Items
                    For i As Integer = 0 To item.SubItems.Count - 1
                        writer.Write(item.SubItems(i).Text)
                        If i < item.SubItems.Count - 1 Then
                            writer.Write(", ")
                        End If
                    Next
                    writer.WriteLine()
                Next
            End Using

            ' Mostrar mensaje de confirmación
            MessageBox.Show("Data successfully saved to TXT file.", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSaveJson_Click(sender As Object, e As EventArgs) Handles btnSaveJson.Click
        ' Obtener la ruta de destino para guardar el archivo JSON
        Dim filePath As String = GetFilePath("Archivo JSON|*.json")
        If filePath IsNot Nothing Then
            Try
                ' Crear una lista para almacenar los datos del ListView
                Dim dataList As New List(Of Dictionary(Of String, String))()

                ' Recorrer los elementos del ListView y agregarlos a la lista
                For Each item As ListViewItem In lvDatos.Items
                    Dim dataItem As New Dictionary(Of String, String)()
                    For Each subItem As ListViewItem.ListViewSubItem In item.SubItems
                        dataItem(lvDatos.Columns(item.SubItems.IndexOf(subItem)).Text) = subItem.Text
                    Next
                    dataList.Add(dataItem)
                Next

                ' Serializar la lista a formato JSON y guardarla en el archivo
                Dim jsonData As String = JsonConvert.SerializeObject(dataList)
                File.WriteAllText(filePath, jsonData)

                MessageBox.Show("Data successfully saved to JSON file.", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show($"Error saving JSON file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    Private Sub btnSavePdf_Click(sender As Object, e As EventArgs) Handles btnSavePdf.Click
        ' Guardar los datos en un archivo PDF
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Archivo PDF|*.pdf"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = saveFileDialog.FileName
            Using stream As New FileStream(filePath, FileMode.Create)
                Dim pdfDoc As New Document(PageSize.A4)
                Dim writer As PdfWriter = PdfWriter.GetInstance(pdfDoc, stream)
                pdfDoc.Open()

                ' Crear una tabla PDF
                Dim table As New PdfPTable(lvDatos.Columns.Count)
                table.WidthPercentage = 100

                ' Añadir las cabeceras de la tabla
                For Each column As ColumnHeader
            In lvDatos.Columns
                    Dim cell As New PdfPCell(New Phrase(column.Text))
                    cell.BackgroundColor = BaseColor.LIGHT_GRAY
                    table.AddCell(cell)
                Next

                ' Añadir las filas de datos
                For Each item As ListViewItem In lvDatos.Items
                    For Each subItem As ListViewItem.ListViewSubItem In item.SubItems
                        table.AddCell(New Phrase(subItem.Text))
                    Next
                Next

                pdfDoc.Add(table)
                pdfDoc.Close()

                ' Mostrar mensaje de confirmación
                MessageBox.Show("Data successfully saved to PDF file.", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        End If
    End Sub

    Private Sub btnOpenTxt_Click(sender As Object, e As EventArgs) Handles btnOpenTxt.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName
            Try
                Using reader As New StreamReader(filePath)
                    ' Limpiar el contenido existente del TextBox
                    txtContent.Clear()

                    ' Leer y mostrar cada línea del archivo en el TextBox
                    Dim line As String
                    While (InlineAssignHelper(line, reader.ReadLine())) IsNot Nothing
                        txtContent.AppendText(line & Environment.NewLine)
                    End While
                End Using
                MessageBox.Show("Text file read correctly.", "Successful Reading", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show($"Error reading file: {ex.Message}", "Reading Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
        target = value
        Return value
    End Function


    Private Sub btnSaveNewTxt_Click(sender As Object, e As EventArgs) Handles btnSaveNewTxt.Click
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = saveFileDialog.FileName
            If File.Exists(filePath) Then
                Dim result As DialogResult = MessageBox.Show("The file already exists, do you want to overwrite it?", "Existing File", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = DialogResult.No Then
                    Return ' Salir si el usuario no desea sobrescribir el archivo
                End If
            End If

            Try
                Using writer As New StreamWriter(filePath)
                    writer.Write(txtContent.Text)
                End Using
                MessageBox.Show("Text file saved correctly.", "Successful Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show($"Error saving the file: {ex.Message}", "Saving Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnClearTxt_Click(sender As Object, e As EventArgs) Handles btnClearTxt.Click
        txtContent.Clear()
    End Sub


    Private Sub DateandTime()
        MessageBox.Show("The date and time is " & DateTime.Now.ToString(), "Date and time", MessageBoxButtons.OK, MessageBoxIcon.None)
    End Sub
End Class
