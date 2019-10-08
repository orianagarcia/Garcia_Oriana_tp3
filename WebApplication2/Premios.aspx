<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Premios.aspx.cs" Inherits="WebApplication2.Premios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


        <h1 class="p-3 mb-2 bg-dark text-white">Promo Ganá!</h1>

    <h2 class="text-center">Elegí tu Premio!</h2>
    <style>
        .card:hover {
            box-shadow: 1px 8px 20px grey;
            -webkit-transition: box-shadow .12s ease-in;
        }
    </style>

   <div class="card-columns" style="margin-left: 10px; margin-right: 10px;">
       
        <p></p>
        <p></p>
        <% foreach (var item in listar)
            { %>

        <div class="card">
            <img src="<% = item.urlImagen%>" class="card-img-top" alt="...">
            <div class="card-body">
                <h5 class="card-title"><% = item.nombre %></h5>
                <p class="card-text"><% = item.descripcion %></p>
            </div>
               <a href="PasoTres.aspx?valor=<%= item.id%>" class="btn btn-dark" ID="btnSeleccionar" style="cursor: pointer">Seleccionar</a>
        </div>
        <% } %>
    </div>



</asp:Content>
