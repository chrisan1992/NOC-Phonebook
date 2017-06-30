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
    public partial class saw_user_control : UserControl
    {
        private static LyncCall call;

        public saw_user_control()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            LiorRif_contact.MobileNumber = "2 + 14165792270";
            LiorRif_contact.MobileButtonClick += new EventHandler(Lior_mobile);
            LiorRif_contact.SkypeButtonClick += new EventHandler(Lior_skype);

            LuluRolfe_contact.MobileNumber = "+1 858 943 9280";
            LuluRolfe_contact.MobileButtonClick += new EventHandler(Lulu_mobile);
            LuluRolfe_contact.SkypeButtonClick += new EventHandler(Lulu_skype);

            DaniZivov_contact.MobileNumber = "+14089309411";
            DaniZivov_contact.MobileButtonClick += new EventHandler(Dani_mobile);
            DaniZivov_contact.SkypeButtonClick += new EventHandler(Dani_skype);

            LironFux_contact.MobileNumber = "+972 54 3133123";
            LironFux_contact.MobileButtonClick += new EventHandler(Liron_mobile);
            LironFux_contact.SkypeButtonClick += new EventHandler(Liron_skype);

            Miroslav_contact.MobileNumber = "+359888810500";
            Miroslav_contact.MobileButtonClick += new EventHandler(Miroslav_mobile);
            Miroslav_contact.SkypeButtonClick += new EventHandler(Miroslav_skype);

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

        private void Miroslav_skype(object sender, EventArgs e)
        {
            
        }

        private void Miroslav_mobile(object sender, EventArgs e)
        {
            call.makeCall(Miroslav_contact.MobileNumber);
        }

        private void Liron_skype(object sender, EventArgs e)
        {
            
        }

        private void Liron_mobile(object sender, EventArgs e)
        {
            call.makeCall(LironFux_contact.MobileNumber);
        }

        private void Dani_skype(object sender, EventArgs e)
        {
            
        }

        private void Dani_mobile(object sender, EventArgs e)
        {
            call.makeCall(DaniZivov_contact.MobileNumber);
        }

        private void Lulu_skype(object sender, EventArgs e)
        {
            
        }

        private void Lulu_mobile(object sender, EventArgs e)
        {
            call.makeCall(LuluRolfe_contact.MobileNumber);
        }

        private void Lior_skype(object sender, EventArgs e)
        {
            
        }

        private void Lior_mobile(object sender, EventArgs e)
        {
            call.makeCall(LiorRif_contact.MobileNumber);
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
            AddContactToList(contactList, LiorRif_contact);
            AddContactToList(contactList, LuluRolfe_contact);
            AddContactToList(contactList, DaniZivov_contact);
            AddContactToList(contactList, LironFux_contact);
            AddContactToList(contactList, Miroslav_contact);
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
