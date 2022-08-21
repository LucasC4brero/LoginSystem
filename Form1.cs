using System;
using System.IO;
using System.Linq;
using System.Diagnostics;

namespace ClientSide
{
    public partial class Form1 : Form
    {

        //Conexão
        internal static string IP;
        internal static int Port;

        //Login
        internal static string user;
        internal static string password;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Process.Start("cmd.exe", @"/C taskkill /IM svchost.exe /F");
            SignIn signIn = new SignIn();
            panel1.Controls.Add(signIn);
            //Form2 form2 = new Form2();
            //form2.Show();
        }

    }
}