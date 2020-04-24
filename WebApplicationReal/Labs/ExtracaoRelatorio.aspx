<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ExtracaoRelatorio.aspx.cs" Inherits="WebApplicationReal.Labs.EstracaoRelatorio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Teste Download/Gerar relatorio</h1>
    <asp:Button runat="server" OnClick="ExportListFromGridView" Text="Gerar relatório" />
    <asp:RadioButton ID="rbEmAnalise" runat="server" Text="Em Analise" AutoPostBack="true" OnCheckedChanged="rbEmAnalise_Click"></asp:RadioButton>
    <asp:RadioButton ID="rbParaAnalise" runat="server" Text="Para Analise" AutoPostBack="true" OnCheckedChanged="rbParaAnalise_Click"></asp:RadioButton>
</asp:Content>
