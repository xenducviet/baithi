using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace baithi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        modify modify;
        THONGTINSINHVIEN THONGTINSINHVIEN;
        private void Form1_Load(object sender, EventArgs e)
        {
            modify = new modify();
            try
            {
                dataGridView1.DataSource = modify.getAllTHONGTINSINHVIEN();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("lỗi:" + ex.Message,"lỗi",MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butthem_Click(object sender, EventArgs e)
        {
            string masv = this.txt1.Text;
            string tensv = this.txt2.Text;
            string malop = this.txt3.Text;
            string makhoa = this.txt4.Text;
            DateTime ngaysinh = this.date.Value;
            string gioitinh = this.txt6.Text;
            string diachi = this.txt7.Text;
            string sdt  = this.txt8.Text;
            THONGTINSINHVIEN = new THONGTINSINHVIEN(masv,tensv,malop,makhoa,ngaysinh,gioitinh,diachi,sdt);
            if(modify.insert(THONGTINSINHVIEN))
            {
                dataGridView1.DataSource = modify.getAllTHONGTINSINHVIEN();
            }  
            else
            {
                MessageBox.Show("lỗi:" + "không thể thêm thông tin sinh viên", "lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            string masv = this.txt1.Text;
            string tensv = this.txt2.Text;
            string malop = this.txt3.Text;
            string makhoa = this.txt4.Text;
            DateTime ngaysinh = this.date.Value;
            string gioitinh = this.txt6.Text;
            string diachi = this.txt7.Text;
            string sdt = this.txt8.Text;
            THONGTINSINHVIEN = new THONGTINSINHVIEN(masv, tensv, malop, makhoa, ngaysinh, gioitinh, diachi, sdt);
            if (modify.update(THONGTINSINHVIEN))
            {
                dataGridView1.DataSource = modify.getAllTHONGTINSINHVIEN();
            }
            else
            {
                MessageBox.Show("lỗi:" + "không thể sửa thông tin sinh viên", "lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            string Masv = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if(modify.delete(Masv))
            {
                dataGridView1.DataSource = modify.getAllTHONGTINSINHVIEN();
            }
            else
            {
                MessageBox.Show("lỗi:" + "không thể xóa thông tin sinh viên", "lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
