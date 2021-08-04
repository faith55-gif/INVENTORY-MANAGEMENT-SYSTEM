Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblPassword.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblDepartment.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnPassword_Click(sender As Object, e As EventArgs) Handles btnPassword.Click
        If cmbUserName.Text = "Manager" And txtPassword.Text = "CapeNexis" And txtUsername.Text = "Manager" Then

            TabControl2.Show()
            TabControl1.Visible = False
            GroupBox1.Visible = False
        ElseIf cmbUserName.Text = "Cashier" And txtPassword.Text = "CapeNexis" And txtUsername.Text = "Cashier" Then
            TabControl2.Show()
            TabControl2.Visible = False
            GroupBox1.Visible = False

        ElseIf cmbUserName.Text = "Stock Controller" And txtPassword.Text = "CapeNexis" And txtUsername.Text = "Stock Controller" Then
            TabControl2.Show()
            TabControl1.Visible = False
            GroupBox1.Visible = False
        Else

            MsgBox("Please Enter Your Username And Password", MsgBoxStyle.Information, "Login")

        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result = MessageBox.Show("are you sure you want to exit?", "Clossing system", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        txtPassword.Clear()
        txtUserName.Clear()

    End Sub

    Private Sub CUSTOMER_DETAILSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CUSTOMER_DETAILSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CUSTOMER_DETAILSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SHOPDataSet)

    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SHOPDataSet.CUSTOMER_DETAILS' table. You can move, or remove it, as needed.
        Me.CUSTOMER_DETAILSTableAdapter.Fill(Me.SHOPDataSet.CUSTOMER_DETAILS)
        'TODO: This line of code loads data into the 'SHOPDataSet.PRODUCT_DETAILS' table. You can move, or remove it, as needed.


        cmbUserName.Items.Add("Manager")
        cmbUserName.Items.Add("Cashier")
        cmbUserName.Items.Add("Stock Controller")

        cmbSearch.Items.Add("CUSTOMER ID")
        cmbSearch.Items.Add("TITLE")
        cmbSearch.Items.Add("FIRSTNAME")
        cmbSearch.Items.Add("LASTNAME")
        cmbSearch.Items.Add("ADDRESS")
        cmbSearch.Items.Add("PHONE NUMBER")

    End Sub

    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click, Label1.Click
        Dim result = MessageBox.Show("are you sure you want to exit?", "Clossing system", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        CUSTOMER_DETAILSBindingSource.AddNew()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        CUSTOMER_DETAILSBindingSource.MoveNext()

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        CUSTOMER_DETAILSBindingSource.MovePrevious()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        CUSTOMER_DETAILSBindingSource.RemoveCurrent()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        On Error GoTo Feedback
        Me.Validate()
        Me.CUSTOMER_DETAILSBindingSource.EndEdit()
        Dim v = Me.CUSTOMER_DETAILSTableAdapter.Update(Me.SHOPDataSet)
Feedback:
        MsgBox("Check your Record", vbInformation)
        Exit Sub
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim stock As String
        stock = cmbSearch.Text

        Select Case stock

            Case "CUSTOMER ID"
                Me.CUSTOMER_DETAILSBindingSource.Filter = "CUSTOMER ID ='" & txtSearch.Text & "'"
            Case "TITLE"
                Me.CUSTOMER_DETAILSBindingSource.Filter = "TITLE='" & txtSearch.Text & "'"
            Case "FIRST NAME"
                Me.CUSTOMER_DETAILSBindingSource.Filter = "FIRSTNAME='" & txtSearch.Text & "'"
            Case "LAST NAME"
                Me.CUSTOMER_DETAILSBindingSource.Filter = "LASTNAME ='" & txtSearch.Text & "'"
            Case "ADRESS"
                Me.CUSTOMER_DETAILSBindingSource.Filter = "ADRESS ='" & txtSearch.Text & "'"
            Case "PHONE NUMBER"
                Me.CUSTOMER_DETAILSBindingSource.Filter = "PHONE NUMBER='" & txtSearch.Text & "'"
            Case Else
                Exit Select
        End Select


    End Sub
End Class







