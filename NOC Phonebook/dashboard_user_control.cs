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

            search_result_1.MobileButtonClick += new EventHandler(result1_mobile);
            search_result_1.SkypeButtonClick += new EventHandler(result1_skype);

            search_result_2.MobileButtonClick += new EventHandler(result2_mobile);
            search_result_2.SkypeButtonClick += new EventHandler(result2_skype);

            search_result_3.MobileButtonClick += new EventHandler(result3_mobile);
            search_result_3.SkypeButtonClick += new EventHandler(result3_skype);
        }

        private void result3_skype(object sender, EventArgs e)
        {
            
        }

        private void result3_mobile(object sender, EventArgs e)
        {
            call.makeCall(search_result_3.MobileNumber);
        }

        private void result2_skype(object sender, EventArgs e)
        {
            
        }

        private void result2_mobile(object sender, EventArgs e)
        {
            call.makeCall(search_result_2.MobileNumber);
        }

        private void result1_skype(object sender, EventArgs e)
        {
            
        }

        private void result1_mobile(object sender, EventArgs e)
        {
            call.makeCall(search_result_1.MobileNumber);
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
        /// Hide the buttons
        /// </summary>
        private void HideComponents()
        {
            search_result_1.Visible = false;
            search_result_2.Visible = false;
            search_result_3.Visible = false;
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
            foreach (Contact c in ContactList)
            {
                if (c.ContactLabel.IndexOf(searchFor, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    searchResults.Add(c);
                    //MessageBox.Show("Name: "+c.ContactLabel+"\nNumber: "+c.MobileNumber);
                }
            }

            HideComponents();
            if (searchResults.Count >= 3)
            {
                search_result_1.ContactLabel = searchResults[0].ContactLabel;
                search_result_1.MobileNumber = searchResults[0].MobileNumber;
                search_result_1.Visible = true;
                search_result_2.ContactLabel = searchResults[1].ContactLabel;
                search_result_2.MobileNumber = searchResults[1].MobileNumber;
                search_result_2.Visible = true;
                search_result_3.ContactLabel = searchResults[2].ContactLabel;
                search_result_3.MobileNumber = searchResults[2].MobileNumber;
                search_result_3.Visible = true;
            }
            else
            {
                if (searchResults.Count == 2)
                {
                    search_result_1.ContactLabel = searchResults[0].ContactLabel;
                    search_result_1.MobileNumber = searchResults[0].MobileNumber;
                    search_result_1.Visible = true;
                    search_result_2.ContactLabel = searchResults[1].ContactLabel;
                    search_result_2.MobileNumber = searchResults[1].MobileNumber;
                    search_result_2.Visible = true;
                }
                else
                {
                    if (searchResults.Count == 1)
                    {
                        search_result_1.ContactLabel = searchResults[0].ContactLabel;
                        search_result_1.MobileNumber = searchResults[0].MobileNumber;
                        search_result_1.Visible = true;
                    }
                    else
                    {
                        //no results
                    }
                }
            }
        }
    }
}
