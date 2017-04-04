<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ViewTestResult.aspx.cs" Inherits="ViewTestResult" %>


    <asp:Content runat="server" ID="Mst1" ContentPlaceHolderID="Con1">
        
    <style type="text/css">
        table {
            font-style: normal;
            font-family: 'Times New Roman', Times, serif;
            font-size: 20px;
        }
    </style>
        <!-- login-section -->
        <section class="login-page">
            <div class="inner-banner demo-2 text-center">
                <header class="logo">
                    <h1><a class="cd-logo link link--takiri" href="index.html">DDME <span style="margin-top: 10%">Diagnosing Diabetes Made Easy.</span></a></h1>
                 
                </header>
                <div id="breadcrumb_wrapper">
                    <div class="container">
                        <h2>Test Results</h2>
                        <h6></h6>
                    </div>
                </div>
            </div>
            <!--- login ---->
            <!-- login -->
            <div class="login">
                <div class="container">                    
                <form id="mainForm" runat="server">
                    <div class="loin-form-grids">
                        <asp:GridView ID="gvDisplayResults" runat="server" AllowPaging="false" AutoGenerateColumns="False" DataKeyNames="Id" class="table table-bordered table-hover dataTable table-striped" role="grid">
                            <Columns>
                                <asp:BoundField DataField="CreationDate" HeaderText="On Date" SortExpression="CreationDate" />
                                <asp:BoundField DataField="Weight" HeaderText="Weight" SortExpression="Doctor" />
                                <asp:BoundField DataField="Height" HeaderText="Height" SortExpression="Date" />
                                <asp:BoundField DataField="IsDiagnosedWithBP" HeaderText="Is Diagnosed With BP" SortExpression="StartTime" />
                                <asp:BoundField DataField="AreRelativesDiagnosed" HeaderText="Are Relatives Diagnosed" SortExpression="EndTime" />
                                <asp:BoundField DataField="IsPhysicallyActive" HeaderText="Is Physically Active" SortExpression="IsApproved" />
                                <asp:BoundField DataField="Waist" HeaderText="Waist" SortExpression="IsApproved" />
                                <asp:BoundField DataField="Score" HeaderText="Score" SortExpression="IsApproved" />
                            </Columns>
                            <PagerStyle CssClass="dataTables_paginate paging_simple_numbers" />
                        </asp:GridView>
                    </div>
                </form>
                </div>
            </div>
        </section>
    </asp:Content>
