Public Class egrisi
    Inherits selidadb
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        check()
        If IsNothing(Session("visitID")) OrElse Session("visitID") = "" Then
            Response.Redirect("nosokomeia.aspx")
        End If
        Dim id As String() = getHospital(Request.QueryString("hosp"))
        Label24.Text = id(1)
        Dim hospId As String = id(0)
        Dim remoteData As New remoteConnection(Request.QueryString("hosp"))
        Dim remoteString As String = remoteData.getData("Select YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.LAST_NAME As ""ΕΠΩΝΥΜΟ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.FIRST_NAME As ""ONOMA"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.AMKA As ""ΑΜΚΑ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.BIRTH_DATE As ""ΗΜ. ΓΕΝΝΗΣΗΣ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.TELEPHONE As ""ΑΡ. ΤΗΛΕΦΩΝΟΥ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.MOBILE As ""ΑΡ. ΚΙΝΗΤΟΥ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.CITY_NAME As ""ΠΟΛΗ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.CITY_TX As ""ΠΕΡΙΟΧΗ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.AREA_NAME As ""ΝΟΜΟΣ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.ADDRESS As ""ΔΙΕΥΘΥΝΣΗ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.NATIONALITY_NAME As ""ΕΘΝΙΚΟΤΗΤΑ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.PROFESSION_NAME As ""ΕΠΑΓΓΕΛΜΑ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_VISIT.START_DT As ""ΗΜ. ΕΙΣΑΓΩΓΗΣ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_VISIT.END_DT As ""ΗΜ. ΕΞΑΓΩΓΗΣ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_VISIT.INSURANCE_MAIN As ""ΑΣΦ. ΦΟΡΕΑΣ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_VISIT.VISIT_CODE As ""ΚΩΔ.ΠΕΡ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_VISIT.ORG_UNIT_NAME As ""ΚΛΙΝΙΚΗ"", " &
                                                            "(YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_VISIT.END_DT - YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_VISIT.START_DT) AS ""ΗΜΕΡΕΣ ΝΟΣΗΛΙΑΣ"" " &
                                                            "FROM YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT JOIN YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_VISIT " &
                                                            "ON YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.PATIENT_CODE = YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_VISIT.PATIENT_CODE " &
                                                            "WHERE YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_VISIT.VISIT_CODE='" & Session("visitID") & "'")
        If remoteString.StartsWith("ΑΔΥΝΑΜΙΑ") OrElse remoteString.StartsWith("ΠΡΟΒΛΗΜΑ") Then
            Response.Write(remoteString)
            Response.End()
        Else
            Dim dt1 As DataTable = remoteData.convertToDataTable(remoteString)

            For f As Integer = 0 To dt1.Rows.Count - 1
                Dim c1 As String
                If Not dt1.Rows(f).Item("ΚΩΔ.ΠΕΡ") Is DBNull.Value Then
                    c1 = dt1.Rows(f).Item("ΚΩΔ.ΠΕΡ")
                    Label16.Text = c1
                Else
                    Label16.Text = "-"
                End If
                Dim c2 As String
                If Not dt1.Rows(f).Item("ΑΜΚΑ") Is DBNull.Value Then
                    c2 = dt1.Rows(f).Item("ΑΜΚΑ")
                    Label17.Text = c2
                Else
                    Label17.Text = "-"
                End If
                Dim c3 As String
                If Not dt1.Rows(f).Item("ΑΣΦ. ΦΟΡΕΑΣ") Is DBNull.Value Then
                    c3 = dt1.Rows(f).Item("ΑΣΦ. ΦΟΡΕΑΣ")
                    Label18.Text = c3
                Else
                    Label18.Text = "-"
                End If
                Dim c4 As String
                If Not dt1.Rows(f).Item("ΕΠΑΓΓΕΛΜΑ") Is DBNull.Value Then
                    c4 = dt1.Rows(f).Item("ΕΠΑΓΓΕΛΜΑ")
                    Label19.Text = c4
                Else
                    Label19.Text = "-"
                End If
                Dim c5 As String
                If Not dt1.Rows(f).Item("ΕΘΝΙΚΟΤΗΤΑ") Is DBNull.Value Then
                    c5 = dt1.Rows(f).Item("ΕΘΝΙΚΟΤΗΤΑ")
                    Label26.Text = c5
                Else
                    Label20.Text = "-"
                End If
                Dim c6 As String
                If Not dt1.Rows(f).Item("ΗΜ. ΕΙΣΑΓΩΓΗΣ") Is DBNull.Value Then
                    c6 = dt1.Rows(f).Item("ΗΜ. ΕΙΣΑΓΩΓΗΣ")
                    Label21.Text = c6
                Else
                    Label21.Text = "-"
                End If
                Dim c7 As String
                If Not dt1.Rows(f).Item("ΗΜ. ΕΞΑΓΩΓΗΣ") Is DBNull.Value Then
                    c7 = dt1.Rows(f).Item("ΗΜ. ΕΞΑΓΩΓΗΣ")
                    Label22.Text = c7
                Else
                    Label22.Text = "-"
                End If
                Dim c8 As String
                If Not dt1.Rows(f).Item("ΕΠΩΝΥΜΟ") Is DBNull.Value Then
                    c8 = dt1.Rows(f).Item("ΕΠΩΝΥΜΟ") & " " & dt1.Rows(f).Item("ONOMA")
                    Label23.Text = c8
                Else
                    Label23.Text = "-"
                End If
                Dim c9 As String
                If Not dt1.Rows(f).Item("ΗΜ. ΓΕΝΝΗΣΗΣ") Is DBNull.Value Then
                    c9 = dt1.Rows(f).Item("ΗΜ. ΓΕΝΝΗΣΗΣ")
                    Dim gen As Integer = DateDiff(DateInterval.Year, CDate(c9), Now)
                    Label20.Text = gen & " (" & c9 & ")"
                Else
                    Label20.Text = "-"
                End If
                Dim c10 As String
                If Not dt1.Rows(f).Item("ΑΡ. ΤΗΛΕΦΩΝΟΥ") Is DBNull.Value Then
                    c10 = dt1.Rows(f).Item("ΑΡ. ΤΗΛΕΦΩΝΟΥ")
                    Label28.Text = "<span style='background-color:yellow;font-size:110%'>" & c10 & "</span>"
                Else
                    Label28.Text = "-"
                End If
                Dim c11 As String
                If Not dt1.Rows(f).Item("ΑΡ. ΚΙΝΗΤΟΥ") Is DBNull.Value Then
                    c11 = dt1.Rows(f).Item("ΑΡ. ΚΙΝΗΤΟΥ")
                    Label30.Text = "<span style='background-color:yellow;font-size:110%'>" & c11 & "</span>"
                Else
                    Label30.Text = "-"
                End If
                Dim c12 As String
                If Not dt1.Rows(f).Item("ΚΛΙΝΙΚΗ") Is DBNull.Value Then
                    c12 = dt1.Rows(f).Item("ΚΛΙΝΙΚΗ")
                    Label2.Text = c12
                Else
                    Label2.Text = "-"
                End If
                Dim c13 As String
                If Not dt1.Rows(f).Item("ΗΜΕΡΕΣ ΝΟΣΗΛΙΑΣ") Is DBNull.Value Then
                    c13 = 1 + Int(dt1.Rows(f).Item("ΗΜΕΡΕΣ ΝΟΣΗΛΙΑΣ"))
                    Label1.Text = c13
                Else
                    Label1.Text = "-"
                End If
                Dim c14 As String
                If Not dt1.Rows(f).Item("ΔΙΕΥΘΥΝΣΗ") Is DBNull.Value Then
                    c14 = dt1.Rows(f).Item("ΔΙΕΥΘΥΝΣΗ")
                    Label3.Text = c14
                Else
                    Label3.Text = "-"
                End If
                Dim c15 As String
                If Not dt1.Rows(f).Item("ΠΟΛΗ") Is DBNull.Value Then
                    c15 = dt1.Rows(f).Item("ΠΟΛΗ")
                    Label4.Text = c15
                Else
                    Label4.Text = "-"
                End If
                Dim c16 As String
                If Not dt1.Rows(f).Item("ΠΕΡΙΟΧΗ") Is DBNull.Value Then
                    c16 = dt1.Rows(f).Item("ΠΕΡΙΟΧΗ")
                    Label10.Text = c16
                Else
                    Label10.Text = "-"
                End If
                Dim c17 As String
                If Not dt1.Rows(f).Item("ΝΟΜΟΣ") Is DBNull.Value Then
                    c17 = dt1.Rows(f).Item("ΝΟΜΟΣ")
                    Label11.Text = c17
                Else
                    Label11.Text = "-"
                End If
            Next
        End If
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Label23.Text.Trim <> "" AndAlso Label23.Text.Trim <> "&nbsp;" Then
            Dim apanthsh As String = ""
            If RadioButton1.Checked Then apanthsh = RadioButton1.Text.Trim
            If RadioButton2.Checked Then apanthsh = RadioButton2.Text.Trim
            If RadioButton3.Checked Then apanthsh = RadioButton3.Text.Trim
            If RadioButton4.Checked Then apanthsh = RadioButton4.Text.Trim
            If RadioButton5.Checked Then apanthsh = RadioButton5.Text.Trim
            If apanthsh = "" Then Exit Sub
            Dim hm As Date = Now
            Dim hmeromhnia As String = hm.Year & "-" & hm.Month & "-" & hm.Day & " " & hm.Hour & ":" & hm.Minute & ":" & hm.Second
            Dim localData As New localDBconnection
            Dim dt As DataTable = localData.getData("SELECT VISIT_CODE FROM [ΑΠΟΚΡΙΣΕΙΣ] WHERE VISIT_CODE='" & Session("visitID") & "'")
            If dt.Rows.Count > 0 Then
                ' update
                localData.updateData("UPDATE [ΑΠΟΚΡΙΣΕΙΣ] SET [ΑΠΟΚΡΙΣΗ]='" & apanthsh & "', [UserName]='" & Session("user") & "', [date-stamp]='" & hmeromhnia & "' WHERE VISIT_CODE='" & Session("visitID") & "'")
            Else
                'insert
                localData.updateData("INSERT INTO [ΑΠΟΚΡΙΣΕΙΣ] ([VISIT_CODE], [PATIENT FULL NAME], [ΑΠΟΚΡΙΣΗ], [ΝΟΣΟΚΟΜΕΙΟ], [UserName]) VALUES (" &
                                                            "'" & Session("visitID") & "', " &
                                                                        "'" & Label23.Text.Replace("'", "") & "', " &
                                                                                                "'" & apanthsh & "', " &
                                                                                                    "'" & Request.QueryString("hosp") & "', " &
                                                                                                        "'" & Session("user") & "')")
            End If
            localData.TerminateLocalDBConnection()
            If RadioButton5.Checked Then
                Response.Redirect("erotimatologio.aspx?hosp=" & Request.QueryString("hosp"))
            Else
                Session("visitID") = ""
                Response.Redirect("peristatika.aspx?hosp=" & Request.QueryString("hosp"))
            End If
        End If
    End Sub
End Class