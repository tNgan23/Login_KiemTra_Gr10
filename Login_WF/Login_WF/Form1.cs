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
            // Ki?m tra th�ng tin ��ng nh?p, v� d?: t�n ng�?i d�ng v� m?t kh?u h?p l?
            string tenDangNhap = txtUserName.Text;
            string matKhau = txtPassword.Text;

            // Ki?m tra th�ng tin ��ng nh?p ? ��y...
            // V� d?: n?u th�ng tin ��ng nh?p h?p l?, chuy?n sang Form2
            if (tenDangNhap == "admin" && matKhau == "123")
            {
                // T?o m?t th? hi?n m?i c?a Form2
                Form2 form2 = new Form2();

                // Hi?n th? Form2 v� ?n Form1
                form2.Show();
                this.Hide();
            }
            else
            {
                // Hi?n th? th�ng b�o l?i n?u th�ng tin ��ng nh?p kh�ng h?p l?
                MessageBox.Show("Th�ng tin ��ng nh?p kh�ng h?p l?. Vui l?ng th? l?i.");
            }
        }
    }
}
