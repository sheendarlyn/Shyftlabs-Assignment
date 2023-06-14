<%@ Page Title="Add New Results" Language="C#" MasterPageFile="~/Shared.Master" AutoEventWireup="true" CodeBehind="AddResults.aspx.cs" Inherits="DevTechTest.AddResults" %>
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
                      <td class="auto-style2" colspan="2"><strong>Add New Result<br />
                          <br />
                          </strong></td>
                  </tr>
                  <tr>
                  
                      <td class="auto-style5">
                          <br />
                          Course name<strong><span class="auto-style3">*</span></strong></td>
                      <td class="auto-style4"><br />
                          <asp:DropDownList ID="drpCourseName" runat="server" ValidationGroup="submit" >
                          </asp:DropDownList>
                          <asp:RequiredFieldValidator ID="rffname" runat="server" ErrorMessage="Please Course name" 
                             ControlToValidate="drpCourseName" ForeColor="Red"></asp:RequiredFieldValidator>
                      </td>
                  </tr>
                  <tr>
                      <td class="auto-style5">
                          <br />
                          Student name<strong><span class="auto-style3">*</span></strong></td>
                      <td class="auto-style4">
                          <br />
                           <asp:DropDownList ID="drpStudent" runat="server" ValidationGroup="submit" >
                          </asp:DropDownList>
                          <asp:RequiredFieldValidator ID="rrfamilyname" runat="server" ErrorMessage="Please choose Student name" 
                             ControlToValidate="drpStudent" ForeColor="Red"></asp:RequiredFieldValidator>
                      </td>
                  </tr>
            
                  <tr>
                      <td class="auto-style5">
                          <br />
                          Score<strong><span class="auto-style3">*</span></strong></td>
                      <td class="auto-style4"><br />
                          <asp:DropDownList ID="drpScore" runat="server" ValidationGroup="submit" >
                              <asp:ListItem></asp:ListItem>
                              <asp:ListItem>A</asp:ListItem>
                              <asp:ListItem>B</asp:ListItem>
                              <asp:ListItem>C</asp:ListItem>
                              <asp:ListItem>D</asp:ListItem>
                              <asp:ListItem>E</asp:ListItem>
                              <asp:ListItem>F</asp:ListItem>
                          </asp:DropDownList>
                          <asp:RequiredFieldValidator ID="rrfemail" runat="server" ErrorMessage="Please choose Score" 
                             ControlToValidate="drpScore"  ForeColor="Red"></asp:RequiredFieldValidator></td>
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

