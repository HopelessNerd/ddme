<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" MasterPageFile="~/MasterPage.master" %>


<asp:Content ID="con1" runat="server" ContentPlaceHolderID="Con1">

    <script type="text/javascript">
        function checkpass() {
            alert("Password And Confirm Password must be same.");
        }
    </script>
    <section class="login-page">
        <div class="inner-banner demo-2 text-center">
            <header class="logo">
                <h1><a class="cd-logo link link--takiri" href="index.html">DDME <span style="margin-top: 10%">Diagnosing Diabetes Made Easy.</span></a></h1>
                px;
            </header>

            <div id="breadcrumb_wrapper">
                <div class="container">
                    <h2>Register</h2>
                    <h6></h6>
                </div>
            </div>
        </div>
        <!-- login -->
        <div class="login">
            <div class="container">
                <h3>Register Here</h3>

                <div class="login-form-grids">
                    <h5>profile information</h5>

                    <form name="Frm1" autocomplete="off" runat="server">

                        <asp:TextBox ID="txtFirstName" runat="server" placeholder="First Name..."></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFirst" ControlToValidate="txtFirstName" runat="server" ErrorMessage="First Name is  required"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="txtLastName" runat="server" placeholder="Last Name..."></asp:TextBox>

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

                        <asp:TextBox ID="txtDescription" runat="server" placeholder="Description" TextMode="MultiLine" CssClass="ddl"></asp:TextBox>

                        <h6>Login information</h6>

                        <div class="radio-inline">
                            <label>
                                <asp:RadioButton runat="server" CssClass="radio" type="radio" Text="Patient" GroupName="Role" ID="rbtnPatient" value="Patient" Checked="false" />
                                &nbsp;
                            </label>
                        </div>
                        <div class="radio-inline">
                            <label>
                                <asp:RadioButton runat="server" CssClass="radio" type="radio" Text="Doctor" GroupName="Role" ID="rbtnDoctor" value="Doctor" Checked="false" />
                                &nbsp;
                            </label>
                        </div>
                        <div class="radio-inline">
                            <label>
                                <asp:RadioButton runat="server" CssClass="radio" type="radio" Text="Pharmacist" GroupName="Role" ID="rbtnPharmacist" value="Pharmacist" Checked="false" />
                                &nbsp;
                            </label>
                        </div>
                        <asp:TextBox ID="txtEmail" runat="server" placeholder="Email Address" TextMode="Email"></asp:TextBox>


                        <asp:TextBox ID="txtPassword" runat="server"  placeholder="Password..." TextMode="Password"></asp:TextBox>
                        <asp:TextBox ID="txtxConfirmPassword" runat="server" placeholder="Confirm Password" TextMode="Password" OnTextChanged="passmatch"></asp:TextBox>



                        <div class="register-check-box">
                            <div class="check">
                                <label class="checkbox">
                                    <input type="checkbox" name="checkbox"><i> </i>I accept the terms and conditions</label>
                            </div>
                        </div>
                        <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
                    </form>
                    <h4>Already Registered</h4>
                    <p><a href="Login.aspx">Login Here</a> (or) go to <a href="Default.aspx">Home Page<span class="glyphicon glyphicon-menu-right" aria-hidden="true"></span></a></p>

                </div>
            </div>
        </div>

        <!-- //login -->
        <!--- /login ---->
    </section>
    <!-- //login-section -->
</asp:Content>
