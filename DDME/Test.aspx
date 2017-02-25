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
									
                                    <label class="test-info">What is your gender ? <span>*</span></label>
                                    
									
                                   	
								<asp:DropDownList ID="ddlGender" runat="server" CssClass="ddl" AutoPostBack="true" OnSelectedIndexChanged="ddlGender_SelectedIndexChanged">
                                    <asp:ListItem>Select gender</asp:ListItem>
                                    <asp:ListItem Text="Male" Value="M">
                                        
                                    </asp:ListItem>
                                    <asp:ListItem Text="Female" Value="F"></asp:ListItem>
								</asp:DropDownList>

                                     <div id="divmale" runat="server" class="alert alert-danger alert-dismissable" visible="false">
                                        Males are at a higher risk for developing type 2 diabetes.
                                    </div>
                                    <div id="divfemale" runat="server" class="alert alert-info alert-dismissable" visible="false">
                                        Males are at a higher risk for developing type 2 diabetes.
                                    </div>

                                    

                                  <!-- make below question visible only if the selected gender is female-->
                               <label class="test-info"> Have you ever been diagnosed with gestational diabetes?
                                    <span>*</span></label>
                                  

								<asp:DropDownList ID="ddlfemgest" runat="server" CssClass="ddl" Visible="false">
                                    <asp:ListItem Text="Yes" Value="Y">
                                        
                                    </asp:ListItem>
                                    <asp:ListItem Text="No" Value="N"></asp:ListItem>
								</asp:DropDownList>
                                    <label class="test-info">What is Your Height? <span>*</span></label>
                                  

								<asp:DropDownList ID="ddlheight" runat="server" CssClass="ddl" AutoPostBack="true" OnSelectedIndexChanged="ddlheight_SelectedIndexChanged">
                                   
                                    
                                      <asp:ListItem Text="4' 10'" Value="410"></asp:ListItem>
                                      <asp:ListItem Text="4' 11'" Value="411"></asp:ListItem>
								</asp:DropDownList>



                                    
                                    <label class="test-info">What is Your Weight? <span>*</span></label>
                                  

								<asp:DropDownList ID="ddlWeight" runat="server" CssClass="ddl">
                                    <asp:ListItem Text="192 lb" Value="Y">
                                        
                                    </asp:ListItem>
                                    <asp:ListItem Text="124 - 147 lb" Value="N"></asp:ListItem>
								</asp:DropDownList>
                                    <div id="bminfo" runat="server" class="alert alert-info alert-dismissable" visible="false">
                                       <b> According to the World Health Organization (WHO), BMI scores of:</b><br /> 
                                        Below 18.5 = Underweight<br /> 
                                        18.5–24.9 = Normal<br /> 
                                        25.0–29.9 = Overweight/Pre-obese<br /> 
                                        30.0 and over = Obese<br /> 
                                    </div>

                                    <label class="test-info">How old are you ? <span>*</span></label>
                                    	
								<asp:DropDownList ID="ddlAge" runat="server" CssClass="ddl" AutoPostBack="True" OnSelectedIndexChanged="ddlAge_SelectedIndexChanged">
                                    <asp:ListItem Text="Less then 40" Value="40">
                                        
                                    </asp:ListItem>
                                    <asp:ListItem Text="40-49" Value="49"></asp:ListItem>
								
                                    <asp:ListItem Text="50-59" Value="59"></asp:ListItem>
								
<asp:ListItem Text="60 years or older" Value="60"></asp:ListItem>
								</asp:DropDownList>

                                     <div id="divageless" runat="server" class="alert alert-info alert-dismissable" visible="false">
                                        As you get older, your risk of developing diabetes goes up.
                                    </div>
									 <div id="divagemore" runat="server" class="alert alert-danger alert-dismissable" visible="false">
                                        As you get older, your risk of developing diabetes goes up.
                                    </div>

                                        <label class="test-info">  
                                        Do you usually do some physical activity such as brisk walking for at least 30 minutes each day?<br>
                                        (This activity can be done while at work or at home)
                                             <span>*</span></label>

								<asp:DropDownList ID="ddlphysical" runat="server" CssClass="ddl">
                                    <asp:ListItem Text="Yes" Value="Y">
                                        
                                    </asp:ListItem>
                                    <asp:ListItem Text="No" Value="N"></asp:ListItem>
								</asp:DropDownList>
                                    <div id="physical" runat="server" class="alert alert-info alert-dismissable" visible="false">
                                        Increasing physical activity is a key element in controlling weight and reducing the likelihood of developing type 2 diabetes. 
                                        Brisk walking is a great way to become more active, and every step counts.
                                        Aim for an average of 30 minutes per day, or 150 minutes per week.
                                        Consult your family doctor or health professional before increasing your physical activity level.
                                    </div>
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
                                 <div id="highbp" runat="server" class="alert alert-info alert-dismissable" visible="false">
                                       Diabetes and high blood pressure are often found together.
                                      You can decrease your risk of high blood pressure by increasing physical activity, reducing salt and fat in your diet, limiting alcohol consumption, avoiding tobacco use, reducing stress, and maintaining a healthy body weight.
                                      Many people with undiagnosed type 2 diabetes have high blood pressure. 
                                     Good control of blood pressure can substantially reduce your risk of developing complications.
                                    </div>

                           <!--         <label class="test-info">What is Your Height? <span>*</span></label>
                                  

								<asp:DropDownList ID="ddlheight1" runat="server" CssClass="ddl" AutoPostBack="true" OnSelectedIndexChanged="ddlheight_SelectedIndexChanged">
                                   
                                    
                                      <asp:ListItem Text="4' 10'" Value="410"></asp:ListItem>
                                      <asp:ListItem Text="4' 11'" Value="411"></asp:ListItem>
								</asp:DropDownList>



                                    
                                    <label class="test-info">What is Your Weight? <span>*</span></label>
                                  

								<asp:DropDownList ID="ddlWeigh1t" runat="server" CssClass="ddl">
                                    <asp:ListItem Text="192 lb" Value="Y">
                                        
                                    </asp:ListItem>
                                    <asp:ListItem Text="124 - 147 lb" Value="N"></asp:ListItem>
								</asp:DropDownList>-->
								
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
    
    <!--<script type="text/javascript">
        function showinfo()
        {
            divmale.hidden=""
        }

    </script>-->

</asp:Content>

