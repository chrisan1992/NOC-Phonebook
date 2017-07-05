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
        private static LyncCall call;

        public dashboard_user_control()
        {
            InitializeComponent();

            call = new LyncCall();
        }

        /// <summary>
        /// Saves the contact list
        /// </summary>
        /// <param name="contacts"></param>
        public void SetContactList(List<Contact> contacts)
        {
            ContactList = contacts;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                btnSearch.PerformClick();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String searchFor = txtSearch.Text;
            List<Contact> searchResults = new List<Contact>();
            DataTable table = new DataTable();
            table.Columns.Add("Contact Name");
            table.Columns.Add("Mobile Number");
            table.Columns.Add("Skype Numer");
            foreach (Contact c in ContactList)
            {
                if (c.ContactLabel.IndexOf(searchFor, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    DataRow rd = table.NewRow();
                    rd[0] = c.ContactLabel;
                    rd[1] = c.MobileNumber;
                    rd[2] = c.SkypeNumber;
                    table.Rows.Add(rd);

                    searchResults.Add(c);
                    //MessageBox.Show("Name: "+c.ContactLabel+"\nNumber: "+c.MobileNumber);
                }
            }

            dataGridView1.DataSource = table;
        }
    }
}
