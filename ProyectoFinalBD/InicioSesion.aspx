<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InicioSesion.aspx.cs" Inherits="ProyectoFinalBD.InicioSesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<h1>Inicio Sesion</h1>
	<br /><br /><br />
	<asp:Label runat= "server" Text="Correo:"></asp:Label>
	:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
	<asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
	<br />
	<br />
	<asp:Label runat= "server" Text="Contraseña:" ID="Label1"></asp:Label>
&nbsp;<asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
	<br /><br />
	&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
	<asp:CheckBox runat="server" Text="Recordarme" ID="recordarme" />
	<br /><br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
	<asp:Button OnClick="btnLogin_Click" runat="server" ID="btnLogin" Text="Ingresar" CssClass="btn btn-success" />
	<br /><br />
	<asp:Label runat="server" ID="mensaje" ForeColor="Green"></asp:Label>
</asp:Content>
