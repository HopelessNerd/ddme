<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BookAppoinment.aspx.cs" Inherits="BookAppoinment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Con1" runat="Server">
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

                        <asp:DropDownList runat="server" ID="ddlDoctor" CssClass="ddl">
                            <asp:ListItem Text="doctor1">

                            </asp:ListItem>
                            <asp:ListItem Text="doctor2">

                            </asp:ListItem>
                            <asp:ListItem Text="doctor3">

                            </asp:ListItem>

                        </asp:DropDownList>

                        <div class="clearfix"></div>
                        <label class="test-info">Select Date <span>*</span></label>
                        <input clientidmode="Static" runat="server" class="date" id="dtpAppointmentDate" type="text" value="Appointment date" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Appointment date';}" required="">

                        <div class="clearfix"></div>
                        <label class="test-info">Start TIme <span>*</span></label>

                        <asp:DropDownList runat="server" ID="ddlStartTime" CssClass="ddl">

                            <asp:ListItem Value="08:00:00">08:00</asp:ListItem>
                            <asp:ListItem Value="08:30:00">08:30</asp:ListItem>
                            <asp:ListItem Value="09:00:00">09:00</asp:ListItem>
                            <asp:ListItem Value="09:30:00">09:30</asp:ListItem>
                            <asp:ListItem Value="10:00:00">10:00</asp:ListItem>
                            <asp:ListItem Value="10:30:00">10:30</asp:ListItem>
                            <asp:ListItem Value="11:00:00">11:00</asp:ListItem>
                            <asp:ListItem Value="11:30:00">11:30</asp:ListItem>
                            <asp:ListItem Value="12:00:00">12:00</asp:ListItem>
                            <asp:ListItem Value="12:30:00">12:30</asp:ListItem>
                            <asp:ListItem Value="13:00:00">13:00</asp:ListItem>
                            <asp:ListItem Value="13:30:00">13:30</asp:ListItem>
                            <asp:ListItem Value="14:00:00">14:00</asp:ListItem>
                            <asp:ListItem Value="14:30:00">14:30</asp:ListItem>
                            <asp:ListItem Value="15:00:00">15:00</asp:ListItem>
                            <asp:ListItem Value="15:30:00">15:30</asp:ListItem>
                            <asp:ListItem Value="16:00:00">16:00</asp:ListItem>
                            <asp:ListItem Value="16:30:00">16:30</asp:ListItem>
                            <asp:ListItem Value="17:00:00">17:00</asp:ListItem>

                        </asp:DropDownList>
                        <label class="test-info">End TIme <span>*</span></label>

                        <asp:DropDownList runat="server" ID="ddlEndTime" CssClass="ddl">

                            <asp:ListItem Value="08:00:00">08:00</asp:ListItem>
                            <asp:ListItem Value="08:30:00">08:30</asp:ListItem>
                            <asp:ListItem Value="09:00:00">09:00</asp:ListItem>
                            <asp:ListItem Value="09:30:00">09:30</asp:ListItem>
                            <asp:ListItem Value="10:00:00">10:00</asp:ListItem>
                            <asp:ListItem Value="10:30:00">10:30</asp:ListItem>
                            <asp:ListItem Value="11:00:00">11:00</asp:ListItem>
                            <asp:ListItem Value="11:30:00">11:30</asp:ListItem>
                            <asp:ListItem Value="12:00:00">12:00</asp:ListItem>
                            <asp:ListItem Value="12:30:00">12:30</asp:ListItem>
                            <asp:ListItem Value="13:00:00">13:00</asp:ListItem>
                            <asp:ListItem Value="13:30:00">13:30</asp:ListItem>
                            <asp:ListItem Value="14:00:00">14:00</asp:ListItem>
                            <asp:ListItem Value="14:30:00">14:30</asp:ListItem>
                            <asp:ListItem Value="15:00:00">15:00</asp:ListItem>
                            <asp:ListItem Value="15:30:00">15:30</asp:ListItem>
                            <asp:ListItem Value="16:00:00">16:00</asp:ListItem>
                            <asp:ListItem Value="16:30:00">16:30</asp:ListItem>
                            <asp:ListItem Value="17:00:00">17:00</asp:ListItem>

                        </asp:DropDownList>
                        <asp:Button ID="btnBoookAppoinment" runat="server" Text="Book Appoinment" OnClick="btnBoookAppoinment_Click" Style="margin-left: 0%; width: 100%;" />
                    </form>

                </div>

            </div>
        </div>

    </section>

    <!-- //login-section -->

    <div class="clearfix"></div>

</asp:Content>

