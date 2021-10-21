<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="MostrarDatos.aspx.cs" Inherits="Practica_Examen_1_Ejercicio_2.MostrarDatos1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Mostrar los datos del empleado</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:HiddenField runat="server" ID="hf_Control" />                  
             <div class ="Jumbotron">

             <h3>Agregar un empleado</h3>
           
            Codigo:<asp:TextBox ID="TxtCodigo" runat="server"></asp:TextBox><br />
            Nombre:<asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox><br />
            Horas laboradas:<asp:TextBox ID="TxtHoras" runat="server"></asp:TextBox><br />
            Salario Horas:<asp:TextBox ID="TxtSalHora" runat="server"></asp:TextBox><br />
            Salario Bruto:<asp:TextBox ID="TxtSalBruto" runat="server"></asp:TextBox><br />
         
            <asp:Button ID="btn_Guardar" runat="server" Text="Guardar" OnClick="btn_Guardar_Click" /><br />
            <asp:Button ID="btn_Mostrar" runat="server" Text="Mostrar" OnClick="btn_Mostrar_Click" /><br />

                 <br />
                 <h3>Tablas de empleados</h3>
                 <asp:GridView DataKeyNames="codigo_empleado" ID="GridView1" runat="server" OnRowDataBound="GridView1_RowDataBound" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1">
                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#330099" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                <SortedAscendingCellStyle BackColor="#FEFCEB" />
                <SortedAscendingHeaderStyle BackColor="#AF0101" />
                <SortedDescendingCellStyle BackColor="#F6F0C0" />
                <SortedDescendingHeaderStyle BackColor="#7E0000" />
                 </asp:GridView>




                 <br />
                <asp:Panel ID="Panel1" runat="server" Visible="false">
                Codigo:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
                Nombre:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
                Horas laboradas:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
                Salario Horas:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
                Salario Bruto:<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
                <asp:Button ID="btn_Cerrar" runat="server" Text="Cerrar" OnClick="btn_Cerrar_Click" />
                <asp:Button ID="btn_Borrar" runat="server" Text="Borrar" OnClick="btn_Borrar_Click" />
            </asp:Panel>

        </div>
    </form>
</body>
</html>
