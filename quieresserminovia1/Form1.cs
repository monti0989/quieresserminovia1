using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quieresserminovia1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox2;
            panel2.Hide();
            button1.TabStop = false;
            btnNO.TabStop = false;
        }
        public void MoverBoton() 
        {
            Random r = new Random();
            int x = r.Next(0, this.Width - btnNO.Width);
            int y = r.Next(0, this.Height - btnNO.Height);
            btnNO.Location = new Point(x, y);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnNO_MouseMove(object sender, MouseEventArgs e)
        {
            MoverBoton();
            if (btnNO.Location == button1.Location || btnNO.Location == label1.Location) 
            {
                MoverBoton();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
