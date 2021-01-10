<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="laba4.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>AddsDemonstration</title>
</head>
<body>
    <form id="form1" runat="server">
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
                url: "Simple.asmx/Adds",
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
</body>
</html>