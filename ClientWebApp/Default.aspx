<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ClientWebApp._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Live Journeys : Journey Search</h2>

    </div>
        <asp:Label ID="Label1" runat="server" Text="Station One"></asp:Label>
        <asp:TextBox ID="txtStation1" runat="server"></asp:TextBox>

        
        <asp:Label ID="label2" runat="server" Text="Station Two"></asp:Label>
        <asp:TextBox ID="txtStation2" runat="server"></asp:TextBox>
      

        <asp:Button ID="BtnSearch" runat="server" Text="Search" OnClick="BtnSearch_Click" />
        <asp:Button ID="BtnClear" runat="server" Text="Clear" OnClick="BtnClear_Click" />

        <br />
         <asp:Panel ID="Panel1" runat="server">
             <asp:Label ID="lblUnits" runat="server" Text="Results in km?: "></asp:Label> 
             <asp:CheckBox ID="CbKm" runat="server" Text="Yes" />
           
            
         </asp:Panel>
        
        
        <br />

        <asp:Label ID="lblDistance" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="lblTime" runat="server" Text=""></asp:Label> <br />
        <asp:Label ID="lblChange" runat="server" Text=""></asp:Label> <br />
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label> <br />


    </form>
</body>
</html>
