﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ltm_lab4
{
    public partial class Bai4_ViewSource : Form
    {
        public Bai4_ViewSource(string html)
        {
            InitializeComponent();
            richTextBox1.Text = html;
        }
    }
}
