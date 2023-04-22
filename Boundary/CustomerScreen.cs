using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using Control;
using System.Globalization;
using System.Runtime.CompilerServices;
using GUIForJTS;

namespace Jaguars_Tech_Support.Boundary
{
    public partial class CustomerScreen : TicketScreen
    {
        TicketList<Ticket> TXLIST = new TicketList<Ticket>();
        Account currentUser = new Account();
        public CustomerScreen(TicketList<Ticket> list, Account user)
        {
            currentUser = user;
            InitializeComponent();
            label2.Text = user.Name;
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
                ticketBox txInfo = new ticketBox($"{t.TicketNo}", t.TicketSubject, t.TechName, t.Status);
                Panel custPanel = new Panel();
                txInfo.ForeColor = Color.Black;
                custPanel.Location = new Point(89, y);
                custPanel.BorderStyle = BorderStyle.FixedSingle;
                custPanel.BackColor = Color.White;
                custPanel.Size = new Size(1000, 65);
                custPanel.Anchor = AnchorStyles.None;
                this.Controls.Add(custPanel);
                custPanel.Controls.Add(txInfo);
                y += 82;
            }
        }

        private void CustomerScreen_Load(object sender, EventArgs e)
        {
            Display(TXLIST);
        }


        public override void Logout()
        {
            Close();
            LoginForm login = new LoginForm();
            login.Show();
            LogoutControl.Logout(currentUser.Email);
        }
        //dont forget to put the "start request" button back on the customer page
    }
}



