<%@ Page Title="Calculator" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="WebForms.Calculator" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="panel1" runat="server">
        <ContentTemplate>
            <br />
            <asp:TextBox ID="TxtResult" runat="server" Width="256px" Height="37px" BackColor="#FFFF99" BorderColor="Black"></asp:TextBox>
            <asp:Label ID="LblOperation" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <table style="width: 100%;">
                <tr>
                    <td>
                        <asp:Button ID="BtnSeven" runat="server" Text="7" OnClick="BtnSeven_Click" Height="45px" Width="61px" />
                        <asp:Button ID="BtnEight" runat="server" Text="8" OnClick="BtnEight_Click" Height="45px" Width="61px" />
                        <asp:Button ID="BtnNine" runat="server" Text="9" OnClick="BtnNine_Click" Height="45px" Width="61px" />
                        <asp:Button ID="BtnSum" runat="server" Text="+" OnClick="BtnSum_Click" Height="45px" Width="61px" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="BtnFour" runat="server" Text="4" OnClick="BtnFour_Click" Height="45px" Width="61px" />
                        <asp:Button ID="BtnFive" runat="server" Text="5" OnClick="BtnFive_Click" Height="45px" Width="61px" />
                        <asp:Button ID="BtnSix" runat="server" Text="6" OnClick="BtnSix_Click" Height="45px" Width="61px" />
                        <asp:Button ID="BTnSub" runat="server" Text="-" OnClick="BtnSub_Click" Height="45px" Width="61px" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="BtnOne" runat="server" Text="1" OnClick="BtnOne_Click" Height="45px" Width="61px" />
                        <asp:Button ID="Btntwo" runat="server" Text="2" OnClick="BtnTwo_Click" Height="45px" Width="61px" />
                        <asp:Button ID="BtnThree" runat="server" Text="3" OnClick="BtnThree_Click" Height="45px" Width="61px" />
                        <asp:Button ID="BtnMult" runat="server" Text="x" OnClick="BtnMult_Click" Height="45px" Width="61px" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="BtnZero" runat="server" Text="0" OnClick="BtnZero_Click" Height="45px" Width="126px" />
                        <asp:Button ID="BtnPoint" runat="server" Text="." OnClick="BtnPoint_Click" Height="45px" Width="61px" />
                        <asp:Button ID="BtnDiv" runat="server" Text="÷" OnClick="BtnDiv_Click" Height="45px" Width="61px" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="BtnEqual" runat="server" Text="=" OnClick="BtnEqual_Click" Height="45px" Width="256px" BackColor="#FFFF99" BorderColor="Black" ForeColor="Black" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="BtnCE" runat="server" Text="CE" OnClick="BtnCE_Click" Height="45px" Width="126px" BackColor="Gray" BorderColor="Black" ForeColor="Black" />
                        <asp:Button ID="BtnC" runat="server" Text="C" OnClick="BtnC_Click" Height="45px" Width="126px" BackColor="Gray" BorderColor="Black" ForeColor="Black" />
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
    <script type="text/javascript" src="Scripts/Calculator.js"></script>
</asp:Content>