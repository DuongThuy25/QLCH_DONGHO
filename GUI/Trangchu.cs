using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA1_QLCH_DongHo
{
    public partial class Trangchu : Form
    {
        public Trangchu()
        {
            InitializeComponent();
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.BackColor = Color.Transparent;
            btnSanpham.FlatStyle = FlatStyle.Flat;
            btnSanpham.FlatAppearance.BorderSize = 0;
            btnSanpham.BackColor = Color.Transparent;
            btnKhachhang.FlatStyle = FlatStyle.Flat;
            btnKhachhang.FlatAppearance.BorderSize = 0;
            btnKhachhang.BackColor = Color.Transparent;
            btnNhanvien.FlatStyle = FlatStyle.Flat;
            btnNhanvien.FlatAppearance.BorderSize = 0;
            btnNhanvien.BackColor = Color.Transparent;
            btnNhaCC.FlatStyle = FlatStyle.Flat;
            btnNhaCC.FlatAppearance.BorderSize = 0;
            btnNhaCC.BackColor = Color.Transparent;
            btnBanhang.FlatStyle = FlatStyle.Flat;
            btnBanhang.FlatAppearance.BorderSize = 0;
            btnBanhang.BackColor = Color.Transparent;

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private Form currentFormChild;
        private void OpenChildForm(Form childFrom)
        {
            if(currentFormChild!= null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childFrom;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            childFrom.Dock= DockStyle.Fill;
            panel_Body.Controls.Add(childFrom);
            panel_Body.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            lblHome.Text = "HOME";
        }
        private void btnSanpham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form());
            lblHome.Text = btnSanpham.Text;
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormKhachHang());
            lblHome.Text = btnKhachhang.Text;
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNhanVien());
            lblHome.Text = btnNhanvien.Text;
        }
        private void btnNhaCC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNhaCC());
            lblHome.Text = btnNhaCC.Text;
        }
        private void btnBanhang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form());
            lblHome.Text = btnBanhang.Text;
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongKe());
            lblHome.Text = btnThongKe.Text;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            lblHome.Text = "HOME";
        }

        private void panel_Left_Paint(object sender, PaintEventArgs e)
        {
            
        }

        

        private void lblHome_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Trangchu_Load(object sender, EventArgs e)
        {
            //btnLoaiHang.Visible = false;
        }

        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            btnHome.ForeColor = Color.BlueViolet;
            
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            btnHome.ForeColor = SystemColors.ControlText;
        }

        private void btnSanpham_MouseHover(object sender, EventArgs e)
        {
            btnSanpham.ForeColor = Color.BlueViolet;
        }

        private void btnSanpham_MouseLeave(object sender, EventArgs e)
        {
            btnSanpham.ForeColor = SystemColors.ControlText;
        }

        private void btnKhachhang_MouseHover(object sender, EventArgs e)
        {
            btnKhachhang.ForeColor = Color.LightSteelBlue;
        }

        private void btnKhachhang_MouseLeave(object sender, EventArgs e)
        {
            btnKhachhang.ForeColor = SystemColors.ControlText;
        }

        private void btnNhanvien_MouseHover(object sender, EventArgs e)
        {
            btnNhanvien.ForeColor = Color.BlueViolet;
        }

        private void btnNhanvien_MouseLeave(object sender, EventArgs e)
        {
            btnNhanvien.ForeColor = SystemColors.ControlText;
        }

        private void btnNhaCC_MouseHover(object sender, EventArgs e)
        {
            btnNhaCC.ForeColor = Color.BlueViolet;
        }

        private void btnNhaCC_MouseLeave(object sender, EventArgs e)
        {
            btnNhaCC.ForeColor = SystemColors.ControlText;
        }

        private void btnBanhang_MouseHover(object sender, EventArgs e)
        {
            btnBanhang.ForeColor = Color.BlueViolet;
        }

        private void btnBanhang_MouseLeave(object sender, EventArgs e)
        {
            btnBanhang.ForeColor = SystemColors.ControlText;
        }

        private void panel_Top_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
