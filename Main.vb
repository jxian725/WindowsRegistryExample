Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        'ButtonCreateChild.Enabled = False
    End Sub

    Dim NewName As String
    Private Sub TextBoxRName_Click(sender As Object, e As EventArgs) Handles TextBoxRName.Click
        TextBoxRName.Text = ""
    End Sub

    Private Sub ButtonCreate_Click(sender As Object, e As EventArgs) Handles ButtonCreate.Click
        If TextBoxRName.Text = "Please Enter Registry Name" Then
            MsgBox("Please Enter Registry Name")
            TextBoxRName.Text = ""
        ElseIf TextBoxRName.Text = "" Then
            MsgBox("Please Enter Registry Name")
        Else
            NewName = TextBoxRName.Text
            My.Computer.Registry.CurrentUser.CreateSubKey(NewName)
            MsgBox("Parent Created")
            ButtonCreateChild.Enabled = True
        End If
    End Sub

    Private Sub ButtonCreateChild_Click(sender As Object, e As EventArgs) Handles ButtonCreateChild.Click
        If TextBoxChild.Text = "" Then
            MsgBox("Please Enter Child Name")
        ElseIf TextBoxChild.Text = "Please Enter Child Name" Then
            MsgBox("Please Enter Child Name")
            TextBoxChild.Text = ""
        Else
            If TextBoxChildValue.Text = "" Then
                MsgBox("Please Enter Child Value")
            ElseIf TextBoxChildValue.Text = "Please Enter Child Value" Then
                MsgBox("Please Enter Child value")
                TextBoxChild.Text = ""
            Else
                NewName = TextBoxRName.Text
                Dim RegisLoc As String = "HKEY_CURRENT_USER\" + NewName
                My.Computer.Registry.SetValue(RegisLoc, TextBoxChild.Text, TextBoxChildValue.Text)
                MsgBox("Pair Created")
            End If
        End If
    End Sub

    Private Sub ButtonRead_Click(sender As Object, e As EventArgs) Handles ButtonRead.Click
        If TextBoxRead.Text = "" Then
            MsgBox("Please enter value to read")
        Else
            If TextBoxReadChild.Text = "" Then
                MsgBox("Please enter value to read")
            Else
                Dim inpputval As String = TextBoxRead.Text
                Dim inputchild As String = "HKEY_CURRENT_USER\" + TextBoxReadChild.Text
                Dim readValue = My.Computer.Registry.GetValue(inputchild, inpputval, Nothing)
                If My.Computer.Registry.GetValue(inputchild, inpputval, Nothing) Is Nothing Then
                    MsgBox("Value does not exist.")
                Else
                    MsgBox("Value :" & readValue)
                End If
            End If
        End If
    End Sub
End Class
