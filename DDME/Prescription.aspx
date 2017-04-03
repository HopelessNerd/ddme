<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Prescription.aspx.cs" Inherits="Register" MasterPageFile="~/MasterPage.master" %>


<asp:Content ID="con1" runat="server" ContentPlaceHolderID="Con1">

    <!---start-date-piker---->
    <link rel="stylesheet" href="css/jquery-ui.css" />
    <script src="js/jquery-ui.js"></script>
    <script>
        $(function () {
            $("#datepicker").datepicker();
        });
    </script>
    <!---/End-date-piker---->

    <section class="login-page">
        <div class="inner-banner demo-2 text-center">
            <header class="logo">
                <h1><a class="cd-logo link link--takiri" href="index.html">DDME <span style="margin-top: 10%">Diagnosing Diabetes Made Easy.</span></a></h1>
                px;
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
                    <form name="Frm1" runat="server">

                        <asp:Label runat="server">Select Patient: </asp:Label>
                        <asp:DropDownList ID="ddlPatient" runat="server"></asp:DropDownList>
                        <br />
                        <asp:RequiredFieldValidator ID="ReqPatient" runat="server" ControlToValidate="ddlPatient" ErrorMessage="Please select Patient" ForeColor="Red"></asp:RequiredFieldValidator>
                         <br />
                        <br />
                         <h5>Attachments </h5>
                        <asp:FileUpload ID="txtattach1" runat="server" />
                        <br />
                        <asp:FileUpload ID="FileUpload1" runat="server" />



                        <h6>Details</h6>
                        <div>
                        <asp:TextBox ID="txtPrescription" runat="server" placeholder="Prescription"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtPrescription" runat="server" ErrorMessage="Field is required" ForeColor="Red"></asp:RequiredFieldValidator>
                       </div>
                        <div>
                            
                       </div>
                         <asp:TextBox TextMode="MultiLine" ID="txtNote" runat="server" CssClass="ddl" placeholder="Note">                             

                        </asp:TextBox>

                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" />

                    </form>

                </div>
            </div>
        </div>

        <!-- //login -->
        <!--- /login ---->
    </section>
    <!-- //login-section -->


</asp:Content>
