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
    public partial class crisis_user_control : UserControl
    {
        private static LyncCall call;

        public crisis_user_control()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            Diego_contact.MobileButtonClick += new EventHandler(Diego_mobile);
            Diego_contact.SkypeButtonClick += new EventHandler(Diego_skype);

            Eran_contact.MobileButtonClick += new EventHandler(Eran_mobile);
            Eran_contact.SkypeButtonClick += new EventHandler(Eran_skype);

            YaronAvior_contact.MobileButtonClick += new EventHandler(Yaron_mobile);
            YaronAvior_contact.SkypeButtonClick += new EventHandler(Yaron_skype);

            YossiG_contact.MobileButtonClick += new EventHandler(YossiG_mobile);
            YossiG_contact.SkypeButtonClick += new EventHandler(YossiG_skype);

            Itay_contact.MobileButtonClick += new EventHandler(Itay_mobile);
            Itay_contact.SkypeButtonClick += new EventHandler(Itay_skype);

            Eli_contact.MobileButtonClick += new EventHandler(Eli_mobile);
            Eli_contact.SkypeButtonClick += new EventHandler(Eli_skype);

            Maroon_contact.MobileButtonClick += new EventHandler(Maroon_mobile);
            Maroon_contact.SkypeButtonClick += new EventHandler(Maroon_skype);

            Nir_contact.MobileButtonClick += new EventHandler(Nir_mobile);
            Nir_contact.SkypeButtonClick += new EventHandler(Nir_skype);

            Rachel_contact.MobileButtonClick += new EventHandler(Rachel_mobile);
            Rachel_contact.SkypeButtonClick += new EventHandler(Rachel_skype);

            YossiS_contact.MobileButtonClick += new EventHandler(YossiS_mobile);
            YossiS_contact.SkypeButtonClick += new EventHandler(YossiS_skype);

            Vadim_contact.MobileButtonClick += new EventHandler(Vadim_mobile);
            Vadim_contact.SkypeButtonClick += new EventHandler(Vadim_skype);
        }

        private void Vadim_skype(object sender, EventArgs e)
        {
           
        }

        private void Vadim_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972525759368");
        }

        private void YossiS_skype(object sender, EventArgs e)
        {
            
        }

        private void YossiS_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972525697029");
        }

        private void Rachel_skype(object sender, EventArgs e)
        {
            
        }

        private void Rachel_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972 54 6385225");
        }

        private void Nir_skype(object sender, EventArgs e)
        {
            
        }

        private void Nir_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972 54 4497044");
        }

        private void Maroon_skype(object sender, EventArgs e)
        {
            
        }

        private void Maroon_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972503137644");
        }

        private void Eli_skype(object sender, EventArgs e)
        {
            
        }

        private void Eli_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972544429922");
        }

        private void Itay_skype(object sender, EventArgs e)
        {
            
        }

        private void Itay_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972 54 4497019");
        }

        private void YossiG_skype(object sender, EventArgs e)
        {
            
        }

        private void YossiG_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972545245606");
        }

        private void Yaron_skype(object sender, EventArgs e)
        {
            
        }

        private void Yaron_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972545597057");
        }

        private void Eran_skype(object sender, EventArgs e)
        {
            
        }

        private void Eran_mobile(object sender, EventArgs e)
        {
            call.makeCall("+1 408 3683400");
        }

        private void Diego_skype(object sender, EventArgs e)
        {
            
        }

        private void Diego_mobile(object sender, EventArgs e)
        {
            call.makeCall("+506 88634118");
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
            AddContactToList(contactList, Diego_contact);
            AddContactToList(contactList, Eran_contact);
            AddContactToList(contactList, YaronAvior_contact);
            AddContactToList(contactList, YossiG_contact);
            AddContactToList(contactList, Itay_contact);
            AddContactToList(contactList, Eli_contact);
            AddContactToList(contactList, Maroon_contact);
            AddContactToList(contactList, Nir_contact);
            AddContactToList(contactList, Rachel_contact);
            AddContactToList(contactList, YossiS_contact);
            AddContactToList(contactList, Vadim_contact);
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
