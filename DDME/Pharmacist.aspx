﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pharmacist.aspx.cs" Inherits="Register" MasterPageFile="~/MasterPage.master"%>


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
     <script type="text/javascript">
        function detailupdate() {
            alert("Your Details are Updated.");
            window.location.href = "Notification.aspx";
        }
    </script>

    <section class="login-page">
			<div class="inner-banner demo-2 text-center">
				<header class="logo">
				<h1><a class="cd-logo link link--takiri" href="index.html">DDME <span style="margin-top:10%">Diagnosing Diabetes Made Easy.</span></a></h1>px;
						</header>
				<div id="breadcrumb_wrapper">
					<div class="container">		
						<h2>Pharmicist Details</h2>
						<h6></h6>
					</div>
				</div>
			</div>
    			<!-- login -->
			<div class="login">
				<div class="container">
					<h3>Pharmicist
                     Details</h3>
					
							<div class="login-form-grids">
									<h5>Pharmacist information</h5>
								<form name="Frm1" runat ="server">
									
                                    <asp:TextBox ID="txtFirstName" runat="server" placeholder="First Name..." ></asp:TextBox>
                                 
								
									 <asp:TextBox ID="txtLastName" runat="server"  placeholder="Last Name..." ></asp:TextBox>
							
                        <div class="radio-inline">
                            <label>
                                <asp:RadioButton runat="server" CssClass="radio" type="radio" Text="Male" GroupName="Gender" ID="chkMale" value="Male" Checked="false" />
                                &nbsp;
                            </label>
                        </div>
                        <div class="radio-inline">
                            <label>
                                <asp:RadioButton runat="server" CssClass="radio" type="radio" Text="Female" GroupName="Gender" ID="chkFemale" value="Female" Checked="false" />
                                &nbsp;
                            </label>
                        </div>
<h6>Contact Details</h6>

                                     <asp:TextBox ID="txtPhrmacyName" runat="server" CssClass="ddl" placeholder="Pharmacy Name"></asp:TextBox>


                                    <asp:TextBox  TextMode="MultiLine" ID="txtAddress" runat="server" CssClass="ddl" placeholder="Address">



                                    </asp:TextBox>
                                     <asp:TextBox ID="txtCountry" runat="server"  placeholder="Country" ></asp:TextBox>
                                     <asp:TextBox ID="txtEmail" runat="server"  placeholder="E-mail Address" ></asp:TextBox>
								 
								  <asp:TextBox ID="txtMobile" runat="server"  placeholder="Mobile Number" ></asp:TextBox>
								 <asp:TextBox ID="txtAlternative" runat="server"  placeholder="Alternative Number" ></asp:TextBox>
								
									
								
                                    <asp:Button ID="btnSubmit" runat="server" Text ="Submit" OnClick="btnSubmit_Click" /> 

								</form>
                                	
							</div>
						</div>
						</div>
					
				<!-- //login -->
			<!--- /login ---->
		</section>
		<!-- //login-section -->


</asp:Content>