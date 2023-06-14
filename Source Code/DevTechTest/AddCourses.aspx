<%@ Page Title="Add Courses" Language="C#" MasterPageFile="~/Shared.Master" AutoEventWireup="true" CodeBehind="AddCourses.aspx.cs" Inherits="DevTechTest.AddCourses" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      
      <form id="form1" runat="server" style="padding-left:200px" >
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
   
          <div>
              <style>
table, th, td {
  border: 1px solid black;
  border-collapse: collapse;
}
                  .auto-style3 {
                      color: #FF3300;
                  }
              </style>
              <table class="auto-style1"  >
                  <tr style="text-align:center" >
                      <td class="auto-style2" colspan="2"><strong>Add Courses<br />
                          <br />
                          </strong></td>
                  </tr>
                  <tr>
                  
                      <td class="auto-style5">
                          <br />
                          Courses name<strong><span class="auto-style3">*</span></strong></td>
                      <td class="auto-style4">
                          <asp:HiddenField ID="hfcourseId" Value="0" runat="server" /><br />
                          <asp:TextBox ID="txtCourseName" runat="server" ValidationGroup="submit" ></asp:TextBox>
                          <asp:RequiredFieldValidator ID="rffname" runat="server" ErrorMessage="Courses name should be mandatory" 
                             ControlToValidate="txtCourseName" ForeColor="Red"></asp:RequiredFieldValidator>
                      </td>
                  </tr>
                  <tr>
                      <td class="auto-style5" colspan="2">
                          <br />
                   
                          <asp:Button ID="btnSubmit" runat="server" Text="Submit" Font-Bold="true" Height="35px" Width="94px" OnClick="btnSubmit_Click"  />&nbsp;
                          <asp:Button ID="btnClear" runat="server" Text="Clear" Font-Bold="true" Height="35px" Width="94px"  ValidationGroup="submit" OnClick="btnClear_Click" />
                          &nbsp;</td>
                  </tr>
                  </table>

          </div>
        </form>
</asp:Content>
