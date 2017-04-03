<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Notification.aspx.cs" Inherits="Notification" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Con1" Runat="Server">
  
    	<section class="login-page">
			<div class="inner-banner demo-2 text-center">
				<header class="logo">
				<h1><a class="cd-logo link link--takiri" href="index.html">DDME <span style="margin-top:10%">Diagnosing Diabetes Made Easy.</span></a></h1>px;
					</header>
				<div id="breadcrumb_wrapper">
					<div class="container">		
						<h2>Events</h2>
						<h6></h6>
					</div>
				</div>
			</div>

            
            <div class="login">
				<div class="container" style="font-size : 20px;">
                    <form id="frm" runat="server">
                
                    <asp:GridView ID="gvDisplayAppointments" runat="server" AllowPaging="false" AutoGenerateColumns="False" DataKeyNames="Id" class="table table-bordered table-hover dataTable table-striped" role="grid">
                            <Columns>
                                <asp:BoundField DataField="Name" HeaderText="Doctor" SortExpression="Doctor" />
                                <asp:BoundField DataField="Detail" HeaderText="Date" SortExpression="Date" />
                                <asp:BoundField DataField="StartTime" HeaderText="Start Date" SortExpression="StartTime" />
                                <asp:BoundField DataField="EndTime" HeaderText="End Date" SortExpression="EndTime" />
                              
                                <asp:TemplateField HeaderStyle-Width="60">
                                    <ItemTemplate>
                                        <asp:ImageButton ID="btnSelectAppointment" OnClick="btnSelectAppointment_Click" runat="server" formnovalidate
                                            ImageUrl="images\tick.png" ToolTip="Select Family" CommandArgument='<%#Eval("Id")%>' />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <PagerStyle CssClass="dataTables_paginate paging_simple_numbers" />
                        </asp:GridView>
                     
                    
                    </form>
                    
                      </div>

            </div>

</section>
						  

</asp:Content>

