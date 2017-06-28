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
    public partial class apm_user_control : UserControl
    {
        private static LyncCall call;

        public apm_user_control()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            Karvin_contact.MobileButtonClick += new EventHandler(Karvin_mobile);
            Karvin_contact.SkypeButtonClick += new EventHandler(Karvin_skype);

            Joseiby_contact.MobileButtonClick += new EventHandler(Joseiby_mobile);
            Joseiby_contact.SkypeButtonClick += new EventHandler(Joseiby_skype);

            Javier_contact.MobileButtonClick += new EventHandler(Javier_mobile);
            Javier_contact.SkypeButtonClick += new EventHandler(Javier_skype);

            Ericka_contact.MobileButtonClick += new EventHandler(Ericka_mobile);
            Ericka_contact.SkypeButtonClick += new EventHandler(Ericka_skype);

            Alex_contact.MobileButtonClick += new EventHandler(Alex_mobile);
            Alex_contact.SkypeButtonClick += new EventHandler(Alex_skype);

            Zakher_contact.MobileButtonClick += new EventHandler(Zakher_mobile);
            Zakher_contact.SkypeButtonClick += new EventHandler(Zakher_skype);

            Kfir_contact.MobileButtonClick += new EventHandler(Kfir_mobile);
            Kfir_contact.SkypeButtonClick += new EventHandler(Kfir_skype);

            Igal_contact.MobileButtonClick += new EventHandler(Igal_mobile);
            Igal_contact.SkypeButtonClick += new EventHandler(Igal_skype);

            Diego_contact.MobileButtonClick += new EventHandler(Diego_mobile);
            Diego_contact.SkypeButtonClick += new EventHandler(Diego_skype);

            Yossi_contact.MobileButtonClick += new EventHandler(Yossi_mobile);
            Yossi_contact.SkypeButtonClick += new EventHandler(Yossi_skype);
        }

        private void Yossi_skype(object sender, EventArgs e)
        {
            
        }

        private void Yossi_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972525697029");
        }

        private void Diego_skype(object sender, EventArgs e)
        {
            
        }

        private void Diego_mobile(object sender, EventArgs e)
        {
            call.makeCall("+506 88634118");
        }

        private void Igal_skype(object sender, EventArgs e)
        {
            
        }

        private void Igal_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972506380116");
        }

        private void Kfir_skype(object sender, EventArgs e)
        {
            
        }

        private void Kfir_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972549955674");
        }

        private void Zakher_skype(object sender, EventArgs e)
        {
            
        }

        private void Zakher_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972546335263");
        }

        private void Alex_skype(object sender, EventArgs e)
        {
            
        }

        private void Alex_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972546620319");
        }

        private void Ericka_skype(object sender, EventArgs e)
        {
            
        }

        private void Ericka_mobile(object sender, EventArgs e)
        {
            call.makeCall("+506 86354271");
        }

        private void Javier_skype(object sender, EventArgs e)
        {
            
        }

        private void Javier_mobile(object sender, EventArgs e)
        {
            call.makeCall("+50670126952");
        }

        private void Joseiby_skype(object sender, EventArgs e)
        {
            
        }

        private void Joseiby_mobile(object sender, EventArgs e)
        {
            call.makeCall("+506 88888213");
        }

        private void Karvin_skype(object sender, EventArgs e)
        {
            
        }

        private void Karvin_mobile(object sender, EventArgs e)
        {
            call.makeCall("+506 89692626");
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
            AddContactToList(contactList, Joseiby_contact);
            AddContactToList(contactList, Javier_contact);
            AddContactToList(contactList, Ericka_contact);
            AddContactToList(contactList, Alex_contact);
            AddContactToList(contactList, Zakher_contact);
            AddContactToList(contactList, Kfir_contact);
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
