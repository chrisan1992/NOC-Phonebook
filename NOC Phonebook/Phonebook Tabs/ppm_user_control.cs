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
    public partial class ppm_user_control : UserControl
    {
        private static LyncCall call;

        public ppm_user_control()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            AmitJain_contact.MobileNumber = "+1 2032436867";
            AmitJain_contact.MobileButtonClick += new EventHandler(AmitJain_mobile);
            AmitJain_contact.SkypeButtonClick += new EventHandler(AmitJain_skype);

            MehulSha_contact.MobileNumber = "+1 3025212720";
            MehulSha_contact.MobileButtonClick += new EventHandler(MehulSha_mobile);
            MehulSha_contact.SkypeButtonClick += new EventHandler(MehulSha_skype);

            MoranRostamian_contact.MobileNumber = "+972503137554";
            MoranRostamian_contact.MobileButtonClick += new EventHandler(Moran_mobile);
            MoranRostamian_contact.SkypeButtonClick += new EventHandler(Moran_skype);

            JayArjunan_contact.MobileNumber = "+61 2 82786642";
            JayArjunan_contact.MobileButtonClick += new EventHandler(Jay_mobile);
            JayArjunan_contact.SkypeButtonClick += new EventHandler(Jay_skype);

            Preeti_contact.MobileNumber = "+918860940744";
            Preeti_contact.MobileButtonClick += new EventHandler(Preeti_mobile);
            Preeti_contact.SkypeButtonClick += new EventHandler(Preeti_skype);

            IgalBarboy_contact.MobileNumber = "+972506380116";
            IgalBarboy_contact.MobileButtonClick += new EventHandler(Igal_mobile);
            IgalBarboy_contact.SkypeButtonClick += new EventHandler(Igal_skype);

            Kalyan_contact.MobileNumber = "+1 650 224 2722";
            Kalyan_contact.MobileButtonClick += new EventHandler(Kalyan_mobile);
            Kalyan_contact.SkypeButtonClick += new EventHandler(Kalyan_skype);

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

        private void Kalyan_skype(object sender, EventArgs e)
        {
            
        }

        private void Kalyan_mobile(object sender, EventArgs e)
        {
            call.makeCall(Kalyan_contact.MobileNumber);
        }

        private void Igal_skype(object sender, EventArgs e)
        {
            
        }

        private void Igal_mobile(object sender, EventArgs e)
        {
            call.makeCall(IgalBarboy_contact.MobileNumber);
        }

        private void Preeti_skype(object sender, EventArgs e)
        {
            
        }

        private void Preeti_mobile(object sender, EventArgs e)
        {
            call.makeCall(Preeti_contact.MobileNumber);
        }

        private void Jay_skype(object sender, EventArgs e)
        {
            
        }

        private void Jay_mobile(object sender, EventArgs e)
        {
            call.makeCall(JayArjunan_contact.MobileNumber);
        }

        private void Moran_skype(object sender, EventArgs e)
        {
            
        }

        private void Moran_mobile(object sender, EventArgs e)
        {
            call.makeCall(MoranRostamian_contact.MobileNumber);
        }

        private void MehulSha_skype(object sender, EventArgs e)
        {
            
        }

        private void MehulSha_mobile(object sender, EventArgs e)
        {
            call.makeCall(MehulSha_contact.MobileNumber);
        }

        private void AmitJain_skype(object sender, EventArgs e)
        {
            
        }

        private void AmitJain_mobile(object sender, EventArgs e)
        {
            call.makeCall(AmitJain_contact.MobileNumber);
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
            AddContactToList(contactList, AmitJain_contact);
            AddContactToList(contactList, MehulSha_contact);
            AddContactToList(contactList, MoranRostamian_contact);
            AddContactToList(contactList, JayArjunan_contact);
            AddContactToList(contactList, Preeti_contact);
            AddContactToList(contactList, IgalBarboy_contact);
            AddContactToList(contactList, Kalyan_contact);
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
