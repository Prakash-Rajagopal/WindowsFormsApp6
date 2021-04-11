using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "Jpeg Image|*.jpg|PNG Image|*.png|Gif Image|*.gif";
            s.ShowDialog();

            System.IO.FileStream fs = (System.IO.FileStream)s.OpenFile();
            switch (s.FilterIndex)
            {
                case 1:
                    pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                    break;
                case 2:
                    pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                    break;
                case 3:
                    pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
                    break;
            }
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FontDialog f = new FontDialog();
            f.ShowDialog();
            textBox1.Font = f.Font;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            c.ShowDialog();
            textBox1.ForeColor = c.Color;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            c.ShowDialog();
            textBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#3FEF2C");
        }
    }
}
