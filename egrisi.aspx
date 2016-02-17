<%@ Page Title="Στοιχεία Ασθενή" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="egrisi.aspx.vb" Inherits="dimoskopisi.egrisi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <meta name="viewport" content="width=device-width, initial-scale=1">
 
     <style type="text/css">
         .centered-table {
          margin-left: auto;
         margin-right: auto;
         }
    </style>

    <div style="width:100%;text-align:center">
    <br/> 
    <asp:Label ID="Label24" runat="server" Font-Bold="True" align ="Left"></asp:Label>
    <br/>
    <br/>
        <%--class="centered-table"--%>
    <table class="table table-striped table-bordered table-condensed">
        <tr>
            <td style="vertical-align:top">
                    <asp:Table ID="Table4" runat="server" align="right">
                        <asp:TableRow>
                            <asp:TableCell><h5>
                                <asp:Label runat="server" Text="Δημογραφικά Στοιχεία" Font-Bold="True"></asp:Label>
                          </h5>  </asp:TableCell>
                        </asp:TableRow>
                         <asp:TableRow>
                            <asp:TableCell HorizontalAlign ="Right">
                                <asp:Label runat="server" Text="Επιλεγμένος Ασθενής:" Font-Bold="True"></asp:Label>
                            </asp:TableCell>
                              <asp:TableCell  HorizontalAlign ="Left">
                                <asp:Label ID="Label23" runat="server"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell HorizontalAlign ="Right">
                                <asp:Label runat="server" Text="Ήλικία:" Font-Bold="True" align="right"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell  HorizontalAlign ="Left">
                                <asp:Label ID="Label20" runat="server"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell HorizontalAlign ="Right">
                                <asp:Label runat="server" Text="Εθνικότητα:" Font-Bold="True"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell HorizontalAlign ="Left">
                                <asp:Label ID="Label26" runat="server"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell HorizontalAlign ="Right">
                                <asp:Label runat="server" Text="Αρ. Τηλεφώνου:" Font-Bold="True"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell HorizontalAlign ="Left">
                                <asp:Label ID="Label28" runat="server"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell HorizontalAlign ="Right">
                                <asp:Label runat="server" Text="Αρ. Κιν. Τηλ.:" Font-Bold="True"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell HorizontalAlign ="Left">
                                <asp:Label ID="Label30" runat="server"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell HorizontalAlign ="Right">
                                <asp:Label runat="server" Text="Επάγγελμα:" Font-Bold="True"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell HorizontalAlign ="Left">
                                <asp:Label ID="Label19" runat="server"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table> 
            </td>
            <td style="vertical-align:top">
                   <asp:Table ID="Table5" runat="server" align="left">
                        <asp:TableRow>
                            <asp:TableCell><h5>
                                <asp:Label runat="server" Text="Στοιχεία Περιστατικού" Font-Bold="True"></asp:Label>
                           </h5> </asp:TableCell>

                            <asp:TableCell>
                                  <asp:Label ID="Label12" runat="server" Text="No" Visible="false" ></asp:Label>
                            </asp:TableCell>
                             <asp:TableCell>
                                  <asp:Label ID="Label13" runat="server" Text="No" Visible="false" ></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                         <asp:TableRow>
                            <asp:TableCell HorizontalAlign ="Right">
                                <asp:Label runat="server" Text="Κωδ. Περιστατικού:" Font-Bold="True"></asp:Label>
                            </asp:TableCell>
                             <asp:TableCell  HorizontalAlign ="Left">
                                <asp:Label ID="Label16" runat="server" ></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell HorizontalAlign ="Right">
                                <asp:Label runat="server" Text="Κλινική:" Font-Bold="True"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell  HorizontalAlign ="Left">
                                <asp:Label ID="Label2" runat="server" ></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell HorizontalAlign ="Right">
                                <asp:Label runat="server" Text="Ημ.Εισαγωγής:" Font-Bold="True"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell HorizontalAlign ="Left">
                                <asp:Label ID="Label21" runat="server" ></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell HorizontalAlign ="Right">
                                <asp:Label runat="server" Text="Ημ. Εξαγωγής:" Font-Bold="True"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell HorizontalAlign ="Left">
                                <asp:Label ID="Label22" runat="server" ></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell HorizontalAlign ="Right">
                                <asp:Label runat="server" Text="Ημ. Νοσηλείας:" Font-Bold="True"></asp:Label>
                            </asp:TableCell>
                             <asp:TableCell HorizontalAlign ="Left">
                                 <asp:Label ID="Label1" runat="server"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table> 
            </td>
        </tr>
    </table>
    <br />
       <asp:Table ID="Table2" runat="server" BackColor="white"
            BorderColor="gray"
            BorderWidth="2"  
            CellPadding="5"
            CellSpacing="1"
            GridLines="Both"
            class="centered-table" Font-Bold="False"
           > 

            <asp:TableRow ID="TableRow7" runat="server" BackColor="white">
           
                <asp:TableCell>
                    <asp:Label ID="Label7" runat="server" Text="ΑΜΚΑ" Font-Bold="True"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="Label14" runat="server" Text="ΑΣΦ.Φορέας" Font-Bold="True"></asp:Label>
                </asp:TableCell>
               <asp:TableCell>
                    <asp:Label ID="Label8" runat="server" Text="Διεύθυνση" Font-Bold="True"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="Label5" runat="server" Text="Πόλη" Font-Bold="True"></asp:Label>
                </asp:TableCell>
                 <asp:TableCell>
                    <asp:Label ID="Label6" runat="server" Text="Περιοχή" Font-Bold="True"></asp:Label>
                </asp:TableCell>
                 <asp:TableCell>
                    <asp:Label ID="Label9" runat="server" Text="Νομός" Font-Bold="True"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
           <asp:TableRow 
                ID="TableRow8" 
                runat="server" 
                BackColor="white"
                >
                <asp:TableCell>
                    <asp:Label ID="Label17" runat="server" ></asp:Label>
                </asp:TableCell>
               <asp:TableCell>
                    <asp:Label ID="Label18" runat="server" ></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="Label4" runat="server"></asp:Label>
                </asp:TableCell>
               <asp:TableCell>
                    <asp:Label ID="Label10" runat="server"></asp:Label>
                </asp:TableCell>
               <asp:TableCell>
                    <asp:Label ID="Label11" runat="server"></asp:Label>
                </asp:TableCell>
                 </asp:TableRow>
                     
        </asp:Table>
    <br/>
    <br/>
     <asp:Table ID="Table1" 
            runat="server" 
            BackColor="white"
            BorderColor="gray"
            BorderWidth="2"  
            CellPadding="5"
            CellSpacing="1"
            GridLines="Both"
          class="centered-table"
            > 

            <asp:TableRow 
                ID="TableRow1" 
                runat="server" 
                >
                <asp:TableCell HorizontalAlign="Left" BackColor="LightBlue">
                    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="patientAction" Text="&nbsp;&nbsp;Ο ασθενής δεν απάντησε" />
                </asp:TableCell>
                <asp:TableCell>
                   <img  src="Resources/smartphone90.png" style="width: 32px; height: 32px; "; />
               </asp:TableCell>
                </asp:TableRow>
           <asp:TableRow 
                ID="TableRow2" 
                runat="server" 
                BackColor="white"
                >
             
                 <asp:TableCell HorizontalAlign="Left" BackColor="LightCoral">
                     <asp:RadioButton ID="RadioButton2" runat="server"  GroupName="patientAction" Text="&nbsp;&nbsp;Ο ασθενής απάντησε, αλλά δεν ήθελε να συμμετέχει"/>
                </asp:TableCell>
               <asp:TableCell>
                   <img  src="Resources/cellphone.png" style="width: 32px; height: 32px; "; />
               </asp:TableCell>
            </asp:TableRow>

            <asp:TableRow 
                ID="TableRow3" 
                runat="server" 
                BackColor="white"
                >
                 <asp:TableCell HorizontalAlign="Left" BackColor="LightGoldenrodYellow">
                     <asp:RadioButton ID="RadioButton3" runat="server" GroupName="patientAction"  Text="&nbsp;&nbsp;Απαντήθηκε από συγγενή και ο ασθενής απουσίαζε"/>
                </asp:TableCell>
                <asp:TableCell>
                   <img  src="Resources/smartphone84.png" style="width: 32px; height: 32px; "; />
               </asp:TableCell>

            </asp:TableRow>
                    <asp:TableRow 
                ID="TableRow4" 
                runat="server" 
                BackColor="white"
                >
                 <asp:TableCell HorizontalAlign="Left" BackColor="LightGray">
                     <asp:RadioButton ID="RadioButton4" runat="server" GroupName="patientAction" Text="&nbsp;&nbsp;Λανθασμένος αριθμός τηλεφώνου" />
                </asp:TableCell>
              
               <asp:TableCell>
                   <img  src="Resources/smartphone89.png" style="width: 32px; height: 32px; "; />
               </asp:TableCell>
            </asp:TableRow>

           <asp:TableRow 
                ID="TableRow5" 
                runat="server" 
                BackColor="white"
           >
                 <asp:TableCell HorizontalAlign="Left" BackColor="LightGreen">
                     <asp:RadioButton ID="RadioButton5" runat="server" GroupName="patientAction" Text="&nbsp;&nbsp;Ο ασθενής απάντησε και θέλει να συμμετέχει"/>
                </asp:TableCell>
               <asp:TableCell>
                   <img  src="Resources/cellphone90.png" style="width: 32px; height: 32px; "; />
               </asp:TableCell>
            </asp:TableRow>

         <asp:TableRow 
                ID="TableRow6" 
                runat="server" 
                BackColor="white" 
               BorderColor="white"  
                >
             <asp:TableCell>
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:Button ID="Button1" runat="server" Text="Καταχώρηση" />
                </asp:TableCell>
             <asp:TableCell>
                
             </asp:TableCell>
             </asp:TableRow>
    </asp:Table>
</div>
    <p style="text-align:center">
        <br /><br />
            <img alt="Back" src="Resources/back.png" onclick="javascript:window.history.back()"  style="width: 32px; height: 32px; cursor:pointer;"; />
    </p>

</asp:Content>
