using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA1_QLCH_DongHo
{
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = System.Drawing.Color.FromArgb(30, 128, 186);
        }

        private void btnLamMoi_MouseUp(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = System.Drawing.Color.PeachPuff;
        }

        private void btnThem_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = System.Drawing.Color.FromArgb(30, 128, 185);
        }

        private void btnThem_MouseUp(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = System.Drawing.Color.PeachPuff;
        }

        private void btnSua_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = System.Drawing.Color.FromArgb(30, 128, 185);
        }

        private void btnSua_MouseUp(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = System.Drawing.Color.PeachPuff;
        }

        private void btnXoa_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = System.Drawing.Color.FromArgb(30, 128, 185);
        }

        private void btnXoa_MouseUp(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = System.Drawing.Color.PeachPuff;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }
    }
}
