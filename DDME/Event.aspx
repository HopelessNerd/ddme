<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Event.aspx.cs" Inherits="Register" MasterPageFile="~/MasterPage.master"%>


<asp:Content ID="con1" runat="server" ContentPlaceHolderID="Con1">

    <!---start-date-piker---->
								<link rel="stylesheet" href="css/jquery-ui.css" />
								<script src="js/jquery-ui.js"></script>
									<script>
										$(function() {
										$( "#txtstart" ).datepicker();
										});
										$(function () {
										    $("#txtend").datepicker();
										});
									</script>
							<!---/End-date-piker---->

    <section class="login-page">
			<div class="inner-banner demo-2 text-center">
				<header class="logo">
				<h1><a class="cd-logo link link--takiri" href="index.html">DDME <span style="margin-top:10%">Diagnosing Diabetes Made Easy.</span></a></h1>px;
						</header>
				<div id="breadcrumb_wrapper">
					<div class="container">		
						<h2>Events</h2>
						<h6></h6>
					</div>
				</div>
			</div>
    			<!-- login -->
			<div class="login">
				<div class="container">
					<h3>Genrate Events </h3>
					
							<div class="login-form-grids">
                                 
									<h5> Event Details </h5>
								<form name="Frm1" runat ="server">

                                     <asp:Label runat="server">Select Patient: </asp:Label>
                               
                                     <asp:DropDownList ID="ddlPatient" runat="server" CssClass="ddl"></asp:DropDownList>
                                    <asp:TextBox ID="txtEventName" runat="server" placeholder="Event Name"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="txtEvnt" runat="server" ControlToValidate="txtEventName" ErrorMessage="This field is required." ForeColor="Red"></asp:RequiredFieldValidator>
                                    <asp:TextBox ID="txtDetail" runat="server" placeholder="Details" TextMode="MultiLine" CssClass="ddl"></asp:TextBox>
                                    
                        			
 <input class="date" id="txtstart" type="text" placeholder="Start Date" required="required" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '';}" >
			 
                         <input class="date" id="txtend" type="text" placeholder="End Date" required="required" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '';}">
		

	<asp:Button ID="btnSubmit" runat="server" Text ="Create" /> 

								</form>
                                	
							</div>
						</div>
						</div>
					
				<!-- //login -->
			<!--- /login ---->
		</section>
		<!-- //login-section -->


</asp:Content>