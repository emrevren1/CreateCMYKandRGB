using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace nesnefinal3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColor();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColor();
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColor();
        }

        private void hScrollBar4_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColor();
        }
        //--------------------------------------------------------------------------
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColor2();
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColor2();
        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColor2();
        }
        private void UpdateColor()
        {
            int c = hScrollBar1.Value;
            int m = hScrollBar2.Value;
            int y = hScrollBar3.Value;
            int k = hScrollBar4.Value;

            float cyan = c / 100f;
            float magenta = m / 100f;
            float yellow = y / 100f;
            float black = k / 100f;

            float red = (1 - cyan) * (1 - black);
            float green = (1 - magenta) * (1 - black);
            float blue = (1 - yellow) * (1 - black);

            Color color = Color.FromArgb((int)(red * 255), (int)(green * 255), (int)(blue * 255));
            pictureBox1.BackColor = color;
            //--------------------------------
        }
        private void UpdateColor2()
        {

            int r = vScrollBar1.Value;
            int g = vScrollBar2.Value;
            int b = vScrollBar3.Value;

            Color color = Color.FromArgb(r, g, b);
            pictureBox2.BackColor = color;
            //--------------------------------
        }

    }
}