<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Flights.aspx.cs" Inherits="FlightApp.Flights" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Flight Entry</h1>
    <hr />
    <div class="row">
        <div class="col-md-12">
            <div class="form-group">
                <label>FlightId</label>
                <asp:TextBox ID="txtflightid" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>FlightName</label>
                <asp:TextBox ID="txtflightname" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>FlightType</label>
                <asp:TextBox ID="txtflighttype" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Country</label>
                <asp:TextBox ID="txtcountry" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-primary" OnClick="btnSave_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="btn btn-primary" OnClick="btnDelete_Click" />
            <asp:Button ID="btnReset" runat="server" Text="Reset" CssClass="btn btn-default" />
        </div>
        <div class="row">
            <div class="col-md-12 form-group">
                <asp:Label runat="server" CssClass="alert alert-success form-control" Text="" ID="lblSuccessMsg" Visible="false"></asp:Label>
                <asp:Label runat="server" CssClass="alert alert-danger form-control" Text="" ID="lblErrMsg" Visible="false"></asp:Label>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12 form-group">
                <asp:GridView ID="gvflights" runat="server" CssClass="form-control"></asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
