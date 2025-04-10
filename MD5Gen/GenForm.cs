using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace MD5Gen
{
    public partial class GenForm : Form
    {
        private const string md5Key = "";
        public GenForm()
        {
            InitializeComponent();
        }
        private void normalTextBox_TextChanged(object sender, EventArgs e)
        {
            md5ResultTextBox.Text = GenerateTextMD5(normalTextBox.Text);
        }
        private static string GenerateTextMD5(string text)
        {
            using (var hmacMD5 = new HMACMD5(Encoding.UTF8.GetBytes(md5Key)))
            {
                byte[] data = hmacMD5.ComputeHash(Encoding.UTF8.GetBytes(text));

                StringBuilder sBuilder = new();
                for (int i = 0; i < data.Length; i++)
                    sBuilder.Append(data[i].ToString("x2"));

                return sBuilder.ToString();
            }
        }

        private void GenForm_Load(object sender, EventArgs e)
        {
            if (md5Key == "")
            {
                MessageBox.Show("There's no key defined to generate hashes!\nDon't forget to define one.", null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}