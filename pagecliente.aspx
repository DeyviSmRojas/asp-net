<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="pagecliente.aspx.cs" Inherits="primerAplicaciom.pagecliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   

    

   

    <table style="width: 100%">
        <tr>
            <td colspan="3" style="height: 27px">
                <h1>
                    Clientes
                </h1>
            </td>
        </tr>
        <tr>
            <td rowspan="5" style="width: 9px">
                
                <img alt="cli" src="cliente.jpg" style="width: 256px; height: 256px" /></td>
            
            <td>
                <asp:Label ID="Label1" runat="server" Text="Id Cliente "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtcliente" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Direccion"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtdireccion" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 30px">
                <asp:Label ID="Label4" runat="server" Text="Telefono"></asp:Label>
            </td>
            <td style="height: 30px">
                <asp:TextBox ID="txttelefono" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblestado" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Button ID="btnagregar" runat="server" Text="Agregar" OnClick="btnagregar_Click" />
            </td>
        </tr>
    </table>

   

    

   

</asp:Content>
