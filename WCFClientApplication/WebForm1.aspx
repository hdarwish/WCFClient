<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WCFClientApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
       
        <table>
            <tr>
                <td>
                     <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label> 
                </td>
                 <td>
                     <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
          <tr>
                <td>
                     <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label> 
                </td>
                 <td>
                     <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                     <asp:Label ID="Label3" runat="server" Text="Gender"></asp:Label> 
                </td>
                 <td>
                     <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                     <asp:Label ID="Label4" runat="server" Text="Date of Birth"></asp:Label> 
                </td>
                 <td>
                     <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                     <asp:Label ID="Label6" runat="server" Text="Employee Type"></asp:Label> 
                </td>
                <td>
                    <asp:DropDownList ID="ddlEmployeeType" runat="server" OnSelectedIndexChanged="ddlEmployeeType_SelectedIndexChanged" AutoPostBack="True">
                        <asp:ListItem Value="-1" Text="Select Employee Type"></asp:ListItem>
                        <asp:ListItem Value="1" Text="Full Time Employee"></asp:ListItem>
                        <asp:ListItem Value="2" Text="Part Time Employee"></asp:ListItem>
                    </asp:DropDownList>

                </td>
            </tr>
            <tr id="trAnnualsalary" runat="server" visible="false">
                <td>
                     <asp:Label ID="Label7" runat="server" Text="Annual Salary"></asp:Label> 
                </td>
                <td>  <asp:TextBox ID="txtannual" runat="server"></asp:TextBox></td>
            </tr>
            <tr  id="trhrpay" runat="server" visible="false">
                 <td>
                     <asp:Label ID="Label8" runat="server" Text="Hourly Pay"></asp:Label> 
                </td>
                <td>  <asp:TextBox ID="txthrpay" runat="server"></asp:TextBox></td>
            </tr>
            <tr  id="trhourworked" runat="server" visible="false">
                 <td>
                     <asp:Label ID="Label9" runat="server" Text="Hours Worked"></asp:Label> 
                </td>
                <td>  <asp:TextBox ID="txthourworked" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td >
                    
                    <asp:Button ID="btnGetEmp" runat="server" Text="Get Employee" OnClick="btnGetEmp_Click" />
                </td>
                <td >
                    <asp:Button ID="btnSaveEmp" runat="server" Text="Save Employee" OnClick="btnSaveEmp_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label5" runat="server" Text="Labelmsg" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:TextBox ID="txtProgress" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
       
    </div>
    </form>
</body>
</html>
