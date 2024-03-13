using System;
using System.Windows.Forms;

namespace Login_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Ki?m tra thông tin ðãng nh?p, ví d?: tên ngý?i dùng và m?t kh?u h?p l?
            string tenDangNhap = txtUserName.Text;
            string matKhau = txtPassword.Text;

            // Ki?m tra thông tin ðãng nh?p ? ðây...
            // Ví d?: n?u thông tin ðãng nh?p h?p l?, chuy?n sang Form2
            if (tenDangNhap == "admin" && matKhau == "123")
            {
                // T?o m?t th? hi?n m?i c?a Form2
                Form2 form2 = new Form2();

                // Hi?n th? Form2 và ?n Form1
                form2.Show();
                this.Hide();
            }
            else
            {
                // Hi?n th? thông báo l?i n?u thông tin ðãng nh?p không h?p l?
                MessageBox.Show("Thông tin ðãng nh?p không h?p l?. Vui l?ng th? l?i.");
            }
        }
    }
}
