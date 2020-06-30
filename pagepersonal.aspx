<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="pagepersonal.aspx.cs" Inherits="pagepersonal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   

    <br />
   

    <table style="width: 100%">
        <tr>
            <td colspan="3">
            <h1>
                Personal SABSA
            </h1>    
            </td>
        </tr>
        <tr>
            <td rowspan="12" style="width: 143px">
                <img alt="rrhh" src="rrhh.jpg" style="width: 333px; height: 342px" /></td>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Id Personal"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtpersonal" runat="server"></asp:TextBox>
                <asp:Button ID="btnbuscar" runat="server" OnClick="btnbuscar_Click" Text="Buscar" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Monbres"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="ApePaterno"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtapepaterno" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="ApeMaterno"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtapematerno" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="CI"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtci" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="FchaNacimiento"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtfchanacimiento" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Sexo"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtsexo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Nacionalidad"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtnacionalidad" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label9" runat="server" Text="EstadoCivil"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtestadocivil" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label10" runat="server" Text="Email"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label11" runat="server" Text="Codigo"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtcodigo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label12" runat="server" Text="Estado"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtestado" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 143px">&nbsp;</td>
            <td>
                <asp:Label runat="server" Text="Direccion"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtdireccion" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 143px">&nbsp;</td>
            <td>
                <asp:Label ID="Label14" runat="server" Text="Telefono"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txttelefono" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 143px">&nbsp;</td>
            <td>
                <asp:Label ID="Label15" runat="server" Text="Dias de vacacion:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDiasVacacion" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 143px">
                <asp:Label ID="lblestado" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnagregar" runat="server" Text="Agregar" OnClick="btnagregar_Click" />
                <asp:Button ID="btneliminar" runat="server" OnClick="btneliminar_Click" Text="Eliminar" />
                <asp:Button ID="btnlimpiar" runat="server" OnClick="btnlimpiar_Click" Text="Limpiar" />
            </td>
        </tr>
    </table>
   

</asp:Content>

