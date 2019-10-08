<%@ Page Title="- Promo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TP3_Garcia_Oriana._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
      
        <p class="lead">Ingresá el código de tu voucher! .</p>
         <asp:TextBox ID="TxbVoucher" runat="server" ClientIDMode="Static" class="form-control col-4" placeholder="XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"></asp:TextBox>
        <p> </p>
       <asp:Button type="button" class="btn btn-dark" ClientIDMode="Static" ID="btnVoucher" runat="server" Text="Siguiente &raquo;" />
    
    </div>
           
</asp:Content>
