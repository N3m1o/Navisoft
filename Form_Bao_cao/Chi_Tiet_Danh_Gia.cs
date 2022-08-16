using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Words;
using Aspose.Words.Tables;
using ThuVienWinform.Report.AsposeWordExtension;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Word;


namespace Navisoft.Form_Bao_cao
{
    public partial class Chi_Tiet_Danh_Gia : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-IQ04FMD\SQLEXPRESS;Initial Catalog=NamViet;Integrated Security=True";
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        System.Data.DataTable table = new System.Data.DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT MaDG AS N'Mã đánh giá', MaDDG AS N'Mã đợt đánh giá', DanhGia.MaNV AS N'Mã nhân viên', TenNV AS N'Tên nhân viên', NgayDG AS N'Ngày đánh giá', DiemNVTDG AS N'Điểm nhân viên tự đánh giá', DiemQLDG AS N'Điểm quản lý đánh giá', XetDuyet AS N'Xét duyệt', YKienPheDuyet AS N'Ý kiến phê duyệt', TrangThai AS N'Trạng thái' FROM DanhGia INNER JOIN NhanVien ON DanhGia.MaNV = NhanVien.MaNV";
            dataAdapter.SelectCommand = command;
            table.Clear();
            dataAdapter.Fill(table);
            dgv.DataSource = table;
        }

        public Chi_Tiet_Danh_Gia()
        {
            InitializeComponent();
        }

        private void Chi_Tiet_Danh_Gia_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void btn_Xuat_Click(object sender, EventArgs e)
        {
            var homNay = DateTime.Now;
            //Dẫn xuất file template
            Aspose.Words.Document baoCao = new Aspose.Words.Document("Template\\Bao_Cao_Chi_Tiet_Template.doc");

            //Điền thông tin vào file word
            baoCao.MailMerge.Execute(new[] { "Ngay_Thang_Nam_BC" }, new[] { string.Format("Hà Nội, ngày {0} tháng {1} năm {2}", homNay.Day, homNay.Month, homNay.Year) });

            //Điền thông tin lên bảng

            Aspose.Words.Tables.Table tableBaoCao = baoCao.GetChild(NodeType.Table, 1, true) as Aspose.Words.Tables.Table;//Lấy bảng thứ 2 trong file mẫu
            int hangHienTai = 1;
            int soDong = dgv.RowCount;
            tableBaoCao.InsertRows(hangHienTai, hangHienTai, soDong);

            loadData();

            for (int i = 0; i < soDong; i++)
            {
                tableBaoCao.PutValue(i + 2, 0, (i + 1).ToString());
                tableBaoCao.PutValue(i + 2, 1, dgv.Rows[i].Cells[1].Value.ToString());
                tableBaoCao.PutValue(i + 2, 2, dgv.Rows[i].Cells[2].Value.ToString());
                tableBaoCao.PutValue(i + 2, 3, dgv.Rows[i].Cells[3].Value.ToString());
                tableBaoCao.PutValue(i + 2, 4, dgv.Rows[i].Cells[4].Value.ToString());
                tableBaoCao.PutValue(i + 2, 5, dgv.Rows[i].Cells[7].Value.ToString());
                tableBaoCao.PutValue(i + 2, 6, dgv.Rows[i].Cells[5].Value.ToString());
                tableBaoCao.PutValue(i + 2, 7, dgv.Rows[i].Cells[6].Value.ToString());
            }

            //Lưu và mở file
            baoCao.SaveAndOpenFile("Bao_Cao_Chi_Tiet.docx");

            MessageBox.Show("Xuất báo cáo thành công");
        }
    }
}
