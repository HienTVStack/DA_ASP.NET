<%@ Page Title="" Language="C#" MasterPageFile="~/admin/quantrivien.master" AutoEventWireup="true" CodeFile="QuanLiSanPham.aspx.cs" Inherits="QuanLiSanPham" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/csQuanLiSanPham.css" rel="stylesheet" />
    <link href="../css/csSearch.css" rel="stylesheet" />
   <%-- <%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>--%>
    
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="titleSlide">
        <span>    
          <i class="fa fa-product-hunt" aria-hidden="true"></i>
        </span>
        <h3>
            QUẢN LÍ SẢN PHẨM
        </h3>
    </div>
    <div class="product">
        <div class="product-header">
            <ul class="menu-product">
                <li>
                    <a href="#">
                        <span>
                            <i class="fa fa-refresh" aria-hidden="true"></i>
                        </span>
                        Tải lại
                    </a>
                </li>
                <li>
                    <a href="#">
                        <span>
                            <i class="fa fa-wrench" aria-hidden="true"></i>
                        </span>
                        Chỉnh sửa
                    </a>
                </li>
                <li>
                    <a href="#">
                        <span>
                            <i class="fa fa-wrench" aria-hidden="true"></i>
                        </span>
                        Cập nhật
                    </a>
                </li>
                <li>
                    <a href="#">
                        <span>
                            <i class="fa fa-file-o" aria-hidden="true"></i>
                        </span>
                        Trang mới
                    </a>
                </li>
            </ul>
        </div>
        <div class="tab-search">
           <ul class="menu-search">
               <li>
                   <span>
                       <i class="fa fa-search" aria-hidden="true"></i>
                   </span>
               </li>
               <li>
                   <asp:TextBox runat="server" ID="txtSearch"></asp:TextBox>
               </li>
               <li>
                   <asp:Button runat="server" ID="btnSearch" Text="Search" OnClick="btnSearch_Click" />
               </li>
           </ul>
        </div>
    <div class="titleSlide">
        <span>    
          <i class="fa fa-product-hunt" aria-hidden="true"></i>
        </span>
        <h3>
            CHI TIẾT SẢN PHẨM
        </h3>
    </div>
        <div class="hero">
            <table>              
                 <tr>
                    <td>
                        <asp:CustomValidator ID="CustomValidatorTenSP" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator>
                    </td>
                     <td>
                         <asp:CustomValidator runat="server" ErrorMessage="CustomValidator" ID="CustomValidatorKieuSP"></asp:CustomValidator>
                     </td>
                </tr>
                 <tr>
                    <td>
                        <asp:CustomValidator ID="CustomValidatorXXu" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:CustomValidator ID="CustomValidatorGiaBan" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator>
                    </td>
                     <td>
                        <asp:CustomValidator ID="CustomValidatorSLTon" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator>
                    </td>
                </tr>
                 
                 <tr>
                     <td>
                        <asp:CustomValidator ID="CustomValidatorMoTa" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator>
                    </td>
                    <td>
                        <asp:CustomValidator ID="CustomValidatorImage" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator>
                    </td>
                </tr>
            </table>
            
    <table class="tblCTSP">    
     
        <tr>
            <td>Mã sản phẩm: 
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtMaSanPham" CssClass="csTextBoxSP" ReadOnly="true"></asp:TextBox>
            </td>
            <td colspan="2">
                <a href="QuanLiSanPham.aspx">Tạo mới sản phẩm</a>
            </td>
        </tr>
        <tr>
            <td>
                Tên sản phẩm: 
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtTenSanPham" CssClass="csTextBoxSP"></asp:TextBox>
            </td>
            <td>
                Loại sản phẩm: 
            </td>
            <td>
               <asp:DropDownList runat="server" ID="DDLKieuSP" AutoPostBack="True" OnSelectedIndexChanged="DDLKieuSP_SelectedIndexChanged"></asp:DropDownList>  
              
             </td>         
        </tr>
        <tr>
            <td>
                Giá bán: 
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtGiaBan" CssClass="csTextBoxSP"></asp:TextBox>
            </td>
            <td>
                Số lượng còn:  
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtSLCon" CssClass="csTextBoxSP"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Xuất xứ
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtXuatXu" CssClass="csTextBoxSP" ></asp:TextBox>
            </td>

            <td>
                Hình ảnh: 
            </td>
            <td>
                <asp:FileUpload runat="server" ID="images" />
            </td>

           
        </tr>
        <tr>
            <td>
                Mô tả:
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtMoTa" Height="70px" Width="250px" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td>
                <asp:Button runat="server" ID="btnUpLoadImage" Text="Tải ảnh lên: " OnClick="btnUpLoadImage_Click" />
            </td>
            <td>
                <asp:Image ID="image" runat="server" Width="150px" Height="150px" />
            </td>
        </tr>
        <tr>
            <td>
                Số lượng xem: 
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtSXem" CssClass="csTextBoxSP"></asp:TextBox>
            </td>
            <td>
                Bán chạy: 
            </td>
            <td>
                <asp:RadioButtonList runat="server" RepeatDirection="Horizontal" ID="RadioButtonListBanChay" CssClass="radioButton" Width="250px">
                    <asp:ListItem Selected="True">On</asp:ListItem>
                    <asp:ListItem>OFF</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td>
                Còn hàng: 
            </td>
            <td>
                <asp:RadioButtonList runat="server" RepeatDirection="Horizontal" ID="RadioButtonListConHang" CssClass="radioButton" Width="250px">
                    <asp:ListItem Selected="True">On</asp:ListItem>
                    <asp:ListItem>OFF</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>
                Hiển thị: 
            </td>
            <td>
                <asp:RadioButtonList runat="server" RepeatDirection="Horizontal" ID="RadioButtonListHienThi" CssClass="radioButton" Width="250px">
                    <asp:ListItem Selected="True">On</asp:ListItem>
                    <asp:ListItem>OFF</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
       

    </table>
        <ul class="menu-xuli">
            <li>
                <asp:Button runat="server" ID="btnThem" Text="Thêm" Width="100px" Height="25px" OnClick="btnThem_Click" />
            </li>
            <li>
                <asp:Button runat="server" ID="btnXoa" Text="Xóa" Width="100px" Height="25px" OnClick="btnXoa_Click" />
            </li>
            <li>
                <asp:Button runat="server" ID="btnSua" Text="Sửa" Width="100px" Height="25px" OnClick="btnSua_Click" />
            </li>
        </ul>
        </div>

          <div class="titleSlide">
             <span>    
              <i class="fa fa-product-hunt" aria-hidden="true"></i>
            </span>
            <h3>
                DANH SÁCH SẢN PHẨM
            </h3>
        </div>
        <div style="height: 20px; width: 100%;"></div>
        <div class="tab-search">
           <ul class="menu-search">
               <li>
                   <span>
                       <i class="fa fa-search" aria-hidden="true"></i>
                   </span>
               </li>
               <li>
                   <asp:DropDownList runat="server" ID="DDLLoaiSP" AutoPostBack="True" OnSelectedIndexChanged="DDLLoaiSP_SelectedIndexChanged"></asp:DropDownList>
               </li>
           </ul>
        </div>

        <div style="text-align: center">
            <asp:GridView runat="server" OnPageIndexChanging="GVdanhSachSanPham_PageIndexChanging" AllowPaging="true" PageSize="10" ID="GVdanhSachSanPham" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None" AutoGenerateColumns="False" CssClass="test" OnSelectedIndexChanged="GVdanhSachSanPham_SelectedIndexChanged">
                <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#594B9C" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#33276A" />        
                <Columns>
                     <asp:BoundField DataField="PK_iSanPhamID" HeaderText="Mã SP" ItemStyle-Width="20px" >
                        <ItemStyle Width="20px"></ItemStyle>
                     </asp:BoundField>
                    <asp:BoundField DataField="sTenSanPham" HeaderText="Tên SP" ItemStyle-Width="120px" >
                    <ItemStyle Width="120px"></ItemStyle>
                     </asp:BoundField>
                    <asp:BoundField DataField="FK_sDanhMucSanPhamID" HeaderText="Loại sản phẩm" ItemStyle-Width="100px" />
                    <asp:BoundField DataField="sMoTa" HeaderText="Mô tả" ItemStyle-Width="300px" >
                    <ItemStyle Width="300px"></ItemStyle>
                     </asp:BoundField>
                    <asp:BoundField DataField="sXuatXu" HeaderText="Xuất xứ" ItemStyle-Width="70px" >
                    <ItemStyle Width="70px"></ItemStyle>
                     </asp:BoundField>
                    <asp:BoundField DataField="fGiaBan" HeaderText="Giá bán" />
                    <asp:BoundField DataField="iSoLuongTon" HeaderText="Số lượng" />
                    <asp:ImageField DataImageUrlField="sImage" HeaderText="Hình ảnh" ItemStyle-Width="200px" ItemStyle-Height="150px">
                        <ControlStyle Height="200px" Width="200px" />
                    <ItemStyle Height="200px" Width="200px" CssClass="image"></ItemStyle>
                     </asp:ImageField>
                    <asp:BoundField DataField="iSoLuongXem" HeaderText="SL xem" />
                     <asp:CommandField ShowEditButton="True" />
                  
                </Columns>       
            </asp:GridView>
        </div>

    </div>


  

</asp:Content>

