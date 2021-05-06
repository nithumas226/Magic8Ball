﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic8Ball
{
    public partial class Form1 : Form
    {
        Random randGen = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void ballButton_Click(object sender, EventArgs e)
        {
            int number;
            number = randGen.Next(1, 7);

            switch (number)
            {
                case 1:
                    outputLabel.Text = "Definitley";
                    break;
                case 2:
                    outputLabel.Text = "Never";
                    break;
                case 3:
                    outputLabel.Text = "Likely";
                    break;
                case 4:
                    outputLabel.Text = "Highley Likely";
                    break;
                case 5:
                    outputLabel.Text = "Unlikely";
                    break;
                case 6:
                    outputLabel.Text = "Highley Unlikely";
                    break;
            }

        }
    }
}
