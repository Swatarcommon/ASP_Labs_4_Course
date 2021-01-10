<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Lab_6_Web_Form</h1>
    </div>

    <div class="row">
      <form id="form1">
        <p>X:<input type="text" id="x"/></p>
        <p>Y:<input type="text" id="y"/></p>
        <p>Result:<input type="text" id="result"/></p>
        <p><input type="button" onclick="getSum_Ajax()" value="Click" /></p>
    </form>
    <script src="jquery-3.4.1.js"></script>
    <script>
        function getSum_Ajax() {
            const data = {
                x: parseInt($("#x").val()),
                y: parseInt($("#y").val())
            };
            $.ajax({
                url: "SimpleInterfaces.asmx/Adds",
                type: "GET",
                dataType: "json",
                contentType: "application/json; charset=utf-8",
                data: data,
                success: result => {
                    $("#result").val(result.d);
                },
                error: error => {
                    console.log(error);
                }
            })
        }
    </script>
    </div>

</asp:Content>
