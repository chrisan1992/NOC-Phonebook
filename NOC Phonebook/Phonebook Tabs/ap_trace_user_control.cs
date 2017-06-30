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
    public partial class ap_trace_user_control : UserControl
    {

        private static LyncCall call;

        public ap_trace_user_control()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            Edwin_contact.MobileNumber = "+506 87029212";
            Edwin_contact.MobileButtonClick += new EventHandler(Edwin_mobile);
            Edwin_contact.SkypeButtonClick += new EventHandler(Edwin_skype);

            Ghassam_contact.MobileNumber = "+972523055944";
            Ghassam_contact.MobileButtonClick += new EventHandler(Ghassan_mobile);
            Ghassam_contact.SkypeButtonClick += new EventHandler(Ghassan_skype);

            Fadi_contact.MobileNumber = "+972 545416840";
            Fadi_contact.MobileButtonClick += new EventHandler(Fadi_mobile);
            Fadi_contact.SkypeButtonClick += new EventHandler(Fadi_skype);

            Yessenia_contact.MobileNumber = "+50660507776";
            Yessenia_contact.MobileButtonClick += new EventHandler(Yessenia_mobile);
            Yessenia_contact.SkypeButtonClick += new EventHandler(Yessenia_skype);

            Itay_contact.MobileNumber = "+972 54 4497019";
            Itay_contact.MobileButtonClick += new EventHandler(Itay_mobile);
            Itay_contact.SkypeButtonClick += new EventHandler(Itay_skype);

            TalTalmon_contact.MobileNumber = "+972 545597074";
            TalTalmon_contact.MobileButtonClick += new EventHandler(Tal_mobile);
            TalTalmon_contact.SkypeButtonClick += new EventHandler(Tal_skype);
        }

        private void Tal_skype(object sender, EventArgs e)
        {

        }

        private void Tal_mobile(object sender, EventArgs e)
        {
            call.makeCall(TalTalmon_contact.MobileNumber);
        }

        private void Itay_skype(object sender, EventArgs e)
        {

        }

        private void Itay_mobile(object sender, EventArgs e)
        {
            call.makeCall(Itay_contact.MobileNumber);
        }

        private void Yessenia_skype(object sender, EventArgs e)
        {

        }

        private void Yessenia_mobile(object sender, EventArgs e)
        {
            call.makeCall(Yessenia_contact.MobileNumber);
        }

        private void Fadi_skype(object sender, EventArgs e)
        {

        }

        private void Fadi_mobile(object sender, EventArgs e)
        {
            call.makeCall(Fadi_contact.MobileNumber);
        }

        private void Ghassan_skype(object sender, EventArgs e)
        {

        }

        private void Ghassan_mobile(object sender, EventArgs e)
        {
            call.makeCall(Ghassam_contact.MobileNumber);
        }

        private void Edwin_skype(object sender, EventArgs e)
        {

        }

        private void Edwin_mobile(object sender, EventArgs e)
        {
            call.makeCall(Edwin_contact.MobileNumber);
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
            AddContactToList(contactList, Edwin_contact);
            AddContactToList(contactList, Ghassam_contact);
            AddContactToList(contactList, Fadi_contact);
            AddContactToList(contactList, Yessenia_contact);
            AddContactToList(contactList, Itay_contact);
            AddContactToList(contactList, TalTalmon_contact);
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
