<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Test.aspx.cs" Inherits="Test" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Con1" Runat="Server">

    	<!-- login-section -->
		<section class="login-page">
			<div class="inner-banner demo-2 text-center">
				<header class="logo">
			<h1><a class="cd-logo link link--takiri" href="index.html">DDME <span style="margin-top:10%">Diagnosing Diabetes Made Easy.</span></a></h1>px;
						</header>
				<div id="breadcrumb_wrapper">
					<div class="container">		
						<h2>Test</h2>
						<h6></h6>
					</div>
				</div>
			</div>
			<!--- login ---->
			<!-- login -->
			<div class="login">
				<div class="container">
					<h3>Help us know you better!</h3>
				
							<div class="login-form-grids">
								<form runat="server" id="Frm1">
									<label class="test-info">How old are you ? <span>*</span></label>
                                    	
								<asp:DropDownList ID="ddlAge" runat="server" CssClass="ddl">
                                    <asp:ListItem Text="Less then 40" Value="40">
                                        
                                    </asp:ListItem>
                                    <asp:ListItem Text="40-49" Value="49"></asp:ListItem>
								
                                    <asp:ListItem Text="50-59" Value="59"></asp:ListItem>
								
<asp:ListItem Text="60 years or older" Value="60"></asp:ListItem>
								</asp:DropDownList>

									<label class="test-info">Are you Man or Woman ? <span>*</span></label>
                                    
									
                                    	
								<asp:DropDownList ID="ddlGender" runat="server" CssClass="ddl">
                                    <asp:ListItem Text="Male" Value="M">
                                        
                                    </asp:ListItem>
                                    <asp:ListItem Text="Female" Value="F"></asp:ListItem>
								</asp:DropDownList>

                                    
									<label class="test-info"> Do you have a Mother, Father ,sister or brother with diabetes? <span>*</span></label>
                                  

								<asp:DropDownList ID="ddlFamily" runat="server" CssClass="ddl">
                                    <asp:ListItem Text="Yes" Value="Y">
                                        
                                    </asp:ListItem>
                                    <asp:ListItem Text="No" Value="N"></asp:ListItem>
								</asp:DropDownList>


                               <label class="test-info"> Do you ever been dignosed with Higher Blood presure? <span>*</span></label>
                                  

								<asp:DropDownList ID="ddlbp" runat="server" CssClass="ddl">
                                    <asp:ListItem Text="Yes" Value="Y">
                                        
                                    </asp:ListItem>
                                    <asp:ListItem Text="No" Value="N"></asp:ListItem>
								</asp:DropDownList>



                               <label class="test-info">Are you Physically active ? <span>*</span></label>
                                  

								<asp:DropDownList ID="ddlphysical" runat="server" CssClass="ddl">
                                    <asp:ListItem Text="Yes" Value="Y">
                                        
                                    </asp:ListItem>
                                    <asp:ListItem Text="No" Value="N"></asp:ListItem>
								</asp:DropDownList>


                                    <label class="test-info">What is Your Height? <span>*</span></label>
                                  

								<asp:DropDownList ID="ddlheight" runat="server" CssClass="ddl">
                                   
                                    
                                      <asp:ListItem Text="4' 10'" Value="N"></asp:ListItem>
                                      <asp:ListItem Text="4' 11'" Value="N"></asp:ListItem>
                                      <asp:ListItem Text="5' 1'" Value="N"></asp:ListItem>
                                      <asp:ListItem Text="5' 2'" Value="N"></asp:ListItem>
                                      <asp:ListItem Text="5' 3'" Value="N"></asp:ListItem>

                                      <asp:ListItem Text="5' 4'" Value="N"></asp:ListItem>
                                      <asp:ListItem Text="No" Value="N"></asp:ListItem>
                                      <asp:ListItem Text="No" Value="N"></asp:ListItem>
                                      <asp:ListItem Text="No" Value="N"></asp:ListItem>

                                      <asp:ListItem Text="No" Value="N"></asp:ListItem>
                                      <asp:ListItem Text="No" Value="N"></asp:ListItem>
                                      <asp:ListItem Text="No" Value="N"></asp:ListItem>
                                      <asp:ListItem Text="No" Value="N"></asp:ListItem>
                                      <asp:ListItem Text="No" Value="N"></asp:ListItem>
                                      <asp:ListItem Text="No" Value="N"></asp:ListItem>
                                      <asp:ListItem Text="No" Value="N"></asp:ListItem>
                                      <asp:ListItem Text="No" Value="N"></asp:ListItem>
                                      <asp:ListItem Text="No" Value="N"></asp:ListItem>

                                      <asp:ListItem Text="No" Value="N"></asp:ListItem>
								</asp:DropDownList>



                                    
                                    <label class="test-info">What is Your Weight? <span>*</span></label>
                                  

								<asp:DropDownList ID="DropDownList1" runat="server" CssClass="ddl">
                                    <asp:ListItem Text="192 lb" Value="Y">
                                        
                                    </asp:ListItem>
                                    <asp:ListItem Text="124 - 147 lb" Value="N"></asp:ListItem>
								</asp:DropDownList>






								
			                                    <asp:Button ID="btnResult" runat="server" Text ="Result" />
								</form>


                           
							</div>
							<h4>For New People</h4>
							<p><a href="Register.aspx">Register Here</a> (or) go to <a href="Default.aspx">Home Page<span class="glyphicon glyphicon-menu-right" aria-hidden="true"></span></a></p>
						</div>
					</div>
				<!-- //login -->
			<!--- /login ---->
		</section>


</asp:Content>

