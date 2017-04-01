<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Prescription.aspx.cs" Inherits="Register" MasterPageFile="~/MasterPage.master"%>


<asp:Content ID="con1" runat="server" ContentPlaceHolderID="Con1">

    <!---start-date-piker---->
								<link rel="stylesheet" href="css/jquery-ui.css" />
								<script src="js/jquery-ui.js"></script>
									<script>
										$(function() {
										$( "#datepicker" ).datepicker();
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
						<h2>Prescription Details</h2>
						<h6></h6>
					</div>
				</div>
			</div>
    			<!-- login -->
			<div class="login">
				<div class="container">
					<h3>Prescription Details</h3>
					
							<div class="login-form-grids">
                                <asp:Label runat="server">Select Patient: </asp:Label>
                                <asp:DropDownList ID="ddlPatient" runat="server"></asp:DropDownList>
									<h5> Attachments </h5>
								<form name="Frm1" runat ="server">


                                    <asp:FileUpload ID="txtattach1" runat="server" />
                                    <br />
                                    <asp:FileUpload ID="FileUpload1" runat="server" />

									
                                    
 								<h6>Details</h6>

                                    <asp:TextBox ID="txtPrescription" runat="server" placeholder="Prescription"></asp:TextBox>

                                    <asp:TextBox  TextMode="MultiLine" ID="txtNote" runat="server" CssClass="ddl" placeholder="Note">                             </asp:TextBox>
									
								
                                    <asp:Button ID="btnSubmit" runat="server" Text ="Submit" /> 

								</form>
                                	
							</div>
						</div>
						</div>
					
				<!-- //login -->
			<!--- /login ---->
		</section>
		<!-- //login-section -->


</asp:Content>