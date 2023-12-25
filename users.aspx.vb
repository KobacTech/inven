Imports System.Data
Imports System.Data.SqlClient
Public Class users
    Inherits System.Web.UI.Page
    Dim conn As New SqlConnection("data source=DESKTOP-E478ILL; initial catalog=inventory_db; integrated security= True")
    Dim cmd As New SqlCommand
    Protected Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        conn.Open()
        cmd.CommandText = "insert into users values('" + fullname.Text + "', '" + username.Text + "','" + password.Text + "','" + usertype.Text + "','" + udate.Text + "')"
        cmd.ExecuteNonQuery()
        MsgBox("Inserted Successfullly", MsgBoxStyle.Information, "User Inserted")
        conn.Close()
        ClearFlieds()
        ReadData()
    End Sub
    Sub ReadData()
        cmd.CommandText = "select * from users "
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        GridView1.DataBind()
    End Sub
    Sub ClearFlieds()
        fullname.Text = " "
        username.Text = " "
        password.Text = " "
        usertype.SelectedItem.Text = " "
        udate.Text = " "
    End Sub
    Protected Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        conn.Open()
        cmd.CommandText = "select * from users where id='" + search.Text + "'"
        Dim myread As SqlDataReader
        myread = cmd.ExecuteReader
        myread.Read()
        If myread.HasRows = True Then
            fullname.Text = myread(1)
            username.Text = myread(2)
            password.TextMode = TextBoxMode.SingleLine
            password.Text = myread(3)
            usertype.Text = myread(4)
            udate.Text = myread(5)
        End If

    End Sub

    Protected Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        conn.Open()
        cmd.CommandText = "update users set fullname= '" + fullname.Text + "', username='" + username.Text + "', password='" + password.Text + "', usertype='" + usertype.Text + "', date='" + udate.Text + "' where id='" + search.Text + "'"
        cmd.ExecuteNonQuery()
        MsgBox("update successfully", MsgBoxStyle.Information, "use update")
        conn.Close()
        ReadData()
        ClearFlieds()

    End Sub

    Protected Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        conn.Open()
        cmd.CommandText = " delete from users where id='" + search.Text + "'"
        cmd.ExecuteNonQuery()
        MsgBox("Dlelete Successfully", MsgBoxStyle.Information, "user deleted")
        ReadData()
        ClearFlieds()

    End Sub
End Class