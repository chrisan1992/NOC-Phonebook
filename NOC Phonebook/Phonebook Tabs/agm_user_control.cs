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
    public partial class agm_user_control : UserControl
    {
        private static LyncCall call;

        public agm_user_control()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            Sergio_contact.MobileButtonClick += new EventHandler(Sergio_mobile);
            Sergio_contact.SkypeButtonClick += new EventHandler(Sergio_skype);

            Bin_contact.MobileButtonClick += new EventHandler(Bin_mobile);
            Bin_contact.SkypeButtonClick += new EventHandler(Bin_skype);

            Sophi_contact.MobileButtonClick += new EventHandler(Sophi_mobile);
            Sophi_contact.SkypeButtonClick += new EventHandler(Sophi_skype);

            Amin_contact.MobileButtonClick += new EventHandler(Amin_mobile);
            Amin_contact.SkypeButtonClick += new EventHandler(Amin_skype);

            Gitit_contact.MobileButtonClick += new EventHandler(Gitit_mobile);
            Gitit_contact.SkypeButtonClick += new EventHandler(Gitit_skype);

            Anatoly_contact.MobileButtonClick += new EventHandler(Anatoly_mobile);
            Anatoly_contact.SkypeButtonClick += new EventHandler(Anatoly_skype);

            Avital_contact.MobileButtonClick += new EventHandler(Avital_mobile);
            Avital_contact.SkypeButtonClick += new EventHandler(Avital_skype);

            Itay_contact.MobileButtonClick += new EventHandler(Itay_mobile);
            Itay_contact.SkypeButtonClick += new EventHandler(Itay_skype);

            Vadim_contact.MobileButtonClick += new EventHandler(Vadim_mobile);
            Vadim_contact.SkypeButtonClick += new EventHandler(Vadim_skype);
        }

        private void Vadim_skype(object sender, EventArgs e)
        {
            
        }

        private void Vadim_mobile(object sender, EventArgs e)
        {
            call.makeCall(Vadim_contact.MobileNumber);
        }

        private void Itay_skype(object sender, EventArgs e)
        {
            
        }

        private void Itay_mobile(object sender, EventArgs e)
        {
            call.makeCall(Itay_contact.MobileNumber);
        }

        private void Avital_skype(object sender, EventArgs e)
        {
            
        }

        private void Avital_mobile(object sender, EventArgs e)
        {
            call.makeCall(Avital_contact.MobileNumber);
        }

        private void Anatoly_skype(object sender, EventArgs e)
        {
            
        }

        private void Anatoly_mobile(object sender, EventArgs e)
        {
            call.makeCall(Anatoly_contact.MobileNumber);
        }

        private void Gitit_skype(object sender, EventArgs e)
        {
            
        }

        private void Gitit_mobile(object sender, EventArgs e)
        {
            call.makeCall(Gitit_contact.MobileNumber);
        }

        private void Amin_skype(object sender, EventArgs e)
        {
            
        }

        private void Amin_mobile(object sender, EventArgs e)
        {
            call.makeCall(Amin_contact.MobileNumber);
        }

        private void Sophi_skype(object sender, EventArgs e)
        {
            
        }

        private void Sophi_mobile(object sender, EventArgs e)
        {
            call.makeCall(Sophi_contact.MobileNumber);
        }

        private void Bin_skype(object sender, EventArgs e)
        {
            
        }

        private void Bin_mobile(object sender, EventArgs e)
        {
            call.makeCall(Bin_contact.MobileNumber);
        }

        private void Sergio_skype(object sender, EventArgs e)
        {
            
        }

        private void Sergio_mobile(object sender, EventArgs e)
        {
            call.makeCall(Sergio_contact.MobileNumber);
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
            AddContactToList(contactList, Sergio_contact);
            AddContactToList(contactList, Bin_contact);
            AddContactToList(contactList, Sophi_contact);
            AddContactToList(contactList, Amin_contact);
            AddContactToList(contactList, Gitit_contact);
            AddContactToList(contactList, Anatoly_contact);
            AddContactToList(contactList, Avital_contact);
            AddContactToList(contactList, Itay_contact);
            AddContactToList(contactList, Vadim_contact);
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
