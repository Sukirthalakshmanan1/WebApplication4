<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication4.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <Center><h3>Class Section</h3></Center>
    <asp:Label ID="Label1" runat="server" BorderStyle="Solid" Text="Standard:" Width="76px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;
<p>
    &nbsp;</p>
<asp:Label ID="Label2" runat="server" BorderStyle="Solid" Text="Class strength:"></asp:Label>
<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <br />
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert Class" BorderStyle="Solid" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" BorderStyle="Solid" OnClick="Button2_Click" Text="Update class details" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button3" runat="server" BorderStyle="Solid" OnClick="Button3_Click" Text="Delete class details" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button5" runat="server" BackColor="#CCFFFF" BorderColor="#33CC33" BorderStyle="Solid" Font-Italic="True" Height="42px" OnClick="Button5_Click" style="margin-top: 0px" Text="Show all classes" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button4" runat="server" BorderColor="#0000CC" BorderStyle="Ridge" Font-Bold="True" Height="29px" OnClick="Button4_Click" style="margin-top: 14px" Text="Search for class" Width="189px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <asp:Label ID="Display" runat="server" Text="Msg" BackColor="#0066FF" BorderStyle="None" Height="32px" Width="215px"></asp:Label>
    <br />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <br />
    <asp:Label ID="Display2" runat="server" BorderColor="Aqua" Text="Msg on view"></asp:Label>
    <br />
    <br />
    <asp:GridView ID="GridView2" runat="server">
    </asp:GridView>
    <br />
    <br />
    <br />
    <br />
    <br />
    </asp:Content>
