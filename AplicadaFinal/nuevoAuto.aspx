<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="nuevoAuto.aspx.cs" Inherits="AplicadaFinal.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="wrap">

        <div class="parte1 seccion">

			<h2>Datos del vehiculo</h2>

            <div class="btnBuscar">

    			<input type="text" placeholder="Patente" class="input">
                <a href="#" class="btnNuevoAuto">Buscar</a>

            </div>

			<input type="text" placeholder="Marca" disabled>
			<input type="text" placeholder="Modelo" disabled>
			<input type="text" placeholder="Año" disabled>

        </div>

        <div class="parte2 seccion">

        	<h2>Datos del propietarios</h2>    

            <div class="btnBuscar">

            	<input type="text" placeholder="DNI" class="input">
	            <a href="#" class="btnNuevoAuto">Buscar</a>

            </div>

        	<input type="text" placeholder="Apellido y nombre" disabled>
        	<input type="text" placeholder="Telefono" disabled>
        	<input type="text" placeholder="Mail" disabled>


        </div>

        <div class="parte3 seccion">
            
            <select name="select" id="select">
                
                <option value="servicio1">Servicio1</option> 
                <option value="servicio2">Servicio2</option>
                <option value="servicio3">Servicio3</option>

            </select>

        </div>

	     <a href="#" class="btnNuevoAuto">Generar Presupuesto</a>
    </div>

</asp:Content>
