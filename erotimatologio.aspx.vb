Public Class erotimatologio
    Inherits selidadb
    Public prvthForaAristera As Boolean = False
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        check()
        If IsNothing(Session("visitID")) OrElse Session("visitID") = "" Then
            Response.Redirect("nosokomeia.aspx")
        Else
            'zhtaw apo th vash na dw an yparxei hdh eggrafh sth vash tou visit_code  
            'kai to sygkrinw me to session gia na diasfalisw na mhn mporei na ksanakanei to erwthmatologio
            Dim localData2 As New localDBconnection
            Dim dt As DataTable = localData2.getData("SELECT [VISIT_CODE] FROM [ΔΗΜΟΓΡΑΦΙΚΑ] WHERE [VISIT_CODE]='" & Session("visitID") & "'")
            localData2.TerminateLocalDBConnection()
            If dt.Rows.Count > 0 Then
                Response.Write("Το περιστατικό έχει ήδη καταχωρηθεί στο ερωτηματολόγιο.")
                Response.End()
            End If
        End If
        Dim id As String() = getHospital(Request.QueryString("hosp"))
        Label24.Text = id(1)
        Dim hospId As String = id(0)
        Dim remoteData As New remoteConnection(Request.QueryString("hosp"))
        Dim remoteString As String = remoteData.getData("Select YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.LAST_NAME As ""ΕΠΩΝΥΜΟ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.FIRST_NAME As ""ONOMA"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.AMKA As ""ΑΜΚΑ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.BIRTH_DATE As ""ΗΜ. ΓΕΝΝΗΣΗΣ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.CITY_NAME As ""ΠΟΛΗ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.CITY_TX As ""ΠΕΡΙΟΧΗ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.AREA_NAME As ""ΝΟΜΟΣ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.ADDRESS As ""ΔΙΕΥΘΥΝΣΗ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.NATIONALITY_NAME As ""ΕΘΝΙΚΟΤΗΤΑ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_PATIENT.PROFESSION_NAME As ""ΕΠΑΓΓΕΛΜΑ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_VISIT.START_DT As ""ΗΜ. ΕΙΣΑΓΩΓΗΣ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_VISIT.END_DT As ""ΗΜ. ΕΞΑΓΩΓΗΣ"", " &
                                                            "YD7_" & remoteData.NOSOKOMEIO & "_PROD.VI_VISIT.INSURANCE_MAIN As ""ΑΣΦ. ΦΟΡΕΑΣ"", " &
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

            Next
        End If

        Dim localData As New localDBconnection
        Dim dt2 As DataTable = localData.getData("SELECT ΔΗΜΟΣΚΟΠΙΣΕΙΣ.ΠΕΡΙΓΡΑΦΗ, " &
                      "ΚΑΤΗΓΟΡΙΕΣ.ΠΕΡΙΓΡΑΦΗ AS ΠεριγραφΚατηγ, ΕΡΩΤΗΣΕΙΣ.ΠΕΡΙΓΡΑΦΗ AS ΠεριγραφΕρωτ, " &
                      "ΕΡΩΤΗΣΕΙΣ.ΤΥΠΟΣ, " &
                      "ΕΡΩΤΗΣΕΙΣ.[Α/Α], ΕΡΩΤΗΣΕΙΣ.ID_QUES, ΚΑΤΗΓΟΡΙΕΣ.ID_CAT " &
                      "FROM ΕΡΩΤΗΣΕΙΣ INNER JOIN  " &
                      "ΚΑΤΗΓΟΡΙΕΣ ON ΕΡΩΤΗΣΕΙΣ.ID_CAT = ΚΑΤΗΓΟΡΙΕΣ.ID_CAT INNER JOIN " &
                      "ΑΝΤΙΣΤΟΙΧΙΑ ON ΕΡΩΤΗΣΕΙΣ.ID_QUES = ΑΝΤΙΣΤΟΙΧΙΑ.ID_QUES INNER JOIN " &
                      "ΔΗΜΟΣΚΟΠΙΣΕΙΣ ON ΑΝΤΙΣΤΟΙΧΙΑ.ID_DIM = ΔΗΜΟΣΚΟΠΙΣΕΙΣ.ID_DIM " &
                      "WHERE (ΔΗΜΟΣΚΟΠΙΣΕΙΣ.ID_DIM = 1) " &
                      "ORDER BY ΚΑΤΗΓΟΡΙΕΣ.αα, ΕΡΩΤΗΣΕΙΣ.[Α/Α]")
        localData.TerminateLocalDBConnection()
        If dt2.Rows.Count > 0 Then
            Dim changeCat As String = ""
            Dim p As New Panel
            Dim t As New Table
            For f As Integer = 0 To dt2.Rows.Count - 1
                If changeCat <> dt2.Rows(f).Item("ΠεριγραφΚατηγ") Then
                    'ελεγχει καθε φορα το ονομα της κατηγοριας 
                    'δλδ αν η μεταβλητη ειναι ιδια με τη περιγραφη κατηγοριας
                    If changeCat = "" Then
                        'τη 1η φορα ισχυει
                        changeCat = dt2.Rows(f).Item("ΠεριγραφΚατηγ")
                        'βαζει στη 1η περιπτωση το ονομα της κατηγοριας 
                        Dim l As New Literal
                        l.Text = "<h3>" & dt2.Rows(f).Item("ΠεριγραφΚατηγ") & "</h3>"
                        'βαζει στο ακορντεον τη περιγραφη του
                        accordion.Controls.Add(l)
                    Else
                        changeCat = dt2.Rows(f).Item("ΠεριγραφΚατηγ")
                        'αλλαζει το ονομα της κατηγοριας, περναει στο 2ο λουπ
                        p.Controls.Add(t)
                        accordion.Controls.Add(p)
                        Dim l As New Literal
                        l.Text = "<h3>" & dt2.Rows(f).Item("ΠεριγραφΚατηγ") & "</h3>"
                        accordion.Controls.Add(l)
                        p = New Panel
                        t = New Table
                        'φτιαχνει ενα κενο πανελ και κενο πινακα 
                    End If
                End If
                If dt2.Rows(f).Item("ΤΥΠΟΣ") = 1 Then
                    'αν ειναι τυπου 1 η απαντηση του ερωτηματος
                    Dim rbl As New RadioButtonList
                    Dim dr1, dr2, dr3, dr4, dr5, dr6 As New ListItem
                    dr1.Text = "1"
                    dr2.Text = "2"
                    dr3.Text = "3"
                    dr4.Text = "4"
                    dr5.Text = "5"
                    dr6.Text = "ΔΞ/ΔΑ"
                    If Not IsPostBack Then dr6.Selected = True
                    Dim ll As New ListItem
                    ll.Text = "1"
                    rbl.Items.Add(dr1)
                    rbl.Items.Add(dr2)
                    rbl.Items.Add(dr3)
                    rbl.Items.Add(dr4)
                    rbl.Items.Add(dr5)
                    rbl.Items.Add(dr6)
                    rbl.RepeatDirection = RepeatDirection.Horizontal
                    rbl.ID = "rbl-" & dt2.Rows(f).Item("ID_QUES") & "-" & dt2.Rows(f).Item("ID_CAT")
                    Dim r1 As New TableRow
                    'κάνει ανά γραμμή γκρι τις σειρές 
                    If f Mod 2 = 0 Then r1.BackColor = Drawing.Color.LightGray
                    Dim c1, c2 As New TableCell
                    'c1.ColumnSpan = "2"
                    c1.Text = dt2.Rows(f).Item("ΠεριγραφΕρωτ")
                    c2.Controls.Add(rbl)
                    'c2.ColumnSpan = "2"
                    'c2.HorizontalAlign = HorizontalAlign.Center
                    r1.Cells.Add(c1)
                    r1.Cells.Add(c2)
                    t.Rows.Add(r1)
                    't.Rows.Add(r2)
                ElseIf dt2.Rows(f).Item("ΤΥΠΟΣ") = 2 Then
                    Dim dr As New DropDownList
                    dr.Items.Add("ΝΑΙ")
                    dr.Items.Add("ΟΧΙ")
                    dr.ID = "tf-" & dt2.Rows(f).Item("ID_QUES") & "-" & dt2.Rows(f).Item("ID_CAT")
                    Dim r As New TableRow
                    'κάνει ανά γραμμή γκρι τις σειρές 
                    If f Mod 2 = 0 Then r.BackColor = Drawing.Color.LightGray
                    Dim c1, c2 As New TableCell
                    c1.Text = dt2.Rows(f).Item("ΠεριγραφΕρωτ")
                    c2.Controls.Add(dr)
                    'If f Mod 2 = 0 Then c1.BackColor = Drawing.Color.LightGray
                    'If f Mod 2 = 0 Then c2.BackColor = Drawing.Color.LightGray
                    r.Cells.Add(c1)
                    r.Cells.Add(c2)
                    t.Rows.Add(r)
                ElseIf dt2.Rows(f).Item("ΤΥΠΟΣ") = 3 Then
                    Dim dr As New TextBox
                    dr.Width = 500
                    dr.Text = ""
                    dr.ID = "tx-" & dt2.Rows(f).Item("ID_QUES") & "-" & dt2.Rows(f).Item("ID_CAT")
                    Dim r1, r2 As New TableRow
                    If f Mod 2 = 0 Then r1.BackColor = Drawing.Color.LightGray
                    If f Mod 2 = 0 Then r2.BackColor = Drawing.Color.LightGray
                    Dim c1, c2 As New TableCell
                    c1.Text = dt2.Rows(f).Item("ΠεριγραφΕρωτ")
                    c1.ColumnSpan = "2"
                    c2.Controls.Add(dr)
                    c2.ColumnSpan = "2"
                    r1.Cells.Add(c1)
                    r2.Cells.Add(c2)
                    t.Rows.Add(r1)
                    t.Rows.Add(r2)
                End If
            Next 'Προχωραει το f κατα 1
            'βαζει στη τελευταια γραμμη 
            p.Controls.Add(t)
            accordion.Controls.Add(p)
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim localData As New localDBconnection
        For Each o As Object In accordion.Controls
            test(o, localData)
        Next
        localData.TerminateLocalDBConnection()
        Session("visitID") = ""
        Response.Redirect("peristatika.aspx?hosp=" & Request.QueryString("hosp"))
    End Sub
    Private Sub test(a As Object, localData As localDBconnection)
        If a.ToString.IndexOf("literal") < 0 Then
            For Each o As Object In a.controls
                Call test(o, localData)
            Next
        End If
        If a.id <> "" Then
            If a.id.StartsWith("tx-") Then
                ' kvdikas gia keimeno
                Dim tx As TextBox = TryCast(a, TextBox)
                If Not IsNothing(tx) Then
                    Dim idQ As String = tx.ID.Replace("tx-", "")
                    Dim l As String() = idQ.Split("-")
                    Call enhmervsh(localData, tx.Text, l(0), l(1), 3)
                End If
            ElseIf a.id.ToString.StartsWith("tf-") Then
                ' kvdikas gia truefalse
                Dim tf As DropDownList = TryCast(a, DropDownList)
                If Not IsNothing(tf) Then
                    Dim idQ As String = tf.ID.Replace("tf-", "")
                    Dim l As String() = idQ.Split("-")
                    Dim txt As String = ""
                    If tf.SelectedItem.Text = "ΝΑΙ" Then
                        txt = "ΝΑΙ"
                    ElseIf tf.SelectedItem.Text = "ΟΧΙ" Then
                        txt = "ΟΧΙ"
                    End If
                    If txt <> "" Then
                        Call enhmervsh(localData, txt, l(0), l(1), 2)
                    End If
                End If
            ElseIf a.id.StartsWith("rbl-") Then
                'kwdikas gia radiobutton
                Dim rbl As RadioButtonList = TryCast(a, RadioButtonList)
                If Not IsNothing(rbl) Then
                    Dim idQ As String = rbl.ID.Replace("rbl-", "")
                    Dim l As String() = idQ.Split("-")
                    Dim txt As String = ""
                    If rbl.Items(0).Selected Then
                        txt = "1"
                    ElseIf rbl.Items(1).Selected Then
                        txt = "2"
                    ElseIf rbl.Items(2).Selected Then
                        txt = "3"
                    ElseIf rbl.Items(3).Selected Then
                        txt = "4"
                    ElseIf rbl.Items(4).Selected Then
                        txt = "5"
                    ElseIf rbl.Items(5).Selected Then
                        txt = "-"
                    End If
                    If txt <> "" Then
                        Call enhmervsh(localData, txt, l(0), l(1), 1)
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub enhmervsh(localData As localDBconnection, apotelesma As String, idq As String, idCat As String, typos As String)
        If Not prvthForaAristera Then
            'insert ston kyrio pinaka
            'ta stoixeia tvn dhmografikvn toy
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
                localData.updateData("INSERT INTO [ΔΗΜΟΓΡΑΦΙΚΑ] ([VISIT_CODE], [PATIENT FULL NAME], " &
                                     "[ΑΜΚΑ], [ΗΜ. ΓΕΝΝΗΣΗΣ], [ΑΡ. ΤΗΛΕΦΩΝΟΥ], [ΑΡ. ΚΙΝΗΤΟΥ], [ΠΟΛΗ], " &
                                     "[ΠΕΡΙΟΧΗ], [ΝΟΜΟΣ], [ΔΙΕΥΘΥΝΣΗ], [ΕΘΝΙΚΟΤΗΤΑ], [ΕΠΑΓΓΕΛΜΑ], " &
                                     "[ΗΜ. ΕΙΣΑΓΩΓΗΣ], [ΗΜ. ΕΞΟΔΟΥ], [ΑΣΦ. ΦΟΡΕΑΣ], [ΝΟΣΟΚΟΜΕΙΟ], " &
                                     "[ΚΛΙΝΙΚΗ], [userName]) VALUES (" &
                        "'" & Session("visitID") & "', " &
                        "'" & dt1.Rows(0).Item("ΕΠΩΝΥΜΟ").ToString.Replace("'", "") & " " & dt1.Rows(0).Item("ONOMA").ToString.Replace("'", "") & "', " &
                        "'" & dt1.Rows(0).Item("ΑΜΚΑ") & "', " &
                        "'" & returnISODate(dt1.Rows(0).Item("ΗΜ. ΓΕΝΝΗΣΗΣ").ToString) & "', " &
                        IIf(dt1.Rows(0).Item("ΑΡ. ΤΗΛΕΦΩΝΟΥ") Is DBNull.Value, "NULL, ", "'" & dt1.Rows(0).Item("ΑΡ. ΤΗΛΕΦΩΝΟΥ").ToString.Replace("'", "") & "', ") &
                        IIf(dt1.Rows(0).Item("ΑΡ. ΚΙΝΗΤΟΥ") Is DBNull.Value, "NULL, ", "'" & dt1.Rows(0).Item("ΑΡ. ΚΙΝΗΤΟΥ").ToString.Replace("'", "") & "', ") &
                        IIf(dt1.Rows(0).Item("ΠΟΛΗ") Is DBNull.Value, "NULL, ", "'" & dt1.Rows(0).Item("ΠΟΛΗ").ToString.Replace("'", "") & "', ") &
                        IIf(dt1.Rows(0).Item("ΠΕΡΙΟΧΗ") Is DBNull.Value, "NULL, ", "'" & dt1.Rows(0).Item("ΠΕΡΙΟΧΗ").ToString.Replace("'", "") & "', ") &
                        IIf(dt1.Rows(0).Item("ΝΟΜΟΣ") Is DBNull.Value, "NULL, ", "'" & dt1.Rows(0).Item("ΝΟΜΟΣ").ToString.Replace("'", "") & "', ") &
                        IIf(dt1.Rows(0).Item("ΔΙΕΥΘΥΝΣΗ") Is DBNull.Value, "NULL, ", "'" & dt1.Rows(0).Item("ΔΙΕΥΘΥΝΣΗ").ToString.Replace("'", "") & "', ") &
                        IIf(dt1.Rows(0).Item("ΕΘΝΙΚΟΤΗΤΑ") Is DBNull.Value, "NULL, ", "'" & dt1.Rows(0).Item("ΕΘΝΙΚΟΤΗΤΑ").ToString.Replace("'", "") & "', ") &
                        IIf(dt1.Rows(0).Item("ΕΠΑΓΓΕΛΜΑ") Is DBNull.Value, "NULL, ", "'" & dt1.Rows(0).Item("ΕΠΑΓΓΕΛΜΑ").ToString.Replace("'", "") & "', ") &
                        "'" & returnISODate(dt1.Rows(0).Item("ΗΜ. ΕΙΣΑΓΩΓΗΣ").ToString) & "', " &
                        "'" & returnISODate(dt1.Rows(0).Item("ΗΜ. ΕΞΑΓΩΓΗΣ").ToString) & "', " &
                        IIf(dt1.Rows(0).Item("ΑΣΦ. ΦΟΡΕΑΣ") Is DBNull.Value, "NULL, ", "'" & dt1.Rows(0).Item("ΑΣΦ. ΦΟΡΕΑΣ").ToString.Replace("'", "") & "', ") &
                        "'" & Request.QueryString("hosp") & "', " &
                        IIf(dt1.Rows(0).Item("ΚΛΙΝΙΚΗ") Is DBNull.Value, "NULL, ", "'" & dt1.Rows(0).Item("ΚΛΙΝΙΚΗ").ToString.Replace("'", "") & "', ") &
                        "'" & Session("user") & "')")
            End If
            prvthForaAristera = True
        End If
        If apotelesma.Length > 400 Then apotelesma = Left(apotelesma, 400)
        localData.updateData("INSERT INTO [ΑΠΟΤΕΛΕΣΜΑΤΑ] ([VISIT_CODE], [ID_DIM], [ID_CAT], [ID_QUES], [ΑΠΟΤΕΛΕΣΜΑΤΑ], [ΤΥΠΟΣ]) VALUES (" &
        "'" & Session("visitID") & "', " &
        Session("dimoskopisiID") & ", " &
        idCat & ", " &
        idq & ", " &
        "'" & apotelesma.Replace("'", "") & "', " &
        typos & ")")
    End Sub
    Private Function returnISODate(dt As String) As String
        If IsDate(dt) Then
            Dim tmpDate As Date = CDate(dt)
            Dim y As String = tmpDate.Year
            Dim m As String = tmpDate.Month
            Dim hm As String = tmpDate.Day
            Dim h As String = tmpDate.Hour
            Dim minute As String = tmpDate.Minute
            Dim sec As String = tmpDate.Second
            Return y & "-" & m & "-" & hm & " " & h & ":" & minute & ":" & sec
        End If
        Return ""
    End Function

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim localData As New localDBconnection
        'όταν διακόπτετε η σύνδεση γυρνάει στη βάση μια απόκριση που λέει
        'Ο ασθενής απάντησε, αλλά η σύνδεση διακόπηκε
        localData.updateData("UPDATE [ΑΠΟΚΡΙΣΕΙΣ] SET [ΑΠΟΚΡΙΣΗ]='Ο ασθενής απάντησε, αλλά η σύνδεση διακόπηκε' WHERE VISIT_CODE='" & Session("visitID") & "'")
        localData.TerminateLocalDBConnection()
        Response.Redirect("peristatika.aspx?hosp=" & Request.QueryString("hosp"))
    End Sub
End Class