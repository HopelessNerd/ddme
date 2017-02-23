<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BookAppoinment.aspx.cs" Inherits="BookAppoinment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Con1" Runat="Server">


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
                    
					      	<div class="modal-header">
					        	
					        	<h4 class="modal-title" id="myModalLabel">
                                    <div class="head_4">
			                         <h3>Make An appointment Now</h3>
									
			                        </div></h4>
					      	</div>
							<div class="modal-body">
								<form id="Frm1" class="register" runat="server">
                                    <asp:TextBox ID ="txtName" runat="server"  placeholder="Name"></asp:TextBox>
                                    <asp:TextBox ID ="txtPonne" runat="server"  placeholder="Phone Number"></asp:TextBox>
                                     <asp:TextBox ID ="txtEmail" runat="server"  placeholder="Email"></asp:TextBox>
                                    <asp:DropDownList runat="server" ID="ddlDoctor"  CssClass="ddl2">
                                        <asp:ListItem Text="doctor1" >

                                        </asp:ListItem>
                                         <asp:ListItem Text="doctor2" >

                                        </asp:ListItem> <asp:ListItem Text="doctor3" >

                                        </asp:ListItem>

                                    </asp:DropDownList>

	<input class="date" id="datepicker" type="text" value="Appointment date" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Appointment date';}" required=>
							<asp:DropDownList runat="server" ID="dllTime"  CssClass="ddl2">
                                        <asp:ListItem Text="9:00 am" >

                                        </asp:ListItem>
                                         <asp:ListItem Text="10:00 am" >

                                        </asp:ListItem> <asp:ListItem Text="12 am" >

                                        </asp:ListItem>

                                  	</asp:DropDownList>
                                    <asp:Button ID="btnBoookAppoinment" runat="server" Text ="Book Appoinment" />
								</form>
						
                            </div>
		                 </div>
					
		       
								
			</div>
				<!-- //login -->
			<!--- /login ---->
		</section>
		<!-- //login-section -->

    <div class="clearfix"></div>
        </section>
</asp:Content>

