<%@ Page Title="" Language="C#" MasterPageFile="~/admin/quantrivien.master" AutoEventWireup="true" CodeFile="TrangChu.aspx.cs" Inherits="admin_QuanLiSanPham" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <%--<link href="../css/csSidebar.css" rel="stylesheet" />--%>
    <link href="../css/csSearch.css" rel="stylesheet" />
    <link href="../css/cssTrangChu.css" rel="stylesheet" />
    <link href="../css/txtTitleSilde.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="sidebar">
        <div class="sidebar-header">
           <ul class="menu-sidebar">
               <li style="background: red;">
                   
                    <h3>13805</h3>
                   <p>Lượt xem</p>
                       <span><i class="fa fa-eye" aria-hidden="true"></i></span>
                   
                   
                       
               </li>
               <li style="background: #DBA901;">
                   <h3>786</h3>
                   <p>Đã bán</p>
                   <span><i class="fa fa-shopping-cart" aria-hidden="true"></i></span>
               </li>
               
               <li style="background: green;">
                   <h3>756</h3>
                   <p>Khách hàng</p>
                   <span><i class="fa fa-users" aria-hidden="true"></i></span>
               </li>
               <li style="background: #2EFEF7;">
                   <h3>1029</h3>
                   <p>Nhận xét</p>
                   <span><i class="fa fa-comments-o" aria-hidden="true"></i></span>
               </li>
              
           </ul>
        </div>

        <div class="titleSlide" style="border-top: 2px solid #590E10; margin-bottom: 10px;">
            <span>    
                 <i class="fa fa-bar-chart" aria-hidden="true"></i>
            </span>
            <h3>
                BIỂU ĐỒ SẢN PHẨM
            </h3>
        </div>

         <div class="tab-search">
           <ul class="menu-search">
               <li>
                   <span>
                       <i class="fa fa-search" aria-hidden="true"></i>
                   </span>
               </li>
               <li>
                   <asp:DropDownList runat="server" ID="DropDownListLoaiSanPham" AutoPostBack="True" OnSelectedIndexChanged="DropDownListLoaiSanPham_SelectedIndexChanged"></asp:DropDownList>
               </li>
              <%-- <li>
                   <asp:Button runat="server" ID="btnSearch" Text="Search" />
               </li>--%>
           </ul>
        </div>

        <div class="siderbar-slide">
            <div class="slide-orders">
                <%--<div>
                    <asp:Chart ID="Chart1" runat="server" OnLoad="Chart1_Load">
                        <Series>
                            <asp:Series Name="Series1"></asp:Series>
                        </Series>
                        <ChartAreas>
                            <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                        </ChartAreas>
                    </asp:Chart>
                </div>--%>
            </div>
            <div class="slide-comment">
                <div class=""></div>

                <div class="chart">
                    <asp:Chart ID="ChartLuotXemSP" runat="server" OnLoad="ChartLuotXemSP_Load" Width="1007px">
                        <Series>
                            <asp:Series Name="Series1"></asp:Series>
                        </Series>
                        <ChartAreas>
                            <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                        </ChartAreas>
                    </asp:Chart>
                </div>
                
            </div>
        </div>
         <div class="titleSlide" style="border-top: 2px solid #590E10; margin-bottom: 10px;">
            <span>    
                 <i class="fa fa-bar-chart" aria-hidden="true"></i>
            </span>
            <h3>
                TOP 10 LƯỢT XEM
            </h3>
             
        </div>
        <div>
            <asp:GridView runat="server" ID="gvSanBanChay" AutoGenerateColumns="False">
                <Columns>
                     <asp:BoundField DataField="PK_iSanPhamID" HeaderText="Mã SP" ItemStyle-Width="20px" >
                        <ItemStyle Width="20px"></ItemStyle>
                     </asp:BoundField>
                    <asp:BoundField DataField="sTenSanPham" HeaderText="Tên SP" ItemStyle-Width="120px" >
                    <ItemStyle Width="120px"></ItemStyle>
                     </asp:BoundField>
                    <asp:BoundField DataField="FK_sDanhMucSanPhamID" HeaderText="Loại sản phẩm" ItemStyle-Width="100px" >
                    <ItemStyle Width="100px"></ItemStyle>
                     </asp:BoundField>
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
                  
                </Columns>  
            </asp:GridView>
        </div>
    </div>
</asp:Content>

