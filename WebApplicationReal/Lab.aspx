<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lab.aspx.cs" Inherits="WebApplicationReal.Lab1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Lab - Matheus</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnListao" runat="server" OnClick="btnListao_Click" Text="Listão" />
            <asp:Button ID="btnListaoFraude" runat="server" OnClick="btnListaoFraude_Click" Text="Listão Fraude" />
            <p>
                <asp:RadioButton ID="rbEmAnalise" runat="server" Text="Em Analise" AutoPostBack="true" OnCheckedChanged="rbEmAnalise_Click"></asp:RadioButton>
                <asp:RadioButton ID="rbParaAnalise" runat="server" Text="Para Analise" AutoPostBack="true" OnCheckedChanged="rbParaAnalise_Click"></asp:RadioButton>
            </p>
            <asp:Label ID="labelTeste" Text="Texto teste" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
