﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circuit_Simulator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            buttonAND.Image = CircuitSimLib.Properties.Resources.and;
            buttonOR.Image = CircuitSimLib.Properties.Resources.or;
        }

        private void buttonAND_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Cross;
        }

        private void buttonOR_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Cross;
        }
    }
}
