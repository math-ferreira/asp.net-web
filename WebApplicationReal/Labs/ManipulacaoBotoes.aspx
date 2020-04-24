<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManipulacaoBotoes.aspx.cs" Inherits="WebApplicationReal.Labs.ManipulacaoBotoes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
        function functionBtn3() {
            alert("Voce clicou no botão 3! integração entre .cs e .js");
        }

        function functionBtn4() {
            console.log("Teste function 4");
            var v = document.getElementById("<%=btn4.ClientID%>");
            v.style.backgroundColor = "red";
            return false; //return false to block webpage refresh
        }
    </script>

    <h1>Teste Botões</h1>
    <asp:Button ID="btn1" ForeColor="black" runat="server" OnClick="btn1_Click" Text="Botão 1 - via .cs" /><p></p>
    <asp:Button ID="btn2" ForeColor="black" runat="server" OnClick="btn2_Click" Text="Botão 2 - via .cs" /><p></p>
    <asp:Button ID="btn3" ForeColor="black" runat="server" OnClick="btn3_Click" Text="Botão 3 - via .cs e .js" /><p></p>
    <asp:Button ID="btn4" ForeColor="black" runat="server" OnClientClick="return functionBtn4()" Text="Botão 4 - via .js" /><p></p>
</asp:Content>
