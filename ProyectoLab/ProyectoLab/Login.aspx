<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProyectoLab.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
        <link rel="stylesheet" type="text/css"  href="css/login.css"/>
</head>
<body>
        <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
        <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
        <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
    <div class="wrapper">

            <div class="container">
                <h1>Ingreso al Sistema</h1>
                
    <form id="loginFrm" runat="server">
                    <input type="text" placeholder="Usuario" id="txt_dpi" runat="server" />
                    <input type="password" placeholder="Password"  id="txt_pass" runat="server"/>
                    <asp:Button ID="registrobutton" runat="server" Text="Ingresar" OnClick="registrobutton_Click" />
    </form>
                
            </div>

            <ul class="bg-bubbles">
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
            </ul>
        </div>
        <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>
    
</body>
</html>
