using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Найти_Click(object sender, EventArgs e)
        {
            try
            {
                int A, B, x, y, i = 0;

                A = Convert.ToInt32(D1.Text);

                B = Convert.ToInt32(D2.Text);

                if (A > B)
                {
                    whille_t.Text = "A > B!";
                    for_t.Text = "A > B!";
                    dowhile.Text = "A > B!";
                }

                else
                {
                    x = Convert.ToInt32(num1.Text);

                    y = Convert.ToInt32(num2.Text);

                    i = A;

                    whille_t.Text = "";

                    while (i <= B)
                    {
                        if (i % 10 == x || i % 10 == y)
                            whille_t.Text += i + " ";
                        i++;
                    }

                    i = A;

                    dowhile.Text = "";

                    do
                    {
                        if (i % 10 == x || i % 10 == y)
                            dowhile.Text += i + " ";
                        i++;
                    }

                    while (i <= B);

                    for_t.Text = "";

                    for (int j = A; j <= B; j++)
                    {
                        if (j % 10 == x || j % 10 == y)
                            for_t.Text += i + " ";
                    }
                }
            }

            catch
            {
                whille_t.Text = "NULL";
                for_t.Text = "NULL";
                dowhile.Text = "NULL";
            }
        }
    }
}
