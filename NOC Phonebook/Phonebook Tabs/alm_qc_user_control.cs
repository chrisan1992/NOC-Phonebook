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
    public partial class alm_qc_user_control : UserControl
    {
        private static LyncCall call;

        public alm_qc_user_control()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            Failan_contact.MobileNumber = "+506 88681557";
            Failan_contact.MobileButtonClick += new EventHandler(Failan_mobile);
            Failan_contact.SkypeButtonClick += new EventHandler(Failan_skype);

            Dennis_contact.MobileNumber = "+506 88602563";
            Dennis_contact.MobileButtonClick += new EventHandler(Dennis_mobile);
            Dennis_contact.SkypeButtonClick += new EventHandler(Dennis_skype);

            Scott_contact.MobileNumber = "+1 408 9145989";
            Scott_contact.MobileButtonClick += new EventHandler(Scott_mobile);
            Scott_contact.SkypeButtonClick += new EventHandler(Scott_skype);

            Alexander_contact.MobileNumber = "+506 86120838";
            Alexander_contact.MobileButtonClick += new EventHandler(Alexander_mobile);
            Alexander_contact.SkypeButtonClick += new EventHandler(Alexander_skype);

            Idalia_contact.MobileNumber = "+506 83347030";
            Idalia_contact.MobileButtonClick += new EventHandler(Idalia_mobile);
            Idalia_contact.SkypeButtonClick += new EventHandler(Idalia_skype);

            Rafael_contact.MobileNumber = "+506 83828068";
            Rafael_contact.MobileButtonClick += new EventHandler(Rafael_mobile);
            Rafael_contact.SkypeButtonClick += new EventHandler(Rafael_skype);

            Muhammad_contact.MobileNumber = "+1 650 9967939";
            Muhammad_contact.MobileButtonClick += new EventHandler(Muhammad_mobile);
            Muhammad_contact.SkypeButtonClick += new EventHandler(Muhammad_skype);

            Daniela_contact.MobileNumber = "+506 87481672";
            Daniela_contact.MobileButtonClick += new EventHandler(Daniela_mobile);
            Daniela_contact.SkypeButtonClick += new EventHandler(Daniela_skype);

            William_contact.MobileNumber = "+1 408 3683822";
            William_contact.MobileButtonClick += new EventHandler(William_mobile);
            William_contact.SkypeButtonClick += new EventHandler(William_skype);
        }

        private void William_skype(object sender, EventArgs e)
        {
            
        }

        private void William_mobile(object sender, EventArgs e)
        {
            call.makeCall(William_contact.MobileNumber);
        }

        private void Daniela_skype(object sender, EventArgs e)
        {
            
        }

        private void Daniela_mobile(object sender, EventArgs e)
        {
            call.makeCall(Daniela_contact.MobileNumber);
        }

        private void Muhammad_skype(object sender, EventArgs e)
        {
            
        }

        private void Muhammad_mobile(object sender, EventArgs e)
        {
            call.makeCall(Muhammad_contact.MobileNumber);
        }

        private void Rafael_skype(object sender, EventArgs e)
        {
            
        }

        private void Rafael_mobile(object sender, EventArgs e)
        {
            call.makeCall(Rafael_contact.MobileNumber);
        }

        private void Idalia_skype(object sender, EventArgs e)
        {
            
        }

        private void Idalia_mobile(object sender, EventArgs e)
        {
            call.makeCall(Idalia_contact.MobileNumber);
        }

        private void Alexander_skype(object sender, EventArgs e)
        {
            
        }

        private void Alexander_mobile(object sender, EventArgs e)
        {
            call.makeCall(Alexander_contact.MobileNumber);
        }

        private void Scott_skype(object sender, EventArgs e)
        {
            
        }

        private void Scott_mobile(object sender, EventArgs e)
        {
            call.makeCall(Scott_contact.MobileNumber);
        }

        private void Dennis_skype(object sender, EventArgs e)
        {
            
        }

        private void Dennis_mobile(object sender, EventArgs e)
        {
            call.makeCall(Dennis_contact.MobileNumber);
        }

        private void Failan_skype(object sender, EventArgs e)
        {
            
        }

        private void Failan_mobile(object sender, EventArgs e)
        {
            call.makeCall(Failan_contact.MobileNumber);
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
            AddContactToList(contactList, Failan_contact);
            AddContactToList(contactList, Dennis_contact);
            AddContactToList(contactList, Scott_contact);
            AddContactToList(contactList, Alexander_contact);
            AddContactToList(contactList, Idalia_contact);
            AddContactToList(contactList, Rafael_contact);
            AddContactToList(contactList, Muhammad_contact);
            AddContactToList(contactList, Daniela_contact);
            AddContactToList(contactList, William_contact);
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
