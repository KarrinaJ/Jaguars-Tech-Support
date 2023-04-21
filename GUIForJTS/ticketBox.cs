using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIForJTS
{
    public partial class ticketBox : UserControl
    {
        public ticketBox()
        {
            InitializeComponent();
        }

        //ticketBox for customer
        public void ticketBox_Load(object sender, EventArgs e)
        {

        }

        public ticketBox(string ticketNo, string subject, string technician, string status)
        {
            InitializeComponent();
            label8.Text = ticketNo;
            label9.Text = subject;
            label10.Text = technician;
            label11.Text = status;
        }
    }
}
