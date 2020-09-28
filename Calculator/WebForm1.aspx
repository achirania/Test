<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Calculator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Four Function Calculator</title>
    <style type="text/css">
        #sub {
            width: 18px;
        }
    </style>
</head>
<body>
    <h1>Four Function Calculator</h1>
    <form id="calc" runat="server">
        <div>
            <asp:Label ID="o1" runat="server" Text="Operand 1"></asp:Label>
            <asp:TextBox ID="o1num" runat="server"></asp:TextBox></br>
            <asp:Label ID="o2" runat="server" Text="Operand 2"></asp:Label>
            <asp:TextBox ID="o2num" runat="server"></asp:TextBox></br>
            
            <asp:Button ID="add" runat="server" Text="+" onClick="add_Click"/>
            <asp:Button ID="sub" runat="server" Text="-" onClick="sub_Click"/>
            <asp:Button ID="mul" runat="server" Text="*" onClick="mul_Click"/>
            <asp:Button ID="div" runat="server" Text="/" onClick="div_Click"/>
        </div>
    </form>

    <hr>

    <asp:Label ID="result" runat="server" Text=""></asp:Label>
    
</body>
</html>
