Public Class selidadb
    Inherits System.Web.UI.Page

    Public Sub check()
        If IsNothing(Session("user")) OrElse Session("user") = "" Then
            Response.Redirect("~/default.aspx")
        End If
    End Sub
    Public Function getHospital(hosp As String) As String()
        Dim r(1) As String
        r(0) = "1"
        r(1) = "Επιλεγμένο Νοσοκομείο: ΒΕΝΙΖΕΛΕΙΟ"
        Dim nosokomeio As String = hosp
        If nosokomeio = "PAGNH" OrElse
           nosokomeio = "VEN" OrElse
           nosokomeio = "RETH" OrElse
           nosokomeio = "CHANIA" OrElse
           nosokomeio = "NIKOL" OrElse
           nosokomeio = "IERAPETRA" OrElse
           nosokomeio = "SITIA" OrElse
           nosokomeio = "NEAPOLI" Then
            Select Case nosokomeio
                Case "PAGNH"
                    r(0) = "300000001"
                    r(1) = "Επιλεγμένο Νοσοκομείο: ΠΑΓΝΗ"
                Case "VEN"
                    r(0) = "1"
                    r(1) = "Επιλεγμένο Νοσοκομείο: ΒΕΝΙΖΕΛΕΙΟ"
                Case "RETH"
                    r(0) = "900000001"
                    r(1) = "Επιλεγμένο Νοσοκομείο: ΡΕΘΥΜΝΟ"
                Case "CHANIA"
                    r(0) = "700000001"
                    r(1) = "Επιλεγμένο Νοσοκομείο: ΧΑΝΙΑ"
                Case "NIKOL"
                    r(0) = "500000001"
                    r(1) = "Επιλεγμένο Νοσοκομείο: ΑΓΙΟΣ ΝΙΚΟΛΑΟΣ"
                Case "IERAPETRA"
                    r(0) = "1500000001"
                    r(1) = "Επιλεγμένο Νοσοκομείο: ΙΕΡΑΠΕΤΡΑ"
                Case "SITIA"
                    r(0) = "1100000001"
                    r(1) = "Επιλεγμένο Νοσοκομείο: ΣΗΤΕΙΑ"
                Case "NEAPOLI"
                    r(0) = "1300000001"
                    r(1) = "Επιλεγμένο Νοσοκομείο: ΝΕΑΠΟΛΗ"
            End Select
        Else
            Response.Write("Ho ho ho")
            Response.End()
        End If
        Return r
    End Function
End Class
