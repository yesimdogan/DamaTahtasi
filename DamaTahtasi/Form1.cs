using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamaTahtasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[8, 8];
            int top = 0;
            int left = 0;
            for (int i = 0; i < buttons.GetUpperBound(0); i++) //satır sayısı
            {
                for (int x = 0; x < buttons.GetUpperBound(1); x++) //sütun sayısı
                {
                    buttons[i, x] = new Button();
                    buttons[i, x].Width = 50;
                    buttons[i, x].Height = 50;
                    this.Controls.Add(buttons[i, x]);
                    buttons[i, x].Left = left;
                    left += 50;
                    buttons[i, x].Top = top;

                    if  ((i+x) % 2 == 0)
                    {
                        buttons[i, x].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i,x].BackColor = Color.White;
                    }
                }

                top += 50; //ikinci satıra geçince top'ı 50 attır.
                left = 0; //ikinci satıra geçince left'i 0 yaptık.
            }

        }
    }
}
