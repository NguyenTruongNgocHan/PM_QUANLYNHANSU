using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTCK_LTTQ
{
    public partial class Form1 : Form
    {
        private string connStr = @"Server=DESKTOP-VTBENSB\MSSQLK2023;Database=QL_THUVIEN;Trusted_Connection=True;";
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        private DataTable dt;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            comboBoxFilter.SelectedIndex = 0;


        }

        private void tHUVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tHUVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qL_THUVIENDataSet);

        }


        private void LoadData()
        {
            try
            {
                using (conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sqlStr = "SELECT * FROM THUVIEN";
                    adapter = new SqlDataAdapter(sqlStr, conn);

                    dt = new DataTable();
                    adapter.Fill(dt);

                    dgvLibrary.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }

        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 addForm = new Form2();
            addForm.FormClosed += (s, args) => LoadData();
            addForm.ShowDialog();

        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 addForm = new Form3();
            addForm.FormClosed += (s, args) => LoadData();
            addForm.ShowDialog();
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("TENSACH LIKE '%{0}%'", toolStripTextBox1.Text);
        }

        private void dgvLibrary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FilterBooks(int filterOption)
        {
            try
            {
                using (conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = "";

                    // Xác định câu truy vấn theo lựa chọn
                    switch (filterOption)
                    {
                        case 0: // Hiển thị toàn bộ sách
                            query = "SELECT * FROM THUVIEN";
                            break;
                        case 1: // Hiển thị sách còn
                            query = "SELECT * FROM THUVIEN WHERE SLTON > 0";
                            break;
                        case 2: // Hiển thị sách đã hết
                            query = "SELECT * FROM THUVIEN WHERE SLTON = 0";
                            break;
                    }

                    // Đổ dữ liệu mới vào DataTable
                    adapter = new SqlDataAdapter(query, conn);
                    dt = new DataTable();
                    adapter.Fill(dt);

                    // Hiển thị dữ liệu mới
                    dgvLibrary.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lọc dữ liệu: " + ex.Message);
            }
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxFilter.SelectedIndex;

            // Gọi phương thức FilterBooks để lọc dữ liệu
            FilterBooks(selectedIndex);
        }
    }
}
