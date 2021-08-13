using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Web.UI.DataVisualization.Charting;
public partial class admin_QuanLiSanPham : System.Web.UI.Page
{

    SqlConnection con = new SqlConnection(@"Data Source=VanHien;Initial Catalog=QUANLICUAHANG;Persist Security Info=True;User ID=sa;Password=123");
    //DataClassesDataContext db = new DataClassesDataContext();
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (con.State == ConnectionState.Open)
            con.Close();
        con.Open();
        loadDataAll();
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

    void loadDataAll()
    {
        if (!IsPostBack)
        {

            //Lấy dữ liệu cho biểu đồ

            var chart_lx = LoadData("SELECT sTenSanPham, iSoLuongXem FROM tbl_SanPham");
            //ChartLuotXemSP.DataSource = chart_lx;
            //ChartLuotXemSP.DataBind();
            string[] x = new string[chart_lx.Rows.Count];
            int[] y = new int[chart_lx.Rows.Count];

            for (int i = 0; i < chart_lx.Rows.Count; i++)
            {
                x[i] = chart_lx.Rows[i][0].ToString();
                y[i] = Convert.ToInt32(chart_lx.Rows[i][1]);

            }
            ChartLuotXemSP.Series[0].Points.DataBindXY(x, y);
            ChartLuotXemSP.Series[0].ChartType = SeriesChartType.StackedColumn;

            //Truyền dữ liệu vào dropDownList

            //var loaiSanPham = from p in db.tbl_NhomSanPhams
            //                  select new { p.sTenNhomSanPham };

            //DropDownListLoaiSanPham.DataSource = loaiSanPham.ToList();
            //DropDownListLoaiSanPham.DataValueField = "sTenNhomSanPham";
            //DropDownListLoaiSanPham.DataTextField = "sTenNhomSanPham";

            //DropDownListLoaiSanPham.DataBind();

            //DropDownListLoaiSanPham.Items.Insert(0, "Tất cả");
            var accessTypeProduct = LoadData("SELECT * FROM tbl_NhomSanPham");
            DropDownListLoaiSanPham.DataTextField = "sTenNhomSanPham";
            DropDownListLoaiSanPham.DataValueField = "PK_sNhomSanPhamID";
            DropDownListLoaiSanPham.DataSource = accessTypeProduct;
            DropDownListLoaiSanPham.DataBind();
            DropDownListLoaiSanPham.Items.Insert(0, "Tất cả");
            


            var luotXem = LoadData("SELECT SUM(ISoLuongXem) from tbl_SanPham");

            loadSPBanChay();
            
        }
    }

    void loadSPBanChay()
    {
        var query = LoadData("SELECT TOP(10) * FROM tbl_SanPham ORDER BY iSoLuongXem DESC");
        gvSanBanChay.DataSource = query;
        gvSanBanChay.DataBind();
    }

    protected void ChartLuotXemSP_Load(object sender, EventArgs e)
    {

    }
    protected void DropDownListLoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
    {
        string tmp = DropDownListLoaiSanPham.SelectedItem.Text;

        if (tmp.ToString() == "Tất cả")
        {
            var chart_lx = LoadData("SELECT sTenSanPham, iSoLuongXem FROM tbl_SanPham");
            //ChartLuotXemSP.DataSource = chart_lx;
            //ChartLuotXemSP.DataBind();
            string[] x = new string[chart_lx.Rows.Count];
            int[] y = new int[chart_lx.Rows.Count];

            for (int i = 0; i < chart_lx.Rows.Count; i++)
            {
                x[i] = chart_lx.Rows[i][0].ToString();
                y[i] = Convert.ToInt32(chart_lx.Rows[i][1]);

            }
            ChartLuotXemSP.Series[0].Points.DataBindXY(x, y);
            ChartLuotXemSP.Series[0].ChartType = SeriesChartType.StackedColumn;
        }
        else
        {



            var a = LoadData("select sTenSanPham, iSoLuongXem from tbl_SanPham, tbl_DanhMucSanPham, tbl_NhomSanPham where tbl_SanPham.FK_sDanhMucSanPhamID = tbl_DanhMucSanPham.PK_sDanhMucSanPhamID and tbl_DanhMucSanPham.FK_sNhomSanPhamID = tbl_NhomSanPham.PK_sNhomSanPhamID and tbl_NhomSanPham.sTenNhomSanPham = N'" + DropDownListLoaiSanPham.SelectedItem.Text + "'");

            string[] x = new string[a.Rows.Count];
            int[] y = new int[a.Rows.Count];

            for (int i = 0; i < a.Rows.Count; i++)
            {
                x[i] = a.Rows[i][0].ToString();
                y[i] = Convert.ToInt32(a.Rows[i][1]);
            }

            ChartLuotXemSP.Series[0].Points.DataBindXY(x, y);
            ChartLuotXemSP.Series[0].ChartType = SeriesChartType.StackedColumn;
        }
    }
}