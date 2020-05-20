<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="northwindWeb.Customer" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<h3>Maestro customers </h3>
    <a id="myBtn" class="btn btn-primary">Agregar</a>
      <!-- Modal -->
<div class="cmxform" id="commentForm">
  <div class="modal fade" id="myModal" role="dialog">
    <div class="modal-dialog">    
      <!-- Modal content-->
      <div class="modal-content">
        <div class="modal-header">
          <button type="button" class="close" data-dismiss="modal">&times;</button>
          <h4 class="modal-title">Registrar customer</h4>
        </div>
        <div class="modal-body">
            <div class="block">
                <label>FirstName</label>
                <input  type="text" class="addCustomer" />
            </div>
            <div class="block">
                <label>LastName</label>
                <input type="text" class="addCustomer" />
            </div>
            <div class="block">
                <label>City</label>
                <input type="text" class="addCustomer" />
            </div>
            <div class="block">
                <label>Country</label>
                <input type="text" class="addCustomer" />
             </div>
            <div class="block">
                <label>Phone</label>
                <input type="text" class="addCustomer" />
             </div>
        </div>
        <div class="modal-footer">
          <button id="btnGuardar" type="button" class="btn btn-primary">Guardar</button>
          <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>
        </div>
      </div>      
    </div>
  </div>
</div>
    <div style="width: 100%; height: 400px; overflow: scroll">
        <asp:GridView ID="dgvcustomer" runat="server" Class="GridViewContainer table table-striped table-bordered"  AllowPaging="True" AllowSorting="True" >
        <HeaderStyle CssClass="GVFixedHeader" Height="30px" BackColor="#6DC2FF" Font-Size="12px" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" />
        <RowStyle Height="20px" Font-Size="12px" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"/>
        <AlternatingRowStyle CssClass="odd"/>
        </asp:GridView>
    </div>
    <style>
        .GVFixedHeader
        {
            font-weight: bold;
            background-color: Green;
            position: relative;
            top: expression(this.parentNode.parentNode.parentNode.scrollTop-1);
        }
        .GridViewContainer
        {
            overflow-y: scroll;
            overflow-x: hidden;
        }

        input {
            margin-top: 5px;
            margin-bottom: 5px;
            display:inline-block; 
            *display: inline;     /* for IE7*/
            zoom:1;              /* for IE7*/
            vertical-align:middle;
            margin-left:20px
        }

        label {
            display:inline-block;
            *display: inline;     /* for IE7*/
            zoom:1;              /* for IE7*/
            float: left;
            padding-top: 5px;
            text-align: right;
            width: 140px;
        }
    </style>
    <script>
        console.log("desarrollo");
        $(document).ready(function () {
            $("#myBtn").click(function () {
                $("#myModal").modal();
            });
            
            $("#btnGuardar").click(function () {
                $("#commentForm").validate();
            });
           
        });
    </script>
</asp:Content>

