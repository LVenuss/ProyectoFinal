<%@ Page Title="" Language="C#" MasterPageFile="~/SiteAdmin.Master" AutoEventWireup="true" CodeBehind="AgregarProducto.aspx.cs" Inherits="ProyectoFinalBD.AgregarProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server" ID="msjPrincipal" ForeColor="Red"></asp:Label>
	<br />

	<br />
    <center>
	<h1>Agregar nuevo producto </h1>
	<table id="formulario">
		<tr>
			<td><asp:Label runat="server">IDProducto:</asp:Label></td>
			<td><asp:TextBox CssClass="form-control" runat="server" ID="txtID"></asp:TextBox></td>
			<td><asp:Label ID="msjID" runat="server"></asp:Label></td>
		</tr>
        <tr>
			<td><asp:Label runat="server">IDBodega:</asp:Label></td>
			<td><asp:TextBox CssClass="form-control" runat="server" ID="txtBodega"></asp:TextBox></td>
			<td><asp:Label ID="msjIDBo" runat="server"></asp:Label></td>
		</tr>
		<tr>
			<td><asp:Label runat="server">Nombre:</asp:Label></td>
			<td><asp:TextBox CssClass="form-control" runat="server" ID="txtNombre"></asp:TextBox></td>
			<td><asp:Label ID="msjNombre" runat="server"></asp:Label></td>
		</tr>
		<tr>
			<td><asp:Label runat="server">Marca:</asp:Label></td>
			<td><asp:TextBox CssClass="form-control" runat="server" ID="txtMarca"></asp:TextBox></td>
			<td><asp:Label ID="msjMarca" runat="server"></asp:Label></td>
		</tr>
		<tr>
			<td><asp:Label runat="server">Modelo:</asp:Label></td>
			<td><asp:TextBox CssClass="form-control" runat="server" ID="txtModelo"></asp:TextBox></td>
			<td><asp:Label ID="msjModelo" runat="server"></asp:Label></td>
		</tr>
		<tr>
			<td><asp:Label runat="server">Codigo Barras:</asp:Label></td>
			<td><asp:TextBox CssClass="form-control" runat="server" ID="txtCodigoBarra"></asp:TextBox></td>
			<td><asp:Label ID="msjCBarra" runat="server"></asp:Label></td>
		</tr>
        <tr>
			<td><asp:Label runat="server">Descripcion:</asp:Label></td>
			<td><asp:TextBox CssClass="form-control" runat="server" ID="txtDescripcion"></asp:TextBox></td>
			<td><asp:Label ID="MsjDescripcion" runat="server"></asp:Label></td>
		</tr>
        <tr>
			<td><asp:Label runat="server">Existencia:</asp:Label></td>
			<td><asp:TextBox CssClass="form-control" runat="server" ID="txtExistencia"></asp:TextBox></td>
			<td><asp:Label ID="MsjExistencia" runat="server"></asp:Label></td>
		</tr>
        <tr>
			<td><asp:Label runat="server">Precio:</asp:Label></td>
			<td><asp:TextBox CssClass="form-control" runat="server" ID="Precio"></asp:TextBox></td>
			<td><asp:Label ID="MsjPrecio" runat="server"></asp:Label></td>
		</tr>
        <tr>
			<td><asp:Label runat="server">PorcentajeIV:</asp:Label></td>
			<td><asp:TextBox CssClass="form-control" runat="server" ID="txtPorcIV"></asp:TextBox></td>
			<td><asp:Label ID="MsjPorcIV" runat="server"></asp:Label></td>
		</tr>
           <tr>
			<td><asp:Label runat="server">PorcentajeIVA:</asp:Label></td>
			<td><asp:TextBox CssClass="form-control" runat="server" ID="txtPorcIVA"></asp:TextBox></td>
			<td><asp:Label ID="MsjPorIVA" runat="server"></asp:Label></td>
		</tr>
  
          <tr>
			<td><asp:Label runat="server">PrecioVenta:</asp:Label></td>
			<td><asp:TextBox CssClass="form-control" runat="server" ID="txtPrecioVenta"></asp:TextBox></td>
			<td><asp:Label ID="MjsPrecioVenta" runat="server"></asp:Label></td>
		</tr>
    
	</table>
    </center>
    <center >
    <table>
              <tr>
			
			<asp:CheckBox ID="exento" runat="server" Text="Exento"></asp:CheckBox>
             
			<td><asp:Label ID="MsjExento" runat="server"></asp:Label></td>
		</tr>
         <tr>
		
              <asp:CheckBox ID="estado" runat="server" text="Estado"></asp:CheckBox>
             
			<td><asp:Label ID="MsjEstado" runat="server"></asp:Label></td>
		</tr>
    </table>
         </center>
         <center>
	     
	           <asp:Button runat="server" ID ="btnAgregar" CssClass="btn btn-success" Text="Agregar" OnClick="btnAgregar_Click1" />

               <asp:Button runat="server" ID ="btnModificar" CssClass="btn btn-success" Text="Modificar" OnClick="btnModificar_Click" />
        
              
        </center>
           
   <center>
        <br>
		<asp:DropDownList runat="server" CssClass="form-control" ID="ddBeb" AutoPostBack="True"></asp:DropDownList>
        <br>
    </center>
    
	<asp:GridView ID="gvProducto" runat="server" Width="1294px" AutoGenerateColumns="False" BorderStyle="Double" BorderWidth="1px" CellPadding="4" CellSpacing="4" ForeColor="Black" ToolTip="Grilla para Productos" OnSelectedIndexChanged="gvProducto_SelectedIndexChanged" BackColor="#99FF99" OnRowDeleting="gvProducto_RowDeleting">
		<Columns>
            <asp:BoundField DataField="idProducto" HeaderText="ProductoID" />
            <asp:BoundField DataField="idBodega" HeaderText="Bodega" />
            <asp:BoundField DataField="nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="marca" HeaderText="Marca" />
            <asp:BoundField DataField="modelo" HeaderText="Modelo" />
            <asp:BoundField DataField="codigoBarra" HeaderText="Codigo de Barra" />
            <asp:BoundField DataField="descripcion" HeaderText="Descripcion" />
            <asp:BoundField DataField="existencia" HeaderText="Existencia" />
            <asp:BoundField DataField="preciocompra" HeaderText="Precio Compra" />
            <asp:BoundField DataField="porcIV" HeaderText="PorcentajeIV" />
            <asp:BoundField DataField="porcIVA" HeaderText="PorcentajeIVA"></asp:BoundField>
            <asp:BoundField DataField="estado" HeaderText="Estado"></asp:BoundField>
            <asp:BoundField DataField="precioventa" HeaderText="Precio Venta"></asp:BoundField>
            <asp:BoundField DataField="excento" HeaderText="Exento"></asp:BoundField>
            <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />
            <asp:CommandField CancelText="" EditText="" InsertText="" NewText="" ShowDeleteButton="True" UpdateText="" HeaderText="Eliminar "></asp:CommandField>
        </Columns>
	    <EditRowStyle BorderColor="White" />
        <HeaderStyle BackColor="#66FF99" ForeColor="Black" />
        <RowStyle BackColor="White" />
	</asp:GridView>
    		
</asp:Content>
