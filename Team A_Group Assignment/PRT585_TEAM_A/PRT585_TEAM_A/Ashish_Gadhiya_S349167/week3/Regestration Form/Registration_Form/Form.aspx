<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="Form.Form" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <section id="main-content"> 
        <section id="wrapper">
            <div class="row">
                <div class="col-lg-12">
                    <section class="panel">
                        <header class="panel-heading">
                            <div class="col-md-4 col-md-offset-4">
                                <h1>Registration Form</h1>
                            </div>
                        </header>

                        <div class="panel-body">
                            <div class="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label Text="Student Name" runat="server" />
                                        <asp:TextBox runat="server" Enabled="true" CssClass="form-control input-sm" placeholder="Student Name" /> 
                                    </div>
                                </div>
                                 <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label Text="Father Name" runat="server" />
                                        <asp:TextBox runat="server" Enabled="true" CssClass="form-control input-sm" placeholder="Father Name" /> 
                                    </div>
                                </div>
                            </div>


                            <div class="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label Text="DOB" runat="server" />
                                        <asp:TextBox runat="server" Enabled="true" Textmode="Date" CssClass="form-control input-sm" placeholder="Date Of Birth" /> 
                                    </div>
                                </div>
                                 <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label Text="Programe" runat="server" />
                                        <asp:TextBox runat="server" Enabled="true" CssClass="form-control input-sm" placeholder="Programe" /> 
                                    </div>
                                </div>
                            </div>


                            <div class="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label Text="Region" runat="server" />
                                        <asp:DropDownList runat="server" CssClass="form-control input-sm">
                                            <asp:ListItem Text="India" />
                                            <asp:ListItem Text="USA" />
                                            <asp:ListItem Text="Iran" />
                                            <asp:ListItem Text="Iraq" />
                                            <asp:ListItem Text="China" />
                                        </asp:DropDownList>
                                        
                                    </div>
                                </div>
                                 <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label Text="Address" runat="server" />
                                        <asp:TextBox runat="server" Enabled="true" CssClass="form-control input-sm" placeholder="Address" /> 
                                    </div>
                                </div>
                            </div>


                              <div class="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label Text="Mobile No" runat="server" />
                                        <asp:TextBox runat="server" Enabled="true" Textmode="phone" CssClass="form-control input-sm" placeholder="Mobile no" /> 
                                    </div>
                                </div>
                                 <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label Text="Gender" runat="server" />
                                        <asp:RadioButtonList runat="server">
                                            <asp:ListItem Text="  Male" />
                                            <asp:ListItem Text="  Female" />
                                        </asp:RadioButtonList>
                                    </div>
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-md-8 col-md-offset-2">
                                    <asp:Button Text="SAVE" ID="btnsave" CssClass="btn btn-primary" Width="170px" runat="server" />
                                    <asp:Button Text="UPDATE" ID="Button1" CssClass="btn btn-primary" Width="170px" runat="server" />
                                    <asp:Button Text="DELETE" ID="Button2" CssClass="btn btn-danger" Width="170px" runat="server" />
                                </div>

                            </div>







                        </div>
                    </section>
                </div>
            </div>
        </section>
    </section>

</asp:Content>
