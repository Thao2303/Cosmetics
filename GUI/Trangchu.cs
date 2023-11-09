using Cosmetics.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cosmetics
{
    public partial class Form1 : Form
     {
        private Form currentFormChild;

        private void OpenChildForm(Form ChildForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(ChildForm);
            panel_body.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btMuahang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Hoadon());
        }

        private void btQLSP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Quanlysanpham());
        }

        private void btQLNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Quanlynhanvien());
        }

        private void btQLKH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Quanlykhachhang());
        }

        private void btQLTK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Quanlytaikhoan());
        }

        private void btLichsu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Lichsuban());
        }

        private void btSaoluu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Saoluu());
        }
    }
}
