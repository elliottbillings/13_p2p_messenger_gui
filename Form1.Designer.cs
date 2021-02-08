using System;
using System.Windows.Forms;

namespace _13_p2p_messenger_gui
{
    partial class P2P_Messenger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_left = new System.Windows.Forms.Panel();
            this.btn_export_contact_csv = new System.Windows.Forms.Button();
            this.gb_user_details = new System.Windows.Forms.GroupBox();
            this.label_username = new System.Windows.Forms.Label();
            this.label_user_email = new System.Windows.Forms.Label();
            this.field_username = new System.Windows.Forms.TextBox();
            this.field_user_email = new System.Windows.Forms.TextBox();
            this.gb_network_config = new System.Windows.Forms.GroupBox();
            this.label_lan_subnet = new System.Windows.Forms.Label();
            this.label_lan_ip = new System.Windows.Forms.Label();
            this.radiobutton_nc_auto = new System.Windows.Forms.RadioButton();
            this.radiobutton_nc_manual = new System.Windows.Forms.RadioButton();
            this.field_lan_ip = new System.Windows.Forms.TextBox();
            this.field_lan_subnet = new System.Windows.Forms.TextBox();
            this.label_wan_ip = new System.Windows.Forms.Label();
            this.field_port = new System.Windows.Forms.TextBox();
            this.field_wan_ip = new System.Windows.Forms.TextBox();
            this.label_port = new System.Windows.Forms.Label();
            this.field_wan_subnet = new System.Windows.Forms.TextBox();
            this.label_wan_subnet = new System.Windows.Forms.Label();
            this.btn_new_session = new System.Windows.Forms.Button();
            this.panel_centre = new System.Windows.Forms.Panel();
            this.label_message = new System.Windows.Forms.Label();
            this.label_session_status = new System.Windows.Forms.Label();
            this.label_chat = new System.Windows.Forms.Label();
            this.btn_send_message = new System.Windows.Forms.Button();
            this.tbox_message = new System.Windows.Forms.TextBox();
            this.field_session_status = new System.Windows.Forms.TextBox();
            this.tbox_chat = new System.Windows.Forms.TextBox();
            this.panel_right = new System.Windows.Forms.Panel();
            this.btn_import_contact_csv = new System.Windows.Forms.Button();
            this.lb_known_clients = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lv_active_clients = new System.Windows.Forms.ListView();
            this.gb_send_client_invite = new System.Windows.Forms.GroupBox();
            this.field_client_invite_email = new System.Windows.Forms.TextBox();
            this.label_client_invite_email = new System.Windows.Forms.Label();
            this.btn_invite_client = new System.Windows.Forms.Button();
            this.btn_dial_client = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel_left.SuspendLayout();
            this.gb_user_details.SuspendLayout();
            this.gb_network_config.SuspendLayout();
            this.panel_centre.SuspendLayout();
            this.panel_right.SuspendLayout();
            this.gb_send_client_invite.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.Controls.Add(this.btn_export_contact_csv);
            this.panel_left.Controls.Add(this.gb_user_details);
            this.panel_left.Controls.Add(this.gb_network_config);
            this.panel_left.Controls.Add(this.btn_new_session);
            this.panel_left.Location = new System.Drawing.Point(3, -2);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(263, 576);
            this.panel_left.TabIndex = 1;
            // 
            // btn_export_contact_csv
            // 
            this.btn_export_contact_csv.Location = new System.Drawing.Point(9, 349);
            this.btn_export_contact_csv.Name = "btn_export_contact_csv";
            this.btn_export_contact_csv.Size = new System.Drawing.Size(250, 23);
            this.btn_export_contact_csv.TabIndex = 22;
            this.btn_export_contact_csv.Text = "Export Contact CSV";
            this.btn_export_contact_csv.UseVisualStyleBackColor = true;
            this.btn_export_contact_csv.Click += new System.EventHandler(this.btn_export_contact_csv_Click);
            // 
            // gb_user_details
            // 
            this.gb_user_details.Controls.Add(this.label_username);
            this.gb_user_details.Controls.Add(this.label_user_email);
            this.gb_user_details.Controls.Add(this.field_username);
            this.gb_user_details.Controls.Add(this.field_user_email);
            this.gb_user_details.Location = new System.Drawing.Point(10, 14);
            this.gb_user_details.Name = "gb_user_details";
            this.gb_user_details.Size = new System.Drawing.Size(235, 100);
            this.gb_user_details.TabIndex = 21;
            this.gb_user_details.TabStop = false;
            this.gb_user_details.Text = "User Details";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(16, 26);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(55, 13);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "Username";
            // 
            // label_user_email
            // 
            this.label_user_email.AutoSize = true;
            this.label_user_email.Location = new System.Drawing.Point(16, 47);
            this.label_user_email.Name = "label_user_email";
            this.label_user_email.Size = new System.Drawing.Size(32, 13);
            this.label_user_email.TabIndex = 1;
            this.label_user_email.Text = "Email";
            // 
            // field_username
            // 
            this.field_username.Location = new System.Drawing.Point(85, 23);
            this.field_username.Name = "field_username";
            this.field_username.Size = new System.Drawing.Size(135, 20);
            this.field_username.TabIndex = 2;
            this.field_username.TextChanged += new System.EventHandler(this.field_username_TextChanged);
            // 
            // field_user_email
            // 
            this.field_user_email.Location = new System.Drawing.Point(85, 44);
            this.field_user_email.Name = "field_user_email";
            this.field_user_email.Size = new System.Drawing.Size(135, 20);
            this.field_user_email.TabIndex = 3;
            this.field_user_email.TextChanged += new System.EventHandler(this.field_user_email_TextChanged);
            // 
            // gb_network_config
            // 
            this.gb_network_config.Controls.Add(this.label_lan_subnet);
            this.gb_network_config.Controls.Add(this.label_lan_ip);
            this.gb_network_config.Controls.Add(this.radiobutton_nc_auto);
            this.gb_network_config.Controls.Add(this.radiobutton_nc_manual);
            this.gb_network_config.Controls.Add(this.field_lan_ip);
            this.gb_network_config.Controls.Add(this.field_lan_subnet);
            this.gb_network_config.Controls.Add(this.label_wan_ip);
            this.gb_network_config.Controls.Add(this.field_port);
            this.gb_network_config.Controls.Add(this.field_wan_ip);
            this.gb_network_config.Controls.Add(this.label_port);
            this.gb_network_config.Controls.Add(this.field_wan_subnet);
            this.gb_network_config.Controls.Add(this.label_wan_subnet);
            this.gb_network_config.Location = new System.Drawing.Point(9, 120);
            this.gb_network_config.Name = "gb_network_config";
            this.gb_network_config.Size = new System.Drawing.Size(236, 219);
            this.gb_network_config.TabIndex = 20;
            this.gb_network_config.TabStop = false;
            this.gb_network_config.Text = "Network Config";
            // 
            // label_lan_subnet
            // 
            this.label_lan_subnet.AutoSize = true;
            this.label_lan_subnet.Location = new System.Drawing.Point(30, 98);
            this.label_lan_subnet.Name = "label_lan_subnet";
            this.label_lan_subnet.Size = new System.Drawing.Size(65, 13);
            this.label_lan_subnet.TabIndex = 7;
            this.label_lan_subnet.Text = "LAN Subnet";
            // 
            // label_lan_ip
            // 
            this.label_lan_ip.AutoSize = true;
            this.label_lan_ip.Location = new System.Drawing.Point(31, 75);
            this.label_lan_ip.Name = "label_lan_ip";
            this.label_lan_ip.Size = new System.Drawing.Size(41, 13);
            this.label_lan_ip.TabIndex = 4;
            this.label_lan_ip.Text = "LAN IP";
            // 
            // radiobutton_nc_auto
            // 
            this.radiobutton_nc_auto.AutoSize = true;
            this.radiobutton_nc_auto.Location = new System.Drawing.Point(141, 28);
            this.radiobutton_nc_auto.Name = "radiobutton_nc_auto";
            this.radiobutton_nc_auto.Size = new System.Drawing.Size(60, 17);
            this.radiobutton_nc_auto.TabIndex = 18;
            this.radiobutton_nc_auto.TabStop = true;
            this.radiobutton_nc_auto.Text = "Manual";
            this.radiobutton_nc_auto.UseVisualStyleBackColor = true;
            // 
            // radiobutton_nc_manual
            // 
            this.radiobutton_nc_manual.AutoSize = true;
            this.radiobutton_nc_manual.Location = new System.Drawing.Point(75, 28);
            this.radiobutton_nc_manual.Name = "radiobutton_nc_manual";
            this.radiobutton_nc_manual.Size = new System.Drawing.Size(47, 17);
            this.radiobutton_nc_manual.TabIndex = 17;
            this.radiobutton_nc_manual.TabStop = true;
            this.radiobutton_nc_manual.Text = "Auto";
            this.radiobutton_nc_manual.UseVisualStyleBackColor = true;
            // 
            // field_lan_ip
            // 
            this.field_lan_ip.Location = new System.Drawing.Point(101, 75);
            this.field_lan_ip.Name = "field_lan_ip";
            this.field_lan_ip.Size = new System.Drawing.Size(100, 20);
            this.field_lan_ip.TabIndex = 5;
            // 
            // field_lan_subnet
            // 
            this.field_lan_subnet.Location = new System.Drawing.Point(101, 96);
            this.field_lan_subnet.Name = "field_lan_subnet";
            this.field_lan_subnet.Size = new System.Drawing.Size(100, 20);
            this.field_lan_subnet.TabIndex = 6;
            // 
            // label_wan_ip
            // 
            this.label_wan_ip.AutoSize = true;
            this.label_wan_ip.Location = new System.Drawing.Point(31, 117);
            this.label_wan_ip.Name = "label_wan_ip";
            this.label_wan_ip.Size = new System.Drawing.Size(46, 13);
            this.label_wan_ip.TabIndex = 9;
            this.label_wan_ip.Text = "WAN IP";
            // 
            // field_port
            // 
            this.field_port.Location = new System.Drawing.Point(101, 159);
            this.field_port.Name = "field_port";
            this.field_port.Size = new System.Drawing.Size(100, 20);
            this.field_port.TabIndex = 14;
            // 
            // field_wan_ip
            // 
            this.field_wan_ip.Location = new System.Drawing.Point(101, 117);
            this.field_wan_ip.Name = "field_wan_ip";
            this.field_wan_ip.Size = new System.Drawing.Size(100, 20);
            this.field_wan_ip.TabIndex = 10;
            // 
            // label_port
            // 
            this.label_port.AutoSize = true;
            this.label_port.Location = new System.Drawing.Point(31, 159);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(26, 13);
            this.label_port.TabIndex = 13;
            this.label_port.Text = "Port";
            // 
            // field_wan_subnet
            // 
            this.field_wan_subnet.Location = new System.Drawing.Point(101, 138);
            this.field_wan_subnet.Name = "field_wan_subnet";
            this.field_wan_subnet.Size = new System.Drawing.Size(100, 20);
            this.field_wan_subnet.TabIndex = 11;
            // 
            // label_wan_subnet
            // 
            this.label_wan_subnet.AutoSize = true;
            this.label_wan_subnet.Location = new System.Drawing.Point(30, 140);
            this.label_wan_subnet.Name = "label_wan_subnet";
            this.label_wan_subnet.Size = new System.Drawing.Size(70, 13);
            this.label_wan_subnet.TabIndex = 12;
            this.label_wan_subnet.Text = "WAN Subnet";
            this.label_wan_subnet.Click += new System.EventHandler(this.label8_Click);
            // 
            // btn_new_session
            // 
            this.btn_new_session.Location = new System.Drawing.Point(9, 374);
            this.btn_new_session.Name = "btn_new_session";
            this.btn_new_session.Size = new System.Drawing.Size(250, 23);
            this.btn_new_session.TabIndex = 19;
            this.btn_new_session.Text = "New Session";
            this.btn_new_session.UseVisualStyleBackColor = true;
            this.btn_new_session.Click += new System.EventHandler(this.btn_new_session_Click);
            // 
            // panel_centre
            // 
            this.panel_centre.Controls.Add(this.label_message);
            this.panel_centre.Controls.Add(this.label_session_status);
            this.panel_centre.Controls.Add(this.label_chat);
            this.panel_centre.Controls.Add(this.btn_send_message);
            this.panel_centre.Controls.Add(this.tbox_message);
            this.panel_centre.Controls.Add(this.field_session_status);
            this.panel_centre.Controls.Add(this.tbox_chat);
            this.panel_centre.Location = new System.Drawing.Point(272, -1);
            this.panel_centre.Name = "panel_centre";
            this.panel_centre.Size = new System.Drawing.Size(263, 576);
            this.panel_centre.TabIndex = 2;
            // 
            // label_message
            // 
            this.label_message.AutoSize = true;
            this.label_message.Location = new System.Drawing.Point(4, 449);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(53, 13);
            this.label_message.TabIndex = 6;
            this.label_message.Text = "Message:";
            // 
            // label_session_status
            // 
            this.label_session_status.AutoSize = true;
            this.label_session_status.Location = new System.Drawing.Point(7, 9);
            this.label_session_status.Name = "label_session_status";
            this.label_session_status.Size = new System.Drawing.Size(77, 13);
            this.label_session_status.TabIndex = 5;
            this.label_session_status.Text = "Session Status";
            this.label_session_status.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_chat
            // 
            this.label_chat.AutoSize = true;
            this.label_chat.Location = new System.Drawing.Point(4, 40);
            this.label_chat.Name = "label_chat";
            this.label_chat.Size = new System.Drawing.Size(32, 13);
            this.label_chat.TabIndex = 4;
            this.label_chat.Text = "Chat:";
            // 
            // btn_send_message
            // 
            this.btn_send_message.Location = new System.Drawing.Point(187, 542);
            this.btn_send_message.Name = "btn_send_message";
            this.btn_send_message.Size = new System.Drawing.Size(75, 31);
            this.btn_send_message.TabIndex = 3;
            this.btn_send_message.Text = "Send";
            this.btn_send_message.UseVisualStyleBackColor = true;
            this.btn_send_message.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbox_message
            // 
            this.tbox_message.Location = new System.Drawing.Point(1, 467);
            this.tbox_message.Multiline = true;
            this.tbox_message.Name = "tbox_message";
            this.tbox_message.Size = new System.Drawing.Size(261, 69);
            this.tbox_message.TabIndex = 2;
            // 
            // field_session_status
            // 
            this.field_session_status.Location = new System.Drawing.Point(90, 6);
            this.field_session_status.Name = "field_session_status";
            this.field_session_status.ReadOnly = true;
            this.field_session_status.Size = new System.Drawing.Size(128, 20);
            this.field_session_status.TabIndex = 1;
            // 
            // tbox_chat
            // 
            this.tbox_chat.Location = new System.Drawing.Point(1, 59);
            this.tbox_chat.Multiline = true;
            this.tbox_chat.Name = "tbox_chat";
            this.tbox_chat.ReadOnly = true;
            this.tbox_chat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbox_chat.Size = new System.Drawing.Size(261, 382);
            this.tbox_chat.TabIndex = 0;
            this.tbox_chat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel_right
            // 
            this.panel_right.Controls.Add(this.btn_import_contact_csv);
            this.panel_right.Controls.Add(this.lb_known_clients);
            this.panel_right.Controls.Add(this.label2);
            this.panel_right.Controls.Add(this.label1);
            this.panel_right.Controls.Add(this.lv_active_clients);
            this.panel_right.Controls.Add(this.gb_send_client_invite);
            this.panel_right.Controls.Add(this.btn_dial_client);
            this.panel_right.Location = new System.Drawing.Point(541, 0);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(263, 576);
            this.panel_right.TabIndex = 3;
            // 
            // btn_import_contact_csv
            // 
            this.btn_import_contact_csv.Location = new System.Drawing.Point(8, 296);
            this.btn_import_contact_csv.Name = "btn_import_contact_csv";
            this.btn_import_contact_csv.Size = new System.Drawing.Size(250, 23);
            this.btn_import_contact_csv.TabIndex = 26;
            this.btn_import_contact_csv.Text = "Import Contact CSV";
            this.btn_import_contact_csv.UseVisualStyleBackColor = true;
            // 
            // lb_known_clients
            // 
            this.lb_known_clients.FormattingEnabled = true;
            this.lb_known_clients.Location = new System.Drawing.Point(136, 32);
            this.lb_known_clients.Name = "lb_known_clients";
            this.lb_known_clients.Size = new System.Drawing.Size(121, 212);
            this.lb_known_clients.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Known Clients";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Active Clients";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lv_active_clients
            // 
            this.lv_active_clients.HideSelection = false;
            this.lv_active_clients.Location = new System.Drawing.Point(5, 32);
            this.lv_active_clients.Name = "lv_active_clients";
            this.lv_active_clients.Size = new System.Drawing.Size(121, 212);
            this.lv_active_clients.TabIndex = 22;
            this.lv_active_clients.UseCompatibleStateImageBehavior = false;
            // 
            // gb_send_client_invite
            // 
            this.gb_send_client_invite.Controls.Add(this.field_client_invite_email);
            this.gb_send_client_invite.Controls.Add(this.label_client_invite_email);
            this.gb_send_client_invite.Controls.Add(this.btn_invite_client);
            this.gb_send_client_invite.Location = new System.Drawing.Point(8, 466);
            this.gb_send_client_invite.Name = "gb_send_client_invite";
            this.gb_send_client_invite.Size = new System.Drawing.Size(252, 91);
            this.gb_send_client_invite.TabIndex = 21;
            this.gb_send_client_invite.TabStop = false;
            this.gb_send_client_invite.Text = "Send Client Invite";
            // 
            // field_client_invite_email
            // 
            this.field_client_invite_email.Location = new System.Drawing.Point(58, 27);
            this.field_client_invite_email.Name = "field_client_invite_email";
            this.field_client_invite_email.Size = new System.Drawing.Size(179, 20);
            this.field_client_invite_email.TabIndex = 2;
            // 
            // label_client_invite_email
            // 
            this.label_client_invite_email.AutoSize = true;
            this.label_client_invite_email.Location = new System.Drawing.Point(5, 30);
            this.label_client_invite_email.Name = "label_client_invite_email";
            this.label_client_invite_email.Size = new System.Drawing.Size(32, 13);
            this.label_client_invite_email.TabIndex = 18;
            this.label_client_invite_email.Text = "Email";
            // 
            // btn_invite_client
            // 
            this.btn_invite_client.Location = new System.Drawing.Point(162, 53);
            this.btn_invite_client.Name = "btn_invite_client";
            this.btn_invite_client.Size = new System.Drawing.Size(75, 23);
            this.btn_invite_client.TabIndex = 1;
            this.btn_invite_client.Text = "Invite";
            this.btn_invite_client.UseVisualStyleBackColor = true;
            this.btn_invite_client.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_dial_client
            // 
            this.btn_dial_client.Location = new System.Drawing.Point(8, 267);
            this.btn_dial_client.Name = "btn_dial_client";
            this.btn_dial_client.Size = new System.Drawing.Size(250, 23);
            this.btn_dial_client.TabIndex = 20;
            this.btn_dial_client.Text = "Dial Client";
            this.btn_dial_client.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "A/M_netcon";
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // P2P_Messenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 598);
            this.Controls.Add(this.panel_right);
            this.Controls.Add(this.panel_centre);
            this.Controls.Add(this.panel_left);
            this.Name = "P2P_Messenger";
            this.Text = "P2P Messenger";
            this.Load += new System.EventHandler(this.P2P_Messenger_Load);
            this.panel_left.ResumeLayout(false);
            this.gb_user_details.ResumeLayout(false);
            this.gb_user_details.PerformLayout();
            this.gb_network_config.ResumeLayout(false);
            this.gb_network_config.PerformLayout();
            this.panel_centre.ResumeLayout(false);
            this.panel_centre.PerformLayout();
            this.panel_right.ResumeLayout(false);
            this.panel_right.PerformLayout();
            this.gb_send_client_invite.ResumeLayout(false);
            this.gb_send_client_invite.PerformLayout();
            this.ResumeLayout(false);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void field_user_email_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void field_username_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btn_new_session_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Panel panel_centre;
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.Button btn_send_message;
        private System.Windows.Forms.TextBox tbox_message;
        private System.Windows.Forms.TextBox field_session_status;
        private System.Windows.Forms.TextBox tbox_chat;
        private System.Windows.Forms.Button btn_invite_client;
        private System.Windows.Forms.Label label_chat;
        private System.Windows.Forms.Label label_session_status;
        private System.Windows.Forms.TextBox field_user_email;
        private System.Windows.Forms.TextBox field_username;
        private System.Windows.Forms.Label label_user_email;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.TextBox field_port;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.Label label_wan_subnet;
        private System.Windows.Forms.TextBox field_wan_subnet;
        private System.Windows.Forms.TextBox field_wan_ip;
        private System.Windows.Forms.Label label_wan_ip;
        private System.Windows.Forms.Label label_lan_subnet;
        private System.Windows.Forms.TextBox field_lan_subnet;
        private System.Windows.Forms.TextBox field_lan_ip;
        private System.Windows.Forms.Label label_lan_ip;
        private System.Windows.Forms.RadioButton radiobutton_nc_manual;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label_message;
        private System.Windows.Forms.TextBox field_client_invite_email;
        private System.Windows.Forms.RadioButton radiobutton_nc_auto;
        private System.Windows.Forms.Label label_client_invite_email;
        private System.Windows.Forms.Button btn_new_session;
        private System.Windows.Forms.Button btn_dial_client;
        private System.Windows.Forms.GroupBox gb_user_details;
        private System.Windows.Forms.GroupBox gb_network_config;
        private System.Windows.Forms.GroupBox gb_send_client_invite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv_active_clients;
        private System.Windows.Forms.Button btn_import_contact_csv;
        private System.Windows.Forms.ListBox lb_known_clients;
        private Button btn_export_contact_csv;
    }
}

