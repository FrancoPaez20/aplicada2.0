<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="AplicadaFinal.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="login">

        <h2>Iniciar Sesion</h2>

        <div class="form">

            <input type="text" placeholder="Usuario o correo electronico"/>
            <input type="password" placeholder="Contraseña"/>

        </div>

        <a href="#" class="btnLogin">Acceder</a>

    </div>

</asp:Content>
