<%@ Page Title="" Language="C#" MasterPageFile="~/admin/quantrivien.master" AutoEventWireup="true" CodeFile="DangNhap.aspx.cs" Inherits="admin_DangNhap" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="titleSlide">
                             <span>
                                 <i class="fa fa-sign-in" aria-hidden="true"></i>
                             </span>
                             <h3>
                                 ĐĂNG NHẬP / ĐĂNG KÍ
                             </h3>
                         </div>
                         <div  class="log">
                             <table class="tblLog">
                                 <tr>
                                     <td style="text-align: center">
                                         <img src="../images/avtAdmin.png" height="100px" />
                                     </td>
                                 </tr>
                                 <tr>
                                     <td style="font-size: 20px;text-align:center;">ĐĂNG NHẬP baitaplon.com</td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <asp:CustomValidator ID="TBDangNhapLoi" runat="server" ErrorMessage="Tên tài khoản hoặc mật khẩu không chính xác"></asp:CustomValidator>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <asp:Label runat="server" ID="lbt"></asp:Label>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td class="txtTable">
                                         Tên đăng nhập <br />
                                         <asp:TextBox runat="server" ID="txtNameAdmin" CssClass="txtInput" Width="270px"></asp:TextBox>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td class="txtTable">
                                         Mật khẩu<br />
                                         <asp:TextBox runat="server" ID="txtPasswordAdmin" TextMode="Password" CssClass="txtInput" Width="270px"></asp:TextBox>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td style="text-align: center">
                                         <asp:Button runat="server" ID="btnDangNhap1" Text="Đăng nhập" CssClass="btnDangNhap1"  />
                                     </td>
                                 </tr>
                                 <tr>
                                     <td style="text-align: center">
                                         <a href="#">
                                             Quên mật khẩu ?
                                         </a>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td style="text-align: center">                                       
                                         <asp:Button runat="server" ID="btnTaoTaiKhoan" Text="Tạo tài khoản" CssClass="bq"  />
                                     </td>
                                 </tr>
                                 <tr>
                                     <td style="text-align: center">Liên hệ hổ trợ <u>033 712 2712</u></td>
                                 </tr>
                                 <tr>
                                     <td style="text-align: center">CopyRight@2021 - baitaplon.com</td>
                                 </tr>
                             </table>
                         </div>
</asp:Content>

