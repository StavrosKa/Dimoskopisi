Public Class statistika2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("powerUser") <> True Then
            Response.Write("Δεν έχετε δικαίωμα προβολής των στατιστικών")
            Response.End()
        End If
        Dim localData As New localDBconnection
        Dim dt As DataTable = localData.getData("SELECT * FROM [ΕΡΩΤΗΜΑΤΑ ΑΝΑ ΔΗΜΟΣΚΟΠΗΣΗ] WHERE [ID_DIM]=" & Session("dimoskopisiID"))
        Dim tbl As New Table
        Dim r As New TableRow
        Dim tc As New TableCell
        tc.Text = "ΕΡΩΤΗΣΕΙΣ"
        tc.Font.Bold = True
        r.Cells.Add(tc)
        For f As Integer = 0 To dt.Rows.Count - 1
            Dim t As New TableCell
            t.Text = dt.Rows(f).Item("ΠΕΡΙΓΡΑΦΗ")
            r.Cells.Add(t)
        Next
        tbl.Rows.Add(r)
        Dim dt1 As DataTable = localData.getData("SELECT * FROM [ΑΠΟΤΕΛΕΣΜΑΤΑ ΑΝΑ ΔΗΜΟΣΚΟΠΗΣΗ] WHERE [ID_DIM]=" & Session("dimoskopisiID"))
        localData.TerminateLocalDBConnection()

        If dt1.Rows.Count > 0 Then
            r = New TableRow
            Dim th As New TableCell
            th.Text = "ΑΠΑΝΤΗΣΕΙΣ"
            th.Font.Bold = True
            r.Cells.Add(th)
            For f As Integer = 0 To dt1.Rows.Count - 1
                Dim t As New TableCell
                t.Text = dt1.Rows(f).Item("ΑΠΟΤΕΛΕΣΜΑΤΑ")
                r.Cells.Add(t)
            Next
            tbl.Rows.Add(r)
        End If


        If dt1.Rows.Count > 0 Then
            r = New TableRow
            Dim th As New TableCell
            th.Text = "ΚΩΔ.ΕΠΙΣΚ."
            th.Font.Bold = True
            r.Cells.Add(th)
            For f As Integer = 0 To dt1.Rows.Count - 1
                Dim t As New TableCell
                t.Text = dt1.Rows(f).Item("VISIT_CODE")
                r.Cells.Add(t)
            Next

            tbl.Rows.Add(r)

        End If


        For f As Int16 = 0 To tbl.Rows.Count - 1
            If f Mod 2 = 0 Then
                tbl.Rows(f).BackColor = Drawing.Color.AliceBlue
            Else
                tbl.Rows(f).BackColor = Drawing.Color.White
            End If
        Next
        stats.Controls.Add(tbl)
    End Sub

End Class