using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NOC_Phonebook.Phonebook_Tabs
{
    public partial class anm_user_control : UserControl
    {
        private static LyncCall call;

        public anm_user_control()
        {
            InitializeComponent();
        }

        private void InitializeControls()
        {
            Mario_contact.MobileButtonClick += new EventHandler(Mario_mobile);
            Mario_contact.SkypeButtonClick += new EventHandler(Mario_skype);

            Alon_contact.MobileButtonClick += new EventHandler(Alon_mobile);
            Alon_contact.SkypeButtonClick += new EventHandler(Alon_skype);

            Moshe_contact.MobileButtonClick += new EventHandler(Moshe_mobile);
            Moshe_contact.SkypeButtonClick += new EventHandler(Moshe_skype);

            Tal_contact.MobileButtonClick += new EventHandler(Tal_mobile);
            Tal_contact.SkypeButtonClick += new EventHandler(Tal_skype);

            Elia_contact.MobileButtonClick += new EventHandler(Elia_mobile);
            Elia_contact.SkypeButtonClick += new EventHandler(Elia_skype);

            Merav_contact.MobileButtonClick += new EventHandler(Merav_mobile);
            Merav_contact.SkypeButtonClick += new EventHandler(Merav_skype);

            Jacob_contact.MobileButtonClick += new EventHandler(Jacob_mobile);
            Jacob_contact.SkypeButtonClick += new EventHandler(Jacob_skype);

            David_contact.MobileButtonClick += new EventHandler(David_mobile);
            David_contact.SkypeButtonClick += new EventHandler(David_skype);

            Inas_contact.MobileButtonClick += new EventHandler(Inas_mobile);
            Inas_contact.SkypeButtonClick += new EventHandler(Inas_skype);

            Tsahhi_contact.MobileButtonClick += new EventHandler(Tsahhi_mobile);
            Tsahhi_contact.SkypeButtonClick += new EventHandler(Tsahhi_skype);

            MosheM_contact.MobileButtonClick += new EventHandler(MosheM_mobile);
            MosheM_contact.SkypeButtonClick += new EventHandler(MosheM_skype);
        }

        private void MosheM_skype(object sender, EventArgs e)
        {
            
        }

        private void MosheM_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972503137667");
        }

        private void Tsahhi_skype(object sender, EventArgs e)
        {
            
        }

        private void Tsahhi_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972506474284");
        }

        private void Inas_skype(object sender, EventArgs e)
        {
            
        }

        private void Inas_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972503137671");
        }

        private void David_skype(object sender, EventArgs e)
        {
            
        }

        private void David_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972 54 4497037");
        }

        private void Jacob_skype(object sender, EventArgs e)
        {
            
        }

        private void Jacob_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972 546 818525");
        }

        private void Merav_skype(object sender, EventArgs e)
        {
            
        }

        private void Merav_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972 50 3137633");
        }

        private void Elia_skype(object sender, EventArgs e)
        {
            
        }

        private void Elia_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972503137566");
        }

        private void Tal_skype(object sender, EventArgs e)
        {
            
        }

        private void Tal_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972 54 4497009");
        }

        private void Moshe_skype(object sender, EventArgs e)
        {
            
        }

        private void Moshe_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972 50 3137636");
        }

        private void Alon_skype(object sender, EventArgs e)
        {
            
        }

        private void Alon_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972509552021");
        }

        private void Mario_skype(object sender, EventArgs e)
        {
            
        }

        private void Mario_mobile(object sender, EventArgs e)
        {
            call.makeCall("+50683443195");
        }

        // Declare a Name property of type string:
        public LyncCall Call
        {
            get
            {
                return call;
            }
            set
            {
                call = value;
            }
        }

        /// <summary>
        /// Add contacts to the contact list
        /// </summary>
        /// <param name="contactList"></param>
        public void Fill_list(List<Contact> contactList)
        {
            AddContactToList(contactList, Mario_contact);
            AddContactToList(contactList, Alon_contact);
            AddContactToList(contactList, Moshe_contact);
            AddContactToList(contactList, Tal_contact);
            AddContactToList(contactList, Elia_contact);
            AddContactToList(contactList, Merav_contact);
            AddContactToList(contactList, Jacob_contact);
            AddContactToList(contactList, David_contact);
            AddContactToList(contactList, Inas_contact);
            AddContactToList(contactList, Tsahhi_contact);
            AddContactToList(contactList, MosheM_contact);
        }

        /// <summary>
        /// Adding a contact to the list
        /// </summary>
        /// <param name="contactList">list</param>
        /// <param name="contact">contact to add</param>
        private void AddContactToList(List<Contact> contactList, Contact contact)
        {
            if (!contactList.Any(x => x.ContactLabel == contact.ContactLabel))
            {
                contactList.Add(contact);
            }
        }

    }
}
