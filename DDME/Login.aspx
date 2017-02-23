<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login"  MasterPageFile="~/MasterPage.master"%>


<asp:Content runat="server" ID ="Mst1" ContentPlaceHolderID="Con1">    
	<!-- login-section -->
		<section class="login-page">
			<div class="inner-banner demo-2 text-center">
				<header class="logo">
					<h1><a class="cd-logo link link--takiri" href="index.html">DDME <span style="margin-top:10%">Diagnosing Diabetes Made Easy.</span></a></h1>px;
				</header>
				<div id="breadcrumb_wrapper">
					<div class="container">		
						<h2>Login</h2>
						<h6></h6>
					</div>
				</div>
			</div>
			<!--- login ---->
			<!-- login -->
			<div class="login">
				<div class="container">
					<h3>Login Here</h3>
					
							<div class="login-form-grids">
								<form runat="server" id="Frm1">
									<label class="test-info">User Name <span>*</span></label>
									
                                    <asp:TextBox ID ="txtUserName" runat="server" placeholder="Enter Email.. "></asp:TextBox>
									<div class="clearfix"></div>
									<label class="test-info">Password <span>*</span></label>
									 <asp:TextBox ID ="txtPassword" runat="server" placeholder="Enter Password" TextMode="Password"    ></asp:TextBox>
									<div class="clearfix"></div>
									<div class="forgot">
										<a href="#">Forgot Password?</a>
									</div>
			                                    <asp:Button ID="btnLogin" runat="server" Text ="Login" />
								</form>
							</div>
							<h4>For New People</h4>
							<p><a href="Register.aspx">Register Here</a> (or) go to <a href="Default.aspx">Home Page<span class="glyphicon glyphicon-menu-right" aria-hidden="true"></span></a></p>
						</div>
					</div>
				<!-- //login -->
			<!--- /login ---->
		</section>
		<!-- //login-section -->
    </asp:Content>