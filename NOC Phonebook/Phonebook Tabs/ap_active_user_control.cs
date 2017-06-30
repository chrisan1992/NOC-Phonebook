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
    public partial class ap_active_user_control : UserControl
    {
        private static LyncCall call;

        public ap_active_user_control()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            Karvin_contact.MobileNumber = "+506 89692626";
            Karvin_contact.MobileButtonClick += new EventHandler(Karvin_mobile);
            Karvin_contact.SkypeButtonClick += new EventHandler(Karvin_skype);

            Alex_contact.MobileNumber = "+972546620319";
            Alex_contact.MobileButtonClick += new EventHandler(Alex_mobile);
            Alex_contact.SkypeButtonClick += new EventHandler(Alex_skype);

            Igal_contact.MobileNumber = "+972506380116";
            Igal_contact.MobileButtonClick += new EventHandler(Igal_mobile);
            Igal_contact.SkypeButtonClick += new EventHandler(Igal_skype);

            Diego_contact.MobileNumber = "+506 88634118";
            Diego_contact.MobileButtonClick += new EventHandler(Diego_mobile);
            Diego_contact.SkypeButtonClick += new EventHandler(Diego_skype);

            Yossi_contact.MobileNumber = "+972525697029";
            Yossi_contact.MobileButtonClick += new EventHandler(Yossi_mobile);
            Yossi_contact.SkypeButtonClick += new EventHandler(Yossi_skype);
        }

        private void Yossi_skype(object sender, EventArgs e)
        {
            
        }

        private void Yossi_mobile(object sender, EventArgs e)
        {
            call.makeCall(Yossi_contact.MobileNumber);
        }

        private void Diego_skype(object sender, EventArgs e)
        {
            
        }

        private void Diego_mobile(object sender, EventArgs e)
        {
            call.makeCall(Diego_contact.MobileNumber);
        }

        private void Igal_skype(object sender, EventArgs e)
        {
            
        }

        private void Igal_mobile(object sender, EventArgs e)
        {
            call.makeCall(Igal_contact.MobileNumber);
        }

        private void Alex_skype(object sender, EventArgs e)
        {
            
        }

        private void Alex_mobile(object sender, EventArgs e)
        {
            call.makeCall(Alex_contact.MobileNumber);
        }

        private void Karvin_skype(object sender, EventArgs e)
        {
            
        }

        private void Karvin_mobile(object sender, EventArgs e)
        {
            call.makeCall(Karvin_contact.MobileNumber);
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
            AddContactToList(contactList, Karvin_contact);
            AddContactToList(contactList, Alex_contact);
            AddContactToList(contactList, Igal_contact);
            AddContactToList(contactList, Diego_contact);
            AddContactToList(contactList, Yossi_contact);
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
