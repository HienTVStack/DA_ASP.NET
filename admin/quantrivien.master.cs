using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class admin_quantrivien : System.Web.UI.MasterPage
{
    //DataClassesDataContext db = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {

        //btnDangNhap.Text = "Đăng nhập";

        //lbUserAdmin.Text = null;
        //huongDangDien();
        //viewMain.ActiveViewIndex = 2;
        //if (lbUserAdmin.Text != null)
        //{
        //    viewMain.ActiveViewIndex = 2;
        //}
        //else
        //{
        //    viewMain.ActiveViewIndex = 0;
        //}
        //Session.Add("sSoDienThoai", txtSoDienThoai);
        //if (txtSoDienThoai.Text == "")
        //{
        //    viewMain.ActiveViewIndex = 0;
        //}
        //else
        //{
        //    viewMain.ActiveViewIndex = 2;
        //}
        //viewMain.ActiveViewIndex = 0;
        
    }
    protected void btnTaoTaiKhoan_Click(object sender, EventArgs e)
    {
        //viewMain.ActiveViewIndex = 1;
    }
    public void huongDangDien()
    {
        //txtDiaChi.Attributes.Add("placeholder", "Địa chỉ của bạn");
        //txtHoTen.Attributes.Add("placeholder", "Họ và tên đầy đủ");
        //txtMatKhau.Attributes.Add("placeholder", "Nhập mật khẩu");
        //txtRMatKhau.Attributes.Add("placeholder", "Nhập lại mật khẩu");
        //txtSoDienThoai.Attributes.Add("placeholder", "Nhập số điện thoại");
        //txtEmail.Attributes.Add("placeholder", "Nhập địa chỉ email");
        //txtNameAdmin.Attributes.Add("placeholder", "Số di động hoặc địa chỉ email");
        //txtPasswordAdmin.Attributes.Add("placeholder", "Nhập mật khẩu");
      //  txtEmailGY.Attributes.Add("placeholder", "Email của bạn: ");
      //  txtMessageGY.Attributes.Add("placeholder", "Nội dung góp ý");
        
    }

    protected void btnDangNhap1_Click(object sender, EventArgs e)
    {
        //var dskhachhang = from p in db.tbl_TaiKhoans select p;
        //foreach (tbl_TaiKhoan TaiKhoan in dskhachhang)
        //{
        //    if ((TaiKhoan.sSoDienThoai == txtNameAdmin.Text && TaiKhoan.sMatKhau == txtPasswordAdmin.Text) || (TaiKhoan.sEmail == txtNameAdmin.Text && TaiKhoan.sMatKhau == txtPasswordAdmin.Text))
        //    {
        //        lbUserAdmin.Text = TaiKhoan.sHoTen;
        //        btnDangNhap.Text = null;
        //        viewMain.ActiveViewIndex = 2;
        //    }
        //    else
        //    {
        //        TBDangNhapLoi.ErrorMessage = "Tên đăng nhập hoặc mật khẩu không đúng";
        //        TBDangNhapLoi.IsValid = false;
                
                
        //    }
        //}
        //if (kiemTraDangNhap() == true)
        //{
        //    var hoTen = from p in db.tbl_TaiKhoans
        //                where p.sSoDienThoai.Equals(txtSoDienThoai.Text)
        //                select new { p.sHoTen };
        //    if (hoTen.ToList().Count > 0)
        //    {
        //        btnDangNhap.Text = hoTen.ToString();
        //        viewMain.ActiveViewIndex = 2;
        //    }
            
        //}
        //else
        //{
        //    TBDangNhapLoi.ErrorMessage = "Tên đăng nhập hoặc mật khẩu không đúng";
        //    TBDangNhapLoi.IsValid = false;
        //}
    }
    //bool kiemTraDangNhap()
    //{
    //    bool tmp = false;
    //    var dsTK = from p in db.tbl_TaiKhoans
    //               select p;
    //    foreach (tbl_TaiKhoan taiKhoan in dsTK)
    //    {
    //        if ((taiKhoan.sSoDienThoai == txtNameAdmin.Text) || (taiKhoan.sEmail == txtNameAdmin.Text))
    //        {
    //            txtMatKhau.Text = "1";
    //            var matKhau = from q in db.tbl_TaiKhoans
    //                          where q.sMatKhau.Equals(txtMatKhau.Text)
    //                          select new { q.sMatKhau, q.sSoDienThoai, q.sEmail };
               
    //            if (matKhau.ToList().Count > 0)
    //            {
    //                tmp = true;
    //            }
    //            else
    //            {
    //                tmp = false;
    //            }
    //        }
    //    }


    //    return tmp;
    //}
    protected void btnRDangNhap_Click(object sender, EventArgs e)
    {
        
      
       
    }

    protected void btnDangKi_Click(object sender, EventArgs e)
    {
        //tbl_TaiKhoan TaiKhoan = new tbl_TaiKhoan();

        //var sltk = from p in db.tbl_TaiKhoans where p.sSoDienThoai == txtSoDienThoai.Text select p.sSoDienThoai;

        //if (sltk.Count() > 0)
        //{
        //    CustomValidatorDangKi.ErrorMessage = "Số điện thoại hoặc email đã có người sử dụng";
        //    CustomValidatorDangKi.IsValid = false;
        //}
        //else
        //{
        //    TaiKhoan.sMatKhau = txtMatKhau.Text;
        //    TaiKhoan.sHoTen = txtHoTen.Text;
        //    TaiKhoan.sSoDienThoai = txtSoDienThoai.Text;
        //    TaiKhoan.sEmail = txtEmail.Text;
        //    TaiKhoan.sDiaChi = txtDiaChi.Text;
        //    TaiKhoan.sChucVu = "ADMIN";
        //    TaiKhoan.sNamSinh = ddlDay.SelectedItem.Text + "/" + ddlThang.SelectedItem.Text + "/" + ddrNam.SelectedItem.Text;
        //    //rblGioiTinh.SelectedItem.Text = "Nam";
        //    if (rblGioiTinh.SelectedItem.Text == "Nam")
        //    {
        //        TaiKhoan.bGioiTinh = true;
        //    }
        //    else
        //        TaiKhoan.bGioiTinh = false;

        //    db.tbl_TaiKhoans.InsertOnSubmit(TaiKhoan);
        //   // db.SubmitChanges();
        //}


        //db.SubmitChanges();
    }

    private bool kiemTraTonTai()
    {
        bool takt = false;
        //String sdt = txtSoDienThoai.Text;
        //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["websiteBanHangOnl"].ConnectionString);
        //conn.Open();
        //SqlCommand cmd = new SqlCommand("select sSoDienThoai from tbl_TaiKhoan");

        //SqlDataReader dr = cmd.ExecuteReader();
        //while (dr.Read())
        //{
        //    if (sdt == dr.GetString(0))
        //    {
        //        takt = true;
        //        break;
        //    }
        //}
        //conn.Close();
        return takt;
        //bool tmp = false;
        //var sltk = from p in db.tbl_TaiKhoans where p.sSoDienThoai == txtSoDienThoai.Text select p.sSoDienThoai.Count();
        //int a = sltk.Count();
        //if
        //return tmp;
    }
    
}
