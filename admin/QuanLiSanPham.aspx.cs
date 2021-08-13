using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class QuanLiSanPham : System.Web.UI.Page
{
   
    SqlConnection con = new SqlConnection(@"Data Source=VanHien;Initial Catalog=QUANLICUAHANG;Persist Security Info=True;User ID=sa;Password=123");

    protected void Page_Load(object sender, EventArgs e)
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
        con.Open();
        LoadData_CT();
        dataProduct();
    }

    protected void DDLDanhMucSP_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    DataTable LoadData(string query)
    {
        var cmd = new SqlCommand(query, con);
        var dr = cmd.ExecuteReader();
        var dt = new DataTable();
        dt.Load(dr);
        dr.Dispose();
        return dt;
    }
    void LoadData_CT()
    {
        //var query = LoadData("SELECT * FROM tbl_SanPham");
        //GVdanhSachSanPham.DataSource = query;
        //GVdanhSachSanPham.DataBind();
        if (!IsPostBack)
        {
            var accessTypeProduct = LoadData("SELECT * FROM tbl_DanhMucSanPham");
            DDLKieuSP.DataTextField = "PK_sDanhMucSanPhamID";
            DDLKieuSP.DataValueField = "PK_sDanhMucSanPhamID";
            DDLKieuSP.DataSource = accessTypeProduct;
            DDLKieuSP.DataBind();
            DDLKieuSP.Items.Insert(0, "Tất cả");


            DDLLoaiSP.DataTextField = "PK_sDanhMucSanPhamID";
            DDLLoaiSP.DataValueField = "PK_sDanhMucSanPhamID";
            DDLLoaiSP.DataSource = accessTypeProduct;
            DDLLoaiSP.DataBind();
            DDLLoaiSP.Items.Insert(0, "Tất cả");
        }

       
       
    }

    void dataProduct()
    {
        var query = LoadData("SELECT * FROM tbl_SanPham");
        GVdanhSachSanPham.DataSource = query;
        GVdanhSachSanPham.DataBind();
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {

        var searchProduct = LoadData("SELECT * FROM tbl_SanPham WHERE sTenSanPham LIKE '%' + '" + txtSearch.Text + "' + '%'");
        GVdanhSachSanPham.DataSource = searchProduct;
        GVdanhSachSanPham.DataBind();
    }
    protected void btnThem_Click(object sender, EventArgs e)
    {
        //tbl_SanPham SanPham = new tbl_SanPham();


        ////var LoadDataDanhMuc = from p in db.tbl_DanhMucSanPhams
        ////                      join q in db.tbl_SanPhams
        ////                      on p.PK_sDanhMucSanPhamID equals q.FK_sDanhMucSanPhamID
        ////                      where p.sTenDanhMucSanPham == DDLDanhMucSP.Text
        ////                      select p.PK_sDanhMucSanPhamID;

        //if (kiemTra() == true)
        //{
        //    SanPham.sTenSanPham = txtTenSanPham.Text;
        //    SanPham.fGiaBan = Convert.ToInt32(txtGiaBan.Text);
        //    SanPham.iSoLuongTon = Convert.ToInt32(txtSLCon.Text);
        //    SanPham.sMoTa = txtMoTa.Text;
        //    SanPham.FK_sDanhMucSanPhamID = DDLDanhMucSP.Text;
        //    SanPham.sXuatXu = "Việt Nam";
        //    SanPham.sImage = image.ImageUrl;
        //    SanPham.FK_iGiamGiaID = 1;
        //    SanPham.FK_iKhoHangID = 1;
        //    SanPham.iSoLuongXem = Convert.ToInt32(txtSXem.Text);
        //    if (RadioButtonListBanChay.SelectedItem.Text == "On")
        //        SanPham.bBanChay = true;
        //    else SanPham.bBanChay = false;
        //    if (RadioButtonListConHang.SelectedItem.Text == "On")
        //        SanPham.bConHang = true;
        //    else SanPham.bConHang = false;
        //    if (RadioButtonListHienThi.SelectedItem.Text == "On")
        //        SanPham.bHienThi = true;
        //    else SanPham.bHienThi = false;
        //    db.tbl_SanPhams.InsertOnSubmit(SanPham);
        //    db.SubmitChanges();
        //}




        //ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Thêm thành công')", true);
        //LoadData_CT();
        //newTextFiledInput();

        if (kiemTra() == true)
        {
            LoadData("INSERT INTO tbl_SanPham VALUES ('" + DDLKieuSP.SelectedItem.Text + "', 1, 1, '" + txtTenSanPham.Text + "', '" + txtMoTa.Text + "', '" + txtXuatXu.Text + "', '" + txtGiaBan.Text + "', '" + txtSLCon.Text + "', '" + image.ImageUrl + "', '" + txtSXem.Text + "', 1,1,1 )");
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Thêm thành công')", true);
            dataProduct();
            newTextFiledInput();
        }

        
       }
    protected void btnUpLoadImage_Click(object sender, EventArgs e)
    {
        if (images.HasFile)
        {
            string add = MapPath("images") + @"\" + images.FileName;
            if (!System.IO.File.Exists(add))
            {
                images.SaveAs(add);
            }
            image.ImageUrl = "images/" + images.FileName;
            image.DataBind();
        }
    }
    protected void DDLKieuSP_SelectedIndexChanged(object sender, EventArgs e)
    {
        //string IDNhomSanPham = DDLKieuSP.SelectedValue.ToString();

        //var IDDanhMucSanPham = from p in db.tbl_DanhMucSanPhams
        //                       where p.FK_sNhomSanPhamID.Equals(IDNhomSanPham) 
        //                       select new { p.PK_sDanhMucSanPhamID, p.sTenDanhMucSanPham };
        //var danhMucSanPhamID = IDDanhMucSanPham.ToList();
        //if (danhMucSanPhamID.Count > 0)
        //{
        //    DDLDanhMucSP.DataValueField = "PK_sDanhMucSanPhamID";
        //    DDLDanhMucSP.DataTextField = "PK_sDanhMucSanPhamID";
        //    DDLDanhMucSP.DataSource = danhMucSanPhamID;
        //    DDLDanhMucSP.DataBind();
        //    DDLDanhMucSP.Items.Insert(0, "Chọn");
        //}
    }
    protected void DDLLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
    {
        //string loaiSP = DDLLoaiSP.SelectedItem.Text;

        //if (loaiSP.ToString() == "Tất cả")
        //{
        //    var loadData = from p in db.tbl_SanPhams select p;
        //    GVdanhSachSanPham.DataSource = loadData;
        //}
        //else
        //{
        //    var IDSanPham = from p in db.tbl_SanPhams
        //                    where p.FK_sDanhMucSanPhamID.Equals(loaiSP)
        //                    select new { p.PK_iSanPhamID,p.FK_sDanhMucSanPhamID, p.sTenSanPham, p.fGiaBan, p.sXuatXu, p.sMoTa, p.bConHang, p.bHienThi,p.iSoLuongTon, p.sImage, p.iSoLuongXem };
        //    var sanPham = IDSanPham.ToList();
        //    if (sanPham.Count > 0)
        //    {
        //        GVdanhSachSanPham.DataSource = sanPham;
        //    }
           
        //}
        //GVdanhSachSanPham.DataBind(); 

        if (DDLLoaiSP.SelectedItem.Text.Equals("Tất cả"))
        {
            dataProduct();

        }
        else
        {
            var queryProdcutWhere = LoadData("SELECT * FROM tbl_SanPham WHERE  FK_sDanhMucSanPhamID = '" + DDLLoaiSP.SelectedItem.Text + "' ");
            if (queryProdcutWhere != null)
            {
                GVdanhSachSanPham.DataSource = queryProdcutWhere;
                GVdanhSachSanPham.DataBind();
            }
            else
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Thêm thành công')", true);
        }

    }

    bool kiemTra()
    {
        bool kt = true;
        if (txtTenSanPham.Text == "")
        {
            CustomValidatorTenSP.Text = "Nhập tên sản phẩm đi";
            CustomValidatorTenSP.IsValid = false;
            kt = false;
        }
        else CustomValidatorTenSP.IsValid = true;
        if (DDLKieuSP.SelectedItem.Text == "" || DDLKieuSP.SelectedItem.Text == "Chọn")
        {
            CustomValidatorKieuSP.Text = "Chọn loại sản phẩm";
            CustomValidatorKieuSP.IsValid = false;
            kt = false;
        } else CustomValidatorKieuSP.IsValid = true;        
        if (txtGiaBan.Text == "")
        {
            CustomValidatorGiaBan.Text = "Nhập giá bán";
            CustomValidatorGiaBan.IsValid = false;
            kt = false;
        }
        else CustomValidatorGiaBan.IsValid = true;
        if (txtSLCon.Text == "")
        {
            CustomValidatorSLTon.Text = "Nhập số lượng sản phẩm";
            CustomValidatorSLTon.IsValid = false;
            kt = false;
        }
        else CustomValidatorSLTon.IsValid = true;
        if (txtXuatXu.Text == "")
        {
            CustomValidatorXXu.Text = "Nhập nơi sản xuất";
            CustomValidatorXXu.IsValid = false;
            kt = false;
        }
        else CustomValidatorXXu.IsValid = true;
        if (txtMoTa.Text == "")
        {
            CustomValidatorMoTa.Text = "Nhập mô tả sản phẩm";
            CustomValidatorMoTa.IsValid = false;
            kt = false;
        }
        else CustomValidatorMoTa.IsValid = false;

        try
        {
            for (int i = 0; i < txtSLCon.Text.Length; i++)
            {
                int a = Convert.ToInt32(txtSLCon.Text[i].ToString());
            }
        }
        catch
        {
            if (!CustomValidatorSLTon.IsValid == true)
            {
                CustomValidatorSLTon.Text = "Chỉ nhập số";
                CustomValidatorSLTon.IsValid = false;
            }
            kt = false;
        }

        try { 
            for (int i = 0; i < txtGiaBan.Text.Length; i++)
            {
                int a = Convert.ToInt32(txtGiaBan.Text[i].ToString());
            } 
        }
        catch
        {
            if (!CustomValidatorGiaBan.IsValid == true) 
            {
                CustomValidatorGiaBan.Text = "Giá bán phải là số";
                CustomValidatorGiaBan.IsValid = false;
            }
        }
        return kt;

    }
    public void newTextFiledInput()
    {

        txtMaSanPham.Text = "Mã sản phẩm tự tạo";
        txtMaSanPham.Enabled = true;
        txtTenSanPham.Text = "";
        txtGiaBan.Text = "";
        txtMoTa.Text = "";
        txtSLCon.Text = "";
        txtSXem.Text = "";
        txtXuatXu.Text = "";
             
    }
    protected void btnXoa_Click(object sender, EventArgs e)
    {
       // tbl_SanPham sanpham = db.tbl_SanPhams.SingleOrDefault(p => p.sTenSanPham == txtTenSanPham.Text);
    //    txtMaSanPham.Enabled = true;
      //  txtMaSanPham.ReadOnly = false;
        

        if(txtMaSanPham.Text.Equals("")){
            CustomValidatorTenSP.Text = "Bạn hãy chọn 1 sản phẩm để xóa";
            CustomValidatorTenSP.IsValid = false;
        }
        else
        {
            CustomValidatorTenSP.IsValid = true;
        //    db.tbl_SanPhams.DeleteAllOnSubmit(sanpham);
            LoadData("delete from tbl_SanPham where PK_iSanPhamID = '" + txtMaSanPham.Text + "'");
           // db.SubmitChanges();
           // LoadData_CT();
            dataProduct();
        }
        newTextFiledInput();
    
    }
    protected void btnSua_Click(object sender, EventArgs e)
    {
    //    tbl_SanPham sanpham = db.tbl_SanPhams.SingleOrDefault(p => p.sTenSanPham == txtTenSanPham.Text);

    //    updateSanPham("update");
    //    sanpham.iSoLuongTon = Convert.ToInt32(txtSLCon.Text);
    //    sanpham.iSoLuongXem = Convert.ToInt32(txtSXem.Text);
        if (txtMaSanPham.Text != "")
        {
            CustomValidatorTenSP.IsValid = true;
            LoadData("update tbl_SanPham set iSoLuongTon = '" + txtSLCon.Text + "' where PK_iSanPhamID = '" + txtMaSanPham.Text + "'");
        }
        else
        {
            CustomValidatorTenSP.ErrorMessage = "Chưa nhập mã sản phẩm muốn xóa";
            CustomValidatorTenSP.IsValid = false;
        }
        //LoadData_CT();
        dataProduct();
    }

    void updateSanPham(string type)
    {
        //tbl_SanPham sanpham = db.tbl_SanPhams.SingleOrDefault(p => p.PK_iSanPhamID == Convert.ToInt32(txtMaSanPham.Text));
        //if (type == "insert")
        //{
        //    sanpham.iSoLuongTon = sanpham.iSoLuongTon + Convert.ToInt32(txtSLCon.Text);
        //    sanpham.iSoLuongXem = sanpham.iSoLuongXem + Convert.ToInt32(txtSXem.Text);
        //    db.SubmitChanges();
        //}
        //if (type == "update")
        //{
        //    sanpham.iSoLuongTon = sanpham.iSoLuongTon + Convert.ToInt32(txtSLCon.Text);
        //    sanpham.iSoLuongXem = sanpham.iSoLuongXem + Convert.ToInt32(txtSXem.Text);
        //    db.SubmitChanges();
        //}
        //if (type == "delete")
        //{
        //    sanpham.iSoLuongTon = sanpham.iSoLuongTon - Convert.ToInt32(txtSLCon.Text);
        //    sanpham.iSoLuongXem = sanpham.iSoLuongXem - Convert.ToInt32(txtSXem.Text);
        //    db.SubmitChanges();
        //}
    }
    protected void GVdanhSachSanPham_SelectedIndexChanged(object sender, EventArgs e)
    {

    }


    protected void GVdanhSachSanPham_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GVdanhSachSanPham.PageIndex = e.NewPageIndex;
    }
	
}