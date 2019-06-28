<%@ Page Title="" Language="C#" MasterPageFile="~/SiteAdmin.Master" AutoEventWireup="true" CodeBehind="Pedido.aspx.cs" Inherits="ProyectoFinalBD.Pedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
         <center>
             <br />
                <h1> Agregar Pedido</h1>
             <br />
         </center>
    
    <center>
       
    <table id="formulario">
		<tr>
			<td><asp:Label runat="server">IDPedido:</asp:Label></td>
			<td><asp:TextBox CssClass="form-control" runat="server" ID="tbID"></asp:TextBox></td>
			<td><asp:Label ID="msjID" runat="server"></asp:Label></td>
            
		</tr>
        <tr>
			<td><asp:Label runat="server">IDProveedor:</asp:Label></td>
           <td><asp:DropDownList runat="server" CssClass="form-control"  ID="ddProveedor" AutoPostBack="True"></asp:DropDownList></td>

			<td><asp:Label ID="msjProveedor" runat="server"></asp:Label></td>
            
		</tr>
               <tr>
			<td><asp:Label runat="server">IDProducto:</asp:Label></td>
           <td><asp:DropDownList runat="server" CssClass="form-control"  ID="ddProducto" AutoPostBack="True"></asp:DropDownList></td>

			<td><asp:Label ID="Label1" runat="server"></asp:Label></td>
            
		</tr>
		<tr>
			<td><asp:Label runat="server">IDUsuario:</asp:Label></td>
			<td><asp:TextBox CssClass="form-control" runat="server" ID="tbUsuario"></asp:TextBox></td>
			<td><asp:Label ID="msjUser" runat="server"></asp:Label></td>
            
		</tr>
		<tr>
			<td><asp:Label runat="server">Cantidad:</asp:Label></td>
			<td><asp:TextBox CssClass="form-control" runat="server" ID="tbCantidad"></asp:TextBox></td>
			<td><asp:Label ID="msjCant" runat="server"></asp:Label></td>
           
		</tr>
		<tr>
			<td><asp:Label runat="server">Total:</asp:Label></td>
			<td><asp:TextBox CssClass="form-control" runat="server" ID="tbTotal"></asp:TextBox></td>
			<td><asp:Label ID="msjTotal" runat="server"></asp:Label></td>
            <td> <asp:Button runat="server" ID ="btnCalcular" CssClass="btn btn-success" Text="Calcular" /></td>
		</tr>
        	<tr>
			<td><asp:Label runat="server">Fecha:</asp:Label></td>
			<td><asp:TextBox TextMode="Date" CssClass="form-control" runat="server" ID="txtFecha"></asp:TextBox></td>
			<td><asp:Label ID="msjFecha" runat="server"></asp:Label></td>
		</tr>
	
	</table>
        </center>
         
         <center>
             <br>
             <tr>
	    <td><asp:Button runat="server" ID ="btnAgregar" CssClass="btn btn-success" Text="Agregar" OnClick="btnAgregar_Click1" /></td>
        <td><asp:Button runat="server" ID ="btnModificar" CssClass="btn btn-success" Text="Modificar" OnClick="btnModificar_Click" /></td>
            </tr>
             </br>
        </center>
    
        <center>
            <br>
                <asp:GridView ID="gvPedido" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvPedido_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="idPedido" HeaderText="IDPedido" />
                        <asp:BoundField DataField="idProveedor" HeaderText="IDProveedor" />
                        <asp:BoundField DataField="idUsuario" HeaderText="IDUsuario" />
                        <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" />
                        <asp:BoundField DataField="Total" HeaderText="Total" />
                        <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
            </br>
        </center>
</asp:Content>
