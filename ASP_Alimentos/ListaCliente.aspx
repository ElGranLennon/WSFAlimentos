<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaCliente.aspx.cs" Inherits="ASP_Alimentos.ListaCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <!-- Versión compilada y comprimida del CSS de Bootstrap -->
<link rel="stylesheet" href="//netdna.bootstrapcdn.com/bootstrap/3.1.0/css/bootstrap.min.css">
 
<!-- Tema opcional -->
<link rel="stylesheet" href="//netdna.bootstrapcdn.com/bootstrap/3.1.0/css/bootstrap-theme.min.css">
 
<!-- Versión compilada y comprimida del JavaScript de Bootstrap -->
<script src="//netdna.bootstrapcdn.com/bootstrap/3.1.0/js/bootstrap.min.js"></script>


    <asp:Panel ID="Panel1" runat="server" Height="562px" Width="1056px">
        <br />
        <asp:Button ID="btnListar" runat="server" Text="Listar" OnClick="Button1_Click" />

        <asp:GridView ID="gv1"  runat="server" Height="192px" Width="551px">
        </asp:GridView>
    
    
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"></asp:ObjectDataSource>
    
    
    </asp:Panel>

</asp:Content>




