<%@ Page Title="Αρχική" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="dimoskopisi._Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<style type="text/css">
 h1 {
     color: #03C462;font-weight: 300;
}
 h3{
     color: #AAA;
 }
  .centered-table {
      width:6em;
   margin-left: 110px;
   margin-right: auto;
}  
  IMG.displayed {
    display: block;
    margin-left: auto;
    margin-right: auto }  
</style>
    
<div class="jumbotron text-center" style="padding-top: 10px; padding-bottom: 10px; margin-right: 80px;margin-left: 80px;">
    <IMG class="displayed" src="Resources/chart.png" style="width: 112px; height: 102px;"; />
  <h3>Καλωσήρθατε στην πλατφόρμα αξιολόγησης ασθενών</h3> 
  <p>στα Νοσοκομεία Κρήτης</p> 
</div>
    <!-- CSS στατιστικών και εν μέρη της εισόδου -->
    <style>
        .bg-grey {
        background-color: #f6f6f6;
        }
        .container-fluid {
            padding: 60px 50px;
        }
        /*το χρώμα του πινακίου των στατιστικών*/
        .logo {
       font-size: 200px;
       color: #67b983;
       text-shadow: 2px 2px 4px #696969;
        }
        @media screen and (max-width: 768px) {
        .col-sm-4 {
        text-align: center;
        margin: 25px 0;
        }
        .logo-small {
        color: #2086a2;
        font-size: 50px;
        }
        }
    </style>

       <script src="js/ie-emulation-modes-warning.js"></script>
        <link href="Content/signin.css" rel="stylesheet">
    
        <div class="container text-center" style="width:35%">  
             <h3 class="form-signin-heading text-left">Είσοδος στην πλατφόρμα</h3>
             <label for="inputEmail" class="sr-only">Όνομα χρήστη</label>
              <input runat="server" type="text" id="inputUserName" class="form-control" maxlength="50" placeholder="Όνομα χρήστη" autofocus>
              <label for="inputPassword" class="sr-only">Κωδικός</label>
              <input runat="server" type="password"  maxlength="50" id="inputPassword" class="form-control" placeholder="Κωδικός">
            <br />
        <button runat="server" id="button2" class="btn btn-lg btn-primary btn-block" type="submit" style="width:100%">Πιστοποίηση</button>    
            <div>
                <asp:Label ID="LabelErr" runat="server" Text="Λάθος όνομα χρήστη ή κωδικού πρόσβασης" ForeColor ="Red" Visible="false"></asp:Label>
            </div>
     </div> 
    <br />

    <!--Στατιστικό πανελάκι όμορφο-->

<div id="about" class="container-fluid bg-grey">
  <div class="row">
    <div class="col-sm-8">
      <h2>ΑΝΑΛΥΣΗ ΕΡΩΤΗΜΑΤΟΛΟΓΙΟΥ</h2>
      <h4>Το ερωτηματολόγιο που χρησιμοποιήθηκε πήρε την τελική του μορφή αφού συμπληρώθηκε σε μια πιλοτική έρευνα από φοιτητές που συμμετείχαν.</h4> 
<p><strong>Απαραίτητες προϋποθέσεις για τη σωστή χρήση των ερωτηματολογίων σε μία έρευνα αποτελούν:</strong></p>
<ul>
<li>Ο σωστός σχεδιασμός του ερωτηματολογίου</li>
<li>Η στάθμιση και ο έλεγχος της εγκυρότητας του ερωτηματολογίου</li>
<li>Η σωστή κωδικοποίηση των πληροφοριών που καταγράφει το ερωτηματολόγιο</li>
<li>Η καταχώρηση των πληροφοριών σε κατάλληλα σχεδιασμένη βάση δεδομένων</li>
<li>Η στατιστική επεξεργασία του ερωτηματολογίου</li>
</ul>      <a href="About.aspx" class="btn btn-default btn-lg" role="button">Περισσότερα</a>
    </div>
    <div class="col-sm-4">
      <span class="glyphicon glyphicon-signal logo"></span>
    </div>
  </div>
</div>

    <!--Καρουζελάκι όμορφο-->
    				
        <h2>&nbsp &nbsp &nbsp ΜΕ ΤΗ ΣΥΝΕΡΓΑΣΙΑ</h2>	
						<!----sreen-gallery-cursual---->
						<div class="sreen-gallery-cursual">
							 <!-- requried-jsfiles-for owl -->
							<link href="Content/owl.carousel.css" rel="stylesheet">
							    <script src="js/owl.carousel.js"></script>
							        <script>
							    $(document).ready(function() {
							      $("#owl-demo").owlCarousel({
							        items : 2,
							        lazyLoad : true,
							        autoPlay : true,
							      });
							    });
							    </script>
							 <!-- //requried-jsfiles-for owl -->
					</div>                     
				<!--//screen-shot-gallery---->
			 <!----people-says----->
					<div class="test-monials text-center">
						<div class="container">
							<span><img src="Resources/carousel/icon1.png" title="quit"/></span>
						<script>
							    $(document).ready(function() {
							      $("#owl-demo1").owlCarousel({
							        items : 1,
							        lazyLoad : true,
							        autoPlay : true,
							        itemsDesktop : 2,
							      });
							    });
						 </script>
						<div id="owl-demo1" class="owl-carousel">
					       <div class="item">
					          <p>Η Διεύθυνση πληροφορικής της 7ης Υγειονομικής Περιφέρειας, από το 2002, σχεδιάζει, αναπτύσσει και προσπαθεί, προς την κατεύθυνση της ενσωμάτωσης της πληροφορικής στο χώρο της υγείας. Έτσι, συμμετείχε και βοήθησε πολλές καινοτόμες δράσεις, ώστε να θεωρείται η Κρήτη από τις υγειονομικές περιφέρειες, με τη μεγαλύτερη εξάπλωση πληροφοριακών συστημάτων στην Ελλάδα.</p>
					     		<div class="quit-people">
					     			<img src="Resources/carousel/logo-ype.jpg" title="name" style="box-shadow: 3px 3px 4px #fffcb2;" />
					     			<h4 style="margin-top: 20px;margin-bottom: 20px;"><a href="http://www.hc-crete.gr/"> 7η Υγειονομική Περιφέρεια Κρήτης</a></h4>
					     			<strong><span>Διεύθυνση Πληροφορικής</span></strong>
					     		</div>
					       </div>
					        <div class="item">
					          <p>Βασιζόμενο στο παρελθόν στρέφεται στο μέλλον με σκοπό την εκπαίδευση των φοιτητών, την παραγωγή νέας γνώσης μέσω της έρευνας, την αλληλεπίδραση με την τοπική κοινωνία προς αμοιβαία ωφέλεια, την συνεργασία με άλλα εκπαιδευτικά ιδρύματα για την βελτίωση και προώθηση του εκπαιδευτικού και ερευνητικού έργου.</p>
					     		<div class="quit-people">
					     			<img src="Resources/carousel/teicrete_logo_small_nutral.png" title="name" />
					     			<h4 style="margin-top: 20px;margin-bottom: 20px;"><a href="https://www.teicrete.gr/nosil/el/node/184"> Τμήμα Νοσηλευτικής</a></h4>
					     			<strong><span>ΤΕΙ Κρήτης</span></strong>
					     		</div>                        
					       </div>					      
				         </div>
				         </div>
					</div>
				<!----//people-says----->	

    <!-- Επικοινωνία όμορφη -->

    <div id="contact" class="container-fluid bg-grey">
  <h2 class="text-center">ΕΠΙΚΟΙΝΩΝΙΑ</h2>
  <div class="row">
    <div class="col-sm-5">
      <p>Επικοινωνήστε μαζί μας και θα λάβετε άμμεση ανταπόκριση μέσα σε 24 ώρες.</p>
      <p><span class="glyphicon glyphicon-map-marker"></span> Σμύρνης 26, ΤΚ 71201, Τ.Θ. 1285, Ηράκλειο Κρήτης</p>
      <p><span class="glyphicon glyphicon-phone"></span> +30-2813 404400</p>
      <p><span class="glyphicon glyphicon-envelope"></span> info@hc-crete.gr</p> 
    </div>
    <div class="col-sm-7">
      <div class="row">
        <div class="col-sm-6 form-group">
          <input runat="server" class="form-control" id="name" name="name" placeholder="Όνομα" type="text">
        </div>
        <div class="col-sm-6 form-group">
          <input runat="server" class="form-control" id="email" name="email" placeholder="Email" type="email" >
        </div>
      </div>
      <textarea runat="server" class="form-control" id="comments" name="comments" placeholder="Σχόλια" rows="5"></textarea><br>
      <div class="row">
        <div class="col-sm-12 form-group">
          <button class="btn btn-default pull-right" type="submit">Αποστολή</button>
        </div>
        <div style="color:white; display:none" id="contactMsg" runat="server">Το μήνυμα σας έφυγε!! Σας ευχαριστούμε...</div>
      </div> 
    </div>
  </div>
</div>	

</asp:Content>
