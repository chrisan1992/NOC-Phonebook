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
    public partial class am_rc_user_control : UserControl
    {
        private static LyncCall call;

        public am_rc_user_control()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            Keerthi_contact.MobileNumber = "+91  9677181157";
            Keerthi_contact.MobileButtonClick += new EventHandler(Keerthi_mobile);
            Keerthi_contact.SkypeButtonClick += new EventHandler(Keerthi_skype);

            Anand_contact.MobileNumber = "+91  9880508508";
            Anand_contact.MobileButtonClick += new EventHandler(Anand_mobile);
            Anand_contact.SkypeButtonClick += new EventHandler(Anand_skype);

            Vaasuthevan_contact.MobileNumber = "+91 9962537685";
            Vaasuthevan_contact.MobileButtonClick += new EventHandler(Vaasuthevan_mobile);
            Vaasuthevan_contact.SkypeButtonClick += new EventHandler(Vaasuthevan_skype);

            Dileep_contact.MobileNumber = "+91  9994191448";
            Dileep_contact.MobileButtonClick += new EventHandler(Dileep_mobile);
            Dileep_contact.SkypeButtonClick += new EventHandler(Dileep_skype);

            Igal_contact.MobileNumber = "+972506380116";
            Igal_contact.MobileButtonClick += new EventHandler(Igal_mobile);
            Igal_contact.SkypeButtonClick += new EventHandler(Igal_skype);

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

        private void Igal_skype(object sender, EventArgs e)
        {

        }

        private void Igal_mobile(object sender, EventArgs e)
        {
            call.makeCall(Igal_contact.MobileNumber);
        }

        private void Dileep_skype(object sender, EventArgs e)
        {

        }

        private void Dileep_mobile(object sender, EventArgs e)
        {
            call.makeCall(Dileep_contact.MobileNumber);
        }

        private void Vaasuthevan_skype(object sender, EventArgs e)
        {

        }

        private void Vaasuthevan_mobile(object sender, EventArgs e)
        {
            call.makeCall(Vaasuthevan_contact.MobileNumber);
        }

        private void Anand_skype(object sender, EventArgs e)
        {

        }

        private void Anand_mobile(object sender, EventArgs e)
        {
            call.makeCall(Anand_contact.MobileNumber);
        }

        private void Keerthi_skype(object sender, EventArgs e)
        {

        }

        private void Keerthi_mobile(object sender, EventArgs e)
        {
            call.makeCall(Keerthi_contact.MobileNumber);
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
            AddContactToList(contactList, Keerthi_contact);
            AddContactToList(contactList, Anand_contact);
            AddContactToList(contactList, Vaasuthevan_contact);
            AddContactToList(contactList, Dileep_contact);
            AddContactToList(contactList, Igal_contact);
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
