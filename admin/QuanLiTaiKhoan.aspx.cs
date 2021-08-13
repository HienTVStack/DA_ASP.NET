using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class admin_QuanLiTaiKhoan : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=VanHien;Initial Catalog=QUANLICUAHANG;Persist Security Info=True;User ID=sa;Password=123");

    protected void Page_Load(object sender, EventArgs e)
    {
        if (con.State == ConnectionState.Open)
            con.Close();
        con.Open();
        //loadDataListAccount();
        loadMain();
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

    void loadMain()
    {
        if(!IsPostBack){
            loadDataListAccount();
            loadChucVu(ddlChucVu);
            loadChucVu(ddlSearchCV);
        }
    }
    void loadChucVu( DropDownList a) {
        var ddlCV = LoadData("SELECT * FROM tbl_TaiKhoan");
        a.DataTextField = "sChucVu";
        a.DataValueField = "sChucVu";
        a.DataSource = ddlCV;
        a.DataBind();
        a.Items.Insert(0, "Tất cả");
    }
    void loadDataListAccount()
    {
        var query = LoadData("SELECT * FROM tbl_TaiKhoan");
        gvDSTaiKhoan.DataSource = query;
        gvDSTaiKhoan.DataBind();
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        if (ddlSearchCV.SelectedItem.Text.Equals("Tất cả"))
        {
            var query = LoadData("SELECT * FROM tbl_TaiKhoan WHERE sHoTen LIKE '%' + '" + txtSearchTenNV.Text + "' + '%'");
            gvDSTaiKhoan.DataSource = query;
            gvDSTaiKhoan.DataBind();
        }
        else if (txtSearchTenNV.Text.Equals(""))
        {
            var query = LoadData("SELECT * FROM tbl_TaiKhoan WHERE sChucVu = N'" + ddlSearchCV.SelectedItem.Text + "'");
            gvDSTaiKhoan.DataSource = query;
            gvDSTaiKhoan.DataBind();
        }
        else
        {
            var query = LoadData("SELECT * FROM tbl_TaiKhoan WHERE sChucVu = N'" + ddlSearchCV.SelectedItem.Text + "' AND sHoTen LIKE '%' + '" + txtSearchTenNV.Text + "' + '%'");
            gvDSTaiKhoan.DataSource = query;
            gvDSTaiKhoan.DataBind();
        }
        txtSearchTenNV.Text = "";
        
    }
    protected void gvDSTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow gr = gvDSTaiKhoan.SelectedRow;
        txtMaNV.Text = gr.Cells[1].Text;
        txtTenNV.Text = gr.Cells[2].Text;

        int rowind = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
        txtTenNV.Text = gvDSTaiKhoan.Rows[rowind].Cells[2].Text;
    }
    protected void gvDSTaiKhoan_RowCommand(object sender, GridViewCommandEventArgs e)
    {

    }

    bool checkTextbox()
    {
        bool kt = true;
        if (txtTenNV.Text.Equals(""))
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Tên tài khoản không được bỏ trống')", true);
            kt = false;
        }
        else if(txtNamSinh.Text.Equals("")) {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Năm sinh không được bỏ trống')", true);
            kt = false;
        }
        else if(txtEmail.Text.Equals("")){
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Gmail không được bỏ trống')", true);
            kt = false;
        }
        else if(txtSDT.Text.Equals("")){
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Số điện thoại không được bỏ trống')", true);
            kt = false;
        }
        else if(ddlChucVu.SelectedItem.Text.Equals("")){
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Số điện thoại không được bỏ trống')", true);
            kt = false;
        }
        

           
        return kt;

    }

    public void RefreshTextBoxInfoAccount()
    {
        txtMaNV.Text = "";
        txtTenNV.Text = "";
        txtSDT.Text = "";
        txtEmail.Text = "";
        txtNamSinh.Text = "";
        txtDiaChi.Text = "";
    }

    public void RefreshTextBoxDecentralization()
    {
        txtMaPQ.Text = "";
        txtTenQuyen.Text = "";        
    }
    public void RefreshTextBoxAccDecen()
    {
        txtMaTKQ.Text = "";
        txtMaTK.Text = "";
        txtMaPQID.Text = "";
    }
    //protected void check_CheckedChanged(object sender, EventArgs e)
    //{
    //    int rowind = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
    //    txtTenNV.Text = gvDSTaiKhoan.Rows[rowind].Cells[2].Text;
    //}

    protected void linkBtnSelectGV_Click(object sender, EventArgs e)
    {
        int rowind = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
        txtMaNV.Text = gvDSTaiKhoan.Rows[rowind].Cells[0].Text;
        txtTenNV.Text = gvDSTaiKhoan.Rows[rowind].Cells[1].Text;
        ddlChucVu.SelectedItem.Text = gvDSTaiKhoan.Rows[rowind].Cells[2].Text;
        txtEmail.Text = gvDSTaiKhoan.Rows[rowind].Cells[3].Text;
        txtSDT.Text = gvDSTaiKhoan.Rows[rowind].Cells[4].Text;
        txtNamSinh.Text = gvDSTaiKhoan.Rows[rowind].Cells[5].Text;
        rblGioiTinhh.SelectedValue = gvDSTaiKhoan.Rows[rowind].Cells[6].Text;
        txtDiaChi.Text = gvDSTaiKhoan.Rows[rowind].Cells[7].Text;
        //cblQuyenDN.SelectedValue = gvDSTaiKhoan.Rows[rowind].Cells[8].Text;
    }

    bool checkTrungEmailSDT()
    {
        bool kt = true;
        var query1 = LoadData("SELECT * FROM tbl_TaiKhoan WHERE sSoDienThoai = '" + txtSDT.Text + "'");
        var query2 = LoadData("SELECT * FROM tbl_TaiKhoan WHERE sEmail = '"+txtEmail.Text+"'");
        if (query1.Rows.Count != 0)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Số điện thoại này đã được sử dụng')", true);
            kt = false;
        }
        else if (query2.Rows.Count != 0)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Email này đã được sử dụng')", true);
            kt = false;
        }
        return kt;
    }
    protected void btnThemTK_Click(object sender, EventArgs e)
    {
        if (checkTextbox().Equals(true))
        {
            if (checkTrungEmailSDT().Equals(true))
            {
                LoadData("INSERT INTO tbl_TaiKhoan VALUES (123, '" + txtEmail.Text + "', N'" + ddlChucVu.SelectedItem.Text + "', N'" + txtTenNV.Text + "', '" + txtNamSinh.Text + "', '" + rblGioiTinhh.SelectedValue + "', N'" + txtDiaChi.Text + "', '" + txtSDT.Text + "', 1)");
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Thêm thành công')", true);
                loadDataListAccount();
                RefreshTextBoxAccDecen();
            }
        }
       
    }
    protected void cblQuyenDN_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    protected void btnXoa_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtMaNV.Text != "")
            {
                LoadData("DELETE FROM tbl_TaiKhoan WHERE PK_iTaiKhoanID = '" + txtMaNV.Text + "'");
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Xóa thành công')", true);
                RefreshTextBoxInfoAccount();
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Không tìm thấy mã nhân viên muốn xóa')", true);
            }
            loadDataListAccount();
        }
        catch
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Erro delete accout')", true);
        }
    }
    protected void btnSua_Click(object sender, EventArgs e)
    {
        try{
            if (checkTextbox().Equals(true))
            {
                LoadData("UPDATE tbl_SanPham SET (123, sHoTen = '" + txtTenNV.Text + "', iNamSinh = '" + txtNamSinh.Text + "', sSoDienThoai = '" + txtSDT.Text + "', bGioiTinh = '" + rblGioiTinhh.SelectedItem.Text+ "', sEmail = '"+txtEmail.Text+"', sDiaChi = '"+txtDiaChi.Text+"', bQuyenDangNhap = '"+cblQuyenDN.SelectedItem.Text+"')");
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Thêm thành công')", true);
            }
            loadDataListAccount();
        }
        catch
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Erro update account')", true);
        }
    }
}