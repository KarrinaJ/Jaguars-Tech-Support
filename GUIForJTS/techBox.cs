using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIForJTS
{
    public partial class techBox : UserControl
    {
        public techBox()
        {
            InitializeComponent();
        }

        public techBox(string ticketNo, string requester, string subject, string technician, string status)
        {
            InitializeComponent();
            label1.Text = ticketNo;
            label2.Text = requester;
            label3.Text = subject;
            label4.Text = technician;
            label5.Text = status;
        }
    }
}
