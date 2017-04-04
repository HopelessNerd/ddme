<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ViewPrescription.aspx.cs" Inherits="ViewPrescription" %>

<asp:Content ID="con1" runat="server" ContentPlaceHolderID="Con1">
    <style type="text/css">
        table {
            font-style: normal;
            font-family: 'Times New Roman', Times, serif;
            font-size: 20px;
        }
    </style>
    <section class="login-page">
        <div class="inner-banner demo-2 text-center">
            <header class="logo">
                <h1><a class="cd-logo link link--takiri" href="index.html">DDME <span style="margin-top: 10%">Diagnosing Diabetes Made Easy.</span></a></h1>
                px;
            </header>
            <div id="breadcrumb_wrapper">
                <div class="container">
                    <h2>View Prescription</h2>
                    <h6></h6>
                </div>
            </div>
        </div>x

        <div class="login">
            <div class="container">
                <form id="mainForm" runat="server">
                    <div class="loin-form-grids">
                        <asp:GridView ID="gvDisplayPrescriptions" runat="server" AllowPaging="false" AutoGenerateColumns="False" DataKeyNames="Id" class="table table-bordered table-hover dataTable table-striped" role="grid">
                            <Columns>
                                <asp:BoundField DataField="Patient" HeaderText="Patient" SortExpression="Patient" />
                                <asp:BoundField DataField="Doctor" HeaderText="Doctor" SortExpression="Doctor" />
                                <asp:BoundField DataField="Note" HeaderText="Note" SortExpression="Note" />
                                <asp:BoundField DataField="Prescribe" HeaderText="Prescribe" SortExpression="Prescribe" />
                                <asp:TemplateField HeaderText="Prescription File 1">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkFile1" Text="Download" CommandArgument='<%# Eval("File1") %>' runat="server" OnClick="DownloadFile"></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>                                
                                <asp:TemplateField HeaderText="Prescription File 2">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkFile1" Text="Download" CommandArgument='<%# Eval("File2") %>' runat="server" OnClick="DownloadFile"></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderStyle-Width="60">
                                    <ItemTemplate>
                                        <asp:ImageButton ID="btnSelectPrescription" OnClick="btnSelectPrescription_Click" runat="server" formnovalidate
                                            ImageUrl="images\tick.png" ToolTip="Select Prescription" CommandArgument='<%#Eval("Id")%>' />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <PagerStyle CssClass="dataTables_paginate paging_simple_numbers" />
                        </asp:GridView>
                    </div>
                </form>
            </div>
        </div>

    </section>
    <div class="clearfix"></div>

</asp:Content>

