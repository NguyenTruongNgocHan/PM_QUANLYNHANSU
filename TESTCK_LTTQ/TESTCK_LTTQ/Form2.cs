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
    public partial class Form2 : Form
    {
        private string connStr = @"Server=DESKTOP-VTBENSB\MSSQLK2023;Database=QL_THUVIEN;Trusted_Connection=True;";
        
        public Form2()
        {
            InitializeComponent();
        }

        private void tHUVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tHUVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qL_THUVIENDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ClearInputFields();

        }

        private void tHELOAILabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTENSACH.Text) || string.IsNullOrWhiteSpace(tbTACGIA.Text) ||
       string.IsNullOrWhiteSpace(tbTHELOAI.Text) || string.IsNullOrWhiteSpace(tbSLTON.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = "INSERT INTO THUVIEN (TENSACH, TACGIA, THELOAI, SLTON) " +
                                   "VALUES (@TENSACH, @TACGIA, @THELOAI, @SLTON)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TENSACH", tbTENSACH.Text);
                        cmd.Parameters.AddWithValue("@TACGIA", tbTACGIA.Text);
                        cmd.Parameters.AddWithValue("@THELOAI", tbTHELOAI.Text);
                        cmd.Parameters.AddWithValue("@SLTON", int.Parse(tbSLTON.Text));

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Thêm sách thành công!");
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void ClearInputFields()
        {
            tbTENSACH.Clear();
            tbTACGIA.Clear();
            tbTHELOAI.Clear();
            tbSLTON.Clear();
        }


    }
}
