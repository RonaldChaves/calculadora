<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculatorTest.aspx.cs" Inherits="Test.CalculatorTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:Label ID="LblNumOne" runat="server" Text="Primeiro Número"></asp:Label>
                <asp:TextBox ID="TxtNumOne" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="LblNumTwo" runat="server" Text="Segundo Número"></asp:Label>
                <asp:TextBox ID="TxtNumTwo" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="LblOperation" runat="server" Text="Operação"></asp:Label>
                <asp:TextBox ID="TxtOperation" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="LblResult" runat="server" Text="Resultado:"></asp:Label>
                <asp:TextBox ID="TxtResult" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="Btn" runat="server" Text="Calcular" OnClick="Btn_Click" />
            </div>
        </div>
    </form>
</body>
</html>
