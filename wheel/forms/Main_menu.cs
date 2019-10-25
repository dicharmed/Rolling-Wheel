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
    public partial class Main_menu : Form
    {
        public Main_menu()
        {
            InitializeComponent();
        }

        private void ShowMenu()
        {
            switch (ListBox1.SelectedIndex)
            {
                case 0:
                    Сycloid frm2 = new Сycloid();
                    frm2.Show();
                    break;
                case 1:
                    Epicycloid frm3 = new Epicycloid();
                    frm3.Show();
                    break;
                case 2:
                    Gipocycloid frm4 = new Gipocycloid();
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
