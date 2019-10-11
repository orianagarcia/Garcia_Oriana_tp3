<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="PasoTres.aspx.cs" Inherits="WebApplication2.PasoTres" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="p-3 mb-2 bg-dark text-white">Promo Ganá!</h1>
    
       <div class="container">
      
        <div class="form-row">
            <div class="form-group col-md-4">
                <h2>Ingresá tus datos</h2>
            </div>
        </div>
               
        <div class="form-row">
            <div class="form-group col-md-3">
                 <asp:Label Text="DNI" ID="lblDNI" ClientIDMode="Static" runat="server" CssClass="control-label " />
                <asp:TextBox runat="server" ClientIDMode="Static" Style="margin-top: 10px;" ID="txbDNI" CssClass="form-control" />
            </div>
            <div class="form-group col-md-1">
               <asp:Button Text="Buscar" class="btn btn-dark" ClientIDMode="Static" ID="BtnBuscar" runat="server" OnClick=" BtnBuscar_click" />
           </div>
        </div>

                                 
            <div class="form-row">
            <div class="form-group col-md-3">
                <asp:Label Text="Nombre" ID="lblNombre" ClientIDMode="Static" runat="server" CssClass="control-label " />
                <asp:TextBox runat="server" ClientIDMode="Static" Style="margin-top: 10px;" ID="txbNombre" CssClass="form-control " />
           </div> 
                <div class="form-group col-md-3">      
                <asp:Label Text="Apellido" ID="lblApellido" ClientIDMode="Static" runat="server" CssClass="control-label " />
                <asp:TextBox runat="server" ClientIDMode="Static" Style="margin-top: 10px;" ID="txbApellido" CssClass="form-control " />
            </div>
                <div class="form-group col-md-3">
                <asp:Label Text="Mail" ID="Label1" ClientIDMode="Static" runat="server" CssClass="control-label " />
                <asp:TextBox runat="server" ClientIDMode="Static" Style="margin-top: 10px;" ID="txbMail" CssClass="form-control " />
            </div>
      </div>

              <div class="form-row">
            <div class="form-group col-md-3">
                <asp:Label Text="Direccion" ID="lblDireccion" ClientIDMode="Static" runat="server" CssClass="control-label " />
                <asp:TextBox runat="server" ClientIDMode="Static" Style="margin-top: 10px;" ID="txbDireccion" CssClass="form-control " />
            </div>
            <div class="form-group col-md-3">
                 <asp:Label Text="Ciudad" ID="lblCiudad" ClientIDMode="Static" runat="server" CssClass="control-label " />
                <asp:TextBox runat="server" ClientIDMode="Static" Style="margin-top: 10px;" ID="txbCiudad" CssClass="form-control " />
           </div>  
              <div class="form-group col-md-3"> 
                  <asp:Label Text="Codigo Postal" ID="lblCp" ClientIDMode="Static" runat="server" CssClass="control-label " />
                <asp:TextBox runat="server" ClientIDMode="Static" Style="margin-top: 10px;" ID="txbCp" CssClass="form-control " />
             </div>
            
      </div>   
           <p> </p>
           <div>
                  <asp:Button Text="Participar!" class="btn btn-dark" ClientIDMode="Static" ID="BtnParticipar" runat="server" OnClick="BtnParticipar_click" />
        </div>
         </div>
</asp:Content>
