using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblHasil.Text = " ";
            string a1 = textmasuk.Text;      
            string value = textmasuk.Text;
            int valu;
            int valu1;
            int valu2;           
            int counter = 0;
            string a3 = textasal.Text;
            string a4 = textakhir.Text;
            valu1 = (int)a3[0];
            valu2 = (int)a4[0];
            while (valu1 != valu2)
            {
                valu1++;
                counter++;
            }
            byte contoh;
            for (int h =0; h< a1.Length; h++)
            {
                valu = (int)a1[h] + counter;
                contoh = Convert.ToByte(valu);
                lblHasil.Text += Char.ConvertFromUtf32(contoh).ToUpper();
                
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
