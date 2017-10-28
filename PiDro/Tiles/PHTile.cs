﻿using System;
using System.Windows.Forms;

namespace Pidro.Tiles
{
    public partial class PHTile : UserControl
    {
        public PHTile()
        {
            InitializeComponent();
            
            panel1.BackColor = ComponentBase.colorPallet4;  
            textBox1.BackColor = ComponentBase.colorPallet1;
            textBox1.ForeColor = ComponentBase.colorPallet5;
            button1.BackColor = ComponentBase.colorPallet3;
            button2.BackColor = ComponentBase.colorPallet3;
            button3.BackColor = ComponentBase.colorPallet3;
            label1.ForeColor = ComponentBase.colorPallet3;
        }

        public void set(String ph)
        {
            textBox1.Text = ph;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
