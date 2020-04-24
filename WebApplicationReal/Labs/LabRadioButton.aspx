<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LabRadioButton.aspx.cs" Inherits="WebApplicationReal.LabRadioButton" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Teste Radio Button</h1>
    <asp:Button ID="btnListao" runat="server" OnClick="btnListao_Click" Text="Listão" />
    <asp:Button ID="btnListaoFraude" runat="server" OnClick="btnListaoFraude_Click" Text="Listão Fraude" />
    <p>
        <asp:RadioButton ID="rbEmAnalise" runat="server" Text="Em Analise" AutoPostBack="true" OnCheckedChanged="rbEmAnalise_Click"></asp:RadioButton>
        <asp:RadioButton ID="rbParaAnalise" runat="server" Text="Para Analise" AutoPostBack="true" OnCheckedChanged="rbParaAnalise_Click"></asp:RadioButton>
    </p>
    <asp:Label ID="labelTeste" Text="Texto teste" runat="server"></asp:Label>

</asp:Content>
