using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NOC_Phonebook
{
    public partial class dashboard_user_control : UserControl
    {

        private static List<Contact> ContactList;

        public dashboard_user_control()
        {
            InitializeComponent();
        }

        public void SetContactList(List<Contact> contacts)
        {
            ContactList = contacts;
        }

        /// <summary>
        /// Search from the User controls the one specified
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            String searchFor = textBox1.Text;
            foreach (Contact c in ContactList)
            {
                if (c.ContactLabel.IndexOf(searchFor, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    MessageBox.Show("Name: "+c.ContactLabel+"\nNumber: "+c.MobileNumber);
                }
            }
        }
    }
}
