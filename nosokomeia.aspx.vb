Public Class nosokomeia
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsNothing(Session("user")) OrElse Session("user") = "" Then
            Response.Redirect("~/default.aspx")
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("~/peristatika.aspx?hosp=PAGNH")
    End Sub
    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect("~/peristatika.aspx?hosp=VEN")
    End Sub
    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Response.Redirect("~/peristatika.aspx?hosp=RETH")
    End Sub
    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Response.Redirect("~/peristatika.aspx?hosp=CHANIA")
    End Sub
    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Response.Redirect("~/peristatika.aspx?hosp=NIKOL")
    End Sub
    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Response.Redirect("~/peristatika.aspx?hosp=IERAPETRA")
    End Sub
    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Response.Redirect("~/peristatika.aspx?hosp=SITIA")
    End Sub
    Protected Sub Button8_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Response.Redirect("~/peristatika.aspx?hosp=NEAPOLI")
    End Sub

    'Protected Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton1.Click
    '    Response.Redirect("~/peristatika.aspx?hosp=NEAPOLI")
    'End Sub
End Class