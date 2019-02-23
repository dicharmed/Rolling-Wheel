using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wheel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowMenu()
        {
            switch (ListBox1.SelectedIndex)
            {
                case 0:
                    Form2 frm2 = new Form2();
                    frm2.Show();
                    break;
                case 1:
                    Form3 frm3 = new Form3();
                    frm3.Show();
                    break;
                case 2:
                    Form4 frm4 = new Form4();
                    frm4.Show();
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListBox1.Top = 0;
            ListBox1.Left = 0;
            ListBox1.Width = Width;
            ListBox1.Height = Height;
        }
        
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            ShowMenu();
        }
    }
}
