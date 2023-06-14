<%@ Page Title="Home" Language="C#" MasterPageFile="~/Shared.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="DevTechTest.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      
    <form id="form1" runat="server" style="padding-left:200px" >
         <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>

     <div style="align-items:center" >
         <asp:Image  ID="imgHome" ImageUrl="~/Image/home.png" runat="server" />
     </div>
        


    
        </form>
</asp:Content>
