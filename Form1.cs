using HttpTest.helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HttpTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "http://www.189.cn/products/productOnLine.do?method=installments3&systemType=1&t=" + (long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds);
            string html = HttpHelper.PostHttpByJson(url, "{sellpid:00000000A336E7E497060F02E053AE1410ACC81F}");
            textBox1.Text = html;
            int a = 0;
        }
    }
}
