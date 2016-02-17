<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="statistika1.aspx.vb" Inherits="dimoskopisi.statistika" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

 <%--  <div style="text-align: left">
       <h4>
       <asp:Label ID="Label2" runat="server" Text="Πίνακας Στατιστικών Στοιχείων Νο1"></asp:Label>
       </h4>
   </div>--%>
    <div style="text-align: right;width:100%">
        <table style="width:100%">
            <tr>
                <td>
                    <a href="statistika2.aspx">Εναλλακτική προβολή στατιστικών</a>
                </td>
                <td style="text-align:right">
                    <strong><asp:Label ID="Label1" runat="server" Text="Ταξινόμηση Πίνακα με βάση:"></asp:Label></strong>     
                        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" BackColor="#D1DDF5">
                        <asp:ListItem Value="0">Το Κωδικό επίσκεψης, και την κατηγορία</asp:ListItem>
                        <asp:ListItem Value="1">Την Κατηγορία και την άυξουσα αρίθμηση</asp:ListItem>
                        <asp:ListItem Value="2">Την Κατηγορία και τον κωδικό επίσκεψης</asp:ListItem>
                        <asp:ListItem Value="3">Τη χαμηλότερη βαθμολογία</asp:ListItem>
                        <asp:ListItem Value="4">Την υψηλότερη βαθμολογία</asp:ListItem>    
                        <asp:ListItem Value="5">Τη χαμηλότερη βαθμολογία και τον κωδικό επίσκεψης</asp:ListItem>
                        <asp:ListItem Value="6">Την υψηλότερη βαθμολογία και τον κωδικό επίσκεψης</asp:ListItem>  
                        <asp:ListItem Value="7">Τη χαμηλότερη βαθμολογία ,την κατηγορία και την Α/Α</asp:ListItem>
                        <asp:ListItem Value="8">Την υψηλότερη βαθμολογία ,την κατηγορία και την Α/Α</asp:ListItem> 
                    </asp:DropDownList>
                </td>
            </tr>
        </table> 
    </div> 
    <br>
    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
</asp:Content>
