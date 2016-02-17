Public Class statistika
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("powerUser") <> True Then
            Response.Write("Δεν έχετε δικαίωμα προβολής των στατιστικών")
            Response.End()
        End If
        Dim localData As New localDBconnection
        Dim dt As DataTable
        If DropDownList1.SelectedValue = 0 Then
            dt = localData.getData("SELECT * FROM [πινακας] where id_dim=" & Session("dimoskopisiID") & " ORDER BY [ΚΩΔΙΚΟΣ ΕΠΙΣΚ.],[ΚΑΤΗΓΟΡΙΑ]")
        ElseIf DropDownList1.SelectedValue = 2 Then
            dt = localData.getData("SELECT * FROM [πινακας] where id_dim=" & Session("dimoskopisiID") & " ORDER BY [ΚΑΤΗΓΟΡΙΑ],[ΚΩΔΙΚΟΣ ΕΠΙΣΚ.]")

        ElseIf DropDownList1.SelectedValue = 3 Then
            dt = localData.getData("SELECT * FROM [πινακας] WHERE id_dim=" & Session("dimoskopisiID") & " AND isnumeric([ΑΠΑΝΤΗΣΗ])= 1 ORDER BY [ΑΠΑΝΤΗΣΗ] ASC")
        ElseIf DropDownList1.SelectedValue = 4 Then
            dt = localData.getData("SELECT * FROM [πινακας] WHERE id_dim=" & Session("dimoskopisiID") & " AND isnumeric([ΑΠΑΝΤΗΣΗ])= 1 ORDER BY [ΑΠΑΝΤΗΣΗ] DESC")
        ElseIf DropDownList1.SelectedValue = 5 Then
            dt = localData.getData("SELECT * FROM [πινακας] WHERE id_dim=" & Session("dimoskopisiID") & " AND isnumeric([ΑΠΑΝΤΗΣΗ])= 1 ORDER BY [ΑΠΑΝΤΗΣΗ] ASC,[ΚΩΔΙΚΟΣ ΕΠΙΣΚ.]")
        ElseIf DropDownList1.SelectedValue = 6 Then
            dt = localData.getData("SELECT * FROM [πινακας] WHERE id_dim=" & Session("dimoskopisiID") & " AND isnumeric([ΑΠΑΝΤΗΣΗ])= 1 ORDER BY [ΑΠΑΝΤΗΣΗ] DESC,[ΚΩΔΙΚΟΣ ΕΠΙΣΚ.]")
        ElseIf DropDownList1.SelectedValue = 7 Then
            dt = localData.getData("SELECT * FROM [πινακας] WHERE id_dim=" & Session("dimoskopisiID") & " AND isnumeric([ΑΠΑΝΤΗΣΗ])= 1 ORDER BY [ΑΠΑΝΤΗΣΗ] ASC,[ΚΑΤΗΓΟΡΙΑ],[Α.Α]")
        ElseIf DropDownList1.SelectedValue = 8 Then
            dt = localData.getData("SELECT * FROM [πινακας] WHERE id_dim=" & Session("dimoskopisiID") & " AND isnumeric([ΑΠΑΝΤΗΣΗ])= 1 ORDER BY [ΑΠΑΝΤΗΣΗ] DESC,[ΚΑΤΗΓΟΡΙΑ,[Α.Α]")
        Else
            dt = localData.getData("SELECT * FROM [πινακας] where id_dim=" & Session("dimoskopisiID") & " ORDER BY [ΚΑΤΗΓΟΡΙΑ],[Α.Α]")
        End If
        localData.TerminateLocalDBConnection()
        dt.Columns.Remove("ID_DIM")
        GridView1.DataSource = dt
        GridView1.DataBind()
    End Sub

End Class