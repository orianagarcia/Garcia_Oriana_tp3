<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Voucher.aspx.cs" Inherits="WebApplication2.Voucher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="p-3 mb-2 bg-dark text-white">Promo Ganá!</h1>

       <div class="jumbotron">
      
        <p class="lead">Ingresá el codigo del voucher! </p>
         <asp:TextBox ID="txbVoucher" runat="server" ClientIDMode="Static" class="form-control col-4" placeholder="XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"></asp:TextBox>
        <p> </p>
       <asp:Button type="button" class="btn btn-dark" ClientIDMode="Static" ID="BtnVoucherAceptar" runat="server" Text="Siguiente &raquo;" OnClick="BtnVoucherAceptar_Click" OnClientClick= "" />
    
    </div>
           

</asp:Content>
