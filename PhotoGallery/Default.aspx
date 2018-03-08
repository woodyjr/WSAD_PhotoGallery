<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" Width="311px" />
            <asp:Button ID="btnUpload" runat="server" OnClick="btnUpload_Click" Text="Upload" Width="140px" />
            <br />
            <br /><br />
            <asp:Panel ID="Panel1" runat="server" BorderStyle="Inset" Width="757px">
            </asp:Panel>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
