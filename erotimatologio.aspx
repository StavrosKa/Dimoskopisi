<%@ Page Title="Ερωτηματολόγιο" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="erotimatologio.aspx.vb" Inherits="dimoskopisi.erotimatologio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 

    <style type="text/css">
 .centered-table {
   margin-left: auto;
   margin-right: auto;

}
</style>
    
    <div style="width:100%;text-align:center">
    <%--<asp:Label ID="Label3" runat="server" Font-Bold="True" align="Left"></asp:Label>--%>
    <br/>        
    <asp:Label ID="Label24" runat="server" Font-Bold="True" align="Left"></asp:Label>
    <br/>   
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
                                <asp:Label runat="server" Text="Επάγγελμα:" Font-Bold="True"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell HorizontalAlign ="Left">
                                <asp:Label ID="Label19" runat="server"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                           <asp:TableRow>
                            <asp:TableCell HorizontalAlign ="Right">
                                <asp:Label runat="server" Text="Πόλη:" Font-Bold="True"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell HorizontalAlign ="Left">
                                <asp:Label ID="Label5" runat="server"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                       
                        <asp:TableRow>
                            <asp:TableCell HorizontalAlign ="Right">
                                <asp:Label runat="server" Text="Περιοχή:" Font-Bold="True"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell HorizontalAlign ="Left">
                                <asp:Label ID="Label6" runat="server"></asp:Label>
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
        </div>
    
  <style>
        :focus, :active { outline:0; }

        #accordion { 
            width:1000px; 
            margin:0 auto; 
            font:normal normal 13px sans-serif; 
            color:#555; 
        }
        
        #accordion h3 {
            padding:5px; 
            -webkit-border-radius:3px; 
            border-radius:3px;
            -moz-box-shadow:0 1px 4px #CCC; 
            -webkit-box-shadow:0 1px 4px #CCC; 
            box-shadow:0 1px 4px #CCC; 
            margin:3px 0; 
            cursor:pointer;
        }

        #accordion div {
            margin:0 0 0 10px; 
            padding:10px; 
            border:solid 1px #F6F6F6; 
            height:auto;
        }
    </style>
    
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
    <script src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.10.2/jquery-ui.min.js"></script>

       <div id="accordion" runat="server" ClientIDMode ="Static">
        </div>
    <script>
    $(document).ready(function() {
        // JQUERY FUNCTION.
        $("#accordion").accordion({
            heightStyle: "content"
        });
    });
    $("#accordion h3").ready(function () {
        $("#accordion h3:first").animate({ 'background-color': '#0a9fc9' }, 300);
        $("#accordion h3:first").css({ 'color': '#FFF' });
    });
    // EXPAND AND COLLAPSE MENUS ON “HEADER CLICK”
    $("#accordion h3").click(function() {
        $("#accordion h3").animate({ 'background-color': '#FFF' }, 300);
        $("#accordion h3").css({ 'color': '#000' });

        // HIGHLIGHT THE SELECTED HEADER (BLOCK)
        $(this).animate({ 'background-color': '#0a9fc9' }, 300);
        $(this).css({ 'color': '#FFF' });
    });

</script>
    <br>
    <table style="text-align: center; vertical-align: middle; width:100%">
        <tr>
            <td>
                <div style="width:100%;text-align:right">
                 <asp:Button ID="Button2" runat="server" Text="Ακύρωση"  class="btn btn-default" OnClientClick="return confirm('ΔΕΝ ΓΙΝΕΤΑΙ ΑΝΑΙΡΕΣΗ. Είστε σίγουρος ότι θέλετε να ακυρώσετε το ερωτηματολόγιο προς τον συγκεκριμένο ασθενή;');"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </div> 
            </td>
            <td>
                <div style="width:100%;text-align:left">
                   <asp:Button ID="Button1" runat="server" Text="Καταχώρηση"  class="btn btn-lg btn-primary"  OnClientClick="return confirm('ΔΕΝ ΓΙΝΕΤΑΙ ΑΝΑΙΡΕΣΗ. Είστε σίγουρος ότι έχετε πλήρως συμπληρώσει το ερωτηματολόγιο;');"/>
                </div> 
            </td>
        </tr>
    </table>   
</asp:Content>
