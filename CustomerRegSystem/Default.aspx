<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <br />
        <br />

        <div style ="font-size:x-large" align ="center">
            Customer Registration System
        </div>
        <br />

        <table style="width: 100%;">
            <tr>
                <td style="width: 195px">&nbsp;</td>
                <td>Customer IC</td>
                <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>&nbsp;<asp:Button ID="Button6" runat="server" BackColor="#000099" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="Button6_Click" Text="GET" />
                </td>
            </tr>
            <tr>
                <td style="width: 195px">&nbsp;</td>
                <td>Customer Name</td>
                <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 195px">&nbsp;</td>
                <td>State</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="State" DataValueField="State">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:db_crsConnectionString %>" ProviderName="<%$ ConnectionStrings:db_crsConnectionString.ProviderName %>" SelectCommand="SELECT [State] FROM [tb_state]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td style="width: 195px">&nbsp;</td>
                <td>Age</td>
                <td><asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 195px">&nbsp;</td>
                <td>Contact</td>
                <td><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 195px; height: 22px;"></td>
                <td style="height: 22px">Password</td>
                <td style="height: 22px"><asp:TextBox ID="TextBox7" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 195px">&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 195px">&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" BackColor="#3333CC" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="Button1_Click" Text="Insert" />
                &nbsp;<asp:Button ID="Button2" runat="server" BackColor="#FF9900" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="Button2_Click" Text="Update" />
                &nbsp;<asp:Button ID="Button3" runat="server" BackColor="#CC0000" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="Button3_Click" OnClientClick="return confirm('Confirm Deletion')" Text="Delete" />
                &nbsp;<asp:Button ID="Button4" runat="server" BackColor="#006600" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="Button4_Click" Text="Search" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button5" runat="server" BackColor="#669999" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="Button5_Click" Text="Refresh" />
                </td>
            </tr>
            <tr>
                <td style="width: 195px">&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 195px">&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:GridView ID="GridView1" runat="server" Width="531px">
                    </asp:GridView>
                </td>
            </tr>
        </table>

    </div>
</asp:Content>
