<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BookAppoinment.aspx.cs" Inherits="BookAppoinment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Con1" Runat="Server">
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
						<h2>Book Appoinment</h2>
						<h6></h6>
					</div>
				</div>
			</div>

    	



            <div class="login">
				<div class="container">
					<h3>Book Your Appoinment</h3>
					
							<div class="login-form-grids">
								<form runat="server" id="Form1">
									<label class="test-info">Select Doctor <span>*</span></label>
									
                                      <asp:DropDownList runat="server" ID="DropDownList1"  CssClass="ddl">
                                        <asp:ListItem Text="doctor1" >

                                        </asp:ListItem>
                                         <asp:ListItem Text="doctor2" >

                                        </asp:ListItem> <asp:ListItem Text="doctor3" >

                                        </asp:ListItem>

                                    </asp:DropDownList>
                                    
                                    									<div class="clearfix"></div>
									<label class="test-info">Select Date <span>*</span></label>
                                        <input class="date" id="datepicker" type="text" value="Appointment date" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Appointment date';}" required="">
						
									<div class="clearfix"></div>
                                    <label class="test-info">Start TIme <span>*</span></label>
                                       
                                     	<asp:DropDownList runat="server" ID="dllTime"  CssClass="ddl">
                                        <asp:ListItem Text="9:00 am" >

                                        </asp:ListItem>
                                         <asp:ListItem Text="10:00 am" >

                                        </asp:ListItem> <asp:ListItem Text="12 am" >

                                        </asp:ListItem>

                                  	</asp:DropDownList>
                                    <label class="test-info">End TIme <span>*</span></label>
                                       
                                     	<asp:DropDownList runat="server" ID="DropDownList2"  CssClass="ddl">
                                        <asp:ListItem Text="9:00 am" >

                                        </asp:ListItem>
                                         <asp:ListItem Text="10:00 am" >

                                        </asp:ListItem> <asp:ListItem Text="12 am" >

                                        </asp:ListItem>

                                  	</asp:DropDownList>
                                 

                                        <asp:Button ID="btnBoookAppoinment" runat="server" Text ="Book Appoinment"  style="margin-left:0%;width:100%;"/>
								</form>
						
							</div>

	</div>
		</div>

        </section>
		
		<!-- //login-section -->

    <div class="clearfix"></div>

</asp:Content>

