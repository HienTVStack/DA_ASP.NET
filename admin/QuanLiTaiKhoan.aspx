<%@ Page Title="" Language="C#" MasterPageFile="~/admin/quantrivien.master" AutoEventWireup="true" CodeFile="QuanLiTaiKhoan.aspx.cs" Inherits="admin_QuanLiTaiKhoan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/txtTitleSilde.css" rel="stylesheet" />
    <link href="../css/csQuanLiSanPham.css" rel="stylesheet" />
    <link href="../css/csSearch.css" rel="stylesheet" />
    <style>
        .main {
            background: #FFF;
            
            float: right;
        }
        .thongTinTaiKhoan {
            width: 100%
        }


     * {
         margin: 0 auto;
         padding: 0;
     }
        
        .auto-style1 {
            height: 25px;
        }
        
        .auto-style2 {
            border: 1px solid #CCC;
        }

     

        .auto-style3 {
            width: 53px;
        }

     

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="main">
        <div class="titleSlide" style="border-top: 2px solid #590E10; margin-bottom: 10px;">
            <span>    
                 <i class="fa fa-bar-chart" aria-hidden="true"></i>
            </span>
            <h3>
                QUẢN LÍ TÀI KHOẢN
            </h3>            
        </div>
        <div class="thongTinTaiKhoan">
            <table style="width: 100%" class="tblRow">
                <tr>
                    <td rowspan="2" style="width: 69%" class="auto-style2">
                        
                        <table class="tblInfoStaff">
                            <tr>
                                <td colspan="4">
                                    <h3 style="text-align: center">Thông tin tài khoản</h3>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style1">Mã nhân viên: </td>
                                <td class="auto-style1">
                                    <asp:TextBox runat="server" ID="txtMaNV" CssClass="csTextBoxSP" Enabled="false"></asp:TextBox>
                                </td>
                                <td class="auto-style3"></td>
                                <td colspan="2" class="auto-style1">
                                    <asp:LinkButton runat="server" ID="lbtnLamMoi" Text="Làm mới"></asp:LinkButton> 
                                </td>
                               
                            </tr>
                            <tr>
                                <td class="auto-style1">Tên nhân viên: </td>
                                <td class="auto-style1">
                                    <asp:TextBox runat="server" ID="txtTenNV" CssClass="csTextBoxSP"></asp:TextBox>
                                </td>
                                <td class="auto-style3"></td>
                                <td class="auto-style1">Năm sinh: </td>
                                <td class="auto-style1">
                                    <asp:TextBox runat="server" ID="txtNamSinh" CssClass="csTextBoxSP"></asp:TextBox>
                                </td>
                            </tr>
                           
                            <tr>
                                <td class="auto-style1">Số điện thoại: </td>
                                <td class="auto-style1">
                                    <asp:TextBox runat="server" ID="txtSDT" CssClass="csTextBoxSP"></asp:TextBox>
                                </td>
                                <td class="auto-style3"></td>
                                <td>Giới tính</td>
                                <td>
                                    <asp:RadioButtonList runat="server" ID="rblGioiTinhh" RepeatDirection="Horizontal" AutoPostBack="True" Width="70%">
                                        <asp:ListItem Text="True" Value="True" Selected="True">Nam</asp:ListItem>
                                        <asp:ListItem Text="False" Value="False">Nữ</asp:ListItem>
                                    </asp:RadioButtonList>
                                </td>
                            </tr>
                             <tr>
                                <td class="auto-style1">Email: </td>
                                <td colspan="4" class="auto-style1">
                                    <asp:TextBox runat="server" ID="txtEmail" Width="60%" CssClass="csTextBoxSP"></asp:TextBox>
                                </td>
                                
                            </tr>
                            <tr>
                                <td class="auto-style1">Chức vụ: </td>
                                <td class="auto-style1">
                                    <asp:DropDownList runat="server" ID="ddlChucVu"></asp:DropDownList>
                                </td>
                                <td class="auto-style3"></td>
                                <td>Quyền đăng nhập: </td>
                                <td>
                                    <asp:CheckBoxList runat="server" ID="cblQuyenDN" RepeatDirection="Horizontal" Width="70%" AutoPostBack="True" OnSelectedIndexChanged="cblQuyenDN_SelectedIndexChanged">
                                        <asp:ListItem Text="True"></asp:ListItem>
                                        <asp:ListItem Text="False"></asp:ListItem>
                                    </asp:CheckBoxList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style1">Địa chỉ: </td>
                                <td colspan="4" class="auto-style1">
                                    <asp:TextBox runat="server" ID="txtDiaChi" Width="80%" CssClass="csTextBoxSP"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="5">
                                    <br /><hr />
                                </td>
                            </tr>
                            <tr style="text-align: center">
                                <td>
                                    <asp:Button runat="server" ID="btnThemTK" Text="Thêm" Width="100px" Height="25px" OnClick="btnThemTK_Click" />
                                </td>
                                <td>
                                    <asp:Button runat="server" ID="btnXoa" Text="Xóa" Width="100px" Height="25px" OnClick="btnXoa_Click" />
                                </td>
                                <td class="auto-style3" colspan="2">
                                    <asp:Button runat="server" ID="btnSua" Text="Sửa" Width="100px" Height="25px" />
                                </td>
                                <%--<td style="width: 20px"></td>--%>
                                <td>
                                    <asp:Button runat="server" ID="btnCapQuyen" Text="Cấp quyền"  Width="100px" Height="25px"/>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td class="auto-style2">
                        <table>
                            <tr>
                                <td colspan="2">
                                    <h3>Phân quyền</h3>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Mã phân quyền: 
                                </td>
                                <td>
                                    <asp:TextBox runat="server" ID="txtMaPQ"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>Tên quyền: </td>
                                <td>
                                    <asp:TextBox runat="server" ID="txtTenQuyen"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2"><br /><hr /></td>
                            </tr>
                            <tr style="text-align:center">
                                <td>
                                    <asp:Button runat="server" ID="btnThemPQ" Text="Thêm phân quyền" />
                                </td>
                                <td>
                                    <asp:Button runat="server" ID="btnChinhSuaPQ" Text="Chỉnh sửa" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <table>
                            <tr>
                                <td colspan="2">
                                    <h3>Tài khoản quyền</h3>
                                </td>
                            </tr>
                            <tr>
                                <td>ID tài khoản quyền: </td>
                                <td>
                                    <asp:TextBox runat="server" ID="txtMaTKQ"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>ID tài khoản: </td>
                                <td>
                                    <asp:TextBox runat="server" ID="txtMaTK"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>ID phân quyền: </td>
                                <td>
                                    <asp:TextBox runat="server" ID="txtMaPQID"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2"><br /><hr /></td>
                            </tr>
                            <tr style="text-align: center">
                                <td>
                                    <asp:Button runat="server" ID="btnPhanQuyen" Text="Phân quyền" />
                                </td>
                                <td>
                                    <asp:Button runat="server" ID="btnXoaQuyen" Text="Xóa quyền" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
           
         </div>
         <div class="titleSlide" style="border-top: 2px solid #590E10; margin-bottom: 10px;">
            <span>    
                 <i class="fa fa-bar-chart" aria-hidden="true"></i>
            </span>
            <h3>
                DANH SÁCH TÀI KHOẢN
            </h3>
        </div>
        <br />
        
        <div class="tab-search">
           <ul class="menu-search">
               <li>
                   <span>
                       <i class="fa fa-search" aria-hidden="true"></i>
                   </span>
               </li>
               <li>Chức vụ: </li>
               <li>
                   <asp:DropDownList runat="server" ID="ddlSearchCV"></asp:DropDownList>
               </li>
               
           </ul>
            <ul class="menu-search">
                <li>
                    Tên nhân viên: 
                </li>
                <li>
                    <asp:TextBox runat="server" ID="txtSearchTenNV" CssClass="csTextBoxSP"></asp:TextBox>
                </li>
            </ul>
            <ul class="menu-search">
                
                    <li>
                   <asp:Button runat="server" ID="btnSearch" Text="Search" OnClick="btnSearch_Click" CssClass="btnDangNhap1" />
               
                </li>
            </ul>
        </div>
        
        <br /><br />
        <div>
            <asp:GridView runat="server" ID="gvDSTaiKhoan" AutoGenerateColumns="False" Width="100%" OnRowCommand="gvDSTaiKhoan_RowCommand" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="PK_iTaiKhoanID">
                <Columns>
                    <asp:BoundField DataField="PK_iTaiKhoanID" HeaderText="Mã nhân viên" ItemStyle-Width="30px" InsertVisible="False" ReadOnly="True" SortExpression="PK_iTaiKhoanID" >
<ItemStyle Width="30px"></ItemStyle>
                    </asp:BoundField>
                   <asp:BoundField DataField="sHoTen" HeaderText="Họ và tên" SortExpression="sHoTen" />
                    
                    <asp:BoundField DataField="sChucVu" HeaderText="Chức vụ" SortExpression="sChucVu" />
                    <asp:BoundField DataField="sEmail" HeaderText="Gmail" SortExpression="sEmail" ItemStyle-Width="270px" >
<ItemStyle Width="270px"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="sSoDienThoai" HeaderText="Số điện thoại" ItemStyle-Width="100px" SortExpression="sSoDienThoai" >
<ItemStyle Width="100px"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="iNamSinh" HeaderText="Năm sinh" SortExpression="iNamSinh" />
                    <asp:CheckBoxField DataField="bGioiTinh" HeaderText="Giới tính" SortExpression="bGioiTinh" />
                    <asp:BoundField DataField="sDiaChi" HeaderText="Địa chỉ" ItemStyle-Width="270px" SortExpression="sDiaChi" >             
<ItemStyle Width="270px"></ItemStyle>
                    </asp:BoundField>
                    <asp:CheckBoxField DataField="bQuyenDangNhap" ItemStyle-Width="40px" HeaderText="Quyền đăng nhập" SortExpression="bQuyenDangNhap" >
<ItemStyle Width="40px"></ItemStyle>
                    </asp:CheckBoxField>
                    
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton runat="server" ID="linkBtnSelectGV" OnClick="linkBtnSelectGV_Click" Text="Chọn"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#330099" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                <SortedAscendingCellStyle BackColor="#FEFCEB" />
                <SortedAscendingHeaderStyle BackColor="#AF0101" />
                <SortedDescendingCellStyle BackColor="#F6F0C0" />
                <SortedDescendingHeaderStyle BackColor="#7E0000" />
            </asp:GridView>
        </div>
        </div>
</asp:Content>

