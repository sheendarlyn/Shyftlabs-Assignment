<%@ Page Title="Results List" Language="C#" MasterPageFile="~/Shared.Master" AutoEventWireup="true" CodeBehind="ResultsList.aspx.cs" Inherits="DevTechTest.ResultsList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <form id="form1" runat="server" style="padding-left:200px" >
         <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
          <table class="auto-style1">
              <tr width="50%>
                  <td class="auto-style2"><strong>Result List<br />
                      <br />
                      </strong></td>
              </tr>
              <tr>
                  <td>
          <asp:GridView ID="gvResult" runat="server" PageSize="50" AllowPaging="True" AutoGenerateColumns="False" EmptyDataText="No Result Found" 
                        OnPageIndexChanging="gvResult_PageIndexChanging"  Width="55%" CellPadding="4" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" GridLines="Horizontal">
                                                        <Columns>
                                                        <asp:BoundField DataField="coursename" HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"  
                                                            HeaderText="Course" >
                                                            <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                                            <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                                            <ItemStyle Width="500px"></ItemStyle>
                                                            </asp:BoundField>

                                                             <asp:BoundField DataField="fullname" HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"  
                                                            HeaderText="Student" >
                                                            <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                                            <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                                            <ItemStyle Width="500px"></ItemStyle>
                                                            </asp:BoundField>

                                                             <asp:BoundField DataField="score" HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"  
                                                            HeaderText="Score" >
                                                            <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                                            <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                                            <ItemStyle Width="500px"></ItemStyle>
                                                            </asp:BoundField>
                                                  
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
