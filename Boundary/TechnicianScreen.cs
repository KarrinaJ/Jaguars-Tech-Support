﻿using Entity;
using GUIForJTS;
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
    public partial class TechnicianScreen : TicketScreen
    {
        TicketList<Ticket> TXLIST = new TicketList<Ticket>();
        public TechnicianScreen(TicketList<Ticket> list, string name)
        {
            InitializeComponent();
            label8.Text = name;
            foreach (Ticket t in list)
            {
                TXLIST.Add(t);
            }
        }

        public void Display(TicketList<Ticket> txList)
        {
            int y = 369;
            foreach (Ticket t in TXLIST)
            {
                techBox txInfo = new techBox($"{t.TicketNo}", t.Name, t.TicketSubject, t.TechName, t.Status);
                Panel techPanel = new Panel();
                txInfo.ForeColor = Color.Black;
                techPanel.Location = new Point(89, y);
                techPanel.BorderStyle = BorderStyle.FixedSingle;
                techPanel.BackColor = Color.White;
                techPanel.Size = new Size(1000, 65);
                techPanel.Anchor = AnchorStyles.None;
                this.Controls.Add(techPanel);
                techPanel.Controls.Add(txInfo);
                y += 82;
            }
        }

        private void TechnicianScreen_Load(object sender, EventArgs e)
        {
            Display(TXLIST);
        }
    }
}
