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
    public partial class alm_pc_user_control : UserControl
    {
        private static LyncCall call;

        public alm_pc_user_control()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            Gregory_contact.MobileNumber = "+506 60406721";
            Gregory_contact.MobileButtonClick += new EventHandler(Gregory_mobile);
            Gregory_contact.SkypeButtonClick += new EventHandler(Gregory_skype);

            Alejandro_contact.MobileNumber = "+506 70123648";
            Alejandro_contact.MobileButtonClick += new EventHandler(Alejandro_mobile);
            Alejandro_contact.SkypeButtonClick += new EventHandler(Alejandro_skype);

            Paula_contact.MobileNumber = "+MISSING!!!";
            Paula_contact.MobileButtonClick += new EventHandler(Paula_mobile);
            Paula_contact.SkypeButtonClick += new EventHandler(Paula_skype);

            Ortal_contact.MobileNumber = "+972543493499";
            Ortal_contact.MobileButtonClick += new EventHandler(Ortal_mobile);
            Ortal_contact.SkypeButtonClick += new EventHandler(Ortal_skype);

            Noga_contact.MobileNumber = "+972 525697045";
            Noga_contact.MobileButtonClick += new EventHandler(Noga_mobile);
            Noga_contact.SkypeButtonClick += new EventHandler(Noga_skype);

            Marina_contact.MobileNumber = "+972 522010407";
            Marina_contact.MobileButtonClick += new EventHandler(Marina_mobile);
            Marina_contact.SkypeButtonClick += new EventHandler(Marina_skype);

            Cristian_contact.MobileNumber = "+506 83411006";
            Cristian_contact.MobileButtonClick += new EventHandler(Cristian_mobile);
            Cristian_contact.SkypeButtonClick += new EventHandler(Cristian_skype);

            Yaron_contact.MobileNumber = "+972545597057";
            Yaron_contact.MobileButtonClick += new EventHandler(Yaron_mobile);
            Yaron_contact.SkypeButtonClick += new EventHandler(Yaron_skype);

            Brandon_contact.MobileNumber = "+1 408 4319287";
            Brandon_contact.MobileButtonClick += new EventHandler(Brandon_mobile);
            Brandon_contact.SkypeButtonClick += new EventHandler(Brandon_skype);

            Hofi_contact.MobileNumber = "+972 54 5597064";
            Hofi_contact.MobileButtonClick += new EventHandler(Hofi_mobile);
            Hofi_contact.SkypeButtonClick += new EventHandler(Hofi_skype);
        }

        private void Hofi_skype(object sender, EventArgs e)
        {
            
        }

        private void Hofi_mobile(object sender, EventArgs e)
        {
            call.makeCall(Hofi_contact.MobileNumber);
        }

        private void Brandon_skype(object sender, EventArgs e)
        {
            
        }

        private void Brandon_mobile(object sender, EventArgs e)
        {
            call.makeCall(Brandon_contact.MobileNumber);
        }

        private void Yaron_skype(object sender, EventArgs e)
        {
            
        }

        private void Yaron_mobile(object sender, EventArgs e)
        {
            call.makeCall(Yaron_contact.MobileNumber);
        }

        private void Cristian_skype(object sender, EventArgs e)
        {
            
        }

        private void Cristian_mobile(object sender, EventArgs e)
        {
            call.makeCall(Cristian_contact.MobileNumber);
        }

        private void Marina_skype(object sender, EventArgs e)
        {
            
        }

        private void Marina_mobile(object sender, EventArgs e)
        {
            call.makeCall(Marina_contact.MobileNumber);
        }

        private void Noga_skype(object sender, EventArgs e)
        {
            
        }

        private void Noga_mobile(object sender, EventArgs e)
        {
            call.makeCall(Noga_contact.MobileNumber);
        }

        private void Ortal_skype(object sender, EventArgs e)
        {
            
        }

        private void Ortal_mobile(object sender, EventArgs e)
        {
            call.makeCall(Ortal_contact.MobileNumber);
        }

        private void Paula_skype(object sender, EventArgs e)
        {
            
        }

        private void Paula_mobile(object sender, EventArgs e)
        {
            call.makeCall(Paula_contact.MobileNumber);
        }

        private void Alejandro_skype(object sender, EventArgs e)
        {
            
        }

        private void Alejandro_mobile(object sender, EventArgs e)
        {
            call.makeCall(Alejandro_contact.MobileNumber);
        }

        private void Gregory_skype(object sender, EventArgs e)
        {
            
        }

        private void Gregory_mobile(object sender, EventArgs e)
        {
            call.makeCall(Gregory_contact.MobileNumber);
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
            AddContactToList(contactList, Gregory_contact);
            AddContactToList(contactList, Alejandro_contact);
            AddContactToList(contactList, Paula_contact);
            AddContactToList(contactList, Ortal_contact);
            AddContactToList(contactList, Noga_contact);
            AddContactToList(contactList, Marina_contact);
            AddContactToList(contactList, Cristian_contact);
            AddContactToList(contactList, Yaron_contact);
            AddContactToList(contactList, Brandon_contact);
            AddContactToList(contactList, Hofi_contact);
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
