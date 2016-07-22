using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 猜拳
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            Button btt = (Button)sender;
            if (btt != null)
            {
                player P = new player();
                P.FistName = btt.Text;
                tp.Text= btt.Text;
                int a = P.ShowFist();

                ai A = new ai();
                ta.Text = A.fistname();
                int b = A.result;

                Judge J = new Judge();
                tresult.Text = J.IsWiner(a, b);
            }
        }
    }
}
