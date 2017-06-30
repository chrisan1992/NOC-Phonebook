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
    public partial class srl_user_control : UserControl
    {
        private static LyncCall call;

        public srl_user_control()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            AlejandroLopez_contact.MobileNumber = "+506 70123648";
            AlejandroLopez_contact.MobileButtonClick += new EventHandler(Alejandro_mobile);
            AlejandroLopez_contact.SkypeButtonClick += new EventHandler(Alejandro_skype);

            OscarVillegas_contact.MobileNumber = "+50625084743";
            OscarVillegas_contact.MobileButtonClick += new EventHandler(Oscar_mobile);
            OscarVillegas_contact.SkypeButtonClick += new EventHandler(Oscar_skype);

            Efrat_contact.MobileNumber = "+972 52 5697020";
            Efrat_contact.MobileButtonClick += new EventHandler(Efrat_mobile);
            Efrat_contact.SkypeButtonClick += new EventHandler(Efrat_skype);

            Marina_contact.MobileNumber = "+972 52 2010407";
            Marina_contact.MobileButtonClick += new EventHandler(Marina_mobile);
            Marina_contact.SkypeButtonClick += new EventHandler(Marina_skype);

            Marina_contact.MobileNumber = "+50683411006";
            Marina_contact.MobileButtonClick += new EventHandler(Cristian_mobile);
            Marina_contact.SkypeButtonClick += new EventHandler(Cristian_skype);

            Yaron_contact.MobileNumber = "+972545597057";
            Yaron_contact.MobileButtonClick += new EventHandler(Yaron_mobile);
            Yaron_contact.SkypeButtonClick += new EventHandler(Yaron_skype);

            Brandon_contact.MobileNumber = "+1 408 4319287";
            Brandon_contact.MobileButtonClick += new EventHandler(Brandon_mobile);
            Brandon_contact.SkypeButtonClick += new EventHandler(Brandon_skype);

            Hofi_contact.MobileNumber = "+972 54 559 7064";
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

        private void Efrat_skype(object sender, EventArgs e)
        {
            
        }

        private void Efrat_mobile(object sender, EventArgs e)
        {
            call.makeCall(Efrat_contact.MobileNumber);
        }

        private void Oscar_skype(object sender, EventArgs e)
        {
            
        }

        private void Oscar_mobile(object sender, EventArgs e)
        {
            call.makeCall(OscarVillegas_contact.MobileNumber);
        }

        private void Alejandro_skype(object sender, EventArgs e)
        {
            
        }

        private void Alejandro_mobile(object sender, EventArgs e)
        {
            call.makeCall(AlejandroLopez_contact.MobileNumber);
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
            AddContactToList(contactList, AlejandroLopez_contact);
            AddContactToList(contactList, OscarVillegas_contact);
            AddContactToList(contactList, Efrat_contact);
            AddContactToList(contactList, Marina_contact);
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
