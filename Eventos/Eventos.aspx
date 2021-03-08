<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Eventos.aspx.cs" Inherits="Eventos.Eventos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridViewEventos" runat="server">
                <Columns>
                    <asp:BoundField DataField="eventos" HeaderText="Eventos" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
