using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Resize_Click(object sender, EventArgs e)
        {
           if (this.Size.Width == 1920 && this.Size.Height == 1080)
            {
                this.Size = new Size(1420, 580);
            }else
            {
                this.Size = new Size(1920, 1080);
            }
        }
        private void Hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
