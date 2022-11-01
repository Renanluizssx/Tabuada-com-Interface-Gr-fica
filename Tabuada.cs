using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Click(object sender, EventArgs e)
        { try
            {
                double num, resp;

                num = Convert.ToDouble(textBox1.Text);
                listBox1.Items.Clear();
                for (int c = 1; c <= 10; c++)
                {
                    resp = num * c;
                    listBox1.Items.Add("A tabuada do " + num + " e " + c + " é " + resp);
                }
            } catch
            {
                MessageBox.Show("Palavras não são permitidas");
            }
        }
    }
}