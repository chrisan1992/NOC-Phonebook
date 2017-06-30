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
    public partial class art_user_control : UserControl
    {

        private static LyncCall call;

        public art_user_control()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            AlexDekman_contact.MobileNumber = "+972 547854455";
            AlexDekman_contact.MobileButtonClick += new EventHandler(AlexDekam_mobile);
            AlexDekman_contact.SkypeButtonClick += new EventHandler(AlexDekman_skype);

            AmirGabay_contact.MobileNumber = "+972 548301016";
            AmirGabay_contact.MobileButtonClick += new EventHandler(AmirGabay_mobile);
            AmirGabay_contact.SkypeButtonClick += new EventHandler(AmirGabay_skype);

            ItayLaxer_contact.MobileNumber = "+972 54 4497019";
            ItayLaxer_contact.MobileButtonClick += new EventHandler(ItayLaxer_mobile);
            ItayLaxer_contact.SkypeButtonClick += new EventHandler(ItayLaxer_skype);

            VadimWaisman_contact.MobileNumber = "+972525759368";
            VadimWaisman_contact.MobileButtonClick += new EventHandler(VadimWaisman_mobile);
            VadimWaisman_contact.SkypeButtonClick += new EventHandler(VadimWaisman_skype);
        }

        private void VadimWaisman_skype(object sender, EventArgs e)
        {
            
        }

        private void VadimWaisman_mobile(object sender, EventArgs e)
        {
            call.makeCall(VadimWaisman_contact.MobileNumber);
        }

        private void ItayLaxer_skype(object sender, EventArgs e)
        {
            
        }

        private void ItayLaxer_mobile(object sender, EventArgs e)
        {
            call.makeCall(ItayLaxer_contact.MobileNumber);
        }

        private void AmirGabay_skype(object sender, EventArgs e)
        {
            
        }

        private void AmirGabay_mobile(object sender, EventArgs e)
        {
            call.makeCall(AmirGabay_contact.MobileNumber);
        }

        private void AlexDekman_skype(object sender, EventArgs e)
        {
            
        }

        private void AlexDekam_mobile(object sender, EventArgs e)
        {
            call.makeCall(AlexDekman_contact.MobileNumber);
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
            AddContactToList(contactList, AlexDekman_contact);
            AddContactToList(contactList, AmirGabay_contact);
            AddContactToList(contactList, ItayLaxer_contact);
            AddContactToList(contactList, VadimWaisman_contact);
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
