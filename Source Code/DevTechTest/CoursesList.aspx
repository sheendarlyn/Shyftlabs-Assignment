<%@ Page Title="Courses List" Language="C#" MasterPageFile="~/Shared.Master" AutoEventWireup="true" CodeBehind="CoursesList.aspx.cs" Inherits="DevTechTest.CoursesList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <form id="form1" runat="server" style="padding-left:200px" >
         <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
          <table class="auto-style1">
              <tr width="50%>
                  <td class="auto-style2"><strong>Course List<br />
                      <br />
                      </strong></td>
              </tr>
              <tr>
                  <td>
          <asp:GridView ID="gvCourse" runat="server" PageSize="50" AllowPaging="True" AutoGenerateColumns="False" EmptyDataText="No Courses Found" 
                        OnPageIndexChanging="gvCourse_PageIndexChanging" OnRowCommand="gvCourse_RowCommand" Width="55%" CellPadding="4" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" GridLines="Horizontal">
                                                        <Columns>
                                                        <asp:BoundField DataField="coursename" HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"  
                                                            HeaderText="Course Name" >
                                                            <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                                            <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                                            <ItemStyle Width="500px"></ItemStyle>
                                                            </asp:BoundField>
                                                  
                                                             <asp:TemplateField HeaderStyle-CssClass="styleCenter" HeaderText="Delete" ItemStyle-CssClass="styleCenter">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="btnDelete" runat="server" CausesValidation="false" CommandArgument='<%#Bind("courseid") %>' CommandName="Delete1" 
                                                                        ImageUrl="Image/del-cross.png" OnClientClick="javascript:return window.confirm('Continue to delete this course?')" ToolTip="Delete" />
                                                                </ItemTemplate>
                                                                <HeaderStyle CssClass="styleCenter" />
                                                                <ItemStyle HorizontalAlign="Center" Width="75" />
                                                            </asp:TemplateField>
                                                        </Columns>
                                                        <EmptyDataRowStyle BorderColor="#003380" BorderWidth="0px" />
                                                        <FooterStyle Height="50px" Width="100px" BackColor="White" ForeColor="#333333" />
                                                        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                                                        <PagerStyle CssClass="pagination-ys" BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                                                        <RowStyle BackColor="White" ForeColor="#333333" />
                                                        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                                                        <SortedAscendingCellStyle BackColor="#F7F7F7" />
                                                        <SortedAscendingHeaderStyle BackColor="#487575" />
                                                        <SortedDescendingCellStyle BackColor="#E5E5E5" />
                                                        <SortedDescendingHeaderStyle BackColor="#275353" />
                                                    </asp:GridView>
                  </td>
              </tr>
         </table>
        </form>
</asp:Content>
