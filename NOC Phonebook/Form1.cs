using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Lync.Model;
using Microsoft.Lync.Model.Extensibility;
using Microsoft.Lync.Model.Conversation;
using System.IO;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;

namespace NOC_Phonebook
{
    public partial class Home : Form
    {
        /*
         * Static variables for the content
         */
        private static dashboard_user_control dashboard;
        private static phonebook_user_control phonebook;

        private List<Contact> ContactList;


        public Home()
        {
            InitializeComponent();

            //initialization of the variables
            dashboard = new dashboard_user_control();
            phonebook = new phonebook_user_control();

            ContactList = phonebook.GetContactList();
            dashboard.SetContactList(ContactList);

            //clear the container and add the first view
            main_panel.Controls.Clear();
            main_panel.Controls.Add(dashboard);
        }

        private void Window_Loaded(object sender, EventArgs e)
        {

        }

        /**
         * Close the form and exit application
         * */
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
         * Minimize the form
         * */
        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //Form Draggable
            this.MouseDown += new MouseEventHandler(Form_MouseDown);
        }

        //Form Draggable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void Home_MouseEnter(object sender, EventArgs e)
        {

        }

        /*
         * Phonebook button click
         * */
        private void button2_Click(object sender, EventArgs e)
        {
            toggleButtons(sender);
            title_label.Text = "Phonebook";
            main_panel.Controls.Clear();
            main_panel.Controls.Add(phonebook);
        }

        /*
         * Toggle the button styles when click
         * */
        private void toggleButtons(object sender)
        {
            btn_phonebook.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btn_home.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            ((Button)sender).ForeColor = System.Drawing.Color.FromArgb(1, 163, 130);
        }

        /*
         * Toggle the button style on hover
         * */
        private void toggleButtonHover(object sender)
        {
            btn_phonebook.BackColor = System.Drawing.Color.FromArgb(66, 85, 99);
            btn_home.BackColor = System.Drawing.Color.FromArgb(66, 85, 99);
            ((Button)sender).BackColor = System.Drawing.Color.FromArgb(66, 85, 99);
        }

        /*
         * Incidents button click
         * */
        private void button3_Click(object sender, EventArgs e)
        {
            toggleButtons(sender);
            title_label.Text = "Incidents";
        }

        private void btn_phonebook_MouseHover(object sender, EventArgs e)
        {
            toggleButtonHover(sender);
        }

        private void btn_phonebook_MouseLeave(object sender, EventArgs e)
        {
            btn_phonebook.BackColor = System.Drawing.Color.FromArgb(66, 85, 99);
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            toggleButtons(sender);
            title_label.Text = "Dashboard";
            main_panel.Controls.Clear();
            main_panel.Controls.Add(dashboard);
        }
    }
}
