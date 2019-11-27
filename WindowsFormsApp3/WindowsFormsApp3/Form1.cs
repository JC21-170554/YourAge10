using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        int guukei = 0;
        int kikei = 0;
        int guuko = 0;
        int kiko = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            int tmp = int.Parse(textBox1.Text);
          
            if (tmp > -1)
            {
                if (tmp%2==0)
                {
                    guukei = guukei + tmp;
                    guuko = guuko+1;
                }
                else
                {
                    kikei = kikei + tmp;
                    kiko = kiko+1;
                }
            }
            else
            {
                button1.Enabled = false;
            }
            lblguukei.Text = guukei.ToString();
            lblguuko.Text = guuko.ToString();
            lblkikei.Text = kikei.ToString();
            lblkiko.Text = kiko.ToString();
            
        }
    }
}
