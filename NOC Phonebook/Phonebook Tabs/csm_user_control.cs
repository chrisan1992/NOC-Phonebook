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
    public partial class csm_user_control : UserControl
    {
        private static LyncCall call;

        public csm_user_control()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            Mark_contact.MobileButtonClick += new EventHandler(Mark_mobile);
            Mark_contact.SkypeButtonClick += new EventHandler(Mark_skype);
            
            Neil_contact.MobileButtonClick += new EventHandler(Neil_mobile);
            Neil_contact.SkypeButtonClick += new EventHandler(Neil_skype);

            Johnny_contact.MobileButtonClick += new EventHandler(Johnny_mobile);
            Johnny_contact.SkypeButtonClick += new EventHandler(Johnny_skype);

            Eitam_contact.MobileButtonClick += new EventHandler(Eitam_mobile);
            Eitam_contact.SkypeButtonClick += new EventHandler(Eitam_skype);

            Michael_contact.MobileButtonClick += new EventHandler(Michael_mobile);
            Michael_contact.SkypeButtonClick += new EventHandler(Michael_skype);

            Modi_contact.MobileButtonClick += new EventHandler(Modi_mobile);
            Modi_contact.SkypeButtonClick += new EventHandler(Modi_skype);

            Shaun_contact.MobileButtonClick += new EventHandler(Shaun_mobile);
            Shaun_contact.SkypeButtonClick += new EventHandler(Shaun_skype);

            Fiona_contact.MobileButtonClick += new EventHandler(Fiona_mobile);
            Fiona_contact.SkypeButtonClick += new EventHandler(Fiona_skype);

            Zak_contact.MobileButtonClick += new EventHandler(Zak_mobile);
            Zak_contact.SkypeButtonClick += new EventHandler(Zak_skype);

            Simon_contact.MobileButtonClick += new EventHandler(Simon_mobile);
            Simon_contact.SkypeButtonClick += new EventHandler(Simon_skype);
        }

        private void Simon_skype(object sender, EventArgs e)
        {
            
        }

        private void Simon_mobile(object sender, EventArgs e)
        {
            call.makeCall(Simon_contact.MobileNumber);
        }

        private void Zak_skype(object sender, EventArgs e)
        {
            
        }

        private void Zak_mobile(object sender, EventArgs e)
        {
            call.makeCall(Zak_contact.MobileNumber);
        }

        private void Fiona_skype(object sender, EventArgs e)
        {
            
        }

        private void Fiona_mobile(object sender, EventArgs e)
        {
            call.makeCall(Fiona_contact.MobileNumber);
        }

        private void Shaun_skype(object sender, EventArgs e)
        {
            
        }

        private void Shaun_mobile(object sender, EventArgs e)
        {
            call.makeCall(Shaun_contact.MobileNumber);
        }

        private void Modi_skype(object sender, EventArgs e)
        {
            
        }

        private void Modi_mobile(object sender, EventArgs e)
        {
            call.makeCall(Modi_contact.MobileNumber);
        }

        private void Michael_skype(object sender, EventArgs e)
        {
            
        }

        private void Michael_mobile(object sender, EventArgs e)
        {
            call.makeCall(Michael_contact.MobileNumber);
        }

        private void Eitam_skype(object sender, EventArgs e)
        {
            
        }

        private void Eitam_mobile(object sender, EventArgs e)
        {
            call.makeCall(Eitam_contact.MobileNumber);
        }

        private void Johnny_skype(object sender, EventArgs e)
        {
            
        }

        private void Johnny_mobile(object sender, EventArgs e)
        {
            call.makeCall(Johnny_contact.MobileNumber);
        }

        private void Neil_skype(object sender, EventArgs e)
        {
            
        }

        private void Neil_mobile(object sender, EventArgs e)
        {
            call.makeCall(Neil_contact.MobileNumber);
        }

        private void Mark_skype(object sender, EventArgs e)
        {
            
        }

        private void Mark_mobile(object sender, EventArgs e)
        {
            call.makeCall(Mark_contact.MobileNumber);
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
            AddContactToList(contactList, Mark_contact);
            AddContactToList(contactList, Neil_contact);
            AddContactToList(contactList, Johnny_contact);
            AddContactToList(contactList, Eitam_contact);
            AddContactToList(contactList, Michael_contact);
            AddContactToList(contactList, Modi_contact);
            AddContactToList(contactList, Shaun_contact);
            AddContactToList(contactList, Fiona_contact);
            AddContactToList(contactList, Zak_contact);
            AddContactToList(contactList, Simon_contact);
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
