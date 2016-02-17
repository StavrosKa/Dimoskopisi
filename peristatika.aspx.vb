Public Class peristatika
    Inherits selidadb

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        check()
        Dim id As String() = MyBase.getHospital(Request.QueryString("hosp"))
        Label1.Text = id(1)
        If Request.QueryString("visitID") <> "" Then
            Session("visitID") = Request.QueryString("visitID")
            Response.Redirect("~/egrisi.aspx?hosp=" & Request.QueryString("hosp"))
        Else
            Session("visitID") = ""
        End If
        Dim hospId As String = id(0)
        Dim remoteData As New remoteConnection(Request.QueryString("hosp"))
        Dim hm As Date = DateAdd(DateInterval.Day, -3, Now)
        Dim hm2 As Date = DateAdd(DateInterval.Day, -4, Now)
        Dim hmKritirioMin = DateAdd(DateInterval.Year, -85, Now)
        Dim hmKritirioMax = DateAdd(DateInterval.Year, -18, Now)
        Dim oracleHm As String = "'" & hm.ToShortDateString & " 00:00:00', 'DD/MM/YYYY HH24:MI:SS'"
        Dim oracleHm2 As String = "'" & hm.ToShortDateString & " 23:59:59', 'DD/MM/YYYY HH24:MI:SS'"
        Dim oracleHm3 As String = "'" & hm2.ToShortDateString & " 00:00:00', 'DD/MM/YYYY HH24:MI:SS'"
        Dim oracleHm4 As String = "'" & hm2.ToShortDateString & " 23:59:59', 'DD/MM/YYYY HH24:MI:SS'"
        Dim oracleHmKritirioMin As String = "'" & hmKritirioMin.ToShortDateString & " 00:00:00', 'DD/MM/YYYY HH24:MI:SS'"
        Dim oracleHmKritirioMax As String = "'" & hmKritirioMax.ToShortDateString & " 00:00:00', 'DD/MM/YYYY HH24:MI:SS'"
        Dim remoteString As String = remoteData.getData("SELECT YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.LAST_NAME AS ""ΕΠΩΝΥΜΟ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.FIRST_NAME AS ""ONOMA"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.AMKA AS ""ΑΜΚΑ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.BIRTH_DATE AS ""ΗΜ. ΓΕΝΝΗΣΗΣ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.TELEPHONE AS ""ΑΡ. ΤΗΛΕΦΩΝΟΥ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.MOBILE AS ""ΑΡ. ΚΙΝΗΤΟΥ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.CITY_NAME AS ""ΠΟΛΗ""," &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.CITY_TX AS ""ΠΕΡΙΟΧΗ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.AREA_NAME AS ""ΝΟΜΟΣ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.ADDRESS AS ""ΔΙΕΥΘΥΝΣΗ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.NATIONALITY_NAME AS ""ΕΘΝΙΚΟΤΗΤΑ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.PROFESSION_NAME AS ""ΕΠΑΓΓΕΛΜΑ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_VISIT.START_DT AS ""ΗΜ. ΕΙΣΑΓΩΓΗΣ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_VISIT.END_DT AS ""ΗΜ. ΕΞΟΔΟΥ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_VISIT.INSURANCE_MAIN AS ""ΑΣΦ. ΦΟΡΕΑΣ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_VISIT.VISIT_CODE, " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_VISIT.ORG_UNIT_NAME AS ""ΚΛΙΝΙΚΗ"", " &
                                                            "(YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_VISIT.END_DT - YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_VISIT.START_DT) AS ""ΗΜΕΡΕΣ ΝΟΣΗΛΙΑΣ"" " &
                                                            "FROM YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT JOIN YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_VISIT " &
                                                            "ON YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.PATIENT_CODE = YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_VISIT.PATIENT_CODE " &
                                                            "WHERE ((YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_VISIT.END_DT >= To_Date(" & oracleHm & ") AND " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_VISIT.END_DT <= To_Date(" & oracleHm2 & ")) OR " &
                                                            "(YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_VISIT.END_DT >= To_Date(" & oracleHm3 & ") AND " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_VISIT.END_DT <= To_Date(" & oracleHm4 & "))) AND " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_VISIT.HOSPITAL=" & hospId & " AND " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_VISIT.VISIT_TYPE=1 AND " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.INACTIVE=0 AND " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.IS_DEAD=0 AND " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.AMKA Is Not NULL AND " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.BIRTH_DATE >= To_Date(" & oracleHmKritirioMin & ") And " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.BIRTH_DATE <= To_Date(" & oracleHmKritirioMax & ") And " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_VISIT.END_DT - YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_VISIT.START_DT >1 And " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_VISIT.HOSPITALIZATION_RESULT_DESCR<>'Θάνατος' ORDER BY END_DT")
        If remoteString.StartsWith("ΑΔΥΝΑΜΙΑ") OrElse remoteString.StartsWith("ΠΡΟΒΛΗΜΑ") Then
            Response.Write(remoteString)
            Response.End()
        Else
            Dim dt1 As DataTable = remoteData.convertToDataTable(remoteString)
            If dt1.Rows.Count > 0 Then
                Dim h1 As String = "<span Class='tooltip123'>"
                Dim h2 As String = "<span Class='custom help'><img src='Content/help.png' alt='' height='48' width='48'/>"
                '             <em>Σημαντικό!!</em>Η εντολή</span></span>"
                'Dim h3 As String = "<span Class='tooltip123'>"
                'Dim h4 As String = "<span Class='custom info'><img src='/Content/info.png' alt='' height='48' width='48'/>"


                Call makeTableHeaders()
                Dim localData As New localDBconnection
                For f As Integer = 0 To dt1.Rows.Count - 1
                    Dim r As New TableRow
                    Dim c0 As New TableCell
                    c0.Text = (f + 1).ToString
                    Dim c1 As New TableCell
                    c1.Text = "<a href='peristatika.aspx?visitID=" & dt1.Rows(f).Item("VISIT_CODE") & "&hosp=" & Request.QueryString("hosp") & "'><img alt='Επιλογή Ασθενή' src='Resources/select.png' style='width: 52px; height: 16px; '/></a>"
                    Dim c2 As New TableCell
                    Dim dtTmp As DataTable = localData.getData("Select * FROM [ΑΠΟΚΡΙΣΕΙΣ] WHERE [VISIT_CODE]='" & dt1.Rows(f).Item("VISIT_CODE") & "'")
                    Dim found As String = ""
                    If dtTmp.Rows.Count > 0 Then
                        If dtTmp.Rows(0).Item(2) = "Ο ασθενής δεν απάντησε" Then
                            Dim img As New Image
                            img.ImageUrl = "Resources/smartphone90.png"
                            img.Width = "22"
                            img.Height = "22"
                            img.ToolTip = "Ο ασθενής δεν απάντησε"
                            c2.Controls.Add(img)
                            c0.BackColor = Drawing.Color.LightBlue
                        ElseIf dtTmp.Rows(0).Item(2) = "Ο ασθενής απάντησε, αλλά δεν ήθελε να συμμετέχει" Then
                            Dim img As New Image
                            img.ImageUrl = "Resources/cellphone.png"
                            img.Width = "22"
                            img.Height = "22"
                            img.ToolTip = "Ο ασθενής απάντησε, αλλά δεν ήθελε να συμμετέχει"
                            c2.Controls.Add(img)
                            c0.BackColor = Drawing.Color.LightCoral
                            c1.Text = " "
                        ElseIf dtTmp.Rows(0).Item(2) = "Απαντήθηκε από συγγενή και ο ασθενής απουσίαζε" Then
                            Dim img As New Image
                            img.ImageUrl = "Resources/smartphone84.png"
                            img.Width = "22"
                            img.Height = "22"
                            img.ToolTip = "Απαντήθηκε από συγγενή και ο ασθενής απουσίαζε"
                            c2.Controls.Add(img)
                            c0.BackColor = Drawing.Color.LightGoldenrodYellow
                        ElseIf dtTmp.Rows(0).Item(2) = "Λανθασμένος αριθμός τηλεφώνου" Then
                            Dim img As New Image
                            img.ImageUrl = "Resources/smartphone89.png"
                            img.Width = "22"
                            img.Height = "22"
                            img.ToolTip = "Λανθασμένος αριθμός τηλεφώνου"
                            c2.Controls.Add(img)
                            c0.BackColor = Drawing.Color.LightGray
                            c1.Text = " "
                        ElseIf dtTmp.Rows(0).Item(2) = "Ο ασθενής απάντησε και θέλει να συμμετέχει" Then
                            Dim img As New Image
                            img.ImageUrl = "Resources/cellphone90.png"
                            img.Width = "22"
                            img.Height = "22"
                            img.ToolTip = "Ο ασθενής απάντησε και θέλει να συμμετέχει"
                            c2.Controls.Add(img)
                            c0.BackColor = Drawing.Color.LightGreen
                            c1.Text = " "
                        ElseIf dtTmp.Rows(0).Item(2) = "Ο ασθενής απάντησε, αλλά η σύνδεση διακόπηκε" Then
                            Dim img As New Image
                            img.ImageUrl = "Resources/connection-lost.png"
                            img.Width = "22"
                            img.Height = "22"
                            img.ToolTip = "Ο ασθενής απάντησε, αλλά η σύνδεση διακόπηκε"
                            c2.Controls.Add(img)
                            c0.BackColor = Drawing.Color.Black
                            c0.ForeColor = Drawing.Color.White
                            c1.Text = " "
                        End If
                    Else
                        c2.Text = " "
                    End If
                    Dim c3 As New TableCell
                    If Not dt1.Rows(f).Item("ΑΜΚΑ") Is DBNull.Value Then
                        c3.Text = dt1.Rows(f).Item("ΑΜΚΑ") & ""
                    Else
                        c3.Text = "-"
                    End If
                    Dim c4 As New TableCell
                    Dim name As String
                    name = h1 & IIf(dt1.Rows(f).Item("ΕΠΩΝΥΜΟ") Is DBNull.Value, "-", dt1.Rows(f).Item("ΕΠΩΝΥΜΟ") & " " & dt1.Rows(f).Item("ONOMA")) & h2
                    'name = name & "<em>ΤΙΤΛΟΣ</em>"
                    name &= IIf(dt1.Rows(f).Item("ΕΘΝΙΚΟΤΗΤΑ") Is DBNull.Value, " ΕΘΝΙΚΟΤΗΤΑ: -", " ΕΘΝΙΚΟΤΗΤΑ: " & dt1.Rows(f).Item("ΕΘΝΙΚΟΤΗΤΑ"))
                    name = name & IIf(dt1.Rows(f).Item("ΕΠΑΓΓΕΛΜΑ") Is DBNull.Value, "<br/>ΕΠΑΓΓΕΛΜΑ: -", "<br/>ΕΠΑΓΓΕΛΜΑ: " & dt1.Rows(f).Item("ΕΠΑΓΓΕΛΜΑ"))
                    name = name & IIf(dt1.Rows(f).Item("ΑΣΦ. ΦΟΡΕΑΣ") Is DBNull.Value, "<br/>ΑΣΦ. ΦΟΡΕΑΣ: -", "<br/>ΑΣΦ. ΦΟΡΕΑΣ: " & dt1.Rows(f).Item("ΑΣΦ. ΦΟΡΕΑΣ"))
                    name = name & IIf(dt1.Rows(f).Item("ΗΜ. ΕΙΣΑΓΩΓΗΣ") Is DBNull.Value, "<br/>ΗΜ. ΕΙΣΑΓΩΓΗΣ: -", "<br/>ΗΜ. ΕΙΣΑΓΩΓΗΣ: " & dt1.Rows(f).Item("ΗΜ. ΕΙΣΑΓΩΓΗΣ"))
                    name = name & IIf(dt1.Rows(f).Item("ΗΜ. ΕΞΟΔΟΥ") Is DBNull.Value, "<br/>ΗΜ. ΕΞΟΔΟΥ: -", "<br/>ΗΜ. ΕΞΟΔΟΥ: " & dt1.Rows(f).Item("ΗΜ. ΕΞΟΔΟΥ"))
                    name = name & IIf(dt1.Rows(f).Item("ΔΙΕΥΘΥΝΣΗ") Is DBNull.Value, "<br/>ΔΙΕΥΘΥΝΣΗ: -", "<br/>ΔΙΕΥΘΥΝΣΗ: " & dt1.Rows(f).Item("ΔΙΕΥΘΥΝΣΗ"))
                    name = name & IIf(dt1.Rows(f).Item("ΠΕΡΙΟΧΗ") Is DBNull.Value, "<br/>ΠΕΡΙΟΧΗ: -", "<br/>ΠΕΡΙΟΧΗ: " & dt1.Rows(f).Item("ΠΕΡΙΟΧΗ"))
                    name = name & IIf(dt1.Rows(f).Item("ΝΟΜΟΣ") Is DBNull.Value, "<br/>ΝΟΜΟΣ: -", "<br/>ΝΟΜΟΣ: " & dt1.Rows(f).Item("ΝΟΜΟΣ"))
                    name &= "</span></span>"
                    c4.Text = name

                    Dim c5 As New TableCell
                    If Not dt1.Rows(f).Item("ΗΜ. ΓΕΝΝΗΣΗΣ") Is DBNull.Value Then
                        c5.Text = dt1.Rows(f).Item("ΗΜ. ΓΕΝΝΗΣΗΣ") & "  "
                    Else
                        c5.Text = "-"
                    End If
                    Dim c6 As New TableCell
                    If Not dt1.Rows(f).Item("ΑΡ. ΤΗΛΕΦΩΝΟΥ") Is DBNull.Value Then
                        c6.Text = dt1.Rows(f).Item("ΑΡ. ΤΗΛΕΦΩΝΟΥ") & "  "
                    Else
                        c6.Text = "-"
                    End If
                    Dim c7 As New TableCell
                    If Not dt1.Rows(f).Item("ΑΡ. ΚΙΝΗΤΟΥ") Is DBNull.Value Then
                        c7.Text = dt1.Rows(f).Item("ΑΡ. ΚΙΝΗΤΟΥ") & "  "
                    Else
                        c7.Text = "-"
                    End If
                    Dim c8 As New TableCell
                    If Not dt1.Rows(f).Item("ΠΟΛΗ") Is DBNull.Value Then
                        c8.Text = dt1.Rows(f).Item("ΠΟΛΗ") & "  "
                    Else
                        c8.Text = "-"
                    End If
                    Dim c9 As New TableCell
                    If Not dt1.Rows(f).Item("ΚΛΙΝΙΚΗ") Is DBNull.Value Then
                        c9.Text = dt1.Rows(f).Item("ΚΛΙΝΙΚΗ") & "  "
                    Else
                        c9.Text = "-"
                    End If
                    Dim c10 As New TableCell
                    If Not dt1.Rows(f).Item("ΗΜΕΡΕΣ ΝΟΣΗΛΙΑΣ") Is DBNull.Value Then
                        c10.Text = 1 + Int(dt1.Rows(f).Item("ΗΜΕΡΕΣ ΝΟΣΗΛΙΑΣ")) & " "
                    Else
                        c10.Text = "-"
                    End If
                    r.Cells.Add(c0)
                    r.Cells.Add(c1)
                    r.Cells.Add(c2)
                    r.Cells.Add(c3)
                    r.Cells.Add(c4)
                    r.Cells.Add(c5)
                    r.Cells.Add(c6)
                    r.Cells.Add(c7)
                    r.Cells.Add(c8)
                    r.Cells.Add(c9)
                    r.Cells.Add(c10)
                    Table1.Rows.Add(r)
                Next
                localData.TerminateLocalDBConnection()
            End If
        End If
    End Sub

    Private Sub makeTableHeaders()
        Dim c0 As New TableCell
        c0.Text = "A/A"
        Call deco(c0)
        Dim c1 As New TableCell
        c1.Text = "ΕΝT."
        Call deco(c1)
        Dim c2 As New TableCell
        c2.Text = "ST."
        Call deco(c2)
        Dim c3 As New TableCell
        c3.Text = "ΑΜΚΑ"
        Call deco(c3)
        Dim c4 As New TableCell
        c4.Text = "ΟΝΟΜΑΤΕΠΩΝΥΜΟ"
        Call deco(c4)
        Dim c5 As New TableCell
        c5.Text = "ΗΜ. ΓΕΝΝΗΣΗΣ"
        Call deco(c5)
        Dim c6 As New TableCell
        c6.Text = "ΑΡ. ΤΗΛΕΦΩΝΟΥ"
        Call deco(c6)
        Dim c7 As New TableCell
        c7.Text = "ΑΡ. ΚΙΝΗΤΟΥ"
        Call deco(c7)
        Dim c8 As New TableCell
        c8.Text = "ΠΟΛΗ"
        Call deco(c8)
        Dim c9 As New TableCell
        c9.Text = "ΠΕΡΙΣΤΑΤΙΚΟ"
        Call deco(c9)
        Dim c10 As New TableCell
        c10.Text = "ΗΜ. ΝΟΣΗΛΕΙΑΣ"
        Call deco(c10)
        Dim r As New TableRow
        r.Cells.Add(c0)
        r.Cells.Add(c1)
        r.Cells.Add(c2)
        r.Cells.Add(c3)
        r.Cells.Add(c4)
        r.Cells.Add(c5)
        r.Cells.Add(c6)
        r.Cells.Add(c7)
        r.Cells.Add(c8)
        r.Cells.Add(c9)
        r.Cells.Add(c10)
        Table1.Rows.Add(r)
    End Sub
    Private Sub deco(ByRef c As TableCell)
        c.Font.Bold = True
        c.BackColor = System.Drawing.ColorTranslator.FromHtml("#0a9fc9")
        c.ForeColor = Drawing.Color.White
    End Sub

End Class

