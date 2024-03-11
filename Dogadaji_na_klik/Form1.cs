using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dogadaji_na_klik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button_ne.MouseEnter += Button_ne_MouseEnter;
            button_ne.MouseEnter += Button_ne_MouseEnter1;
        }

        private void Button_ne_MouseEnter1(object sender, EventArgs e)
        {
            MessageBox.Show("Ma prihvati ;)");
        }


        private void Button_ne_MouseEnter(object sender, EventArgs e)
        {
            button_ne.Top += 30;
            if (button_ne.Top >= 350) button_ne.Top = 0;
        }

        private void button_da_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hvala na danom povjerenju :)");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
