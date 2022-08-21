using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientSide
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form1.IP;
            textBox2.Text = Convert.ToString(Form1.Port);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Form1.IP = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Form1.Port = int.Parse(textBox2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("The Port number cannot contain letters or special characters","PORT FORMAT ALERT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);   
            }
        }
    }
}
