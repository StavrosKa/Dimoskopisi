<%@ Page Title="Επιλογή Νοσοκομείου" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="nosokomeia.aspx.vb" Inherits="dimoskopisi.nosokomeia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 <br />
    <asp:Label ID="Label1" runat="server" Text="Επιλογή Νοσοκομείου" Font-Bold="True" Font-Size="Large"></asp:Label>
<!--<h4>Επιλογή Νοσοκομείου</h4>--!>

    <!-- Marketing messaging and featurettes
    ================================================== -->
    <!-- Wrap the rest of the page in another container to center all the content. -->

    <div class="container marketing">

      <!-- Three columns of text below the carousel -->
      <div class="row">
        <div class="col-lg-4 text-center">
          <img class="img-circle" src="Resources/nosokomeia/ierapetra-nosokomeio.jpg" alt="Generic placeholder image" width="140" height="140">
          <h4>Γενικό Νοσοκομείο - Κέντρο Υγείας Ιεράπετρας</h4>
          <%--<p>Donec sed odio dui. Etiam porta sem malesuada magna mollis euismod. Nullam id dolor id nibh ultricies vehicula ut id elit. Morbi leo risus, porta ac consectetur ac, vestibulum at eros. Praesent commodo cursus magna.</p>--%>
          <p><asp:Button ID="Button8" runat="server" class="btn btn-default" Text="Επιλογή &raquo;"/></p>
        </div><!-- /.col-lg-4 -->
        <div class="col-lg-4 text-center">
          <img class="img-circle" src="Resources/nosokomeia/neapolh.png" alt="Generic placeholder image" width="140" height="140">
          <h4>Γενικό Νοσοκομείο - Κέντρο Υγείας Νεάπολης</h4>
          <%--<p>Duis mollis, est non commodo luctus, nisi erat porttitor ligula, eget lacinia odio sem nec elit. Cras mattis consectetur purus sit amet fermentum. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh.</p>--%>
          <p><asp:Button ID="Button10" runat="server" class="btn btn-default" Text="Επιλογή &raquo;"/></p>
        </div><!-- /.col-lg-4 -->
        <div class="col-lg-4 text-center">
          <img class="img-circle" src="Resources/nosokomeia/nikolaos.png" alt="Generic placeholder image" width="140" height="140">
          <h4>Γενικό Νοσοκομείο Αγίου Νικολάου</h4>
          <%--<p>Donec sed odio dui. Cras justo odio, dapibus ac facilisis in, egestas eget quam. Vestibulum id ligula porta felis euismod semper. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus.</p>--%>
          <p><asp:Button ID="Button7" runat="server" class="btn btn-default" Text="Επιλογή &raquo;"/></p>
        </div><!-- /.col-lg-4 -->
      </div><!-- /.row -->
    </div>

       <!-- Marketing messaging and featurettes
    ================================================== -->
    <!-- Wrap the rest of the page in another container to center all the content. -->

    <div class="container marketing">
      <!-- Three columns of text below the carousel -->
      <div class="row">
        <div class="col-lg-4 text-center">
          <img class="img-circle" src="Resources/nosokomeia/pagnh.png" alt="Generic placeholder image" width="140" height="140">
          <h4>Πανεπιστημιακό Γενικό Νοσοκομείο Ηρακλείου</h4>
          <%--<p>Donec sed odio dui. Etiam porta sem malesuada magna mollis euismod. Nullam id dolor id nibh ultricies vehicula ut id elit. Morbi leo risus, porta ac consectetur ac, vestibulum at eros. Praesent commodo cursus magna.</p>--%>
          <p><asp:Button ID="Button1" runat="server" class="btn btn-default" Text="Επιλογή &raquo;"/></p>
        </div><!-- /.col-lg-4 -->
        <div class="col-lg-4 text-center">
          <img class="img-circle" src="Resources/nosokomeia/rethimno.png" alt="Generic placeholder image" width="140" height="140">
          <h4>Γενικό Νοσοκομείο Ρεθύμνης</h4>
          <%--<p>Duis mollis, est non commodo luctus, nisi erat porttitor ligula, eget lacinia odio sem nec elit. Cras mattis consectetur purus sit amet fermentum. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh.</p>--%>
          <p><asp:Button ID="Button4" runat="server" class="btn btn-default" Text="Επιλογή &raquo;"/></p>
        </div><!-- /.col-lg-4 -->
        <div class="col-lg-4 text-center">
          <img class="img-circle" src="Resources/nosokomeia/shteia.png" alt="Generic placeholder image" width="140" height="140">
          <h4>Γενικό Νοσοκομείο - Κέντρο Υγείας Σητείας</h4>
          <%--<p>Donec sed odio dui. Cras justo odio, dapibus ac facilisis in, egestas eget quam. Vestibulum id ligula porta felis euismod semper. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus.</p>--%>
          <p><asp:Button ID="Button9" runat="server" class="btn btn-default" Text="Επιλογή &raquo;"/></p>
        </div><!-- /.col-lg-4 -->
      </div><!-- /.row -->
    </div>

         <!-- Marketing messaging and featurettes
    ================================================== -->
    <!-- Wrap the rest of the page in another container to center all the content. -->

    <div class="container marketing">
      <!-- Three columns of text below the carousel -->
      <div class="row">
        <div class="col-lg-4 text-center">
          <img class="img-circle" src="Resources/nosokomeia/venizeleio.png" alt="Generic placeholder image" width="140" height="140">
          <h4>Γενικό Νοσοκομείο "Βενιζέλειο-Πανάνειο"</h4>
          <%--<p>Γενικό Νοσοκομείο 'Βενιζέλειο-Πανάνειο'</p>--%>
          <p><asp:Button ID="Button2" runat="server" class="btn btn-default" Text="Επιλογή &raquo;"/></p>
        </div><!-- /.col-lg-4 -->
        <div class="col-lg-4 text-center">
          <img class="img-circle" src="Resources/nosokomeia/xania.png" alt="Generic placeholder image" width="140" height="140">
          <h4>Γενικό Νοσοκομείο Χανίων "Ο Άγιος Γεώργιος"</h4>
          <%--<p>Γενικό Νοσοκομείο Χανίων "Ο Άγιος Γεώργιος"</p>--%>
          <p><asp:Button ID="Button5" runat="server" class="btn btn-default" Text="Επιλογή &raquo;"/></p>
        </div><!-- /.col-lg-4 -->
  
      </div><!-- /.row -->
    </div>
</asp:Content>
