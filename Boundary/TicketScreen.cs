﻿using Control;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jaguars_Tech_Support.Boundary
{
    public partial class TicketScreen : Form1
    {
        public TicketScreen()
        {
            InitializeComponent();
        }

        public virtual void Logout()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logout();
        }
    }
}
