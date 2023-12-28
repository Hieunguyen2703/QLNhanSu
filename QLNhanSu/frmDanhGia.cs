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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLNhanSu
{
    public partial class frmDanhGia : Form
    {
        string fileName = "danhGia.xml";
        string status = "";
        int index = -1;
        bool isDataWrite = false;
        DataTable dataTableWrite = new DataTable();
        DataTable dataTableRead = new DataTable();

        DataSet dataSetWrite = new DataSet();
        DataSet dataSetRead = new DataSet();

        public frmDanhGia()
        {
            InitializeComponent();
        }
        DataTable CreateDataTable()
        {
            DataTable dataTable = new DataTable();

            DataColumn colTenNhanVien = new DataColumn("Name");
            DataColumn colMaNhanVien = new DataColumn("Code");
            DataColumn colTenLoai = new DataColumn("TenLoai");
            DataColumn colSoTien = new DataColumn("SoTien");
            DataColumn colLiDo = new DataColumn("LiDo");

            dataTable.Columns.Add(colMaNhanVien);
            dataTable.Columns.Add(colTenNhanVien);
            dataTable.Columns.Add(colTenLoai);
            dataTable.Columns.Add(colSoTien);
            dataTable.Columns.Add(colLiDo);

            return dataTable;
        }

        void WriteXMLDanhGia()
        {
            try
            {
                dataTableWrite = CreateDataTable();

                foreach (var item in listDanhGia.Instance.DanhSachDanhGia)
                {
                    dataTableWrite.Rows.Add(item.Code, item.Name, item.SoTien, item.TenLoai, item.LiDo);
                }

                dataSetWrite.Tables.Add(dataTableWrite);
                dataSetWrite.WriteXml(fileName);
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

        void ReadXMLDanhGia()
        {
            try
            {
                dataSetRead.ReadXml(fileName);

                if (dataSetRead.Tables.Count > 0)
                {
                    dataTableRead = dataSetRead.Tables[0];


                }
                foreach (DataRow item in dataTableRead.Rows)
                {
                    danhGia newDG = new danhGia(item);
                    //listDanhGia.Instance.DanhSachDanhGia.Add(newDG);
                    if (listDanhGia.Instance != null && listDanhGia.Instance.DanhSachDanhGia != null)
                    {
                        listDanhGia.Instance.DanhSachDanhGia.Add(newDG);
                    }
                    else
                    {
                        Console.WriteLine("listDanhGia.Instance hoặc listDanhGia.Instance.DanhSachDanhGia chưa được khởi tạo.");

                    }

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
            var maNV = new DataGridViewTextBoxColumn();
            var name = new DataGridViewTextBoxColumn();
            var tenLoai = new DataGridViewTextBoxColumn();
            var soTien = new DataGridViewTextBoxColumn();
            var liDo = new DataGridViewTextBoxColumn();


            maNV.HeaderText = "Mã nhân viên";
            name.HeaderText = "Tên nhân viên";
            tenLoai.HeaderText = "Tên loại";
            soTien.HeaderText = "Số tiền";
            liDo.HeaderText = "Lí do";



            maNV.DataPropertyName = "Code";
            name.DataPropertyName = "Name";
            tenLoai.DataPropertyName = "TenLoai";
            soTien.DataPropertyName = "SoTien";
            liDo.DataPropertyName = "LiDo";

            dtgDanhGia.Columns.AddRange(new DataGridViewColumn[] { maNV, name, tenLoai, soTien, liDo });
            maNV.Width = 120;
            name.Width = 150;
            tenLoai.Width = 150;
            soTien.Width = 150;
            liDo.Width = 400;


        }
        void LoadlistDanhGia()
        {
            dtgDanhGia.DataSource = null;
            createColumn();
            if (listDanhGia.Instance.DanhSachDanhGia != null && listDanhGia.Instance.DanhSachDanhGia.Count > 0)
            {
                dtgDanhGia.DataSource = listDanhGia.Instance.DanhSachDanhGia; // Gán dữ liệu mới
            }
            dtgDanhGia.Refresh();
        }
        void EnableControls(bool isEnableTexBox, bool isEnableDataGriView)
        {
            txbMaNhanVien.Enabled = txbTenNhanVien.Enabled = txbSoTien.Enabled = txbTenLoai.Enabled = txbLiDo.Enabled = isEnableTexBox;
            dtgDanhGia.Enabled = isEnableDataGriView;
        }
        void clearTextbox()
        {
            foreach (var item in this.Controls)
            {
                System.Windows.Forms.TextBox item1 = item as System.Windows.Forms.TextBox;
                if (item1 != null)
                {

                    item1.Clear();
                }
            }
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmDanhGia_Load(object sender, EventArgs e)
        {
            createColumn();
            ReadXMLDanhGia();
            LoadlistDanhGia();
        }

        private void frmDanhGia_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isDataWrite)
            {
                WriteXMLDanhGia();
                isDataWrite = false;
            }

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
            txbMaNhanVien.Text = listDanhGia.Instance.DanhSachDanhGia[index].Code;
            txbTenNhanVien.Text = listDanhGia.Instance.DanhSachDanhGia[index].Name;
            txbTenLoai.Text = listDanhGia.Instance.DanhSachDanhGia[index].TenLoai;
            txbSoTien.Text = listDanhGia.Instance.DanhSachDanhGia[index].SoTien.ToString();
            txbLiDo.Text = listDanhGia.Instance.DanhSachDanhGia[index].LiDo;


            btHuy.Enabled = btLuu.Enabled = true;
            btThem.Enabled = btSua.Enabled = btXoa.Enabled = false;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            EnableControls(true, false);
            status = "Them";
            btHuy.Enabled = btLuu.Enabled = true;
            btThem.Enabled = btSua.Enabled = btXoa.Enabled = false;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Hay chon mot ban ghi", "Canh bao");
                return;
            }
            listDanhGia.Instance.DanhSachDanhGia.RemoveAt(index);
            LoadlistDanhGia();
        }



        private void btHuy_Click(object sender, EventArgs e)
        {
            clearTextbox();
            EnableControls(false, true);
            btHuy.Enabled = btLuu.Enabled = false;
            btThem.Enabled = btSua.Enabled = btXoa.Enabled = true;
        }
        private void btLuu_Click(object sender, EventArgs e)
        {
            string maNV = txbMaNhanVien.Text;
            string tenNV = txbTenNhanVien.Text;
            string tenLoai = txbTenLoai.Text;
            string soTien = txbSoTien.Text;
            string liDo = txbLiDo.Text;
            if (status == "Them")
            {
                
                    listDanhGia.Instance.DanhSachDanhGia.Add(new danhGia(maNV, tenNV, tenLoai, soTien, liDo));
            }
            else if (status == "Sua")
            {
                    
                    listDanhGia.Instance.DanhSachDanhGia[index].Code = maNV;
                    listDanhGia.Instance.DanhSachDanhGia[index].Name = tenNV;
                    listDanhGia.Instance.DanhSachDanhGia[index].TenLoai = tenLoai;
                    listDanhGia.Instance.DanhSachDanhGia[index].SoTien = soTien;
                    listDanhGia.Instance.DanhSachDanhGia[index].LiDo = liDo;
                
            }
            EnableControls(false, true);
            LoadlistDanhGia();
            clearTextbox();
            btHuy.Enabled = btLuu.Enabled = false;
            btThem.Enabled = btSua.Enabled = btXoa.Enabled = true;
        }
        private void dtgDanhGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
