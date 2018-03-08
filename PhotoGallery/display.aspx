<%@ Page Language="C#" AutoEventWireup="true" CodeFile="display.aspx.cs" Inherits="display" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Button ID="btnBack" runat="server" Text="Back To Gallery" Width="197px" OnClick="btnBack_Click" />
            <br /><br />
            <asp:Image ID="Image1" runat="server" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Back To Gallery" Width="197px" OnClick="btnBack_Click" />
        </div>
    </form>
</body>
</html>
