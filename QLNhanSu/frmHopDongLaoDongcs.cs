using QLNhanSu.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu
{
    public partial class frmHopDongLaoDongcs : Form
    {
        string status = "";
        int index = -1;
        string filename = "hopDong.xml";
        DataTable dataTableWrite = new DataTable();
        DataTable dataTableRead = new DataTable();

        DataSet dataSetWrite = new DataSet();
        DataSet dataSetRead = new DataSet();
        bool isDataWritten = false;

        public frmHopDongLaoDongcs()
        {
            InitializeComponent();

            LoadlisHopDong();
            btHuy.Enabled = btLuu.Enabled = false;
        }

        DataTable CreateDataTable()
        {
            DataTable dataTable = new DataTable();

            DataColumn colMaHD = new DataColumn("MaHD");
            DataColumn colMaNhanVien = new DataColumn("Code");
            DataColumn colNgayBatDau = new DataColumn("NgayBatDau");
            DataColumn colNgayKetThuc = new DataColumn("NgayKetThuc");
            DataColumn colNgayKy = new DataColumn("NgayKy");

            dataTable.Columns.Add(colMaHD);
            dataTable.Columns.Add(colMaNhanVien);
            dataTable.Columns.Add(colNgayBatDau);
            dataTable.Columns.Add(colNgayKetThuc);
            dataTable.Columns.Add(colNgayKy);

            return dataTable;
        }

        void WriteXML()
        {
            try
            {
                dataTableWrite = CreateDataTable();

                foreach (var item in listHopDong.Instance.ListHD)
                {
                    dataTableWrite.Rows.Add(item.MaHD, item.Code, item.NgayBatDau, item.NgayKetTHuc, item.NgayKy);
                }

                dataSetWrite.Tables.Add(dataTableWrite);
                dataSetWrite.WriteXml(filename);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                // Xử lý khi không tìm thấy tệp tin
                Console.WriteLine("Không tìm thấy tệp tin: " + ex.Message);
            }
            catch (System.Xml.XmlException ex)
            {
                // Xử lý khi có lỗi với cú pháp XML
                Console.WriteLine("Lỗi cú pháp XML: " + ex.Message);
            }
        }

        void ReadXML()
        {
            try
            {
                dataSetRead.ReadXml(filename);
               
                if (dataSetRead.Tables.Count > 0)
                {
                    dataTableRead = dataSetRead.Tables[0];

                    // Sử dụng bảng có chỉ số 0 nếu tồn tại
                    // Tiếp tục thực hiện các thao tác với bảng này ở đây
                }
                foreach (DataRow item in dataTableRead.Rows)
                {
                    hopDongLaoDong newHD = new hopDongLaoDong(item);
                    listHopDong.Instance.ListHD.Add(newHD);
                }
            }
            catch (System.IO.FileNotFoundException ex)
            {
                // Xử lý khi không tìm thấy tệp tin
                Console.WriteLine("Không tìm thấy tệp tin: " + ex.Message);
            }
            catch (System.Xml.XmlException ex)
            {
                // Xử lý khi có lỗi với cú pháp XML
                Console.WriteLine("Lỗi cú pháp XML: " + ex.Message);
            }
        }

        void createColumn()
        {
            var maHD = new DataGridViewTextBoxColumn();
            var maNV = new DataGridViewTextBoxColumn();
            var ngayBD = new DataGridViewTextBoxColumn();
            var ngayKT = new DataGridViewTextBoxColumn();
            var ngayKy = new DataGridViewTextBoxColumn();

            maHD.HeaderText = "Mã hợp đồng";
            maNV.HeaderText = "Mã nhân viên";
            ngayBD.HeaderText = "Ngày bắt đầu";
            ngayKT.HeaderText = "Ngày kết thúc";
            ngayKy.HeaderText = "Ngày ký";


            maHD.DataPropertyName = "MaHD";
            maNV.DataPropertyName = "Code";
            ngayBD.DataPropertyName = "NgayBatDau";
            ngayKT.DataPropertyName = "NgayKetTHuc";
            ngayKy.DataPropertyName = "NgayKy";

            dtgThongTin.Columns.AddRange(new DataGridViewColumn[] { maHD, maNV, ngayBD, ngayKT, ngayKy });
            maHD.Width = 120;
            ngayBD.Width = 200;
            ngayKT.Width = 200;
            ngayKy.Width = 200;
            maNV.Width = 100;


        }
        void LoadlisHopDong()
        {
            dtgThongTin.DataSource = null;
            createColumn();
            if (listHopDong.Instance.ListHD != null && listHopDong.Instance.ListHD.Count > 0)
            {
                dtgThongTin.DataSource = listHopDong.Instance.ListHD; // Gán dữ liệu mới
            }
            dtgThongTin.Refresh();
        }

        void EnableControls(bool isEnableTexBox, bool isEnableDataGriView)
        {
            txbMaHD.Enabled = txbNgayBD.Enabled = txbNgayKT.Enabled = txbNgayKy.Enabled = txbMaNV.Enabled = isEnableTexBox;
            dtgThongTin.Enabled = isEnableDataGriView;
        }
        void clearTextbox()
        {
            foreach (var item in this.Controls)
            {
                TextBox item1 = item as TextBox;
                if (item1 != null)
                {

                    item1.Clear();
                }
            }
        }
        //void phanQuyen()
        //{
        //    if(Consr.TaiKhoan.LoaiTaiKhoan = false)
        //    {
        //        btThem.Enabled = btXoa.Enabled= false;
        //    }
        //}




        private void frmHopDongLaoDongcs_Load(object sender, EventArgs e)
        {
            if(Const.TaiKhoan.LoaiTaiKhoan = false)
            {
                btThem.Enabled = btSua.Enabled = btXoa.Enabled = false;
            }
            EnableControls(false, true);
            ReadXML();
            LoadlisHopDong();
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            EnableControls(true, false);
            status = "Them";
            btHuy.Enabled = btLuu.Enabled = true;
            btThem.Enabled = btSua.Enabled = btXoa.Enabled = false;

        }
        private void btSua_Click(object sender, EventArgs e)
        {

            status = "Sua";
            if (index < 0)
            {
                MessageBox.Show("Hay chon mot ban ghi", "Canh bao");
                return;
            }
            EnableControls(true, false);
            txbMaHD.Text = listHopDong.Instance.ListHD[index].MaHD;
            txbNgayBD.Text = listHopDong.Instance.ListHD[index].NgayBatDau;
            txbNgayKT.Text = listHopDong.Instance.ListHD[index].NgayKetTHuc;
            txbNgayKy.Text = listHopDong.Instance.ListHD[index].NgayKy;
            txbMaNV.Text = listHopDong.Instance.ListHD[index].Code;

            btHuy.Enabled = btLuu.Enabled = true;
            btThem.Enabled = btSua.Enabled = btXoa.Enabled = false;
        }
        private void btHuy_Click(object sender, EventArgs e)
        {
            clearTextbox();
            EnableControls(false, true);
            btHuy.Enabled = btLuu.Enabled = false;
            btThem.Enabled = btSua.Enabled = btXoa.Enabled = true;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Hay chon mot ban ghi", "Canh bao");
                return;
            }
            listHopDong.Instance.ListHD.RemoveAt(index);
            LoadlisHopDong();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            string maHD = txbMaHD.Text;
            string ngayBD = txbNgayBD.Text;
            string ngayKT = txbNgayKT.Text;
            string ngayKy = txbNgayKy.Text;
            string maNV = txbMaNV.Text;
            if (status == "Them")
            {
                listHopDong.Instance.ListHD.Add(new hopDongLaoDong(maHD, maNV, ngayBD, ngayKT, ngayKy));
            }
            if (status == "Sua")
            {
                listHopDong.Instance.ListHD[index].MaHD = txbMaHD.Text;
                listHopDong.Instance.ListHD[index].NgayBatDau = txbNgayBD.Text;

                listHopDong.Instance.ListHD[index].NgayKetTHuc = txbNgayKT.Text;

                listHopDong.Instance.ListHD[index].NgayKy = txbNgayKy.Text;

                listHopDong.Instance.ListHD[index].Code = txbMaNV.Text;


            }
            EnableControls(false, true);
            LoadlisHopDong();
            clearTextbox();
            btHuy.Enabled = btLuu.Enabled = false;
            btThem.Enabled = btSua.Enabled = btXoa.Enabled = true;

        }

        private void frmHopDongLaoDongcs_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (!isDataWritten)
            {
                WriteXML();
                isDataWritten = true;
            }

        }


        private void dtgThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
