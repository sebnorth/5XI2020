﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wyszukiwarka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Contains(textBox1.Text)) {

                label2.Text = "Znaleziono tekst: " + $"{textBox1.Text}";
            }

            else
            {

                label2.Text = "Nie znaleziono tekstu.";
            }
        }
    }
}
