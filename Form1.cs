using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_p2p_messenger_gui
{
    public partial class P2P_Messenger : Form
    {
        //instance variables

        //left pane
        string username, user_email, lan_ip, lan_subnet, wan_ip, wan_subnet, port;

        //centre pane
        string session_status;

        //right pane
        string client_email;

        public P2P_Messenger()
        {
            InitializeComponent();
        }

        private void btn_export_contact_csv_Click(object sender, EventArgs e)
        {
            //collate and output current user connection data to CSV
            username = field_username.Text;
            user_email = field_user_email.Text;
            
            MessageBox.Show(username + " " + user_email);
        }

        private void btn_invite_client_Click(object sender, EventArgs e)
        {
            //use email client to send 
        }

        private void P2P_Messenger_Load(object sender, EventArgs e)
        {
            //Main code block
            


        }
    }
}
